using System;

namespace Algoritms
{
    public class ListOfAlgoritms
    {
        private static string[] MakeArray()
        {
            while (true)
            {
                Console.WriteLine("Введите размер массива или stop для выхода:");
                string countString = Console.ReadLine();
                if (countString.ToLower() == "stop")
                {
                    string[] result = new[] {"stop"};
                    return result;
                }
                else
                {
                    try
                    {
                        int countInt = int.Parse(countString);
                        string[] result = new string[countInt];
                        for (int i = 0; i < countInt; i++)
                        {
                            Console.Write($"Введите элемент массива № {i + 1}: ");
                            result[i] = Console.ReadLine();
                        }

                        return result;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Неверный ввод");
                    }
                }
            }

        
        }
        public static void PrimeNumber()  // Проверка простого числа
        {
            Console.WriteLine("Введите проверяемое число: ");
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

        public static void LinearSearch(bool better)
        {
            string[] mass = MakeArray();
            Console.Write("Введите искомое значение: ");
            string foundItem = Console.ReadLine();
            string answer = "Not found";
            if (mass[0].ToLower() != "stop")
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == foundItem)
                    {
                        answer = (i + 1).ToString();
                        if (better)
                        {
                            answer += "(Улучшенный поиск)";
                        }
                        break;
                    }
                }
                Console.WriteLine("Искомый элемент находится на позиции: " + answer);
            }
            
        }

        public static void SentenelLinerSearch()
        {
            string[] mass = MakeArray();
            Console.Write("Введите искомое значение: ");
            string foundItem = Console.ReadLine();
            string answer = "Not found";
            string last;
            if (mass[0].ToLower() != "stop")
            {
                if (mass[mass.Length - 1] == foundItem)
                {
                    answer = mass.Length.ToString();
                }
                else
                {
                    last = mass[mass.Length - 1];
                    mass[mass.Length - 1] = foundItem;
                    int i = 0;
                    while (true)
                    {
                        if (mass[i] == foundItem)
                        {
                            if (i != mass.Length - 1)
                            {
                                answer = ( i+1 ).ToString();
                            }
                            break;
                        }

                        i++;
                    }
                    mass[mass.Length - 1] = last;
                }
                Console.WriteLine("Искомый элемент находится на позиции: " + answer);
            }
        }

        private static int GetFactorial(int n)
        {
            if (n > 0)
                return n * GetFactorial(n - 1);
            else
                return 1;
        }
        public static void Factorial()
        {
            Console.WriteLine("Введите число для определения факториала: ");
            string numberString = Console.ReadLine();
            try
            {
                int numberInt = int.Parse(numberString);
                Console.WriteLine($"Факториал для числа {numberInt}: {GetFactorial(numberInt)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}