using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShopConsole
{
    class Program
    {
        private static string _connectionString = @"Server=LAPTOP-VH7PA2RB\SQLEXPRESS;Database=Shop;Trusted_Connection=True;";

        static void Main(string[] args)
        {
            string command = args[0];

            if (command == "readorder")
            {
                List<Order> orders = ReadOrders();
                foreach ( Order order in orders)
                {
                    Console.WriteLine(order.ProductName);
                }
            }
            else if (command == "insert")
            {
                int createdOrderId = InsertOrder(1, "ProductName", "Price");
                Console.WriteLine("Created order: " + createdOrderId);
            }
            else if (command == "update")
            {
                UpdateOrder(1, "UPDATED ProductName");
            }
            else if (command == "statistic")
            {
                ReadStatistics();
            }
        }

        private static List<Order> ReadOrders()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"SELECT
                            [OrderId],
                            [ProductName],
                            [Price],
                            [CustomerId]
                        FROM [Order]";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var order = new Order
                            {
                                OrderId = Convert.ToInt32(reader["OrderId"]),
                                ProductName = Convert.ToString(reader["ProductName"]),
                                Price = Convert.ToInt32(reader["Price"]),
                                CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            };
                            orders.Add(order);
                        }
                    }
                }
            }
            return orders;
        }

        private static int InsertOrder(int customerId, string productName, string price)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = @"
                    INSERT INTO [Order]
                       ([ProductName],
                        [Price],
                        [CustomerId])
                    VALUES 
                       (@productName,
                        @price,
                        @customerId)
                    SELECT SCOPE_IDENTITY()";

                    cmd.Parameters.Add("@productName", SqlDbType.NVarChar).Value = productName;
                    cmd.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
                    cmd.Parameters.Add("@customerId", SqlDbType.Int).Value = customerId;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private static void UpdateOrder(int ordertId, string productName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        UPDATE [Order]
                        SET [ProductName] = @productName
                        WHERE OrdertId = @orderId";

                    command.Parameters.Add("@orderId", SqlDbType.BigInt).Value = ordertId;
                    command.Parameters.Add("@productName", SqlDbType.NVarChar).Value = productName;

                    command.ExecuteNonQuery();
                }
            }
        }

        private static void ReadStatistics()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText =
                        @"
                            SELECT [Customer].[Name], COUNT([Order].[ProductName]) AS 'Amount', SUM([Order].[Price]) AS 'Sum'
                            FROM[Order]
                            INNER JOIN Customer ON[Order].CustomerId = Customer.CustomerId
                            GROUP BY[Customer].[Name];
                        ";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine($"{"Name", -40} {"Amount", -10} {"Sum", -10}");
                        while (reader.Read())
                        {
                            string Name = Convert.ToString(reader["Name"]);
                            string Amount = Convert.ToString(reader["Amount"]);
                            string Sum = Convert.ToString(reader["Sum"]);
                            Console.WriteLine($"{Name,-40} {Amount,-10} {Sum,-10}");
                        }
                    }
                }
            }
        }
    }
}
