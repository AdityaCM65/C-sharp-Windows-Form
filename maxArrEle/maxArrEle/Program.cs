// Write a C# code to show maximum value from array elements.

using System;

namespace maxArrEle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size , temp = 0;
            Console.WriteLine("Enter Size of an Array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter Array Elements : ");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < size; i++)
            {
               if(arr[0] < arr[i])
                {
                    temp = arr[i];
                }
            }
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
