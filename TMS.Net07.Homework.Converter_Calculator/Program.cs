using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Converter_Calculator
{
    class Program
    {  
       static bool ExitProg( string exitMessage) //запрос на окончание работы прог-мы
       {
            char end;

            Console.WriteLine(exitMessage);
            end = char.Parse(Console.ReadLine().ToLower());

            if(end == 'y')
            {
                return true;
            }

            return false;
       }
        static void Main(string[] args)
        {
            double digit1;
            double digit2;
            double outcome = 0;
            char calcSymbol;
            const string errorMessage = "Некорректный ввод данных!";
            const string exitMessage = "Вы хотите прдолжить? Y - да, любая другая клавиша - нет";
            const string errorDivision = "На ноль делить нельзя!";
            bool exit = true;

            while (exit) 
            {
                Console.Write("Введите первое число: ");

                if(!double.TryParse(Console.ReadLine(), out digit1)) //проверка парсинга в double 1-го значения
                {
                    Console.WriteLine(errorMessage);

                    if (exit = ExitProg(exitMessage)) 
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Введите второе число: "); 

                if (!double.TryParse(Console.ReadLine(), out digit2)) //проверка парсинга в double 2-го значения
                {
                    Console.WriteLine(errorMessage);

                    if (exit = ExitProg(exitMessage))
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("Введите симмвол вычисления (+,-,/,*,%): ");

                if (char.TryParse(Console.ReadLine(), out calcSymbol)) // проверка парсинга в char символа вычисления
                {
                    if ((calcSymbol != '+') && (calcSymbol != '/') && (calcSymbol != '*') && (calcSymbol != '-') && (calcSymbol != '%')) //проверка на соответствие символам вычисления
                    {
                        Console.WriteLine(errorMessage);

                        if (exit = ExitProg(exitMessage))
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                switch (calcSymbol) // вычисление значений
                {
                    case '+':
                        outcome = digit1 + digit2;
                        break;

                    case '-':
                        outcome = digit1 - digit2;
                        break;

                    case '/':
                        if(digit2!=0) // проверка деления на ноль
                        {
                            outcome = digit1 / digit2;
                        }
                        else
                        {
                            Console.WriteLine(errorDivision);

                            if (exit = ExitProg(exitMessage))
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                return;
                            }
                        }
                        break;

                    case '*':
                        outcome = digit1 * digit2;
                        break;

                    case '%':
                        outcome = digit1 % digit2;
                        break;

                    default:
                        Console.WriteLine(errorMessage);
                        break;
                }

                Console.WriteLine($"{digit1} {calcSymbol} {digit2} = {outcome}");

                if (exit = ExitProg(exitMessage))
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
