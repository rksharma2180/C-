using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop");
            for (int i=0; i< 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("While Loop");
            int count = 0;
            while(count < 10)
            {
                Console.WriteLine(count++);
            }
            Console.WriteLine("Do while Loop");
            count = 10;
            do
            {
                Console.WriteLine(count--);
            } while (count > 0);
        }
    }
}
