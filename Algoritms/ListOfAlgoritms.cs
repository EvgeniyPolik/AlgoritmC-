using System;

namespace Algoritms
{
    public class ListOfAlgoritms
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Введите проверяемое число");
            string numberStr = Console.ReadLine();
            int numberRepit;
            try
            {
                int numberInt = int.Parse(numberStr);
                if (numberInt < 10)
                {
                    numberRepit = numberInt;
                }
                else
                {
                    numberRepit = (int) Math.Pow(numberInt, 0.5);
                }
                
                bool prime = true;
                for (int i = 2; i < numberRepit; i++)
                {
                    if (numberInt % i == 0)
                    {
                        prime = false;
                    }
                }

                if (prime)
                {
                    Console.WriteLine("Введенное число " + numberStr + " - простое");
                }
                else
                {
                    Console.WriteLine("Введенное число " + numberStr + " - составное");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Не верный ввод");
            }
        }
    }
}