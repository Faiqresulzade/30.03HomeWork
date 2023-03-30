using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 8;
            Console.WriteLine(Calculate(num1, num2));
        }
        public static int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
