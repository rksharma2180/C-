using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operator
            num3 = -num1;//Multiplies with -1
            Console.WriteLine("Num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //C# has increment/decrement operators 
            //++, --
            
            //Binary Operators 
            //Arithmetic Operators
            //+, -, *, /, %, 
            
            //Relational Operators
            //<, >, 
            
            //Equality Operators
            //==, != operators

            //Conditional Operators
            // &&, ||, 

            Console.ReadKey();
        }
    }
}
