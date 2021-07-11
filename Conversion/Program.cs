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

            //myInt = d;//Can not be converted implicitly

            //cast double into int - explicit conversion
            myInt = (int)d; //higher type value to lower type value
            Console.WriteLine(myInt);

            //Implicit conversions
            int num = 123456789; //smaller type value
            long bigNum = num; //higher type value
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
