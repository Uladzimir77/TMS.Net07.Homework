using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Converter_Calculator
{
    class Program
    {
        static int Fibonacci(int fib)
        {
            if (fib < 2)
            {
                return fib;
            }

            return Fibonacci(fib - 1) + Fibonacci(fib - 2);
        }
        static void Main(string[] args)
        {
            int fib;

            Console.Write("Введите число: ");
            fib = int.Parse(Console.ReadLine());

            Console.WriteLine("Число Фибоначчи  равно: " + Fibonacci(fib));
        }
    }
}
