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
        void WriteAllStudents();
        void AddStudent();
        void DeleteStudent();
        void WriteAllTeachers();
        void AddTeacher();
        void DeleteTeacher();
    }
}
