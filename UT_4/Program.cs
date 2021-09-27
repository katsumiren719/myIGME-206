using System;
using System.Timers;

namespace UT_4
{
    //Author:- Raj Barot
    //Purpose:- Write a console application that re-creates the attached 3questions.exe.

    class Program
    {
        //Author:- Raj Barot
        //Purpose:- A function that recreates the given 3questions.exe file

        static Timer timer;
        static string[] sAnswer;
        static int qTotal;
        static bool btime;

        
        public static void Main(string[] args)
        {
            bool pAgain = false;                     //variable to check if the player wants to play again or not
            string[] sQuestions = new string[3];        //variable to store questions
            sQuestions[0] = "What is your favorite color?";
            sQuestions[1] = "What is the answer to life, the universe and everything?";
            sQuestions[2] = "What is the airspeed velocity of an unladen swallow?";
            sAnswer = new string[3];                    
            sAnswer[0] = "black";
            sAnswer[1] = "42";
            sAnswer[2] = "What do you mean? African or European swallow?";
            timer = new Timer(5000.0);
            timer.Elapsed += new ElapsedEventHandler(TimesUp);

            do
            {
                Console.WriteLine();
                do                                      // Prompting the user for the question number
                {

                    Console.Write("Choose your question (1-3): ");
                    try
                    {
                        qTotal = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        continue;
                    }
                }
                while (qTotal < 1 || qTotal > 3);
                btime = false;
                Console.WriteLine("You have 5 seconds to answer the following question:");
                Console.WriteLine(sQuestions[qTotal - 1]);
                timer.Start();
                string uAnswer = Console.ReadLine();
                timer.Stop();
                if (!btime)
                {
                    if (uAnswer == sAnswer[qTotal - 1])
                    {
                        Console.WriteLine("Well done!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!  The answer is: " + sAnswer[qTotal - 1]);
                    }
                }

                while (true)                                        //Prompting the user if he wants to play again
                {
                    Console.Write("Play again? ");
                    string sRePlay = Console.ReadLine();
                    if (!sRePlay.ToLower().StartsWith("n") && !sRePlay.ToLower().StartsWith("y"))
                    {
                        continue;
                    }
                    else
                    {
                        if (sRePlay.ToLower().StartsWith("n"))
                        {
                            pAgain = false;
                            break;
                        }
                        else
                        {
                            pAgain = true;
                            break;
                        }
                    }
                }

            }
            while (pAgain);
        }

        public static void TimesUp(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            Console.WriteLine("Time's up!");
            Console.WriteLine("The answer is: " + sAnswer[qTotal - 1]);
            Console.WriteLine("Please press enter.");
            btime = true;
        }
    }
}
