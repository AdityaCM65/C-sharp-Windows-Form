// Write a C# Code to Show Even Numbers Between 1 to 10

using System;

namespace evenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();


        }
    }
}
