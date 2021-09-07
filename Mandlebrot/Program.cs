using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandelbrot
{


    class Class1
    {

        [STAThread]
        static void Main(string[] args)
        {

            string Start_Icord = "null";
            string Start_Rcord = "null";
            string End_Icord = "null";
            string End_Rcord = "null";
           
            double dStart_Icord = 0;
            double dStart_Rcord = 0;
            double dEnd_Icord = 0;
            double dEnd_Rcord = 0;
      
            double dDiff_I = 0;
            double dDiff_R = 0;

            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;



            Console.WriteLine("Enter the values for the start and end of imaginary and real coordinates as prompted\n");
            Console.WriteLine("Remember that imagcord must start at higher value than it ends \n");
            Console.WriteLine("Remember that real cord must start at lower value than it ends \n");
            while (true)
            {
                Console.WriteLine("Enter the value for start of imagcoord\n");
                Start_Icord = Console.ReadLine();
                dStart_Icord = Convert.ToDouble(Start_Icord);
                Console.WriteLine("Enter the value for end of imagcoord\n");
                End_Icord = Console.ReadLine();
                dEnd_Icord = Convert.ToDouble(End_Icord);
                if (dStart_Icord > dEnd_Icord)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid values, imagcoord must start at a higer value than it ends\n");
                }

            }
            while (true)
            {
                Console.WriteLine("Enter the value for start of realcoord\n");
                Start_Rcord = Console.ReadLine();
                dStart_Rcord = Convert.ToDouble(Start_Rcord);
               
                Console.WriteLine("Enter the value for end of realcoord\n");
                End_Rcord = Console.ReadLine();
                dEnd_Rcord = Convert.ToDouble(End_Rcord);
               
                if (dStart_Rcord < dEnd_Rcord)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid values, realcoord must start at a lower value than it ends\n");
                }

            }
            dDiff_I = (dStart_Icord - dEnd_Icord) / 48; 
        
            dDiff_R = (dEnd_Rcord - dStart_Rcord) / 80; 
            for (imagCoord = dStart_Icord; imagCoord >= dEnd_Icord; imagCoord -= dDiff_I)
            {
                for (realCoord = dStart_Rcord; realCoord <= dEnd_Rcord; realCoord += dDiff_R)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}