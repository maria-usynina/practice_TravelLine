using System;
using System.Collections.Generic;

namespace UniversityModelLib
{
    public class University : IUniversity
    {
        public List<IFaculty> faculties = new List<IFaculty>()
        {
            new Faculty("информатики и вычислительной техники"),
            new Faculty("управления и права")
        };
        public void WriteAllFaculties()
        {
            foreach (Faculty i in faculties)
            {
                Console.WriteLine("                                                                    Ф-т " + i.Name);
            }
        }
        public void AddFaculty()
        {
            Console.Write("Введите факультет:                                                ф-т ");
            string facultyName = Console.ReadLine();
            Faculty faculty = new(facultyName);
            faculty.Name = facultyName;
            faculties.Add(faculty);
        }
        public void DeleteFaculty()
        {
            Console.Write("Введите факультет:                                                ф-т ");
            string facultyName = Console.ReadLine();
            Faculty name = new Faculty("");
            foreach (Faculty i in faculties)
            {
                if (i.Name == facultyName)
                {
                    name = i;
                }

            }
            faculties.Remove(name);
        }
        public void ChooseFaculty()
        {
            Console.Write("Введите факультет:                                                ф-т ");
            string facultyName = Console.ReadLine();
            Person person = new Person();
            foreach (Faculty i in faculties)
            {
                if (i.Name == facultyName)
                {
                    string count = "1";
                    while (count != "2")
                    {
                        if (count != "1")
                        {
                            Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                        }
                        if (count == "1")
                        {
                            Console.Write("Студент(1)/преподаватель(2)?                                      ");
                            int _person = Convert.ToInt32(Console.ReadLine());
                            if (_person != 1 && _person != 2)
                            {
                                Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                            }
                            if (_person == 1)
                            {
                                person.Student();
                            }
                            if (_person == 2)
                            {
                                person.Teacher();
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
