using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PE_7
{
    // Author :- RAJ BAROT
    // Purpose :- A game of Madlibs
    class Program
    {
        
        static void Main(string[] args)
        {
            int story_number = 0;       //to store number of stories available
            int counter = 0;            // counter temporary variable
            int choose = 0;             // Story number variable
            string sstore = "null";     //  User choice
            string line = null;         // Variable to read different lines
           
            StreamReader input = null;
            
            
            Console.WriteLine("Do u want to play \n");
           
            // Loop to validate user's Play activity
            while (true)
            {
                sstore = Console.ReadLine(); 
                if (sstore.ToLower() == "yes")
                {
                    Console.WriteLine("lets play Madlibs\n");
                    try 
                    {
                        input = new StreamReader("MadLibsTemplate.txt");
                        while ((line = input.ReadLine()) != null)
                        {
                            ++story_number;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error with file: " + e.Message);
                    }
                    finally
                    {
                        if (input != null)
                        {
                            input.Close();
                        }
                    }
               
                    string[] Mlibs = new string[story_number];

                   
                    try
                    {

                        input = new StreamReader("MadLibsTemplate.txt");
                        line = null;
                        while ((line = input.ReadLine()) != null)
                        {
                            Mlibs[counter] = line;
                            Mlibs[counter] = Mlibs[counter].Replace("\\n", "\n");
                            ++counter;
                        }
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("Error with file: " + e.Message);
                    }
                    finally
                    {
                        if (input != null)
                        {
                            input.Close();
                        }
                    }
                     // Which story they want to play
                    Console.WriteLine("Which story do you wanna play? \n Enter number from 1 to " + story_number + "\n");
                    while (true)
                    {
                        try //handling invalid inputs
                        {
                            choose = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid entry, Please enter a numaric value\n");
                        }
                        
                        if (choose <= 0 || choose > story_number)
                        {
                            Console.WriteLine("Invalid choose\n");

                        }
                        else
                        {
                            break;
                        }
                    }
                    choose--; 

                    string[] words = Mlibs[choose].Split(' ');
                    string result = "";
                    foreach (string word in words)
                    {
                        
                        if (word.StartsWith("{"))
                        {
                            string pword;
                            pword = word.Replace('{', ' ');
                            pword = pword.Replace('}', ' ');
                            pword = pword.Replace('_', ' ');

                            Console.WriteLine("Enter a " + pword);
                            string add = Console.ReadLine();
                            result += " " + add;
                        }
                        else
                        {
                            result += " " + word;
                        }
                    }
                    Console.WriteLine(result);
                    break;
                }
                else if (sstore.ToLower() == "no") 
                {
                    Console.WriteLine(" Cyan");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }


        }
    }
}