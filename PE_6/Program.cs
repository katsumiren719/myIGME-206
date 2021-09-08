using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_NUMBER_SEARCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();  // random number generation
            int rNumber = rand.Next(0, 101);
            Console.WriteLine(rNumber);

            int x = 0;

            double searchNumber = 0; // the temp number to traverse throught 100 numbers

            bool element = false;
            while (x <= 8)  // Condition for 8 times attempts
            {
                if (x == 8)
                {
                    Console.WriteLine("Maximum attempts reached.");
                    break;
                }

                while (!element)   // Loop to check for valid input 
                {
                    Console.Write("Enter your guess: ");
                    searchNumber = Convert.ToDouble(Console.ReadLine());

                    if (searchNumber >= 0 && searchNumber <= 100)
                    {
                        element = true;
                    }
                }
                element = false;

                if (searchNumber == rNumber) // if the number we calculate is what the user input is
                {
                    Console.WriteLine("Right Guess");
                    break;
                }

                else if (searchNumber <= rNumber) // Condition to check for lower number
                {
                    Console.WriteLine("Guess is Lower");
                    x++;
                }

                else  // Condition to check for higher
                      // number
                {
                    Console.WriteLine("Guess is higher");
                    x++;
                }
            }
            x++;
        }
    }
}