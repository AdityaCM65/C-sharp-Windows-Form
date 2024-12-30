// Demonstrate use of Functions and Objects in c#

using System;

namespace funcObject
{
    class Demo
    {
        int a, b, sum , sub , mul , div;
        public void read()
        {
            Console.WriteLine("Enter First Number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public void calc()
        {
            sum = a + b;
            Console.WriteLine("The Addition Of A : "+a+" B : "+b+" is :-> "+sum);
            sub = a - b;
            Console.WriteLine("The Substraction Of A : "+a+" B : "+b+" is :-> "+sub);
            mul = a * b;
            Console.WriteLine("The Multiplication Of A : "+a+" B : "+b+" is :-> "+mul);
            div = a / b;
            Console.WriteLine("The Division Of A : " + a + " B : " + b + " is :-> " +div);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            d1.read();
            d1.calc();

            Console.ReadLine();
        }
    }
}
