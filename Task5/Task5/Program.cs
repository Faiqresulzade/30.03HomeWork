using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOkey(true));
        }
        public static string IsOkey(bool result)
        {
            if (result) return "Beli";
            else return "Xeyr";
        }
    }
}
