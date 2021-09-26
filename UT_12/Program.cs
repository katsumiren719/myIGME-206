using System;

namespace UT_12
{

    // Author :- RAJ BAROT
    /* Purpose :- The function should increase the salary by $19,999.99 if name = your name and return true
    Otherwise it should return false.
    The main program should congratulate the user if they got a raise, and display their new salary.*/

    class Program
    {
        // Author :- RAJ BAROT
        // Purpose :- Console application related to salary raise

        static bool GiveRaise(string name, ref double salary)
            // Function to increase Salary
        {
            if (name.ToUpper() == "RAJ")
            {
                salary = salary + 19999.99;  // if conditin = true increase salary
                return true;
            }
            
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.WriteLine("Enter Your Name");
            sName = Console.ReadLine();

            if (GiveRaise(sName, ref dSalary) == true)   // checking bool condtion, if its true increase salary
            {
                Console.WriteLine("Congratulations, your salary got increase");
                Console.WriteLine("This is your New Salary " + dSalary);
            }
            else // checking bool condtion, if its false default salary
            {
                Console.WriteLine("This is your  Salary " + dSalary);
            }

        }
    }
}
