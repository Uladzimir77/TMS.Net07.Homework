using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        static int TryParse(string dig)
        {
            int temp;
            if(!int.TryParse(dig,out temp))
            {
                Console.WriteLine("Некорректный ввод данных!");
            }
            return temp;
        }
        static void Main(string[] args)
        {
            string day, month, year;
            int tempDay, tempMonth, tempYear;

            Console.Write("Введите дату: ");
            day = Console.ReadLine();

            Console.Write("Введите месяц: ");
            month = Console.ReadLine();

            Console.Write("Введите год: ");
            year = Console.ReadLine();

            tempDay=TryParse(day);
            tempMonth = TryParse(month);
            tempYear = TryParse(year);

            DateTime dateValue = new DateTime(tempYear, tempMonth, tempDay);
            Console.WriteLine("Согласно введенным данным, день недели: " + dateValue.ToString("dddd"));

        }
    }
}
