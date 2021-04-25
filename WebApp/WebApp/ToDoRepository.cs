using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WebApp
{
    public class ToDoRepository
    {
        private static string _connectionString = @"Server=LAPTOP-VH7PA2RB\SQLEXPRESS;Database=ToDoList;Trusted_Connection=True;";
        private class ToDo
        {
            public int Id { get; }
            public string Name { get; set;  }
            public bool Done { get; set;  }
            public DateTime CreateDate { get;  }
            public ToDo(int id, string name, bool done)
            {
                Id = id;
                Name = name;
                Done = done;
                CreateDate = DateTime.Now;
            }
        }

        private int GetId()
        {
            List<ToDoDto> ides = new List<ToDoDto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [ToDoId] 
                        FROM [ToDoList]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = new ToDoDto
                            {
                                Id = Convert.ToInt32(reader["ToDoId"])
                            };
                            ides.Add(id);
                        }
                    }
                }
            }
            if (ides.Count == 0)
            {
                return 1;
            }
            else
            {
                return ides.Count + 1;
            }
        }

        public List<ToDoDto> GetAll()
        {
            List<ToDoDto> todos = new List<ToDoDto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                    @"SELECT
                    [ToDoId],
                    [Name],
                    [Done]
                    FROM [ToDoList]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var todo = new ToDoDto
                            {
                                Id = Convert.ToInt32(reader["ToDoId"]),
                                Name = Convert.ToString(reader["Name"]),
                                Done = Convert.ToBoolean(reader["Done"]),
                            };
                            todos.Add(todo);
                        }
                    }
                }
            }
            return todos;
        }

        public int Create(ToDoDto toDoDto)
        {
            int id = GetId();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                    INSERT INTO [ToDoList]
                       ([ToDoId],
                        [Name],
                        [Done])
                    VALUES 
                       (@ToDoId,
                        @Name,
                        @Done)";

                    command.Parameters.Add("@ToDoId", SqlDbType.Int).Value = id;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = toDoDto.Name;
                    command.Parameters.Add("@Done", SqlDbType.Bit).Value = false;

                    return (Convert.ToInt32(command.ExecuteScalar()) + id);
                }
            }
        }

        public void Update(int id, ToDoDto toDoDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        UPDATE [ToDoList]
                        SET [Done] = @Done
                        WHERE ToDoId = @ToDoId";

                    command.Parameters.Add("@ToDoId", SqlDbType.BigInt).Value = id;
                    command.Parameters.Add("@Done", SqlDbType.Bit).Value =true;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
