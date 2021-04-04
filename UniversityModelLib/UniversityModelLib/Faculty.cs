using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Faculty : IFaculty
    {
        private string faculty_name;

        public Faculty()
        {
        }

        public Faculty(string v)
        {
            faculty_name = v;
        }

        public string Name { get => faculty_name; set => faculty_name = value; }

        public List<IStudent> students = new List<IStudent>();
        public void AddStudent(string _student)
        {
            Student student = new Student();
            student.Name = _student;
            students.Add(student);
        }
        public void DeleteStudent(string _student)
        {
            for (int j = 0; j < students.Count; j++)
            {
                if (students[j].Name == _student)
                {
                    students.RemoveAt(j);
                }
            }
        }
        public List<ITeacher> teachers = new List<ITeacher>();
        public void AddTeacher(string _teacher)
        {
            Teacher teacher = new Teacher();
            teacher.Name = _teacher;
            teachers.Add(teacher);
        }
        public void DeleteTeacher(string _teacher)
        {
            for (int j = 0; j < teachers.Count; j++)
            {
                if (teachers[j].Name == _teacher)
                {
                    teachers.RemoveAt(j);
                }
            }
        }
    }
}
