using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        //====QUESTION====//
        //Find Max value of adding a number to an integer
        //====STEPS====//
        //1. Create variables for: 
        //// number 5(int),
        //// MaxValue(int), 
        //// temporary value(int),
        //// length of converting N to a string(int), 
        //// absolute value of N(int),
        //// string to store absolute value(string),
        //// string to convert number 5(string),
        //// list for adding numbers(List<int>)
        //2. Check if N > 0
        ////2a. If yes result is 50
        //3. Get absolute value of N
        //4. Convert absolute value to string
        //5. Get strings length (optional could just use string.Length)
        //6. Instantiate list
        //7. Create 'for' loop to loop through new
        //8. Set temp value = parse of string N after inserting string 5 at index
        //9. If N is > 0 add temp value to list
        ////9a. Else add negative Value to list (-temp value)
        //10. Return Max() value of items in list

        static void Main(string[] args)
        {
            //Return max possible value when including 'N'
            //if '5' is greater than the first number, insert '5' else go to next number
            int UserNumber = 0;
            int Result = 0;
            Console.WriteLine("Please enter your number.");
            UserNumber = int.Parse(Console.ReadLine());
            Result = Max(UserNumber);
            //int result = Max(670);
            Console.WriteLine($"The max value is {Result}");
            Console.ReadKey();

        }
        public static int Max(int N)
        {
            int Add5 = 5; //# to add to int
            int MaxValue = 0; //Max value by adding 5
            int Value = 0; //temp value
            int StringLength = 0; //length of converting N to string
            int AbsoluteN = 0; //absolute value of N
            string StringN = string.Empty; //string to store absolute value of N
            string String5 = Add5.ToString(); //convert Add5 to string to add to StringN
            List<int> PotentialMaxNums; //list to add values to

            if (N == 0)
            {
                MaxValue = 50;
            }
            else
            {
                AbsoluteN = Math.Abs(N); //get absolute value of N
                StringN = AbsoluteN.ToString(); //convert absolute value to string
                StringLength = StringN.Length; //get converted strings length
                PotentialMaxNums = new List<int>();
                for (int i = 0; i < StringLength + 1; i++)
                {
                    Value = int.Parse(StringN.Insert(i, String5)); //insert "5" to index and parse string
                                                                   //Console.WriteLine(Value);
                    if (N > 0)
                    {
                        PotentialMaxNums.Add(Value);// add number to list
                    }
                    else
                    {
                        //Console.WriteLine(-Value);
                        PotentialMaxNums.Add(-Value); // add -number to list
                    }
                }
                MaxValue = PotentialMaxNums.Max();
            }
            return MaxValue;
        }
    }
}
