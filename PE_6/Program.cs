using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_NUMBER_SEARCH
{
    // Program by - Raj Barot
    // Aim : Program to find a random number by guessing
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();  // random number generation
            int rNumber = rand.Next(0, 101);
            Console.WriteLine(rNumber);
            Console.WriteLine("Absolute Values of Negative numbers will be taken");

            int x = 0;

            double sNumber = 0; // the temp number to traverse throught 100 numbers

            bool element = false;
            while (x <= 8)  // Condition for 8 times attempts
            {
                if (x == 8)
                {
                    Console.WriteLine("Maximum attempts reached. U Fail");
                    break;
                }

                while (!element)   // Loop to check for valid input 
                {
                    Console.Write("Enter your guess: ");
                    sNumber = Math.Abs(Convert.ToDouble(Console.ReadLine()));  // Math.abs so as to convert negative number into a positive number
                                                                                    // and find its absolute value

                    if (sNumber >= 0 && sNumber <= 100)
                    {
                        element = true;
                    }
                }
                element = false;

                if (sNumber == rNumber) // if the number we calculate is what the user input is
                {
                    Console.WriteLine("Right Guess");
                    break;
                }

                else if (sNumber <= rNumber) // Condition to check for lower number
                {
                    x++;
                    Console.WriteLine("Guess is Lower");
                    Console.WriteLine("Attempts Left {0:D}", 8-x);
             
                }

                else  // Condition to check for higher
                      // number
                {
                    x++;
                    Console.WriteLine("Guess is higher:");
                    Console.WriteLine("Attempts Left {0:D}:", 8-x);
                    
                }
            }
            x++;
        }
    }
}