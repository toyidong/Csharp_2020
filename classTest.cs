using System;
// test class entry point
namespace classTest
{
    class Cat {
        public string Name {get; set;}
    }

     class Entry {
        public static void Main(){
            Cat myCat = new Cat();
            myCat.Name = "katie";
            Console.WriteLine(myCat.Name);
        }
    }
}
