using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT_3
{

    //Author: Raj Barot
    //Purpose: Create a console application that uses a delegate to impersonate the Console.ReadLine() function when asking for user input.  (Refer to "Math Delegate" or the attached "Number Sorter" application for example delegate code).

    class Program
    {
        // Author :- RAJ BAROT

        // Purpose :-  Same Question as PE 9 lol

        delegate string delegateReadLine();  // declaration
        static void Main(string[] args)
        {
            WriteLine("Type something :");      // user imput
            delegateReadLine readLine = new delegateReadLine(ReadLine);  // initialising readLine with default syntax

            string userInput = readLine();  // assigning input string into readLine
            WriteLine($"Your String: {userInput}");  //print

        }
    }
}
