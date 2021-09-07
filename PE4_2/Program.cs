using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
   
    class Program
    {
       
        
        static void Main(string[] args)
        {
            int x = 0; 
            int y = 0; 

            string sX = "null"; 
            string sY = "null"; 

            bool result = false; // The X-OR variable
           
            Console.WriteLine("Enter two integers when asked; if any > 10 you will be asked to enter again");
            //keep the loop running till a valid input
            while (true)
            {
                Console.WriteLine("Enter the first number\n");
                sX = Console.ReadLine(); 
                Console.WriteLine("Enter the second number\n"); 
                sY = Console.ReadLine(); 
                x = Convert.ToInt32(sX); 
                y = Convert.ToInt32(sY); 
                result = (x > 10) ^ (y > 10); //EX-OR function as Ques 1
                if (result) 
                {
                    Console.WriteLine("Number > 10" + result);
                    break; 
                }
              
                else if (x > 10 && y > 10) 
                {
                    Console.WriteLine("Both numbers > 10, Reenter \n" + result);
                }
                else 
                {
                    Console.WriteLine("Numbers are fine\n" + result);
                    break;
                }
            }
        }
    }
}