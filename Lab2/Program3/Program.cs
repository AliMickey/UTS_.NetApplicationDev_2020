using System;
/*
Week3 Lab program:

Questions:
Write a C# Program to create and display the following triangle pattern:
Example:
1 2 3 4 5
1 2 3 4
1 2 3
1 2
1

Hint: Use nested loops! Refer to the triangle pattern program discussed in the Week-2 Lecture.
*/

namespace Week3LabProgram
{
    class TriangleProgram
    {
        public static void Main(string[] args)
        {
            //// Write code to Accept the number of row to display in the triangle
            Console.Write("Enter the number row in the triangle: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            // Create the triangle in the nested loop
            // // Write code for the Outer loop 
            for (int outerLoop = number; outerLoop != 0; outerLoop--)
            {
                // // Write code for the Inner loop 
                for (int innerLoop = 1; innerLoop <= outerLoop; innerLoop++)
                {
                    // // Write code to Display the values in each row of the triangle
                    Console.Write(innerLoop + " ");
                }
                // // Write code to Transfer the control to next line for display
                Console.Write(System.Environment.NewLine);
            }
            //Write code to Accept a key press from user
            Console.ReadKey();


        }
    }
}

/*
Test Case:
Program Output:
Enter the number row in the triangle: 5

1 2 3 4 5
1 2 3 4
1 2 3
1 2
1

    */
