using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = IsEven(11);
            if (result)
                Console.WriteLine("eded cutdur");
            else
                Console.WriteLine("eded tekdir");
        }
        public static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
