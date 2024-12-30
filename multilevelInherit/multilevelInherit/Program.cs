// Write C# Program to Demonstrate Use of Multilevel Inheritance.

using System;

namespace multilevelInherit
{
    public class Student
    {
        public int roll;
        public string name;
        public void Read()
        {
            Console.WriteLine("Enter Roll Number : ");
            roll = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();

        }
    }
    public class Exam : Student
    {
        public int math, phy, chem;

        public void ReadMarks()
        {
            Console.WriteLine("Enter Math Marks : ");
            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Marks : ");
            phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Marks : ");
            chem = Convert.ToInt32(Console.ReadLine());
        }
    }
    public class Result  : Exam
    {

        public int avg;
        public void DisplayResult()
        {

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll Number : " + roll);
            Console.WriteLine("Math : " + math);
            Console.WriteLine("Physics : " + phy);
            Console.WriteLine("Chemistry : " + chem);

            avg = math + phy + chem / 3;
            Console.WriteLine("Average : "+avg);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Result r1 = new Result();
            r1.Read();
            r1.ReadMarks();
            r1.DisplayResult();

            Console.ReadLine();
        }
    }
}
