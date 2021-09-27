using System;

namespace UT_1
{
    class Program
    {//Author:- Raj Barot
     //Purpose:- Math Quiz Console Application
        static void Main()
        {
            // store user name
            string name = "";

            // string and int of # of questions
            string ques = "";
            int nQuestions = 0;

            // string and base value related to difficulty
            string difficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int QCount = 0;
            int QCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            double op1 = 0;
            double op2 = 0;
            double Ans = 0;

            // string and int for the response
            string Response = "";
            double dResponse = 0;

            // boolean for checking valid input
            bool bValid = false;

            // play again?
            string sAgain = "";

            // seed the random number generator
            Random rand = new Random();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Math Quiz! taaadaa");
            Console.WriteLine();

            // Ask the user's name for their Name
            while (true)
            {
                Console.Write("Enter Name-> ");
                name = Console.ReadLine();

                if (name.Length > 0)
                {
                    break;
                }
            }

        // Start: tlabel to return if they want to play the game again
        start:

            // initialize correct responses as 0
            QCorrect = 0;

            Console.WriteLine();

            do
            {
                Console.Write("How many questions do u want-> ");
                ques = Console.ReadLine();

                try
                {
                    nQuestions = int.Parse(ques);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Integer valid input only");
                    bValid = false;
                }

            } while (!bValid);

            Console.WriteLine();

            do
            {
                Console.Write("Difficulty level (Easy, Medium, Hard)-> ");
                difficulty = Console.ReadLine();
            } while (difficulty.ToLower() != "easy" &&
                     difficulty.ToLower() != "medium" &&
                     difficulty.ToLower() != "hard");

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless name == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (difficulty.ToLower())
            {
                case "easy":
                    nMaxRange = MAX_BASE;
                    if (name.ToLower() == "david")
                    {
                        goto case "hard";
                    }
                    break;

                case "medium":
                    nMaxRange = MAX_BASE * 2;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3;
                    break;
            }

            // ask each question
            for (QCount = 0; QCount < nQuestions; ++QCount)
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 4);

                op1 = rand.Next(0, nMaxRange) + nMaxRange;
                op2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers
                if (op1 == 0 || op2 == 0)
                {
                    // decrement counter to try this one again (because it will be incremented at the top of the loop)
                    --QCount;
                    continue;
                }

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication
                if (nOp == 0)
                {
                    Ans = op1 + op2;
                    ques = $"Question #{QCount + 1}: {op1} + {op2} => ";
                }
                else if (nOp == 1)
                {
                    Ans = op1 - op2;
                    ques = $"Question #{QCount + 1}: {op1} - {op2} => ";
                }

                else if (nOp == 2)
                {
                    Ans = op1 * op2;
                    ques = $"Question #{QCount + 1}: {op1} * {op2} => ";
                }
                else
                {
                    Console.WriteLine("Please enter your answer up to 2 decimal placces\n");
                    Ans = op1 / op2;
                    Ans = Math.Round(Ans, 2);
                    ques = $"Question #{QCount + 1}: {op1} / {op2} => ";
                }

                // display the question and prompt for the answer
                do
                {
                    Console.Write(ques);
                    Response = Console.ReadLine();

                    try
                    {
                        dResponse = double.Parse(Response);
                        bValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter an integer.");
                        bValid = false;
                    }

                } while (!bValid);

                // if response == answer, output reward and increment # correct
                // else output stark answer
                if (dResponse == Ans)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Well done, {0}!!!", name);

                    ++QCorrect;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}. The answer is {1}", name, Ans);
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output their score
            Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", QCorrect, nQuestions, Convert.ToDouble(QCorrect) / (double)QCount);
            Console.WriteLine();

            do
            {
                // Ask if the players wants to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                if (sAgain.ToLower().StartsWith("y"))
                {
                    goto start;
                }
                else if (sAgain.ToLower().StartsWith("n"))
                {
                    break;
                }
            } while (true);
        }
    }
}
