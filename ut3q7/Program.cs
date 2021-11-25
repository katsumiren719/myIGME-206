using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT3Q7
{
    // Author:- Raj Barot
  
    class Program
    {
        static void Main(string[] args)
        {
            List<Wizard> wizards = new List<Wizard>
            {
                new Wizard("raj", 21),
                new Wizard("apple", 21),
                new Wizard("banana", 19),
                new Wizard("carot", 20),
                new Wizard("cabage", 23),
                new Wizard("potato", 21),
                new Wizard("lufy", 19),
                new Wizard("leafy", 21),
                new Wizard("lify", 19),
                new Wizard("lofy", 23),
            };
            Console.WriteLine("Before sorting:\n");
            foreach (var wizard in wizards)
            {
                Console.WriteLine("Name: {0}, Age: {1}", wizard.name, wizard.age);
            }
            wizards.Sort(delegate (Wizard x, Wizard y)
            {
                return x.CompareTo(y);
            });
            Console.WriteLine("After sorting:\n");
            foreach (var wizard in wizards)
            {
                Console.WriteLine("Name: {0}, Age: {1}", wizard.name, wizard.age);
            }
        }
    }
    class Wizard
    {
        public string name;
        public int age;
        public Wizard(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int CompareTo(Wizard another)
        {
            if (this.age > another.age)
            {
                return 1;
            }
            else if (this.age == another.age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}