// Write C# Program To Demonstrate use of Single Inheritance.

using System;

namespace singleInherit
{
    public class Voting
    {
        public int age;

       public void Read()
        {
            Console.WriteLine("Enter Your Age : ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Cvoting : Voting
    {
        public void Check()
        {
            if(age >= 18)
            {
                Console.WriteLine("Eligible For Voting");
            }
            else
            {
                Console.WriteLine("Not Eligible For Voting");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cvoting v1 = new Cvoting();
            v1.Read();
            v1.Check();

            Console.ReadLine();
        }
    }
}
