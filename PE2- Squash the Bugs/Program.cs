using System;

// Class Program
// Author: David Schuh
// Purpose: Bug squashing exercise
// Restrictions: None
class Program
{
    // Method: Main
    // Purpose: Loop through the numbers 1 through 10 
    //          Output N/(N-1) for all 10 numbers
    //          and list all numbers processed
    // Restrictions: None
    static void Main(string[] args)
    {
        // declare int counter
        //int i = 0
        //missing the semicolon ';' (Syntax error)

        //int i = 0;
        double i = 0;

        // changed the datatype of i to double so it doesnt throw error when divide by 0 coz it seemed 
        //  quickest and easiest
        // or the same can be done by try catch blocks 
        // or can throw DividebyZero Exception (Runtime exception )

        string allNumbers = null;

        // loop through the  1 through 10
        // for (i = 1; i < 10; ++i)
        // Changed < to <= to include the 10 in the loop (logical error)
        for (i = 1; i <= 10; ++i)
        {
            // declare string to hold all numbers
            //string allNumbers = null;
            //allNumber string should be declared outside the loop (Logical error)

            // output explanation of calculation
            //Console.Write(i + "/" + i - 1 + " = ");
            //missing brackets in output expression of the calculation (Syntax error)
            Console.Write(i + " / (" + i + "- 1)" + " = ");

            // output the calculation of the numbers
            Console.WriteLine(i / (i - 1));

            // concatenate each number to allNumbers
            allNumbers += i + " ";
            //Console.Write(allNumbers);

            // increment the counter
            //i = i + 1;
            //unnecessary increment (Logical error)
        }

        // output all numbers which have been processed
        //Console.WriteLine("These numbers have been processed: " allNumbers);
        // +  symbol missing before the allNumbers , hence it didnt print the value earlier (syntax error)
        Console.WriteLine("These numbers have been processed: " + allNumbers);
    }
}

