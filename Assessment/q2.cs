using System;

namespace Assessment
{
    internal class Q2
    {
        public void Demo()
        {
            Console.Write("Enter the number of terms: ");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci series up to " + j + " terms:");

            for (int i = 0; i < j; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.WriteLine();
        }

        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}