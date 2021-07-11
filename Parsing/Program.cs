using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Ravi";
            string last = "Sharma";
            string full = first + last;
            Console.WriteLine(full);

            string stringNumber = "15"; //If not parsable then we'll get unhandled exception
            //System.FormatException: Input String was not in correct format.
            int number = Int32.Parse(stringNumber); //TryParse(); another method 
            Console.WriteLine(number);

            _ = Console.Read();
        }
    }
}
