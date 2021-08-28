using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raj_PE1
{
    // Program by - Raj Barot
    // Aim : To print Basic messages and calculations
    class Program
    {
        // Creating class to do the required task
        static void Main(string[] args)
        {
              Console.WriteLine("Hello World");
            // To print Hello world; use the console.writeline function

            Console.WriteLine("Raj Barot");
            // To print my name; use the console.writeline function

            int x, y;
            // declaring 2 integers
            x = 20;
            y = 15;
            // initalizing both numbers with a static value

            int z = x + y;
            // storing the sum of both numbers in variable z
            int z2 = x * y;
            // storing the multiplication of both numbers in variable z2
            int z3 = x - y;
            // storing the difference of both numbers in variable z3

            Console.WriteLine("The addition of both numbers is " + z);
            Console.WriteLine("The multiplication of both numbers is " + z2);
            Console.WriteLine("The subtraction of both numbers is " + z3);

            // Printing the Result values of z z2 and z3 which we calcualted above with a message
        
        }
    }
}
