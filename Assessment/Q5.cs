using System;
using System.Linq;

namespace Assessment11
{
    class Q5
    {
        public void Queries()
        {
            Console.WriteLine("Enter length of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            var result = from s in arr where s > 80 select s;

            if (result.Any())
            {
                Console.WriteLine("The numbers greater than 80 are:");
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No numbers greater than 80 found.");
            }
        }
    }
}