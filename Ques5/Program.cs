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
            Console.WriteLine("Enter the first number : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number : ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the forth number : ");
            double d = Convert.ToDouble(Console.ReadLine());

            double e = a * b * c * d;
            Console.WriteLine("The product of all 4 numbers are : " + e);
        }
    }
}
