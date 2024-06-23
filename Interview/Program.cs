/*
 This function is checking if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.

The criteria for a candidate to be qualified in the coding interview is:

-The candidate should have complete all the questions.
-The maximum time given to complete the interview is 120 minutes.
-The maximum time given for very easy questions is 5 minutes each.
-The maximum time given for easy questions is 10 minutes each.
-The maximum time given for medium questions is 15 minutes each.
-The maximum time given for hard questions is 20 minutes each.

If all the above conditions are satisfied, return "qualified", else return "disqualified".

You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.

Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].

The maximum time to complete the interview includes a buffer time of 20 minutes.

 */


using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120));
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));

            Console.ReadKey();
        }

        static string Interview(int[] array, int time)
        {
            if (array.Length < 8)
            {
                return "disqualified";
            }
            if (array[0]<=5 && array[1] <= 5 && array[2] <= 10 && array[3] <= 10 && array[4] <= 15 && array[5] <= 15 && array[6] <= 20 && array[7] <= 20 && time<=120)
            {
                return "qualified";
            }
            else
            {
                return "disqualified";
            }
            
            
        }
 
    }
}

