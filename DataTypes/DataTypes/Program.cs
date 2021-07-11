using System;

/*Primitive Data Types:
    sbyte i = 120; //signed byte whole number from -128 to 127
    short x = 3000; //whole number from -32768 to 32767
    int x = 200000; // whole number from -2147483648 to 2147483647
    long x = 100000; // whole number from -9223327036854775808 to 9223327036854775807
    float x = 99.99f; // 7 digit precision
    double x = 1.5; //15 digit precesion
    decimal x = 1.5; //28 digit precesion
    bool switch = true; // true/false
    char singleLetter = 'A';

Non primitive
    string s = "jason1995";
*/
namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int num1;

            //Declaring cum initializing the variable
            int number = 5;//readonly struct System.Int32
            double d = 3.2;//System.Double
            string s = "ravi"; //System.String coding standard is use small string
            string s1 = s.ToUpper();
            string s2 = s1.ToLower();

            Console.WriteLine(number);
            Console.WriteLine(d);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
