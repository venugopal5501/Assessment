using System;
class Program
{
    public static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] rem = new int[32];
        int count = 0;
        while (num > 0)
        {
            rem[count] = num % 2;
            num = num / 2;
            count++;
        }
        int[] dem = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            if (rem[i] == 0)
            {
                rem[i] = 1;
                dem[i] = rem[i];
            }
            else
            {
                rem[i] = 0;
                dem[i] = rem[i];
            }
            dem[i] = rem[i];

            // Console.Write(rem[i]);
            Console.Write(dem[i]);
            
        }

        
        Console.WriteLine();
        for (int i = 0; i < dem.Length; i++)
        {
            Console.Write(dem[i]);
        }
    }
}