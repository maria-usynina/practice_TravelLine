using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public interface IFaculty
    {
        string Name { get; set; }
        void AddStudent(string _student);
        void DeleteStudent(string _student);
        void AddTeacher(string _teacher);
        void DeleteTeacher(string _teacher);
    }
}
