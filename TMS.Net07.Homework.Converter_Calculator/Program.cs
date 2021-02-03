using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Converter_Calculator
{
    class Program
    {
        static void Outcome(double sum, double currentByn, string targetMoney)
        {
            double outcome;

            outcome = sum * currentByn;

            Console.WriteLine("Сумма в {0}: {1:0.0000}", targetMoney, outcome);
        }
        static void Main(string[] args)
        {
            double sum, outcome;
            double currentUsd = 0;
            double currentEuro = 0;
            double currentRub = 0;
            double currentByn = 0;
            string sourceMoney, targetMoney;
            const string moneyUsd = "USD";
            const string moneyEuro = "EURO";
            const string moneyByn = "BYN";
            const string moneyRub = "RUB";

            Console.Write("Введите вашу валюту (USD,EURO,BYN,RUB): ");
            sourceMoney = Console.ReadLine();

            Console.Write("Введите предпочитаемую валюту (USD,EURO,BYN,RUB): ");
            targetMoney = Console.ReadLine();

            Console.Write("Введите сумму: ");

            if (!double.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Некорректный ввод данных");
            }

            if(sourceMoney == moneyUsd)
            {
                currentEuro = 0.8294;
                currentRub = 75.8451;
                currentByn = 2.6251;
            }

            if ((sourceMoney == moneyUsd) &&(targetMoney == moneyByn))
            {
                Outcome(sum, currentByn, targetMoney);
            }
            else if ((sourceMoney == moneyUsd) && (targetMoney == moneyEuro))
            {
                Outcome(sum, currentEuro, targetMoney);
            }
            else if ((sourceMoney == moneyUsd) && (targetMoney == moneyRub))
            {
                Outcome(sum, currentRub, targetMoney);
            }


            if (sourceMoney == moneyByn)
            {
                currentEuro = 0.316;
                currentRub = 28.8934;
                currentUsd = 0.381;
            }

            if ((sourceMoney == moneyByn) && (targetMoney == moneyUsd))
            {
                Outcome(sum, currentUsd, targetMoney);
            }
            else if ((sourceMoney == moneyByn) && (targetMoney == moneyEuro))
            {
                Outcome(sum, currentEuro, targetMoney);
            }
            else if ((sourceMoney == moneyByn) && (targetMoney == moneyRub))
            {
                Outcome(sum, currentRub, targetMoney);
            }


            if (sourceMoney == moneyEuro)
            {
                currentByn = 3.165;
                currentRub = 91.4476;
                currentUsd = 1.2057;
            }

            if ((sourceMoney == moneyEuro) && (targetMoney == moneyUsd))
            {
                Outcome(sum, currentUsd, targetMoney);
            }
            else if ((sourceMoney == moneyEuro) && (targetMoney == moneyByn))
            {
                Outcome(sum, currentByn, targetMoney);
            }
            else if ((sourceMoney == moneyEuro) && (targetMoney == moneyRub))
            {
                Outcome(sum, currentRub, targetMoney);
            }


            if (sourceMoney == moneyRub)
            {
                currentByn = 0.0346;
                currentEuro = 0.0109;
                currentUsd = 0.0132;
            }

            if ((sourceMoney == moneyRub) && (targetMoney == moneyUsd))
            {
                Outcome(sum, currentUsd, targetMoney);
            }
            else if ((sourceMoney == moneyRub) && (targetMoney == moneyByn))
            {
                Outcome(sum, currentByn, targetMoney);
            }
            else if ((sourceMoney == moneyRub) && (targetMoney == moneyEuro))
            {
                Outcome(sum, currentEuro, targetMoney);
            }
        }
    }
}
