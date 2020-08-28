using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String userName;
            //String password;
            //Console.WriteLine("╔════════════════════════════════════╗");
            //Console.WriteLine("║  WELCOME TO SIMPLE BANKING SYSTEM  ║");
            //Console.WriteLine("║════════════════════════════════════║");
            //Console.WriteLine("║          LOGIN TO START            ║");
            //Console.WriteLine("║                                    ║");
            //Console.Write("║   USER NAME: ");
            //userName = Console.ReadLine();
            //Console.WriteLine("║                                    ║");
            //Console.Write("║   PASSWORD: ");
            //password =  Console.ReadLine();
            //Console.WriteLine("║                                    ║");
            //Console.WriteLine("╚════════════════════════════════════╝");

            try
            {

                string[] userID = File.ReadAllLines("login.txt");
                Boolean valid = false;
                String userName;
                String password;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║  WELCOME TO SIMPLE BANKING SYSTEM  ║");
                Console.WriteLine("║════════════════════════════════════║");
                Console.WriteLine("║          LOGIN TO START            ║");
                Console.WriteLine("║                                    ║");
                Console.WriteLine("║                                    ║");
                Console.WriteLine("║                                    ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                while (valid == false)
                {
                    Console.Write("USER NAME: ");
                    userName = Console.ReadLine();
                    Console.Write("PASSWORD: ");
                    password = Console.ReadLine();
                
                    foreach (string i in userID)
                    {
                        string[] tempID = i.Split('|');
                        if (userName == tempID[0] && password == tempID[1])
                        {
                            Console.WriteLine("Valid credentials!.. Please enter.");
                            valid = true;
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid credentials!.. Please try again.");
                            break;
                        }
                    }
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
