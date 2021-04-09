using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Student : IStudent
    {
        public Student(string name)
        {
            Name = name;
        }
        public string Name { get ; set ; }
    }
}
