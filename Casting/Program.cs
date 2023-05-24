using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



            Console.WriteLine($"\n{myString}\n");

        }
    }
}
