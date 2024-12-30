// Write a C# code to show addition of array elements

using System;

namespace addtionArrele
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter size of an Array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            int sum = 0;

            Console.WriteLine("Enter Array Elements : ");
            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

            Console.WriteLine("Sum of Array Elements Is : "+sum);

            Console.ReadLine();
        }
    }
}
