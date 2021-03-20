//https://www.w3schools.com/cs/cs_user_input.asp
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment inserted
            Console.WriteLine("Hello World!");  //Another comment
            /*
             * A new multi-line
             * Comment
             */
            //string name = "Aakash";
            //Console.WriteLine(name);

            //int newNum = 24;
            //Console.WriteLine(newNum);

            const int constantInt = 10;
            //Console.WriteLine(constantInt);

            //bool myBool = true;
            //char myLetter = 'E';
            //double myDouble = 5.99D;

            //Console.WriteLine("Hello " + name);
            //int x = 1, y = 7, z = 5;
            //Console.WriteLine(x + y + z);

            /*
            long myLong = 15000000000L;
            Console.WriteLine(myLong);

            float myFloat = 5.75F;
            Console.WriteLine(myFloat);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            char myGrade = 'B';
            Console.WriteLine(myGrade);
            */

            //int myInt = 9;
            //double myDouble = myInt;       // Automatic casting: int to double

            //Console.WriteLine(myInt);      // Outputs 9
            //Console.WriteLine(myDouble);   // Outputs 9

            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9

            int myInte = 10;
            double myDoubl = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInte));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInte));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubl));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }
    }
}
