using System;

/* Write a program to read the employee details from a text file and store them in a List.
   Use the class diagran given in the instruction document as reference
*/

namespace Week9Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the EmployList
            EmployeeList myEmployees = new EmployeeList();

            // Load the date from the text file to the List collection
            myEmployees.LoadEmployees("emp.txt");

            // Display the employee details 
            myEmployees.PrintEmployees();

            // Sort the employee detail and display again.
            myEmployees.SortEmployees();
            Console.WriteLine("\n After Sorting:");
            myEmployees.PrintEmployees();
            
            Console.ReadKey();
        }
    }
}


/* 
 Test case:
Employee Details: Jetson  Jordon ID#:1232 Weekly Income: 251.2
Employee Details: Cogswall  James ID#:7165 Weekly Income: 684.725
Employee Details: Spacelly  George ID#:5903 Weekly Income: 968.032
Employee Details: Elroy  Alsison ID#:123 Weekly Income: 116.62
Employee Details: Rosie  Philip ID#:8080 Weekly Income: 281.019

 After Sorting:
Employee Details: Elroy  Alsison ID#:123 Weekly Income: 116.62
Employee Details: Jetson  Jordon ID#:1232 Weekly Income: 251.2
Employee Details: Spacelly  George ID#:5903 Weekly Income: 968.032
Employee Details: Cogswall  James ID#:7165 Weekly Income: 684.725
Employee Details: Rosie  Philip ID#:8080 Weekly Income: 281.019
    
 */
