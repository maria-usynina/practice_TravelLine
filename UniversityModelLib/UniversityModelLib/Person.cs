using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class Person : IPerson
    {
        private static string facultyName;
        Faculty person = new Faculty(facultyName);
        public void Student()
        {
            Console.Write("Добавить(1)/удалить(2)/посмотреть(3) студентов или выйти(4)?      ");
            string action_with_student = Console.ReadLine();
            while (action_with_student != "4")
            {
                if (action_with_student != "1" && action_with_student != "2" && action_with_student != "3")
                {
                    Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                }
                if (action_with_student == "1")
                {
                    person.AddStudent();
                }
                if (action_with_student == "2" && person.students.Count != 0)
                {
                    person.DeleteStudent();
                }
                if (action_with_student == "3" && person.students.Count != 0)
                {
                    person.WriteAllStudents();
                }
                if (person.students.Count == 0)
                {
                    Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                }
                Console.Write("Добавить(1)/удалить(2)/посмотреть(3) студентов или выйти(4)?      ");
                action_with_student = Console.ReadLine();
            }
        }
        public void Teacher()
        {
            Console.Write("Добавить(1)/удалить(2)/посмотреть(3) преподавателей или выйти(4)? ");
            string action_with_teacher = Console.ReadLine();
            while (action_with_teacher != "4")
            {
                if (action_with_teacher != "1" && action_with_teacher != "2" && action_with_teacher != "3")
                {
                    Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                }
                if (action_with_teacher == "1")
                {
                    person.AddTeacher();
                }
                if (action_with_teacher == "2" && person.teachers.Count != 0)
                {
                    person.DeleteTeacher();
                }
                if (action_with_teacher == "3" && person.teachers.Count != 0)
                {
                    person.WriteAllTeachers();
                }
                if (person.teachers.Count == 0)
                {
                    Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                }
                Console.Write("Добавить(1)/удалить(2)/посмотреть(3) преподавателей или выйти(4)? ");
                action_with_teacher = Console.ReadLine();
            }
        }
    }
}
