// Demonstrate Use Of Array In c#

using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sub, sum = 0;
            double avg;
         

            Console.WriteLine("Enter How Many Subjects : ");
            sub = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[sub];

            for(int i = 0; i < sub; i++)
            {
                Console.WriteLine("Enter Marks OF " + (i + 1) + " Student : ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }

           

            avg = sum / sub;
         
         
            Console.WriteLine("Average of "+sub+" Subjects is : "+avg);
        

            Console.ReadLine();
        }
    }
}
