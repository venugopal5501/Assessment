using System;

namespace Assessment
{
    class Q7
    {
        public void strings()
        {
            Console.WriteLine("Enter the number of strings:");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter string {i + 1}: ");
                arr[i] = Console.ReadLine();
            }

            // Get specific length from user to filter strings by length.
            Console.Write("Enter the specific minimum length: ");
            int specificLength;

            if (!int.TryParse(Console.ReadLine(), out specificLength))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            var minLengthStrings = from s in arr where s.Length >= specificLength select s;

            if (minLengthStrings.Any())
            {
                foreach (var item in minLengthStrings)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"No strings found with a minimum length of {specificLength}.");
            }
        }
    }
}