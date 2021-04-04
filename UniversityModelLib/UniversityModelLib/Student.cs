using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Student : IStudent
    {
        private string _student;

        public Student()
        {
        }

        public Student(string v)
        {
            _student = v;
        }

        public string Name { get => _student; set => _student = value; }
    }
}
