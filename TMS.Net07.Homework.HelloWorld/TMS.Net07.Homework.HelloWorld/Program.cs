using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Введите целое число: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше число: " + number);
        }
    }
}
