// Write C# Program  to Demonstrate use of Multiple Inheritance.
using System;

namespace multipleInherit
{
    interface Ilanguages
    {
        void Lang();
    }
    interface Icourses
    {
         void Course();
    }
    public class Demo : Ilanguages , Icourses
    {
        public void Lang()
        {
            Console.WriteLine("C");
            Console.WriteLine("CPP");
            Console.WriteLine("C#");
            Console.WriteLine("JAVA");
        }

        public void Course()
        {
            Console.WriteLine("Software Development");
            Console.WriteLine("Web Development");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();

            d1.Lang();
            d1.Course();

            Console.ReadLine();
        }
    }
}
