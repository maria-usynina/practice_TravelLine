using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count == 1) 
            {             
                Console.Write("Введите первое число:                  ");
                int first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число:                  ");
                int second_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите действие над числами(+,-,*,/): ");
                string  action = Console.ReadLine();
                int result = 0;

                if (action == "+")
                {
                    result = first_number + second_number;
                }
                if (action == "-")
                {
                    result = first_number - second_number;
                }
                if (action == "*")
                {
                    result  = first_number * second_number;
                }
                if (action == "/")
                {
                    result = first_number / second_number;
                }
                Console.Write("Результат:                             ");
                Console.WriteLine(result);
                Console.Write("Введите 1, если хотите продолжить: ");
                count = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }

        }
    }
}
