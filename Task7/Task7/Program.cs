using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(1.1m));
        }

        public static decimal Power(decimal num1)
        {
            return num1 * num1;
        }
    }
}
