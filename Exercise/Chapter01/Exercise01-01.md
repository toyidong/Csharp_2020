## Chapter 01 ##

### Exercise ###

1. Install and make your self familiar with **Microsoft Visual Studio** and Microsoft Developer Network (**MSDN**) Library Documentation.

Microsoft Visual Studio only works on Windows Machine.
The download URL for Microsoft Visual Studio is https://visualstudio.microsoft.com/downloads/

The Community version is free to use and has most features available.

If you are using computer with <code>Mac OS</code> or <code>Linux</code> operating system, you can not install Visual Studio on your computer(unless you are installing to a virtual machine with <code>Windows OS</code>). However, Microsoft provides **Visual Studio Code** for other OS. The download URL for Microsoft Visual Studio Code is https://code.visualstudio.com/download You can download <code>VS Code</code> for your computer. 

The Microsoft Developer Network (**MSDN**) Library Documentation, now is called <code>Microsoft Docs</code>, the URL is https://docs.microsoft.com/en-us/. Here you will find all information for Microsoft products.

2. Find the description of the **System.Console** class in the standard .NET APT documentation(MSDN Library).

Go to https://docs.microsoft.com/en-us/ and search for **"System.Console"**, then you will find many results. This URL is for API Class Documentation, https://docs.microsoft.com/en-us/dotnet/api/system.console?view=netframework-4.8

3. Find the description of the **System.Console.WriteLine()** method and its different possible parameters in the MSDN Library.

https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netframework-4.8

This method has many **"Overloads"**. Overloaded methods means that all these methods, have same method name (name is overloaded), but different required parameters, thus they have different **signatures** so C# compiler will know which method you are using in your code. You can click on each overloaded method to see detailed explanation and example codes to practice.

Example: For method <code>Console.WriteLine(string format, object arg0, object arg1)</code>
```Csharp
Console.WriteLine(
    "(C) Currency: {0:C}\n" +
    "(E) Decimal: {1:E}\n", 
    -123, -123.45f);
```

4. **Compile and execute** the sample program from this chapter usign the command prompt (the console) and Visual Studio.

For Windows, follow the instruction in this chapter.   

* First, add <code>csc</code> to <code>PATH</code> in your  <code>Windows Environment Variable</code>. 
* Second, write your code in a text editor and save into a file with <code>.cs</code> extension.
* Third, run the following code (assuming you save your file as HelloWorld.cs), <code>csc (C Sharp Compiler)</code> will compile your <code>HelloWorld.cs</code> into <code>HelloWorld.exe</code> executable file.
```sh
csc HelloWorld.cs
```
* Finally, execute this HelloWorld.exe file to see result.

For Linux (Ubuntu 19.10), similar steps in Mac OS

* First install mono, follow the instructions about how to download and install mono on Linux, from this URL, https://www.mono-project.com/download/stable/#download-lin 
* Second, same as Second step in Windows, write your code in a text editor and save into a file with <code>.cs</code> extension.
* Third, run mono C# compiler <code>mcs</code> to compiler <code>.cs</code> file into <code>.exe</code> executable file.
```sh
mcs HelloWorld.cs
```
* Finally, use <code>mono</code> to execute compiled executable file to see the result.
```sh
mono HelloWorld.exe
```

5. **Modify** the sample program to print a different greeting, for example <code>"Good Day"</code>

```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class GoodDay
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Good Day");
        }
    }
}
```
6. Write a console application that **prints your first name and last name** on the console.

```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintYourName
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}",
                            <your-first-name>, 
                            <your-last-name>);
        }
    }
}
```
7. Write a console application that **prints the following numbers** on the console 1, 101, 1001, each on a new line.
```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
        }
    }
}
```
8. Write a program that prints on the console the **current date and time**.
```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintCurrentDateTime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Date.Now);
        }
    }
}
```

9.  Write a program that prints the **square root of 12345**
```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintSqrt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(12345));
        }
    }
}
```

10. Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8
```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintSequence
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i< 100; i++)
            {
                Console.Write("{0}, ", Math.Pow(-1, i) * (i+2));
            }
            Console.WriteLine();
            
        }
    }
}
```
11. Write a program that reads your age from the console and prints your **age after 10 years**.

```csharp
using System;
namespace <Your-Folder-Name>
{
    public static class PrintAgeAfter10Years
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be {0}", age + 10);
            
        }
    }
}

```

12. Describe the difference between **C#** and the **.NET Framework**. 


13. Make a list of the **most popular programming** languages. How are they different from C#?


14. **Decompile** the example program from exercise 5.

For Windows, follow the instruction in this chapter to **Decompile** the executable <code>.exe</code> file.

For Linux/Mac OS, the mono has a **Decompiler**
```sh

```