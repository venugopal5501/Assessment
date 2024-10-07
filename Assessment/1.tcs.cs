using System;
class Program
{
    public static void Main(string[] args)
    {
        int length = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[length];


        for (int i = 0; i < length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            if (arr[i] != 0)
            {
                count++;
            }
        }
        int[] arr1 = new int[count];
        int index = 0;
        for (int i = 0; i < length; i++)
        {
            if (arr[i] != 0)
            {
                arr1[index] = arr[i];
                index++;
            }
        }
        int counts = 0;
        for (int i = 0; i < length; i++)
        {
            if(arr[i]==0){
                counts++;
            }
        }
        int indexs=0;
        int []arr2=new int[counts];
        for(int i=0;i<length;i++){
            if(arr[i]==0){
                arr[indexs]=arr[i];
                indexs++;
            }
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
    }
}