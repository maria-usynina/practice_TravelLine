using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOlympiadLib
{
    public class Olympiad : IOlympiad
    {
        public List<Student> students = new List<Student>();

        public void add(string name, string lastname, string middlename, int score)
        {
            Student student = new Student();
            student.Name = name;
            student.LastName = lastname;
            student.MiddleName = middlename;
            student.Score = Convert.ToString(score);
            students.Add(student);
        }

        public void delete(string name, string lastname, string middlename)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (name == students[i].Name && lastname == students[i].LastName && middlename == students[i].MiddleName)
                {
                    students.RemoveAt(i);
                }
            }
        }

        public int maximum(int score)
        {
            int max = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (Convert.ToInt32(students[i].Score) > max)
                {
                    max = Convert.ToInt32(students[i].Score);
                }
            }
            return max;
        }

        public int winner(int score)
        {
            int max = 0;
            int max_i = 0;
            for (int i = 0; i < students.Count; i++)
            {
                if (Convert.ToInt32(students[i].Score) > max)
                {
                    max = Convert.ToInt32(students[i].Score);
                    max_i = i;
                }
            }
            return max_i;
        }
    }
}
