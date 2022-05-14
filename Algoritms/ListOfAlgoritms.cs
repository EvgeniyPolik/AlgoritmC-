using System;

namespace Algoritms
{
    public class ListOfAlgoritms
    {
        public static void PrimeNumber()  // Проверка простого числа
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

        public static void LinearSearch()
        {
            bool doing = true;
            while (doing = true)
            {
                try
                {
                    Console.WriteLine("Введите размер массива: ");
                    string countString = Console.ReadLine();
                    if (countString == "stop")
                    {
                        break;
                    }
                    else
                    {
                        int count = int.Parse(countString);
                        Console.WriteLine("Введите искомый элемент:");
                        string foundNum = Console.ReadLine();
                        string[] mass = new string[count];
                        string answer = "Not Found";
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"Вводите элемент массива № {i + 1}: ");
                            mass[i] = Console.ReadLine();
                        }
                        for (int j = 0; j < count; j++)
                        {
                            if (mass[j] == foundNum)  // Собственно сам поиск(упрощенно) проверяем все элементы массива
                            {
                                answer = (j+1).ToString();
                            }
                        }
                        Console.WriteLine("Искомый элемент находится на позиции:" + answer);
                        break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Неверный ввод, для выхода введите stop");
                }
            }
 
            
        }
    }
}