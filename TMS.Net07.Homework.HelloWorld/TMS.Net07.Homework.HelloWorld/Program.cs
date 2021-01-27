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
            string str = Console.ReadLine();

            if (int.TryParse(str, out number))
            {
                Console.WriteLine("Ваше число: " + number);
            }
            else
            {
                Console.WriteLine("\'" + str + "\'" + "- не является числом");
            }
        }
    }
}
