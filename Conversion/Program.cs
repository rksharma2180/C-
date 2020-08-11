using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = false;
            double d = 13.37;
            int myInt;

            //cast double into int - explicit conversion
            myInt = (int)d;
            Console.WriteLine(myInt);

            //Implicit conversions
            int num = 123456789;
            long bigNum = num;
            Console.WriteLine(bigNum);

            float myFloat = 13.39f;
            double myDouble = myFloat;
            Console.WriteLine(myDouble);

            //TypeConversion
            string myStringDouble = myDouble.ToString();
            string myStringFloat = myFloat.ToString();
            string myStringInt = myInt.ToString();
            string myStringBool = isCorrect.ToString();

            Console.WriteLine(myStringDouble);
            Console.WriteLine(myStringFloat);
            Console.WriteLine(myStringInt);
            Console.WriteLine(myStringBool);

            Console.Read();

        }
    }
}
