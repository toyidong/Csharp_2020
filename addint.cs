using System;

namespace test
{
    public class addint 
    {
        private string x {get; set;}
        private string y {get; set;}
        // main method is the entry point for your program
        public static void Main()
        {
            byte cn = 20;

            Console.WriteLine(cn + 12);
            Console.WriteLine(cn + "12");
            Console.WriteLine("1111111111111111111111111111111111111111111111111111111111010101".Length);

// get the 64 bit max value
            ulong maxvalue = UInt64.MaxValue; // comment out

            Console.WriteLine(maxvalue);
        }
    }
}

