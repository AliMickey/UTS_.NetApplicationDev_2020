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
       // public double[] marks;

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
        private double[] marks;

        public Student(string name, string address, string standard, string roll) : base(name, address) 
        {
            this.standard = standard;
            this.roll = roll;

        }
        
        public void GetMarks() 
        {
            for(int loopVar = 0; loopVar < 5; loopVar++)
            {
                Console.Write("Enter Marks for Subject-{0}: ", loopVar);
                
                marks[loopVar] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public string CalculateResult()
        {
            double totalMarksObtained = marks.Sum();
            double average = totalMarksObtained / 5;
            if (average < 40)
                return "Fail";
            else
                return "Pass";
        }

        public void DisplayResult()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\t\tMark Sheet");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Name: {0}\nClass: {1}\nRoll: {2}\nAddress: {3}", this.name, this.standard, this.roll, this.address);
            Console.WriteLine("Marks Obtained:");

            double average = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                average += marks[i];
                Console.WriteLine("Subject-{0}: {1}", i, marks[i]);
            }
            average /= 5;

            Console.WriteLine("Average Marks: {0}", average);
            Console.WriteLine("Final Grade: {0}", CalculateResult());
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
