using System;

namespace Methods
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method");
            WriteSomething();
        }

        static void WriteSomething() {
            Console.WriteLine("I am called from method");
        }
    }
}
