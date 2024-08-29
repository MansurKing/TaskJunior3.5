using System;

namespace TaskJunior3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minValue = 0;
            int maxValue = 9;

            int arraySize = 30;
            int[] numbers = new int[arraySize];
            int lastNumberIndex = numbers.Length - 1;

            int maxCount = 0;
            int maxNumber = 0;

            Console.WriteLine(numbers.Length + " - кол-во элементов в самом массиве.\n\nМассив:\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int count = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                    else if (count > maxCount)
                    {
                        maxCount = count;
                        maxNumber = numbers[i];
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumber = numbers[i];
                }
            }

            Console.WriteLine("\n\nЧисло, которое повторяется подряд: " + maxNumber);
            Console.WriteLine("Количество повторений: " + maxCount);
        }
    }
}
