## Steps for set up a dotnet solution ##

1. Create a folder `ExampleCodeTest` and go into this folder
```sh
mkdir ExampleCodeTest
cd ./ExampleCodeTest
```

2. Create a solution file
```sh
dotnet new sln --name ExampleCodeTest
```

3. Create first console project with a name parameter (this is create new project in a subfolder) 

```sh
dotnet new console --name WrapperProject
```
4. Add new project in to solution and list project

```sh
dotnet sln add ./WrapperProject
dotnet sln list
```
the WrapperProject will be added into ExampleCodeTest.sln file.

5. Create other class library projects for the WrapperProject, remember to use --name parameter, so each project will in its own subfolder. These projects are class library so that they can be added as references to WrapperProject

```sh
dotnet new classlib --name Chapter04ExampleCode
dotnet new classlib --name Chapter05ExampleCode
dotnet new classlib --name Chapter04ExampleCode
dotnet new classlib --name Chapter05ExampleCode
```

6. In order to add other projects to WrapperProject, need to add reference to `WrapperProject.csproj` file. Go into WrapperProject folder, add reference to WrapperProject

```sh
cd ./WrapperProject
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
dotnet add reference ../Chapter04ExampleCode
```
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

```sh
cd ./WrapperProject
dotnet run
``` 
or 

- With build first: 
  - Go back to folder with your solution file,
  - build your solution with `dotnet build`, 
  - the default folder path for build will be in `./WrapperProject/bin/Debug/netcoreapp3.1/` folder, 
  - go to this folder and run with `dotnet WrapperProject.dll` **(notice only run .dll with dotnet, NOT with dotnet run)**

```sh
dotnet build
cd ./WrapperProject/bin/Debug/netcoreapp3.1/
dotnet WrapperProject.dll

```