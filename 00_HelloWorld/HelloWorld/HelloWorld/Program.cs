using System;//import library

namespace HelloWorld //project name or the name space like packages in the java
{
    class Program
    {
        //Entry point of our program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //writes the string to the console at new line
            Console.WriteLine(Console.ReadLine()); //Reads the line
            Console.ReadKey(); //keep the console open to read the key
        }
    }
}
