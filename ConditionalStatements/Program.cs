using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature:");
            int temperature = Int32.Parse(Console.ReadLine());
            if(temperature < 20)
                Console.WriteLine("Take the coat");

            if(temperature == 20)
                Console.WriteLine("It is 10 degreees c");

            if(temperature > 20)
                Console.WriteLine("Cozy and warm!");

            Console.Read();
        }
    }
}
