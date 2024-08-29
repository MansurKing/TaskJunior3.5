using System;

namespace TaskJunior3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int firstValueRandom = 0;
            int finishValueRandom = 10;

            int numberOfNumbers = 30;
            int[] numbers = new int[numberOfNumbers];
            int lastNumberIndex = numbers.Length - 1;

            int baseNumbersInARow = 1;
            int numbersInARow = 1;
            int recurringNumber = 0;


            Console.WriteLine(numbers.Length + " - кол-во элементов в самом массиве.\n\nМассив:\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(firstValueRandom, finishValueRandom);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nПоиск повторяющихся чисел:\n");

            for (int i = 0; i < lastNumberIndex; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbersInARow++;

                    if (numbersInARow >= baseNumbersInARow)
                    {
                        recurringNumber = numbers[i];
                        baseNumbersInARow = numbersInARow;
                    }
                    else
                    {
                        numbersInARow = 1;
                    }
                }
            }

            if (baseNumbersInARow > 1)
            {
                Console.WriteLine($"\nЧисло {recurringNumber} повторяется {baseNumbersInARow} раз/а подряд.");
            }
            else
            {
                Console.WriteLine("\nНет повторяющихся подряд чисел.");
            }
        }
    }
}


