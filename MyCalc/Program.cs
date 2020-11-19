using System;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyCalculator");
            Console.WriteLine("");
            Console.WriteLine("Введите первое число:");
            double argument_1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор:");
            string operation = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            double argument_2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = argument_1 + argument_2;
                    break;
                case "-":
                    result = argument_1 - argument_2;
                    break;
                case "*":
                    result = argument_1 * argument_2;
                    break;
                case "/":

                    if (argument_2 == 0)
                        Console.WriteLine("Делить на 0 нельзя!");

                    result = argument_1 / argument_2;
                    break;
            }

            Console.WriteLine("Результат:{0}", result);

        }
    }
}
