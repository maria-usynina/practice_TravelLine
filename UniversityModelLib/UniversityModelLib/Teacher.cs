using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Teacher : ITeacher
    {
        private string teacherName;

        public Teacher()
        {
        }

        public Teacher(string name)
        {
            teacherName = name;
        }

        public string Name { get => teacherName; set => teacherName = value; }
    }
}
