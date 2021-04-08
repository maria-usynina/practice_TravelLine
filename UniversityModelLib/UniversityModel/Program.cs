using System;
using UniversityModelLib;

namespace UniversityModel
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Console.WriteLine("                                                                  СПИСОК ФАКУЛЬТЕТОВ:");
            university.WriteAllFaculties();
            Console.Write("Добавить(1)/удалить(2)/выбрать(3) факультет или выйти(4)?         ");
            string count = Console.ReadLine();
            while (count != "4")
            {
                if (count != "1" && count != "2" && count != "3")
                {
                    Console.WriteLine("                                                                  ВВЕДИТЕ ПРАВИЛЬНУЮ КОМАНДУ!");
                }
                if (count == "1")
                {
                    university.AddFaculty();
                }
                if (count == "2" && university.faculties.Count != 0)
                {
                    university.DeleteFaculty();
                }
                if (count == "3" && university.faculties.Count != 0)
                {
                    university.ChooseFaculty();
                }
                if (university.faculties.Count == 0)
                {
                    Console.WriteLine("                                                                  СПИСОК ПУСТ! ВВЕДИТЕ НОВЫЕ ЗНАЧЕНИЯ!");
                }
                Console.WriteLine();
                university.WriteAllFaculties();
                Console.Write("Добавить(1)/удалить(2)/выбрать(3) факультет или выйти(4)?         ");
                count = Console.ReadLine();
            }
        }
    }
}
