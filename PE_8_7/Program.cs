using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldString;
            Console.WriteLine("Type any string");       // input string
            oldString = Console.ReadLine();             // read input string
            char[] cArray = oldString.ToCharArray();    // coverting it to array so we get char seperately
            string reversestring = String.Empty;        // new empty string
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reversestring += cArray[i];         // adding the char from old string from the end to the start of the reversestring
                                                    
            }

            Console.WriteLine(reversestring);
        }
    }
}
/*
{
    char[] array = s.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}*/

