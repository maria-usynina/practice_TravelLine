using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public interface IUniversity
    {
        void AddFaculty(string faculty_name);
        void DeleteFaculty(string faculty_name);
        void СhooseFaculty(string faculty_name);
    }
}
