using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    // Author : Raj Barot
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[] userChars = Console.ReadLine().ToCharArray();
            int[] alphabets = new int[26];
            Function stringRecord = new Function(userChars, alphabets);

            for (int i = 0; i < stringRecord.ustring.Length; i++)
            {
                if (stringRecord.ustring[i] >= 'A' && stringRecord.ustring[i] <= 'Z')
                {
                    stringRecord.ustring[i] = (char)(stringRecord.ustring[i] + 'a' - 'A');
                }
                if (stringRecord.ustring[i] >= 'a' && stringRecord.ustring[i] <= 'z') stringRecord.num[stringRecord.ustring[i] - 'a']++;
            }

        
            for (int i = 0; i < stringRecord.num.Length; i++)
            {
                Console.WriteLine("{0}: {1}", (char)('a' + i), stringRecord.num[i]);
            }
        }


       
        struct Function
        {
            public char[] ustring;
            public int[] num;

            public Function(char[] ustring, int[] num)
            {
                this.ustring = ustring;
                this.num = num;
            }
        }


    }
}