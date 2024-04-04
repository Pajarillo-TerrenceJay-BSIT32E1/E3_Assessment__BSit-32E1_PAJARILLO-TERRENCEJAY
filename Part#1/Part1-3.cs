using System;

namespace SquareRootLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                double sqrt = Math.Sqrt(i);
                Console.WriteLine("The square root of {0} is {1}", i, sqrt);
            }
        }
    }
}
