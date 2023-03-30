using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(3.5f);
        }
        public static void Calculate(float num)
        {
            int residue = 0;
            int sum = (int)num + 1;
            if ((sum - num) <=0.5)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(sum-1);
            }
        }
    }
}
