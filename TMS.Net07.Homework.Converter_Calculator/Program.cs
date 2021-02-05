using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Converter_Calculator
{
    class Program
    { 
        static int Fact(int dig)
        {
            int temp;

            if ((dig == 1) || (dig == 0))
            {
                return temp = 1;
            }

            return temp = dig * Fact(dig - 1);
        }
        static void Main(string[] args)
        {

            int dig;
            int fact;

            Console.Write("Введите число для расчета факториала: ");
            dig = int.Parse(Console.ReadLine());

            fact = Fact(dig);

            Console.WriteLine($"Факториал числа {dig} равен {fact}");
        }
    }
}
