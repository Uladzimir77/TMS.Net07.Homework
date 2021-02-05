using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Converter_Calculator
{
    class Program
    { 
        static void Main(string[] args)
        {
            int fact=1;
            int dig;

            Console.Write("Введите число: ");
            dig = int.Parse(Console.ReadLine());

            for(int i = 2; i <= dig; ++i)
            {
                fact *= i;
            }

            Console.WriteLine($"Факториал числа {dig} равен {fact}");
        }
    }
}
