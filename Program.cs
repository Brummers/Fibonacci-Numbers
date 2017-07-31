using System;
using System.Numerics;

namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int? fibLength = null;
            BigInteger total = 0, first = 0, second = 1;
            Console.WriteLine("Enter sequence Length: ");
            while (fibLength == null)
            {
                try
                {
                    fibLength = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error, input an integer only!");
                    Console.WriteLine("Enter sequence Length: ");
                }
            }
            Console.Write("Fibonacci sequence with a length of " + fibLength);
            Console.WriteLine();
            for (int i = 0; i < fibLength; i++)
            {
                total = first + second;
                second = first;
                first = total;
                int n = i + 1;
                Console.WriteLine("Fibonacci number " + n + " is: " + total);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
        }
    }
}
