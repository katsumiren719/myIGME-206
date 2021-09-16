using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_9_3
{
    class Program
    {
        delegate string delegateReadLine();
        static void Main(string[] args)
        {
            WriteLine("Type something :");
            delegateReadLine readLine = new delegateReadLine(ReadLine);
            
            string userInput = readLine();
            WriteLine($"Your String: {userInput}");

        }
    }
}

