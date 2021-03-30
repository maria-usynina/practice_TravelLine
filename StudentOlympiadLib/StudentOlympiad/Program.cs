using StudentOlympiadLib;
using System;
using System.Collections.Generic;

namespace StudentOlympiad
{
    class Program
    {
        static void Main(string[] args)
        {
            Olympiad olymp = new Olympiad();

            string count = "да";
            while (count == "да") 
            {
                Console.Write("Введите фамилию участника:           ");
                string lastname = Console.ReadLine();
                Console.Write("Введите имя участника:               ");
                string name= Console.ReadLine();
                Console.Write("Введите отчество участника:          ");
                string middlename = Console.ReadLine();
                Console.Write("Введите кол-во баллов участника:     ");
                int score = Convert.ToInt32(Console.ReadLine());

                olymp.add(lastname, name, middlename, score);

                Console.Write("Продолжить ввод участников?(да/нет): ");
                count = Console.ReadLine();
            }

            for (int i = 0; i < olymp.students.Count; i++)
            {
                Console.WriteLine(olymp.students[i].Name + " " + olymp.students[i].LastName + " " + olymp.students[i].MiddleName + " " + olymp.students[i].Score);
            }

            Console.Write("Победитель:                       ");
            Console.WriteLine(olymp.students[olymp.winner(100)].Name + " " + olymp.students[olymp.winner(100)].LastName + " " + olymp.students[olymp.winner(100)].MiddleName);
            Console.Write("Максимальный результат участника: ");
            Console.WriteLine(olymp.maximum(100));
        }
    }
}
