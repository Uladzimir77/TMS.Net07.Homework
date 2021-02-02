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

            if (!int.TryParse(dig, out temp))
            {
                Console.WriteLine("Некорректный ввод данных!");
            }

            return temp;
        }
        static void Main(string[] args)
        {
            string date, day, month, year, editDate;
            int tempDay, tempMonth, tempYear;
            string[] arrayStr;

            Console.Write("Введите дату (день.месяц.год): ");
            date = Console.ReadLine();

            editDate = date.Replace(".", " ");
            arrayStr = editDate.Split(new char[] { ' ' });

            day = arrayStr[0];
            month = arrayStr[1];
            year = arrayStr[2];

            tempDay = TryParse(day);
            tempMonth = TryParse(month);
            tempYear = TryParse(year);

            DateTime dateValue = new DateTime(tempYear, tempMonth, tempDay);
            Console.WriteLine("\nСогласно введенным данным, день недели: " + dateValue.ToString("dddd") + "\n");
        }
    }
}
