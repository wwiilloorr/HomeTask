using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int PlayerNumber = 0;

            Console.Write("Введіть довжину масиву: ");
            PlayerNumber = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[PlayerNumber];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(100, 900);
            }

            int minimum = 900;
            int suma = 0;

            for (int i = 0; i < number.Length; i++)
            {

                if (number[i] < minimum)
                {
                    minimum = number[i];
                }
                suma += number[i];
            }

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(PlayerNumber + " : " + number[i]);
            }
            Console.WriteLine("Середнє арифметичне значення всіх чисел:" + (suma / PlayerNumber));
            Console.WriteLine("Мінімальне число в масиві: " + minimum);


        }
    }
}
