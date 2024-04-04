using System;

namespace ArrayFormulaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = n * n;
                n++;
            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("The largest element in the array is: " + max);
        }
    }
}
