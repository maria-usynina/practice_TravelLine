using System;
using System.Collections.Generic;
using UniversityModelLib;

namespace UniversityModel
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Console.WriteLine("                                                                  СПИСОК ФАКУЛЬТЕТОВ:");
            for (int i = 0; i < university.faculties.Count; i++)
            {
                Console.WriteLine("                                                                    Ф-т " + university.faculties[i].Name);
            }
            Console.Write("Добавить(1)/удалить(2)/выбрать(3) факультет или выйти(4)?         ");
            string count = Console.ReadLine();
            while (count != "4")
            {
                if (count != "1" && count != "2" && count != "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                }
                if (count == "1")
                {
                    Console.Write("Введите факультет:                                                ф-т ");
                    string faculty_name = Console.ReadLine();
                    university.AddFaculty(faculty_name);
                }
                if (count == "2" && university.faculties.Count != 0)
                {
                    Console.Write("Введите факультет:                                                ф-т ");
                    string faculty_name = Console.ReadLine();
                    university.DeleteFaculty(faculty_name);
                }
                if (university.faculties.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                }
                if (count == "3" && university.faculties.Count != 0)
                {
                    Console.Write("Введите факультет:                                                ф-т ");
                    string faculty_name = Console.ReadLine();
                    university.СhooseFaculty(faculty_name);
                }
                Console.WriteLine();
                for (int i = 0; i < university.faculties.Count; i++)
                {
                    Console.WriteLine("                                                                    Ф-т " + university.faculties[i].Name);
                }
                Console.Write("Добавить(1)/удалить(2)/выбрать(3) факультет или выйти(4)?         ");
                count = Console.ReadLine();
            }
        }
    }
}
