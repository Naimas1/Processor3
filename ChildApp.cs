using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processor3
{
    internal class ChildApp
    {
        void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Неверное количество аргументов.");
                return;
            }

            // Извлечение аргументов командной строки
            double num1 = double.Parse(args[0]);
            double num2 = double.Parse(args[1]);
            string operation = args[2];

            // Выполнение операции
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    return;
            }

            // Вывод аргументов и результата операции
            Console.WriteLine($"Аргументы: {num1}, {num2}, {operation}");
            Console.WriteLine("Результат операции: " + result);
        }
    }
}
