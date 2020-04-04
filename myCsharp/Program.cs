using System;

namespace myCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello I am here!");
            // string a = null;
            // Console.WriteLine(a ?? "a is null");
            // string b = "12";
            // Console.WriteLine(Int16.Parse(b));

            // Console.WriteLine(args);
            // foreach(string x in args)
            // {
            //     Console.WriteLine(x);
            // }

            // Random rand = new Random();
            // int n = rand.Next();
            // bool isOdd =  (n % 2 == 1);
            // Console.WriteLine("{0} is {1}", n, isOdd ? "odd" : "even");

            // int m = (int)(rand.NextDouble()*100);
            // Console.WriteLine("{0} is {1} by both 5 and 7", n%100<<2, (n%100<<2)%35 == 0 ? "divisible" : "NOT divisible");
            // Console.WriteLine("{0} is {1} by both 5 and 7", m, m%35 == 0 ? "divisible" : "NOT divisible");
            // Console.WriteLine("the third digit in {0} is {1}", n, n/100%10);
            // Console.WriteLine("the third bit in {0} is {1}", Convert.ToString(n, 2), n & 0b1000 >> 3);
            // Console.WriteLine(Convert.ToString(0b1000, 2));

            // double a5 = rand.NextDouble() * 10;
            // double b5 = rand.NextDouble() * 10;
            // double h5 = rand.NextDouble() * 10;

            // Console.WriteLine("a = {0}, b = {1}, h = {2}, the area of trapezoid is {3}", a5, b5, h5, (a5+b5)*h5/2);

            // Console.WriteLine("Please give the length of your rectangle side: ");
            // double a6;
            // a6 = Double.Parse(Console.ReadLine());

            // Console.WriteLine("Please give the length of your rectangle height: ");
            // double b6;
            // b6 = Double.Parse(Console.ReadLine());

            // Console.WriteLine("Your rectangle's perimeter is {0}, your rectangle's area is {1}", 2*(a6+b6), a6*b6);

            // Console.WriteLine("What is your weight on the Earth ?");
            // double a7;
            // bool success = Double.TryParse(Console.ReadLine(), out a7);
            // if (success)
            // {
            //     Console.WriteLine("Your weight on the Moon will be {0}", a7*0.17);
            // }
            // else
            // {
            //     Console.WriteLine("Your input is not a valid number.");
            // }

            // Console.WriteLine("Please enter x-cords for your point");
            // double x8;
            // bool isNumber = Double.TryParse(Console.ReadLine(), out x8);
            // while (!isNumber) {
            //     Console.WriteLine("Your input is not a valid number, please enter a valid number for x-cord");
            //     isNumber = Double.TryParse(Console.ReadLine(), out x8);
            // }
            // Console.WriteLine("Please enter y-cords for your point");
            // double y8;
            // isNumber = Double.TryParse(Console.ReadLine(), out y8);
            // while (!isNumber) {
            //     Console.WriteLine("Your input is not a valid number, please enter a valid number for y-cord");
            //     isNumber = Double.TryParse(Console.ReadLine(), out y8);
            // }
            // double distance = Math.Sqrt(x8*x8 + y8*y8);
            // Console.WriteLine("Your point is {0}within the circle K({{0,0}},R=5)", distance > 5 ? "NOT " : "");

            // Console.WriteLine("Please enter x-cords for your point");
            // double x9;
            // bool isNumber = Double.TryParse(Console.ReadLine(), out x9);
            // while (!isNumber) {
            //     Console.WriteLine("Your input is not a valid number, please enter a valid number for x-cord");
            //     isNumber = Double.TryParse(Console.ReadLine(), out x9);
            // }
            // Console.WriteLine("Please enter y-cords for your point");
            // double y9;
            // isNumber = Double.TryParse(Console.ReadLine(), out y9);
            // while (!isNumber) {
            //     Console.WriteLine("Your input is not a valid number, please enter a valid number for y-cord");
            //     isNumber = Double.TryParse(Console.ReadLine(), out y9);
            // }
            // double distance = Math.Sqrt(x9*x9 + y9*y9);
            // Console.WriteLine("Your point is {0}within the circle K({{0,0}},R=5)", distance > 5 ? "NOT " : "");
            // bool isOut = x9 < -1 || x9 > 5 || y9 < 1 || y9 > 5 ;
            // Console.WriteLine("Your point is {0} the rectangle [{{-1, 1}}, {{5, 5}}]", isOut ? "out of" : "within");

        }
    }
}
