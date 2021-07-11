using System;

namespace StringMethods
{
    class Program
    {
        /* String is an object of the System.String class. Here in programming terms
            string means sequence of characters.

            Functions of the string class are used to manipulate and to perform various action on given
            String.
            
            SubString(int32)
            ToLower()
            ToUppre()
            Trim()
            IndexOf(string)
            IsNullOrWhiteSpace() - returns true if the string is either null or is blank else it return false
            String.Format() - is used to insert the object or variable value inside any string
            with String.Format() - we can replace the value in the specified format.
            Syntax: String.Format("any string {index}", Object);
         */
        static void Main(string[] args)
        {
            string firstName = "ravi";
            string lastName = "sharma";
            string fullName = string.Concat("", firstName, lastName, "");
            Console.WriteLine(fullName);

            Console.WriteLine("String concatenation using + operator");
            Console.WriteLine(firstName + " "+ lastName);
            
            string t = String.Format("My Name is {0}", fullName);
            Console.WriteLine(t);

            char searchInput = Console.ReadLine()[0];
            Console.WriteLine(searchInput);
        }
    }
}
