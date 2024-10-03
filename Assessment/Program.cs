using System;
using Assessment;
using Assessment1;
using Assessment11;

class Program
{
    public void Pattern()
    {
        int count = 1;
        Console.Write("Enter Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {
            // Print leading spaces
            for (int j = i; j < a; j++)
            {
                Console.Write(" ");
            }

            // Print the pattern numbers
            for (int k = 1; k <= i; k++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Pattern");
            Console.WriteLine("2. Fibonacci");
            Console.WriteLine("3. Student Mark");
            Console.WriteLine("4. Delegate");
            Console.WriteLine("5. LINQ greater than 80");
            Console.WriteLine("6. String Length");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Program obj = new Program();
                    obj.Pattern();
                    break;

                case 2:
                    Q2 obj1 = new Q2();
                    obj1.Demo();
                    break;

                case 3:
                    Q3 obj2 = new Q3(); // Assuming Q3 is the class for Student Management
                    obj2.Demos();
                    break;

                case 4:
                    Q4 obj3 = new Q4();
                    obj3.Dele();
                    break;

                case 5:
                    Q5 obj4 = new Q5();
                    obj4.Queries();
                    break;

                case 6:
                    Q7 obj5 = new Q7();
                    obj5.strings();
                    break;

                case 0:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, 4, or 5.");
                    break;
            }
        }
    }
}