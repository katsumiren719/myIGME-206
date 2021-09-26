using System;

namespace UT_13
{
    // Author :- RAJ BAROT
    /* Purpose :- The function should increase the salary by $19,999.99 if name = your name and return true
    Otherwise it should return false.
    The main program should congratulate the user if they got a raise, and display their new salary.*/

    struct employee
    {
        // Using structure to do the same thing as Q12
        public string sName;  // need them to be public variables else we cannot access them outside
        public double dSalary;
    };

     class Program
    {
        // Author :- RAJ BAROT
        // Using structure to do the same thing as Q12

        static void Main(string[] args)
        {
            employee e1;
            e1.dSalary = 30000;
            // initialising variables 
            Console.WriteLine("Enter Your Name");
            e1.sName = Console.ReadLine();
            if (GiveRaise(e1) == true) // passing struct object to give raise method
            {
                Console.WriteLine("Congratulations, your salary got increase");
                e1.dSalary += 19999.99;
                Console.WriteLine("This is your New Salary " + e1.dSalary);
            }
            else 
            {
                Console.WriteLine("This is your  Salary " + e1.dSalary);
            }
        }

        static bool GiveRaise(employee e)
        // Function to increase Salary
        {
            if (e.sName.ToUpper() == "RAJ")
            {
                return true;
            }
            else return false;
        }

    
}
}
    




        
