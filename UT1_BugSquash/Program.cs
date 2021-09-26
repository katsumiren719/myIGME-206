using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    // Author :- RAJ BAROT
    // Purpose :- To remove errors and calculate x^y using a recursive function
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY    Syntax error no ;
            int nY;

            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.);  
            // Syntax Error no "" in writelinefunction
            Console.WriteLine("This program calculates x ^ y");
         
           
            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine();
                // we need to initialize sNumber so we add the input from console readline into sNumber
                // Syntax Error
                sNumber = Console.ReadLine();

            } while (!int.TryParse(sNumber, out nX));
            

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            }
            while (int.TryParse(sNumber, out nY));
            //while (int.TryParse(sNumber, out nX));
            // we took the input of y into nX which makes no sense 
            //Logical Error


            // compute the factorial of the number using a recursive function

            nAnswer = Power(nX, nY);
                        

            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            returnVal;
        }
    }
}

