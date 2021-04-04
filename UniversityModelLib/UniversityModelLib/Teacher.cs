using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Teacher : ITeacher
    {
        private string _teacher;

        public Teacher()
        {
        }

        public Teacher(string v)
        {
            _teacher = v;
        }

        public string Name { get => _teacher; set => _teacher = value; }
    }
}
