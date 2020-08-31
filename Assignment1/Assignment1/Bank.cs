using System;
using System.Linq;
using System.IO;

namespace Assignment1
{
	class Bank
	{
		public void MainMenu()
        {
			Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║  WELCOME TO SIMPLE BANKING SYSTEM  ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║     1. Create a new account        ║");
            Console.WriteLine("║     2. Search for an account       ║");
            Console.WriteLine("║     3. Deposit                     ║");
            Console.WriteLine("║     4. Withdraw                    ║");
            Console.WriteLine("║     5. A/C Statement               ║");
            Console.WriteLine("║     6. Delete Account              ║");
            Console.WriteLine("║     7. Exit                        ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            while (true)
            {
                try
                {
                    Console.Write("Enter your choice (1-7): ");
                    string inputChoice = Console.ReadLine();
                    if (Int32.TryParse(inputChoice, out _) && (Convert.ToInt32(inputChoice) > 0 && Convert.ToInt32(inputChoice) < 8))
                    {
                        switch (Convert.ToInt32(inputChoice))
                        {
                            case 1:
                                CreateAccount();
                                break;
                            case 2:
                                SearchAccount();
                                break;
                            case 3:
                                Deposit();
                                break;
                            case 4:
                                Withdraw();
                                break;
                            case 5:
                                Statement();
                                break;
                            case 6:
                                Delete();
                                break;
                            case 7:
                                Environment.Exit(1);
                                break;
                        }
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }
            }
        }

        public void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║        CREATE A NEW ACCOUNT        ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║         ENTER THE DETAILS          ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("First Name: ");
            string fName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Phone: ");
            string phoneTemp = Console.ReadLine();
            while (phoneTemp.Length > 10 || phoneTemp.Length < 1 || !phoneTemp.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Phone: ");
                phoneTemp = Console.ReadLine();
            }
            int phone = Convert.ToInt32(phoneTemp);

            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (!email.Contains('@') || !email.Contains("uts.edu.au"))
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Email: ");
                email = Console.ReadLine();
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Is the information correct? (y/n)");
                    string correctInput = Console.ReadLine();
                    if (correctInput.Length >= 1 && correctInput[0] == 'y')
                    {
                        int accNo = GenerateAccountNumber();
                        if (File.Exists(accNo + ".txt"))
                        {
                            File.Delete(accNo + ".txt");
                        }
                        string[] tempText = { "fName|" + fName, "lName|" + lName, "address|" + address, "phone|" + phone, "email|" + email };
                        File.WriteAllLines(accNo + ".txt", tempText);
                        Console.WriteLine("Account Created! Details will be provided by email.");
                        Console.WriteLine("Account Number is: {0}", accNo);
                        break;
                    }
                    else if (correctInput.Length >= 1 && correctInput[0] == 'n')
                    {
                        MainMenu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
            MainMenu();
        }

        public void SearchAccount()
        {
            Console.Clear();
        }

        public void Deposit()
        {
            Console.Clear();
        }

        public void Withdraw()
        {
            Console.Clear();
        }

        public void Statement()
        {
            Console.Clear();
        }

        public void Delete()
        {
            Console.Clear();
        }

        public int GenerateAccountNumber()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 99999999);
        }
	}
}
