using System;


/*
Program 1:
Write a C# Program to read 10 numbers as user input and find the following:
    a.	Sum of the numbers,
    b.	Average of the numbers,
    c.	Largest number, and 
    d.	Smallest number
    
    Without using arrays!

    Example:
    Enter 10 numbers: 1 2 3 4 5 6 7 8 9 10
    Sum = 55
    Average = 5.5
    Largest number = 10
    Smallest number = 1

    Hint:
    Read the numbers in a loop!

    ** Please Check the complete code and the test cases in order to 
       understand the control flow before trying to solve the questions
*/


namespace Week3LabProgram
{
    class Program1
    {
        static void Main(string[] args)
        {
            // Variable declaration
            // int for numbers, string for user input and float for average
            int number;
            int sum = 0;
            int largestNumber = 0;
            int smallestNumber = 0;
            string inputNumber;
            float average;

            // Initialize flags to assign the first value to the variables
            bool initializedSmallestNumber = false, initializedLargestNumber = false;
            
            // Input 10 numbers from user in a loop and
            // compute the sum, largest and smallest number
            Console.WriteLine("Enter 10 numbers:"); // Enter the code here

            // Write the code initialize the for loop
            for(int i = 0; i < 10; i++)
            {
                //Display message to user to enter a number
                // Complete the code
                Console.Write("Enter number: ");
                
                // Write the code Read the user input as string
                inputNumber = Console.ReadLine();

                //Convert user input from string to integer
                // Hint: use Convert.ToInt32()
                number = Convert.ToInt32(inputNumber);

                // Initial the variable to track largest and smallest number to the first value entered by user
                if (!(initializedLargestNumber && initializedSmallestNumber))
                {
                    // Write the code below
                    largestNumber = number;
                    smallestNumber = number;

                    // Change the bool variable to true
                    initializedSmallestNumber = initializedLargestNumber = true;
                }

                // Write the code to Add all the numbers
                sum += number;

                // Write the code to Check for largest number
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
                // Write the code to Check for smallest number
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            //Write the code to compute average
            average = (float)sum/10;

            // Complete the code to Display result
            Console.WriteLine("\nSum = " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Largest Number: " + largestNumber);
            Console.WriteLine("Smallest number: " + smallestNumber);
            
            //Write the code to Accept a key entry from user
            Console.ReadKey();
        }
    }
}

/*
Test case:

    Enter 10 numbers:
    Enter number 1: 5
    Enter number 2: 6
    Enter number 3: 9
    Enter number 4: 8
    Enter number 5: 4
    Enter number 6: 5
    Enter number 7: 32
    Enter number 8: 1
    Enter number 9: 5
    Enter number 10: 2

    Sum = 77
    Largest Number: 32
    Smallest number: 1
    Average: 7.7


*/
