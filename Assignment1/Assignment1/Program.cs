using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/AliMickey/UTS_.NetApplicationDev_Spring_2020/commits/master

            try
            {

                string[] userID = File.ReadAllLines("login.txt");
                Boolean valid = false;
                Bank bank = new Bank();
                String userName;
                String password;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║  WELCOME TO SIMPLE BANKING SYSTEM  ║");
                Console.WriteLine("║════════════════════════════════════║");
                Console.WriteLine("║          LOGIN TO START            ║");
                Console.WriteLine("║                                    ║");
                Console.WriteLine("║                                    ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                while (valid == false)
                {
                    Console.Write("USER NAME: ");
                    userName = Console.ReadLine();
                    Console.Write("PASSWORD: ");
                    password = null;
                    while (true)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            break;
                        }
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    foreach (string i in userID)
                    {
                        string[] tempID = i.Split('|');
                        if (userName == tempID[0] && password == tempID[1])
                        {
                            Console.WriteLine("Valid credentials!.. Please enter.");
                            valid = true;
                            Console.ReadKey();
                            bank.MainMenu();
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

            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
