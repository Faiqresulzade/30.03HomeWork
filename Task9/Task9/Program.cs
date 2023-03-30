using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(0,0));
        }

        public static int Pow(int num, int power)
        {
            int powNum = 1;
            for (int i = 0; i < power; i++)
            {
                powNum= powNum*num;
            }
            return powNum;
        }
    }
}
