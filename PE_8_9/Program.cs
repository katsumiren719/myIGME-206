using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_9
{
    class Program
    {
        // Author :- RAJ BAROT
        // Purpose :- Console application that places double quotes around each word in a string
        static void Main(string[] args)
        {
                 
            string wordString;                  // string to store the input
            char[] spacecheck = { ' ' };        // need "space" to find as a word seperator
            Console.WriteLine("Type any string");
            wordString = Console.ReadLine();
            string[] myWords;                   // new variable for different seperated words

            myWords = wordString.Split(spacecheck);   // split method seperates the string with ' '(space)

            foreach (string word in myWords)
            {
                Console.Write("\"{0}\" ", word);   // printing them seperately
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}

