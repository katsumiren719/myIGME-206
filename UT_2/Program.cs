using System;

namespace UT_2
{       //Author:- Raj Barot
        //Purpose:- Create a console application that modifies the attached "Number Sorter" application to request sentences and sort the words in the sentence in ascending or descending order.

    class Program
    {

        // the definition of the delegate function data type
        delegate string sortingFunction(string[] a);

        //Author:- Raj Barot
        //Purpose:- "Number Sorter" application to request sentences and sort the words in the sentence in ascending or descending order.
        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            string[] uArray;
            string[] sArray;


            // declare the delegate variable which will point to the function to be called
            sortingFunction sorter;

            // a label to allow us to easily loop back to the start if there are input issues

            Console.WriteLine("Enter numbers with space");

            // read the space-separated string of numbers
            string sWords = Console.ReadLine();

            // split the string into the an array of strings which are the individual numbers
            string[] sWord = sWords.Split(' ');
            foreach (string word in sWord)
            {
                Console.WriteLine(word);
            }

            // initialize the size of the unsorted array to 0
            int uLength = 0;



            // iterate through the array of number strings
            foreach (string sThisWord in sWord)
            {
                // if the length of this string is 0 (ie. they typed 2 spaces in a row)
                if (sThisWord.Length == 0)
                {
                    // skip it
                    continue;
                }
                ++uLength;
            }
            // Console.WriteLine(uLength);

            // now we know how many unsorted numbers there are
            // allocate the size of the unsorted array
            uArray = new string[uLength];

            // reset uLength back to 0 to use as the index to store the numbers in the unsorted array
            uLength = 0;
            foreach (string sThisWord in sWord)
            {
                // still skip the blank strings
                if (sThisWord.Length == 0)
                {
                    continue;
                }


                // store the value into the array
                uArray[uLength] = sThisWord;
                //Console.WriteLine(uArray[uLength]);
                // increment the array index
                uLength++;
            }

            // allocate the size of the sorted array
            sArray = new string[uLength];

            // prompt for <a>scending or <d>escending
            Console.Write("A for Ascending or d for Descending? ");
            string order = Console.ReadLine();

            if (order.ToLower().StartsWith("a"))
            {
                sorter = new sortingFunction(FindLowestValue);
            }
            else
            {
                sorter = new sortingFunction(FindHighestValue);
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (uArray.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                sArray[nSortedLength] = sorter(uArray);

                // remove the current sorted value
                RemoveUnsortedValue(sArray[nSortedLength], ref uArray);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }

            // write the sorted array of numbers
            Console.WriteLine("The sorted list is: ");
            foreach (string thisWord in sArray)
            {
                Console.Write($"{thisWord} ");
            }

            Console.WriteLine();
        }

        // find the lowest value in the array of doubles
        static string FindLowestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string thisWord in array)
            {
                int tempVal1 = thisWord.Length;
                int tempVal2 = returnVal.Length;

                // if the current value is less than the saved lowest value

                if (tempVal1 < tempVal2)
                {
                    // save this as the lowest value
                    returnVal = thisWord;
                }


            }

            // return the lowest value
            return (returnVal);
        }

        static string FindHighestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string thisWord in array)
            {
                int tempVal1 = thisWord.Length;
                int tempVal2 = returnVal.Length;
                // if the current value is greater than the saved highest value
                if (tempVal1 > tempVal2)
                {
                    // save this as the highest value
                    returnVal = thisWord;
                }

            }

            // return the highest value
            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(string removeValue, ref string[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            string[] newArray = new string[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (string srcWord in array)
            {
                // if this is the number to be removed and we didn't remove it yet
                if (srcWord == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = srcWord;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (uArray in this case)
            array = newArray;
        }
    }
}
