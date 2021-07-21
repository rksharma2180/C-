using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            // By Using tryParse() method we can convert a string like "128" into a numeric datatype
            // like an integer
            // tryParse available in float, double
            Console.WriteLine("Enter any number");
            string numberAsString = Console.ReadLine();
            int parsedValue;
            bool isParsed = int.TryParse(numberAsString, out parsedValue);
            if(isParsed)
                Console.WriteLine("Parsed Integar :{0}", parsedValue);
            else
                Console.WriteLine("Unable to parse String to integar: {0}", numberAsString);
        }
    }
}
