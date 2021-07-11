using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //define few variables
            int age = 31;
            string name = "Ravi";
            string job = "Developer";

            //1. String concatenation 
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello My Name is " + name + ", I am " + age + " years old.");

            //2. String formatting
            //string formatting uses index
            Console.WriteLine("String concatenation");
            Console.WriteLine("Hello My Name is {0}, I am {1} years old. I am {2}", name, age, job);

            //3. String interpolation
            //string interpolation uses $ at the start which will allow us to write our variables like 
            //variables like this {variablenames}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello My Name is {name}, I am {age} years old. I am {job}");

            //4. Verbatim String
            //Verbatim string starts with @ and tells the compiler to take the string literally and ignore
            //any spaces and special characters like \n
            Console.WriteLine("Verbatim String");
            Console.WriteLine(@"I am very new to C#. I have just run, C# 'Hello World' program using Visual Studio.

            Can I run or compile a C# program without using Visual Studio?

            If it is possible, then which compiler should I use?

            Thanks");
            //If we remove @ then we'll get error cause \W and \c are not valid escape characters
            Console.WriteLine(@"E:\Workspace-2020\c#");

            Console.WriteLine("This is \n my page");
            //With Verbatim string even the valid escape character doesn't work
            Console.WriteLine(@"This is \n my page");
        }
    }
}
