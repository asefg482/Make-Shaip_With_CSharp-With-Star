using System;

namespace Art_Show
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int i = x; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
