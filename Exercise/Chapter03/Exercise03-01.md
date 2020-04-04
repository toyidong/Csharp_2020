### Chapter 03 Exercises ###

1. Write an expression that checks whether an integer is **odd or even**
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            int n = rand.Next();    // 32 bit positive integer
            bool isOdd =  (n % 2 == 1);
            Console.WriteLine("{0} is {1}", n, isOdd ? "odd" : "even");
        }
    }
}
```

2. Write a Boolean expression that checks whether a given integer is **divisible by both 5 and 7**, without a remainder.
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            int m = (int)(rand.NextDouble()*100); // 64 bit double in [0,1)
            Console.WriteLine("{0} is {1} by both 5 and 7", m, m%35 == 0 ? "divisible" : "NOT divisible");
        }
    }
}
```

3. Write an expression that looks for a givn integer if its **third digit** (right to left) is 7
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            int n = rand.Next();
            Console.WriteLine("the third digit in {0} is {1}", n, n/100%10);
        }
    }
}
```

4. Write an expresion that checks whether the **third bit** in a given integer is 1 or 0
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            int n = rand.Next();
            Console.WriteLine("the third bit in {0} is {1}", Convert.ToString(n, 2), n & 0b1000 >> 3);
        }
    }
}
```

5. Write an expression that calculates the **area of a trapezoid** by given sides **a, b** and heght **h**
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            double a5 = rand.NextDouble() * 10;
            double b5 = rand.NextDouble() * 10;
            double h5 = rand.NextDouble() * 10;

            Console.WriteLine("a = {0}, b = {1}, h = {2}, the area of trapezoid is {3}", a5, b5, h5, (a5+b5)*h5/2);
        }
    }
}
```

6. Write a program that prints on the console the **perimeter and the area of a rectangle** by given side and height entered by the user.
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Console.WriteLine("Please give the length of your rectangle side: ");
            double a6;
            a6 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please give the length of your rectangle height: ");
            double b6;
            b6 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Your rectangle's perimeter is {0}, your rectangle's area is {1}", 2*(a6+b6), a6*b6);
        }
    }
}
```

7. The gravitational field of the Moon is approximately 17% of thaat on the Earth. Write a program that calculates the **weight of a man on the moon** by a given weight on the Earth.
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Console.WriteLine("What is your weight on Earth ?");
            double a7;
            bool success = Double.TryParse(Console.ReadLine(), out a7);
            if (success)
            {
                Console.WriteLine("Your weight on Moon will be {0}", a7*0.17);
            }
            else
            {
                Console.WriteLine("Your input is not a valid number.")
            }
        }
    }
}
```

8. Write an expression that checks for given point {x,y} if it is **within the circle** K({0,0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Console.WriteLine("Please enter x-cords for your point");
            double x8;
            bool isNumber = Double.TryParse(Console.ReadLine(), out x8);
            while (!isNumber) {
                Console.WriteLine("Your input is not a valid number, please enter a valid number for x-cord");
                isNumber = Double.TryParse(Console.ReadLine(), out x8);
            }
            Console.WriteLine("Please enter y-cords for your point");
            double y8;
            isNumber = Double.TryParse(Console.ReadLine(), out y8);
            while (!isNumber) {
                Console.WriteLine("Your input is not a valid number, please enter a valid number for y-cord");
                isNumber = Double.TryParse(Console.ReadLine(), out y8);
            }
            double distance = Math.Sqrt(x8*x8 + y8*y8);
            Console.WriteLine("Your point is {0}within the circle K({{0,0}},R=5)", distance > 5 ? "NOT " : "");
        }
    }
}
```

9.  Write an expression that checks for given point {x,y} if it is **within the circle** K({0,0}, R=5) and **out of the rectangle** [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Console.WriteLine("Please enter x-cords for your point");
            double x9;
            bool isNumber = Double.TryParse(Console.ReadLine(), out x9);
            while (!isNumber) {
                Console.WriteLine("Your input is not a valid number, please enter a valid number for x-cord");
                isNumber = Double.TryParse(Console.ReadLine(), out x9);
            }
            Console.WriteLine("Please enter y-cords for your point");
            double y9;
            isNumber = Double.TryParse(Console.ReadLine(), out y9);
            while (!isNumber) {
                Console.WriteLine("Your input is not a valid number, please enter a valid number for y-cord");
                isNumber = Double.TryParse(Console.ReadLine(), out y9);
            }
            double distance = Math.Sqrt(x9*x9 + y9*y9);
            Console.WriteLine("Your point is {0}within the circle K({{0,0}},R=5)", distance > 5 ? "NOT " : "");
            bool isOut = x9 < -1 || x9 > 5 || y9 < 1 || y9 > 5 ;
            Console.WriteLine("Your point is {0} the rectangle [{{-1, 1}}, {{5, 5}}]", isOut ? "out of" : "within");
        }
    }
}
```

10. Write a program that takes as input a **four-digit number** in format abcd (e.g. 2011) and performs the following actions:
    - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    - Prints on the console the number in reversed order: **dcba** (in our example 1102)
    - Puts the last digit in the first position: **dabc** (in our example 1201)
    - Exchanges the second and the third digit: **acbd** (in our example 2101) 
```csharp
using System;
namespace Exercise03_01
{
    public class Exercise03_01
    {
        public static void Main()
        {
            Random rand = new Random();
            double a5 = rand.NextDouble() * 10;
            double b5 = rand.NextDouble() * 10;
            double h5 = rand.NextDouble() * 10;

            Console.WriteLine("a = {0}, b = {1}, h = {2}, the area of trapezoid is {3}", a5, b5, h5, (a5+b5)*h5/2);
        }
    }
}
```

11. We are given a number **n** and a position **p**. Write a sequence of operations that prints the value of **the bit on the position p** in the number (0 or 1). Example: **n**=35, **p**=5 -> 1. Another example: n=35, p=6 -> 0.
12. Write a Boolean expression that checks if the bit on position **p** in the integer **v** has the value 1. Example v=5, **p**=1 -> **false**.
13. We are given the number **n**, the value **v** (**v** = 0 or 1) and the position **p**. Write a sequence of operatons taht changes the value of **n**, so the bit on the position **p** has the value of **v**. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
14. Write a program that checks if a given number **n** (1 < **n** < 100 ) is a **prime number** (i.e. it is divisible without remainder only to itself and 1)
15. **\*** Write a program that **exchanges the values of the bits** on positions 3, 4, and 5 with bits on position 24, 25 and 26 of a given 32-bit unsigned interger.
16. **\*** Write a program that **exchanges bits** {p, p+1, ..., p+k-1} with bits {q, q+1, ..., q+k-1} of a given 32-bit unsigned integer.