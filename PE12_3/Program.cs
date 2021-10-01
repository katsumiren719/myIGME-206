using System;
using MyClass;

namespace PE12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass obj1 = new MyDerivedClass();
            obj1.MyString = "NEWSTRING";
            Console.WriteLine(obj1.GetString());
        }
    }
}
