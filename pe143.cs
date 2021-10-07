using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace MyApp
{
    //this program tests Animals
    class Program
    {
        //main method
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();

            Console.WriteLine("Dog eats food like:");
            MyMethod(d1);

            Console.WriteLine("Cat eats food like");
            MyMethod(c1);
        }

        public static void MyMethod(object myObject)
        {
            PetEat newobject = (PetEat)myObject;
            newobject.Eat();
        }
    }


}