using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.Write("Введите число: ");

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Некорректный ввод числа!");
            }

            int[] array = new int[number + 1];

            int nFibonacci = Fibonacci(number, array);

            Console.WriteLine("Число Фибоначчи равно: " + nFibonacci);
        }

        static int Fibonacci(int number, int[] array)
        {
            if (number == 0 || number == 1)
            {
                array[number] = number;
                return number;
            }

            if (array[number] == 0)
            {
                array[number] = Fibonacci(number - 1, array) + Fibonacci(number - 2, array);
            }

            return array[number];
        }
    }
    
}
