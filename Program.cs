using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ___2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Subject 1

            Console.WriteLine("Введите число: ");
            Int32 userNumberS1 = Convert.ToInt32(Console.ReadLine());

            if (userNumberS1 % 2 != 0) 
                Console.WriteLine("Вы ввели нечётное число."); 
            else 
                Console.WriteLine("Вы ввели чётное число.");

            #endregion

            #region Subject 2

            Int32 sumWeightCards = 0;
            Int32 idCard = 1;

            Console.WriteLine("Введите количество карт: ");
            Int32 numberOfCards = Convert.ToInt32(Console.ReadLine());

            for (int i = numberOfCards; i > 0; i--)
            {
                Console.WriteLine($"Введите вес карты №{idCard}: ");
                String weightCard = Console.ReadLine();

                switch (weightCard)
                {
                    case "J": 
                        sumWeightCards += 10;
                        break;
                    case "Q":
                        sumWeightCards += 10;
                        break;
                    case "K":
                        sumWeightCards += 10;
                        break;
                    case "T":
                        sumWeightCards += 10;
                        break;
                    default:
                        while ((Convert.ToInt32(weightCard) <= 0) || (Convert.ToInt32(weightCard) > 10))
                        {
                            Console.WriteLine("Введён некорректный вес карты. Диапазон чисел: от 1 до 10. Введите значение карты ещё раз: ");
                            weightCard = Console.ReadLine();
                        }
                        sumWeightCards += Convert.ToInt32(weightCard);
                        break;
                }
                idCard++;
            }
            Console.WriteLine($"Вес всех карт: {sumWeightCards}.");

            #endregion

            #region Subject 3

            Console.WriteLine("Введите число для проверки на признак простоты: ");
            Int32 userNumberS3 = Convert.ToInt32(Console.ReadLine());
            bool isNumberPrime = true;

            for (int i = 2; i < userNumberS3; i++)
            {
                if (userNumberS3 % i == 0)
                {
                    isNumberPrime = false;
                    break;
                }
            }
            if (isNumberPrime) Console.WriteLine("Ваше введённое число простое.");
            else Console.WriteLine("Ваше введённое число не простое.");

            #endregion

            #region Subject 4

            Int32 minValue = int.MaxValue;
            Int32 userValue;
            Console.WriteLine("Введите длину последовательности");
            Int32 length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Введите число: ");
                userValue = Convert.ToInt32(Console.ReadLine());

                if (userValue < minValue)
                {
                    minValue = userValue;
                }
            };

            Console.WriteLine($"Минимальное число: {minValue}");

            #endregion

            #region Subject 5

            Console.WriteLine("Введите максимальное число диапазона");
            Int32 maxUserNumber = Convert.ToInt32(Console.ReadLine());
            String enterUserNumber;
            
            Random random = new Random();
            Int32 randomNumber = random.Next(0, maxUserNumber);

            do{
                Console.WriteLine("Угадайте загаданное число: ");
                enterUserNumber = Console.ReadLine();

                if (enterUserNumber == "")
                {
                    Console.WriteLine($"Число что было загадано: {randomNumber}");
                    break;
                }    
                else if (Convert.ToInt32(enterUserNumber) > maxUserNumber || Convert.ToInt32(enterUserNumber) < 0)
                {
                    Console.WriteLine($"Число выходит из диапазона. Попробуйте ввести от 0 до {maxUserNumber}.\n");
                }
                else if (Convert.ToInt32(enterUserNumber) < randomNumber)
                {
                    Console.WriteLine("Число меньше загаданного числа.\n");
                }
                else if (Convert.ToInt32(enterUserNumber) > randomNumber)
                {
                    Console.WriteLine("Число больше загаданного числа.\n");
                } 
                else if (Convert.ToInt32(enterUserNumber) == randomNumber)
                {
                    Console.WriteLine($"Вы угадали число! Поздравляем!!!");
                    break;
                }

            } while (true) ;

            #endregion

            Console.ReadLine();
        }
    }
}
