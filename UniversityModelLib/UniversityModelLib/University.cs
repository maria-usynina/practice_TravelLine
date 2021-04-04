using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModelLib
{
    public class University : IUniversity
    {
        public List<IFaculty> faculties = new List<IFaculty>()
        {
            new Faculty("информатики и вычислительной техники"),
            new Faculty("управления и права")
        };
        public void AddFaculty(string faculty_name)
        {
            Faculty faculty = new();
            faculty.Name = faculty_name;
            faculties.Add(faculty);
        }
        public void DeleteFaculty(string faculty_name)
        {
            for (int i = 0; i < faculties.Count; i++)
            {
                if (faculties[i].Name == faculty_name) 
                {
                    faculties.RemoveAt(i);
                }
            }
        }
        public void СhooseFaculty(string faculty_name)
        {
            Faculty person = new Faculty();
            for (int i = 0; i < faculties.Count; i++)
            {
                if (faculties[i].Name == faculty_name)
                {
                    string count = "1";
                    while (count != "2")
                    {
                        if (count != "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                        }
                        if (count == "1")
                        { 
                            Console.Write("Студент(1)/преподаватель(2)?                                      ");
                            int _person = Convert.ToInt32(Console.ReadLine());
                            if (_person != 1 && _person != 2)
                            {
                                Console.WriteLine();
                                Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                            }
                            if (_person == 1)
                            {
                                Console.Write("Добавить(1)/удалить(2)/посмотреть(3) студентов или выйти(4)?      ");
                                string action_with_student = Console.ReadLine();
                                while (action_with_student != "4")
                                {
                                    if (action_with_student != "1" && action_with_student != "2" && action_with_student != "3")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                                    }
                                    if (action_with_student == "1")
                                    {
                                        Console.Write("Введите студента(ФИО полностью):                                  ");
                                        string _student = Console.ReadLine();
                                        person.AddStudent(_student);
                                    }
                                    if (action_with_student == "2" && person.students.Count != 0)
                                    {
                                        Console.Write("Введите студента(ФИО полностью):                                  ");
                                        string _student = Console.ReadLine();
                                        person.DeleteStudent(_student);
                                    }
                                    if (person.students.Count == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                                    }
                                    if (action_with_student == "3" && person.students.Count != 0)
                                    {
                                        for (int j = 0; j < person.students.Count; j++)
                                        {
                                            Console.WriteLine("                                                                    " + person.students[j].Name);
                                        }
                                    }
                                    Console.Write("Добавить(1)/удалить(2)/посмотреть(3) студентов или выйти(4)?      ");
                                    action_with_student = Console.ReadLine();
                                }
                            }
                            if (_person == 2)
                            {
                                Console.Write("Добавить(1)/удалить(2)/посмотреть(3) преподавателей или выйти(4)? ");
                                string action_with_teacher = Console.ReadLine();
                                while (action_with_teacher != "4")
                                {
                                    if (action_with_teacher != "1" && action_with_teacher != "2" && action_with_teacher != "3")
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                                    }
                                    if (action_with_teacher == "1")
                                    {
                                        Console.Write("Введите преподавателя(ФИО полностью):                             ");
                                        string _teacher = Console.ReadLine();
                                        person.AddTeacher(_teacher);
                                    }
                                    if (action_with_teacher == "2" && person.teachers.Count != 0)
                                    {
                                        Console.Write("Введите преподавателя(ФИО полностью):                             ");
                                        string _teacher = Console.ReadLine();
                                        person.DeleteTeacher(_teacher);
                                    }
                                    if (person.teachers.Count == 0)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                                    }
                                    if (action_with_teacher == "3" && person.teachers.Count != 0)
                                    {
                                        for (int j = 0; j < person.teachers.Count; j++)
                                        {
                                            Console.WriteLine("                                                                    " + person.teachers[j].Name);
                                        }
                                    }
                                    Console.Write("Добавить(1)/удалить(2)/посмотреть(3) преподавателей или выйти(4)? ");
                                    action_with_teacher = Console.ReadLine();
                                }
                            }
                        }
                        Console.Write("Вернуться к выбору студент/преподаваетль(1)/к списку ф-тов(2)?    ");
                        count = Console.ReadLine();
                    }
                }
            }
        }
    }
}
