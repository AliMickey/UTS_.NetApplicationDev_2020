using System;
/*
Week3 Lab Program:
 
Question:
Write a program in C# to swap the values of two variables.

Example:
Value1 = 10, Value2 = 20
After swapping:
Value1 = 20, Value2 = 10

Hint: Use a temporary variable
*/

namespace Week3LabProgram
{
    class SwapNumbers
    {
        public static void Main(string[] args)
        {
            // Write code to Declare Variables
            int number1;
            int number2;
            string userInput1;
            string userInput2;
            int temp;

            // Write code to Display message to the user and ask to enter two numbers
            Console.Write("\nInput the First Number : ");
            userInput1 = Console.ReadLine();
            number1 = Convert.ToInt32(userInput1);
            Console.Write("\nInput the Second Number : ");
            userInput2 = Console.ReadLine();
            number2 = Convert.ToInt32(userInput2);

            // Write code to Swap the two number using a 3rd/Temp variable
            temp = number1;
            number1 = number2;
            number2 = temp;

            // Write code to Display the results after swaping
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);

            // Write code to Accept a key press from the user
            Console.ReadKey();
        }
    }
}

/*
Test Cases:
Input the First Number :  10
Input the Second Number : 20

After Swapping :
First Number : 20
Second Number : 10

*/
