using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algoritms
{
    internal class Program
    {
        private static void SelAlgoritm(int selectedAlgoritm, string nameAlgoritm)  //Метод вызова выбранного алгоритма
        {
            Console.WriteLine("Выбран алгоритм: " + nameAlgoritm);
            if (selectedAlgoritm == 1)
            {
                ListOfAlgoritms.PrimeNumber();
            }
            else if (selectedAlgoritm == 2)
            {
                ListOfAlgoritms.LinearSearch(false);   
            }
            else if (selectedAlgoritm == 3)
            {
                ListOfAlgoritms.LinearSearch(true);
            }
            else if (selectedAlgoritm == 4)
            {
                ListOfAlgoritms.SentenelLinerSearch();
            }
            else if (selectedAlgoritm == 5)
            {
                ListOfAlgoritms.Factorial();
            }
            else if (selectedAlgoritm == 6)
            {
                ListOfAlgoritms.DoRecursiveLinerSearch();
            }
            else if (selectedAlgoritm == 8)
            {
                ListOfAlgoritms.DoSelectedSort();
            }
            
        }

        public static void Main(string[] args)
        {

            Dictionary<int, string> catalogAlgoritms = new Dictionary<int, string>() //Словарь алгоритмов
            {
                {1, "Простое число"},
                {2, "Линейный поиск"},
                {3, "Улучшенный линейный поиск"},
                {4, "Сторожевой линеный поиск"},
                {5, "Факториал (рекурсия)"},
                {6, "Рекурсивный линейный поиск"},
                {7, "Pass"},
                {8, "Сортировка выбором"}
            };

            while (true)  // Интрефейс выбора алгоритма
            {
                Console.WriteLine("Выберите алгоритм:");
                for (int i = 1; i < catalogAlgoritms.Count + 1; i++)
                {
                    Console.WriteLine(i.ToString() + " " + catalogAlgoritms[i]);
                }
                Console.WriteLine("Введите номер алгоритма или exit для выхода: ");
                string inputStr = Console.ReadLine(); // ввод номера алгоритма
                Debug.Assert(inputStr != null, nameof(inputStr) + " != null");
                if (inputStr.ToLower() == "exit")
                {
                    return;  // Завершаем метод, выходим из программы
                }

                try  // проверка корректности ввода
                {
                    int numberOfAlgoritm = int.Parse(inputStr);
                    SelAlgoritm(numberOfAlgoritm, catalogAlgoritms[numberOfAlgoritm]);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Неверный формат ввода");
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    Console.WriteLine("Неверный выбор");
                }
                    
            }
            
        }
    }
}