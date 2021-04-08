using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Student : IStudent
    {
        private string studentName;

        public Student()
        {
        }

        public Student(string name)
        {
            studentName = name;
        }

        public string Name { get => studentName; set => studentName = value; }
    }
}
