using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            Console.WriteLine(FindSum(numbers));
        }
        public static float FindSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (float)sum/numbers.Length;
        }
    }
}
