using System;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n = 5;
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(" "+j);
                }
                Console.WriteLine();
            }
        }
    }
}
/*
OUTPUT:
 5 4 3 2 1
 5 4 3 2
 5 4 3
 5 4
 5
 
 */