using System;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
/*
The given text file contains 5 set of user IDs and Password. 
The file stores userID and password in the following format:
<User>, <password>
Hello, abc1234
Admin, admin,
User, user
Write a program to read a given text file and print the data about the user Id and password. 
Write appropriate exception handling code to handle exceptions which might occur while reading the text file.  
*/


namespace Week6LabProgram
{
    class Program2
    {
        static void Main(string[] args)
        {
            try
            {
                string[] file = File.ReadAllLines("userIdDB.txt");
                foreach (string i in file)
                {
                    string[] temp = i.Split(',');
                    Console.WriteLine("User Name: {0}, Password: {1}", temp[0], temp[1]);
                }
                Console.ReadKey();   
            }

            catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }

        }
    }
}

/*
Test Case:
Expeted Output: 

UserName: admin, Password: admin
UserName: normaluser, Password: user
UserName: Adam, Password: hello
UserName: George, Password: yessir
UserName: hacker, Password: nohack

    */