using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algoritms
{
    internal class Program
    {
        private static void SelAlgoritm(int selectedAlgoritm, string nameAlgoritm)
        {
            Console.WriteLine("Выбран алгоритм: " + nameAlgoritm);
            if (selectedAlgoritm == 1)
            {
                ListOfAlgoritms.PrimeNumber();
            }
        }

        public static void Main(string[] args)
        {

            Dictionary<int, string> catalogAlgoritms = new Dictionary<int, string>()
            {
                {1, "Простое число"}
            };

            while (true)
            {
                Console.WriteLine("Выберите алгоритм:");
                for (int i = 1; i < catalogAlgoritms.Count + 1; i++)
                {
                    Console.WriteLine(i.ToString() + " " + catalogAlgoritms[i]);
                }
                Console.WriteLine("Введите номер алгоритма или exit для выхода: ");
                string inputStr = Console.ReadLine();
                Debug.Assert(inputStr != null, nameof(inputStr) + " != null");
                if (inputStr.ToLower() == "exit")
                {
                    return;
                }

                try
                {
                    int numberOfAlgoritm = int.Parse(inputStr);
                    SelAlgoritm(numberOfAlgoritm, catalogAlgoritms[numberOfAlgoritm]);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Не верный формат ввода");
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    Console.WriteLine("Не верный выбор");
                }
                    
            }
            
        }
    }
}