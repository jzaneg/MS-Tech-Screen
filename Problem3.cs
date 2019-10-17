using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Problem3
    {
        //====QUESTION====//
        //Given an array of strings, find longest concatenated string with only unique characters
        //====STEPS====//
        //1. Create variables for: 
        //// N(int),
        //// string array for A(string[]), 
        //// int to hold result(int),
        //// int ConcatLength for concatenated word length(int),
        //// int LongestConcat for the LongestConcat(int),
        //// string S to hold concatenated words(string),
        //// bool UniqueString to check if the word has unique characters,
        //// List<string> UniqueStrings to hold unique words;
        //2. Create 'foreach' loop to check if each word of input is unique (call 'IsUniqueString' method)
        ////2a. Add each unique word to UniqueStrings list
        //3. Create 'for' loop to add unique words together
        ////3a. Create inner 'for' loop to continue looping through all words
        //4. Ensure word index != equal and inner for loop hasn't reach end of word
        ////4a. If yes, break
        //5. Create IsUniqueString method to check if word is unique
        //6. Add words together and run through IsUniqueString method
        //7. Create GetStringLength method to calculate length of concatenated word
        //8. If concatenated word is unique, call GetStringLength to get length
        //9. If LongestConcat is less than concatenated word, set LongestConcat = concatenated word
        //10. Return LongestConcat
        //11. Return Max() value of items in list

        public static void Main(string[] args)
        {
            int N = 0; //number of strings to be entered
            string[] A; //array for input strings
            int Result = 0; //result of LongestConcat

            Console.WriteLine("Enter num of strings");
            N = int.Parse(Console.ReadLine());
            A = new string[N]; //Set A to the size of N
            Console.WriteLine("Enter each string one at a time followed by the enter key.");

            for (int i = 0; i < N; i++)
            {
                A[i] += Console.ReadLine();
            }
            Result = FindLongestConcat(A);

            Console.WriteLine(Result);
            Console.ReadKey();
        }
        
        public static int FindLongestConcat(string[] input)
        {
            int ConcatLength = 0; //length of concatenated word
            int LongestConcat = 0; //length of longest concatenated word
            string S = string.Empty; //string to store concatenated word
            bool UniqueString = false; //bool to identify if word has all unique chars
            List<string> UniqueStrings = new List<string>(); //list to store unique words

            foreach (string word in input) //build list of unique strings
            {
                UniqueString = IsUniqueString(word); //check if word has all unique chars
                if (UniqueString == true)
                {
                    UniqueStrings.Add(word); // if yes, add to list
                }
            }
            for (int i = 0; i <= UniqueStrings.Count - 1; i++) //loop through words in unique list
            {
                for (int j = 0; j <= UniqueStrings.Count - 1; j++) //loop through words in unique list
                {
                    if (i == j) //if indexes match and j isn't the last letter increase j, else break
                    {
                        if (j != UniqueStrings.Count - 1)
                        {
                            j++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    S = UniqueStrings[i] + UniqueStrings[j]; //set S to concatenated words
                    UniqueString = IsUniqueString(S); //check if concatenated word is unique
                    if (UniqueString == true) //if unique, get length 
                    {
                        ConcatLength = GetStringLength(S);
                    }
                }
            }
            if (LongestConcat < ConcatLength) //if unique length is greater than longest concat, set longest = unique
            {
                LongestConcat = ConcatLength;
            }
            return LongestConcat; //return longest
        }

        public static bool IsUniqueString(string word)
        {
            bool IsUnique = true; //set unique to true initially

            for (int i = 0; i < word.Length; i++) //loop through all chars
            {
                for (int j = i + 1; j < word.Length; j++) //loop through all chars
                {
                    if (word[i] == word[j]) //if chars match, not unique, break
                    {
                        IsUnique = false;
                        break;
                    }
                }
            }
            return IsUnique; //return if the word is unique
        }
        
        public static int GetStringLength(string S)
        {
            int StringCount = 0;

            StringCount = S.Length; //length = length of unique word

            return StringCount; //return length
        }
    }
}
