using System;
using Chapter04ExampleCode;
using Chapter05ExampleCode;
using Chapter06ExampleCode;
using Chapter07ExampleCode;

namespace WrapperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class04.Print();
            Class05.Print();
            Class06.Print();
            Class07.Print();

            Class04 c4 = new Class04();
            c4.NonStaticPrint();
        }
    }
}
