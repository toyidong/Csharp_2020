### Chapter 03 Exercises ###

1. Write an expression that checks whether an integer is **odd or even**
```csharp
using System;
namespace Exercise03
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
namespace Exercise03
{
    public class Exercise03_02
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
namespace Exercise03
{
    public class Exercise03_03
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
namespace Exercise03
{
    public class Exercise03_04
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
namespace Exercise03
{
    public class Exercise03_05
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
namespace Exercise03
{
    public class Exercise03_06
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
namespace Exercise03
{
    public class Exercise03_07
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
namespace Exercise03
{
    public class Exercise03_08
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
namespace Exercise03
{
    public class Exercise03_09
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
namespace Exercise03
{
    public class Exercise03_10
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a four-digit number:");
            int number;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out number);
            
            while(!isNumber || number.ToString().Length != 4)
            {
                Console.WriteLine("Invalid number, please enter a four-digit number: ");
                isNumber = Int32.TryParse(Console.ReadLine(), out number);
            }

            string numStr = number.ToString();
            int sumDigits = 0;
            foreach(char x in numStr)
            {
                sumDigits += (int)x - 48;
            }
            Console.WriteLine("The sum of the digits is: {0}", sumDigits);

            char[] charArray = numStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine("The number in reversed order: {0}", reversedStr);
            
            string lastDigitFirst = numStr[numStr.Length-1] + numStr.Substring(0,numStr.Length-1);
            Console.WriteLine("Puts the last digit in the first position: {0}", lastDigitFirst);

            charArray = numStr.ToCharArray();
            char temp = charArray[2];
            charArray[2] = charArray[1];
            charArray[1] = temp;
            Console.WriteLine("Exchange the second and third digits: {0}", new string(charArray));
        }
    }
}
```

11. We are given a number **n** and a position **p**. Write a sequence of operations that prints the value of **the bit on the position p** in the number (0 or 1). Example: **n**=35, **p**=5 -> 1. Another example: n=35, p=6 -> 0.
```csharp
using System;
namespace Exercise03 
{
    public class Exercise03_11
    {
        public static void Main()
        {
            Random rand = new Random();
            int n11 = (int)(rand.NextDouble() * 1000);  // random integer from 0 to 1000
            int p11 = 0;
            while (p11 == 0) // string index from 0, position from 1
            {
                p11 = (int)(rand.NextDouble() * (Convert.ToString(n11, 2).Length+1));// random position
            }
            Console.WriteLine("{0} in binary form: {1}", n11, Convert.ToString(n11, 2));
            // position count start from the end (last bit)
            Console.WriteLine("Count from the end, the bit on the position {0} is {1}", p11, p11 == 1 ? n11%2 : (n11 >> (p11-1))%2);
            // position count start from the beginning (first bit)
            string n11Str = Convert.ToString(n11, 2);
            Console.WriteLine("Count from the start, the bit on the position {0} is {1}", p11, n11Str[p11-1] );
        }
    }
}
```

12. Write a Boolean expression that checks if the bit on position **p** in the integer **v** has the value 1. Example v=5, **p**=1 -> **false**.
```csharp
using System;
namespace Exercise03 
{
    public class Exercise03_12
    {
        public static void Main()
        {
            Random rand = new Random();
            int n12 = (int)(rand.NextDouble() * 1000);  // random integer from 0 to 1000
            int p12 = 0;
            while (p12 == 0) // string index from 0, position from 1
            {
                p12 = (int)(rand.NextDouble() * (Convert.ToString(n12, 2).Length+1));// random position
            }
            Console.WriteLine("{0} in binary form: {1}", n12, Convert.ToString(n12, 2));
            // position count start from the end (last bit)
            Console.WriteLine("Count from the end, the bit on the position {0} equal to 1 is {1}", p12, p12 == 1 ? (n12%2) == 1 : ((n12 >> (p12-1))%2)%2 == 1);
            // position count start from the beginning (first bit)
            string n12Str = Convert.ToString(n12, 2);
            Console.WriteLine("Count from the start, the bit on the position {0} equal to 1 is {1}", p12, n12Str[p12-1] == '1' );
            
        }
    }
}
```

13. We are given the number **n**, the value **v** (**v** = 0 or 1) and the position **p**. Write a sequence of operatons taht changes the value of **n**, so the bit on the position **p** has the value of **v**. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
```csharp
using System;
namespace Exercise03
{
    public class Exercise03_13
    {
        public static void Main()
        {
            Random rand = new Random();
            int n13 = (int)(rand.NextDouble() * 1000);  // random integer from 0 to 1000
            int p13 = 0;
            while (p13 == 0) // string index from 0, position from 1
            {
                p13 = (int)(rand.NextDouble() * (Convert.ToString(n13, 2).Length+1));// random position
            }
            int v13 = (n13 >> (p13-1)%2) == 0 ? 1 : 0;

            Console.WriteLine("{0} in binary form: {1}",n13, Convert.ToString(n13, 2));
            Console.WriteLine("Count from the end, change the {0} position bit to {1}", p13, v13);
            int n13New = v13 == 0 ? n13 & (~(1<<(p13-1))): n13 | (1 << (p13-1));
            Console.WriteLine("After exchange, n13 in binary form: {0}", Convert.ToString(n13New, 2));
            Console.WriteLine("After exchange, n13 value is {0}", n13New);
        }
    }
}
```

