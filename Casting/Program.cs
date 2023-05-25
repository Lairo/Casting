using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myFloatValue = 255;
            int myIntValue = (int)myFloatValue;
            //Console.WriteLine("myIntValue is " + myIntValue);
            int myInt = 10;
            int myString = myInt;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            char myChar = 'v';
            myString = (int)(myString + myInt + myByte + myDouble + myChar);            

            //Console.WriteLine($"\n{myString}\n");


            Division();
        }

        private static void Division()
        {
            Console.Write("x: ");
            string xString = Console.ReadLine();
            int.TryParse(xString, out int x);


            Console.Write("\ny: ");
            string yString = Console.ReadLine();
            int.TryParse(yString, out int y);
                        
            float z = (float)x / y;

            Console.WriteLine($"\nx / y = z: {z}\n");

        }
    }
}
