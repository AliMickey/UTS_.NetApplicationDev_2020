using System;
using System.Linq;

/*
Write a program to Create Student a Result management System with the following specifications:
1. There are two classes, Person (Abstract base class), Student(derived class from person)
2. There is one Interface for Generating the Results

Please refer to the instructions document for the class diagrams and Instructions.

    */

namespace Week6LabProgram
{
    public abstract class Person
    {
        public string name;
        public string address;

        public Person(string personName, string personAddress)
        {
            name = personName;
            address = personAddress;
        }          
    }

    public interface IResult<T>
    {
        void GetMarks();
        string CalculateResult();
        void DisplayResult();
    }

    public class Student : Person
    {
        private string standard;
        private string roll;
        private double[] mark;

        public Student(string name, string address, string standard, string roll) : base(name, address) 
        {
            this.standard = standard;
            this.roll = roll;
            this.mark = new double[5];

        }
        
        public void GetMarks() 
        {
            for(int loopVar = 0; loopVar < 5; loopVar++)
            {
                Console.Write("Enter Marks for Subject-{0}: ", loopVar+1);
                string userInput = Console.ReadLine();
                this.mark[loopVar] = Convert.ToDouble(userInput);
            }
        }

        public string CalculateResult()
        {
            double totalMarksObtained = mark.Sum();
            if (totalMarksObtained / 5 < 40)
                return "Fail";
            else
                return "Pass";
        }

        public void DisplayResult()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\t\tMark Sheet");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Class: {0}", this.standard);
            Console.WriteLine("Roll: {0}", this.roll);
            Console.WriteLine("Address: {0}", this.address);
            Console.WriteLine("\nMarks Obtained:");
            for (int loopVar = 0; loopVar < 5; loopVar++)
            {
                Console.WriteLine("Subject-{0}: {1}", loopVar, this.mark[loopVar] + 1);
            }
            Console.WriteLine("\nAverage Marks: {0}", this.mark.Average());
            Console.WriteLine("Final Grade: {0}", this.CalculateResult());
            Console.WriteLine("---------------------------------------------");
        }

    }
    class Week6Program1
    {
        static void Main(string[] args)
        {
            // Write code to Create a Student object
            Student s1 = new Student("George Woolsworth", "Ultimo, Sydney 2007, Australia", "V", "1004");
            // Write code to Get the student's marks
            s1.GetMarks();

            // Write code to Generate the Marks Sheet
            s1.DisplayResult();

            // Accept a key press from user.
            Console.ReadKey();
        }
    }
}

/* Test Case:

Enter Marks for Subject-1:56
Enter Marks for Subject-2:42
Enter Marks for Subject-3:89
Enter Marks for Subject-4:69
Enter Marks for Subject-5:95

---------------------------------------------
                Mark Sheet
---------------------------------------------
Name: George Woolsworth
Class: V
Roll: 1004
Address: Ultimo, Sydney 2007, Australia

Marks Obtained:
Subject-0: 57
Subject-1: 43
Subject-2: 90
Subject-3: 70
Subject-4: 96

Average Marks: 70.2
Final Grade: Pass
---------------------------------------------

    
    */
