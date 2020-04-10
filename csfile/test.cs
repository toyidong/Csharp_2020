using System;

namespace test
{
    public class test {
        public static void Main(){
            System.Console.WriteLine("Hello, Ethan");
            GetEthan();
            Console.WriteLine("bye");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Math.Sqrt(12345));
            for(int i = 0; i< 100; i++)
            {
                Console.Write("{0}, ", Math.Pow(-1, i) * (i+2));
            }
            Console.WriteLine();
        }

        private static void GetEthan(){
            string et = "Ethan";
            int age = 12;

            System.Console.WriteLine("{0} is {1}", age, et);
        }
    }
}