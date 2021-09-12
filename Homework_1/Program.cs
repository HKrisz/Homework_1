using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8] { 1, 6, 8, 4, 5, 7, 2, 3 };

            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }


            Console.Write($"A legnagyobb szám a tömbben: {maxNumber}");
            


            Console.ReadKey();
        }
    }
}
