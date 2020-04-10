## Steps for set up a dotnet solution ##

1. Create a folder `ExampleCodeTest` and go into this folder

<div style="background:black;color:white">
<pre>
mkdir ExampleCodeTest
cd ./ExampleCodeTest
</pre>
</div>

2. Create a solution file

<div style="background:black;color:white">
<pre>
dotnet new sln --name ExampleCodeTest
</pre>
</div>

3. Create first console project with a name parameter (this will create new project in a subfolder) 

<div style="background:black;color:white">
<pre>
dotnet new console --name WrapperProject
</pre>
</div>

4. Add new project in to solution and list project

<div style="background:black;color:white">
<pre>
dotnet sln add ./WrapperProject
dotnet sln list
</pre>
</div>
the WrapperProject will be added into ExampleCodeTest.sln file.

5. Create other class library projects for the WrapperProject, remember to use --name parameter, so each project will in its own subfolder. These projects are class library so that they can be added as references to WrapperProject

<div style="background:black;color:white">
<pre>
dotnet new classlib --name Chapter04ExampleCode
dotnet new classlib --name Chapter05ExampleCode
dotnet new classlib --name Chapter04ExampleCode
dotnet new classlib --name Chapter05ExampleCode
</pre>
</div>

6. In order to add other projects to WrapperProject, need to add reference to `WrapperProject.csproj` file. Go into WrapperProject folder, add reference to WrapperProject

<div style="background:black;color:white">
<pre>
cd ./WrapperProject
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
</pre>
</div>

these references will be added to WrapperProject.csproj file.

7. Whenever you want to use classes/methods from other projects, just include that project namespace in your file, for example, including Chapter04ExampleCode and Chapter05ExampleCode in WrapperProject/Program.cs file

```csharp
using System;
using Chapter04ExampleCode; // add namespace Chapter04ExampleCode
using Chapter05ExampleCode; // add namespace Chapter05ExampleCode

namespace WrapperProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class04.Print();    // call static method from Chapter04ExampleCode.Class04
            Class05.Print();    // call static method from Chapter04ExampleCode.Class05

            Class04 c4 = new Class04(); // instantiate an object from Chapter04ExampleCode.Class04
            c4.NonStaticPrint(); // call non-static method from object
        }
    } 
}
```

8. Add referenced classes/methods in projects accordingly
   1. Add `Class04` and **static** method `Print()`, **non-static** method `NonStaticPrint()`
   2. Add `Class05` and **static** method `Print()` 
```csharp
using System;

namespace Chapter04ExampleCode
{
    public class Class04
    {
        public static void Print()
        {
            Console.WriteLine("This is Chapter 04");
        }
        public void NonStaticPrint()
        {
            Console.WriteLine("This is Chapter 04 - Non static print");
        }
    }
}
```


```csharp
using System;

namespace Chapter04ExampleCode
{
    public class Class05
    {
        public static void Print()
        {
            Console.WriteLine("This is Chapter 05");
        }
    }
}
```
9.  Now you have everything setup. 
10. How to run your project:
- Without build first: 
  - Go back WrapperProject folder, 
  - run your WrapperProject with `dotnet run`, 

<div style="background:black;color:white">
<pre>
cd ./WrapperProject
dotnet run
</pre>
</div>
 
or 

- With build first: 
  - Go back to folder with your solution file,
  - build your solution with `dotnet build`, 
  - the default folder path for build will be in `./WrapperProject/bin/Debug/netcoreapp3.1/` folder, 
  - go to this folder and run with `dotnet WrapperProject.dll` **(notice only run .dll with dotnet, NOT with dotnet run)**

<div style="background:black;color:white">
<pre>
dotnet build
cd ./WrapperProject/bin/Debug/netcoreapp3.1/
dotnet WrapperProject.dll
</pre>
</div>