14. Write a program that checks if a given number **n** (1 < **n** < 100 ) is a **prime number** (i.e. it is divisible without remainder only to itself and 1)
```csharp
using System;
namespace Exercise03
{
    public class Exercise03_14
    {
        public static void Main()
        {
            Random rand = new Random();
            int n14 = (int)(rand.NextDouble() * 99) + 1 ;  // random integer from 1 to 100
            bool isPrime = true;
            for(int i = 2; i < Math.Sqrt(n14); i++)
            {
                if(n14 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine("{0} {1} a prime number", n14, isPrime? "is" : "is NOT");
        }
    }
}
```

15. **\*** Write a program that **exchanges the values of the bits** on positions 3, 4, and 5 with bits on position 24, 25 and 26 of a given 32-bit unsigned interger.
```csharp
using System;
namespace Exercise03
{
    public class Exercise03_15
    {
        public static void Main()
        {
            Random rand = new Random();
            uint thirtyBits = (uint)rand.Next(1 << 30);
            uint twoBits = (uint)rand.Next(1 << 2);
            uint n15 = (thirtyBits << 2) | twoBits;
            Console.WriteLine("In this solution, bit position count start from 0, and from rightmost bit");
            Console.WriteLine("{0} in binary form: {1}",n15, Convert.ToString(n15, 2).PadLeft(32, '0'));
            // save values in 3,4,5,24,25,26 bit position
            int bit3 = (n15 & (1<<3)) == 0 ? 0 : 1;
            int bit4 = (n15 & (1<<4)) == 0 ? 0 : 1;
            int bit5 = (n15 & (1<<5)) == 0 ? 0 : 1;
            int bit24 = (n15 & (1<<24)) == 0 ? 0 : 1;
            int bit25 = (n15 & (1<<25)) == 0 ? 0 : 1;
            int bit26 = (n15 & (1<<26)) == 0 ? 0 : 1;

            // set bit3 to value of bit24
            n15 = bit24 == 0 ? (uint)(n15 & (~(1 << 3))) : (uint)(n15 | (1 << 3));
            // set bit4 to value of bit25
            n15 = bit25 == 0 ? (uint)(n15 & (~(1 << 4))) : (uint)(n15 | (1 << 4));
            // set bit5 to value of bit26
            n15 = bit26 == 0 ? (uint)(n15 & (~(1 << 5))) : (uint)(n15 | (1 << 5));
            // set bit24 to value of bit3
            n15 = bit3 == 0 ? (uint)(n15 & (~(1 << 24))) : (uint)(n15 | (1 << 24));
            // set bit25 to value of bit4
            n15 = bit4 == 0 ? (uint)(n15 & (~(1 << 25))) : (uint)(n15 | (1 << 25));
            // set bit26 to value of bit5
            n15 = bit5 == 0 ? (uint)(n15 & (~(1 << 26))) : (uint)(n15 | (1 << 26));
            
            Console.WriteLine("After exchange, {0} in binary form: {1}", n15, Convert.ToString(n15, 2).PadLeft(32, '0'));
        }
    }
}
```

16. **\*** Write a program that **exchanges bits** {p, p+1, ..., p+k-1} with bits {q, q+1, ..., q+k-1} of a given 32-bit unsigned integer.
```csharp
using System;
namespace Exercise03 
{
    public class Exercise03_16
    {
        public static void Main()
        {
            Random rand = new Random();
            int p16 = 0;
            int q16 = 0;
            int k = 0;
            do
            {
                // pick a random bit position for p and q from 0 to 31
                // pick a random number k, such that p+k-1 && q+k+1 not less than 0, and not greater than 31 (to prevent overflow)
                p16 = (int)(rand.NextDouble()*10);      // p16 is in [0, 9]
                q16 = (int)(rand.NextDouble()*10) + 17; // q16 is in [17, 28]
                k = (int)(rand.NextDouble()*5) + 3;     // k is in [3, 7]

            }while(p16+k-1 > 31 || q16+k-1 > 31 || p16+k-1 < 0 || q16+k-1 < 0);
            Console.WriteLine("In this solution, bit position count start from 0, and from rightmost bit");
            // display to check the value of p16, q16, k
            Console.WriteLine("p16 is {0}, q16 is {1}, k is {2}", p16, q16, k);

            uint thirtyBits = (uint)rand.Next(1 << 30);
            uint twoBits = (uint)rand.Next(1 << 2);
            uint n16 = (thirtyBits << 2) | twoBits;
            
            string n16Str = Convert.ToString(n16, 2).PadLeft(32,'0');
            byte[] intBytes = BitConverter.GetBytes(n16);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(intBytes);
            } 
            Console.Write("{0} in binary form: ", n16);
            foreach(byte x in intBytes)
            {
                Console.Write(Convert.ToString(x, 2).PadLeft(8, '0') + " ");
            }
            Console.WriteLine();

            for(int i = 0; i < k; i++)
            {
                int bitP = ((int)n16 >> (p16+i)) & 1; 
                int bitQ = ((int)n16 >> (q16+i)) & 1;
                // set bit at p+i position
                n16 = (uint)(n16 & (~(1 << p16+i)) | (bitQ << p16+i)); 
                // set bit at q+i position
                n16 = (uint)(n16 & (~(1 << q16+i)) | (bitP << q16+i));

            }
            byte[] intBytesAfter = BitConverter.GetBytes(n16);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(intBytesAfter);
            }           
            Console.Write("After exchange,\n{0} in binary form: ", n16);
            foreach(byte x in intBytesAfter)
            {
                Console.Write(Convert.ToString(x, 2).PadLeft(8, '0') + " ");
            }
            Console.WriteLine();
        }
    }
}
```
