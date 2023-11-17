using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {

        public static void PlayGame(int numF, int numS)
        {

            Random random = new Random();
            int numberF = 0;

            int[] number = new int[100];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1, 6);
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == numF)
                {
                    numberF++;
                }
            }
            Console.WriteLine("Number " + "_" + numS + "_" + " repeated: " + "_" + numberF + "_" + " times!");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            PlayGame(1, 1);
            PlayGame(2, 2);
            PlayGame(3, 3);
            PlayGame(4, 4);
            PlayGame(5, 5);
        }
    }
}

