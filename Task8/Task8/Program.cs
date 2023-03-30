using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result = IsSimple(2);
            if(result)
                Console.WriteLine("eded sadedir");
            else 
            Console.WriteLine("Eded murekkebdir");
        }

        public static bool IsSimple(int num)
        {
            int count = 0;
            for (int i = 2; i*i <=num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count >=1) return false;
            return true;
        }
    }
}
