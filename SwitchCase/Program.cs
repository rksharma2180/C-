using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age!");
            Int32.TryParse(Console.ReadLine(), out int age);
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young for partying");
                    break;
                case 20:
                    Console.WriteLine("You just completed highschool");
                    break;
                default:
                    Console.WriteLine("You can do whatever you want!");
                    break;
            }
        }
    }
}
