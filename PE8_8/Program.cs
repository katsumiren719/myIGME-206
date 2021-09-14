using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    class Program

    // Author :- RAJ BAROT
    // Purpose :- console application that accepts a string and does a case-insensitive replacement of all occurrences of the word "no" with "yes"
    {
        static void Main(string[] args)
        {

            string oldString;                  // string to store the input
          
            Console.WriteLine("Type any string");       // input string
            oldString = Console.ReadLine();

            string newstring  = oldString.Replace("no ","yes");  // simple string replace method
                        // added a space after no a("no ") so words like (not, nor) dont get changed to yest or yesr as well

            Console.WriteLine(newstring);

        }
    }
}

