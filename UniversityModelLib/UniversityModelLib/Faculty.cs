using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Faculty : IFaculty
    {
        private string facultyName;
        public Faculty(string name)
        {
            facultyName = name;
        }

        public string Name { get => facultyName; set => facultyName = value; }
        public List<IStudent> students = new List<IStudent>();
        public List<ITeacher> teachers = new List<ITeacher>();
        public void WriteAllStudents()
        {
            foreach (Student i in students)
            {
                Console.WriteLine("                                                                    " + i.Name);
            }
        }
        public void AddStudent()
        {
            Console.Write("Введите студента(ФИО полностью):                                  ");
            string studentName = Console.ReadLine();
            Student student = new Student(studentName);
            students.Add(student);
        }
        public void DeleteStudent()
        {
            Console.Write("Введите студента(ФИО полностью):                                  ");
            string studentName = Console.ReadLine();
            Student name = new Student("");
            foreach (Student i in students)
            {
                if (i.Name == studentName)
                {
                    name = i;
                }
            }
            students.Remove((IStudent)name);
        }
        public void WriteAllTeachers()
        {
            foreach (Teacher i in teachers)
            {
                Console.WriteLine("                                                                    " + i.Name);
            }
        }
        public void AddTeacher()
        {
            Console.Write("Введите преподавателя(ФИО полностью):                             ");
            string teacherName = Console.ReadLine();
            Teacher teacher = new Teacher(teacherName);
            teachers.Add(teacher);
        }
        public void DeleteTeacher()
        {
            Console.Write("Введите преподавателя(ФИО полностью):                             ");
            string teacherName = Console.ReadLine();
            Teacher name = new Teacher("");
            foreach (Teacher i in teachers)
            {
                if (i.Name == teacherName)
                {
                    name = i;
                }
            }
            teachers.Remove((ITeacher)name);
        }
    }
}
