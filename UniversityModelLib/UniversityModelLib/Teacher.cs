﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Teacher : ITeacher
    {
        public Teacher(string name)
        {
            Name = name;
        }
        public string Name { get ; set ; }
    }
}
