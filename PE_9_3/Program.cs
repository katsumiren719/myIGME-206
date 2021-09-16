using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_9_3
{
    class Program
    {
        // Author :- RAJ BAROT

        // Purpose :-  delegate function and use it to impersonate the Console.ReadLine()

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

