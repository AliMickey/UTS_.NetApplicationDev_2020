using System;
namespace Week9Program1
{
    class Employee : IComparable<Employee>
    {
        // Properties of an Employee
        // Name (First and last name), ID#, hourly rate and total working hours per week
        string employeeFName, employeeSName;
        double hourlyRate, workHours;
        int employeeID;

        // Empolyee Constructor
        public Employee()
        {
            hourlyRate = 0.0;
            workHours = 0.0;
            employeeID = 0;
            employeeFName = "ABC";
            employeeSName = "XYZ";
        }

        // Method to recieve a single line from the emp.txt file as string
        // and extract individual fields from the line by spltting the line using ','
        public void LoadEmployee(string fileLine)
        {
            // Split the comma seperated string into fields 
            string[] fields = fileLine.Split(',');
                       
            // Assign values to respective properties/ members
            employeeFName = fields[0];
            employeeSName = fields[1];
            hourlyRate= Convert.ToDouble(fields[2]);
            employeeID = Convert.ToInt32(fields[3]);
            workHours = Convert.ToDouble(fields[4]);
        }

        // Method to calculate the weekly salary of an Employee
        public double GetWeeklySal()
        {
            return (hourlyRate * workHours);
        }

        // Overide the ToString() method to display the employee details
        public override string ToString()
        {
            return (this.employeeFName + " " + this.employeeSName+" ID#:" +this.employeeID.ToString()+" Weekly Income: " +this.GetWeeklySal().ToString()); 
        }

        // Implement the CompareTo method 
        public int CompareTo(Employee other)
        {
            if (employeeID < other.employeeID) return -1;
            else if (employeeID == other.employeeID) return 1;
            else return 0;
        }

    }
}
