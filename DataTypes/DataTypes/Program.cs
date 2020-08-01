using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
