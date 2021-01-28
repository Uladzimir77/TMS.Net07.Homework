using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        enum DaysOfWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static void Main(string[] args)
        {
            string day;
            string exitProg = "exit";

            Console.WriteLine("Введите день недели, на англ. языке.");
            Console.WriteLine("Пример ввода - Monday, для выхода из программы введте - exit.");

            do
            {
                Console.Write("\nENG: ");
                day = Console.ReadLine();

                Console.Write("RUS: ");

                switch (day)
                {
                    case "Monday":
                        Console.WriteLine($"{DaysOfWeek.Понедельник}"); break;
                    case "Tuesday":
                        Console.WriteLine($"{DaysOfWeek.Вторник}"); break;
                    case "Wednesday":
                        Console.WriteLine($"{DaysOfWeek.Среда}"); break;
                    case "Thursday":
                        Console.WriteLine($"{DaysOfWeek.Четверг}"); break;
                    case "Friday":
                        Console.WriteLine($"{DaysOfWeek.Пятница}"); break;
                    case "Saturday":
                        Console.WriteLine($"{DaysOfWeek.Суббота}"); break;
                    case "Sunday":
                        Console.WriteLine($"{DaysOfWeek.Воскресенье}"); break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод данных!"); break;

                }
            } while (day != exitProg);
        }
    }
}
