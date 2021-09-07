using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number with a decimal precision of 2.");
            string input = Console.ReadLine();
            double a = (Convert.ToDouble(input) + 55.0);
            Console.WriteLine(a);


        }
    }