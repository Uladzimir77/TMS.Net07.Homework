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
            bool i = true;

            while (i)
            {
                Console.Write("\nВведите целое число: ");
                string str = Console.ReadLine();

                if (int.TryParse(str, out number))
                {
                    Console.WriteLine("Ваше число: " + number);

                }
                else
                {
                    Console.WriteLine("\'" + str + "\'" + "- не является числом");

                }

                Console.WriteLine("\nЕсли вы хотите завершить работу приложения нажмите цифру (0)");
                str = Console.ReadLine();

                if (int.TryParse(str, out number))
                {
                    if (number == 0)
                        i = false;
                }
            }
        }
    }
}
