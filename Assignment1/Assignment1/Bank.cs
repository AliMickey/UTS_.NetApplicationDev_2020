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


            if (YNChoice("Is the information correct? (y/n)"))
            {
                int accNo = GenerateAccountNumber();
                if (File.Exists("accounts/" + accNo + ".txt"))
                {
                    accNo = GenerateAccountNumber();
                }
                string[] tempText = { "fName|" + fName, "lName|" + lName, "address|" + address, "phone|" + phone, "email|" + email, "accountNo|" + accNo };
                File.WriteAllLines("accounts/" + accNo + ".txt", tempText);
                Console.WriteLine("Account Created! Details will be provided by email.");
                Console.WriteLine("Account Number is: {0}", accNo);
            }
            else
            {
                MainMenu();
            }

            Console.ReadKey();
            MainMenu();
        }

        public void SearchAccount()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          SEARCH AN ACCOUNT         ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║         ENTER THE DETAILS          ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            while (true)
            {
                try
                {
                    Console.Write("Account Number: ");
                    string number = Console.ReadLine();
                    if (Int32.TryParse(number, out _) && (number.Length > 0 && number.Length < 11))
                    {
                        int accountNumber = Convert.ToInt32(number);
                        string[] accounts = Directory.GetFiles("accounts");
                        foreach (string i in accounts) {
                            string currentAccount = "accounts\\" + number + ".txt";
                            if (i == currentAccount)
                            {
                                string[] accountFile = File.ReadAllLines(currentAccount);
                                string balance = "0";
                                for (int j = 0; j < accountFile.Count(); j++)
                                {
                                    accountFile[j] = accountFile[j].Substring(accountFile[j].IndexOf(@"|") + 1);

                                    if ("balance".Contains(accountFile[j]))
                                    {
                                        balance = accountFile[6];
                                    }
                                }
                                Console.WriteLine(" ");
                                Console.WriteLine("Account found!");
                                Console.WriteLine("╔════════════════════════════════════╗");
                                Console.WriteLine("║          ACCOUNT DETAILS           ║");
                                Console.WriteLine("╚════════════════════════════════════╝");
                                Console.WriteLine("Account No: {0}", accountFile[5]);
                                Console.WriteLine("Account Balance: ${0}", balance); 
                                Console.WriteLine("First Name: {0}", accountFile[0]);
                                Console.WriteLine("Last Name: {0}", accountFile[1]);
                                Console.WriteLine("Address: {0}", accountFile[2]);
                                Console.WriteLine("Phone: {0}", accountFile[3]);
                                Console.WriteLine("Email: {0}", accountFile[4]);
                                Console.WriteLine(" ");
                                if (YNChoice("Check another account (y/n)?"))
                                {
                                    SearchAccount();
                                }
                                else
                                {
                                    MainMenu();
                                }
                            }                      
                        }
                        Console.WriteLine("Account not found!");
                        if (YNChoice("Check another account (y/n)?"))
                        {
                            SearchAccount();
                        }
                        else
                        {
                            MainMenu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
                        
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

        public bool YNChoice(string question)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);
                    string correctInput = Console.ReadLine();
                    if (correctInput.Length >= 1 && correctInput[0] == 'y')
                    {
                        return true;
                    }
                    else if (correctInput.Length >= 1 && correctInput[0] == 'n')
                    {
                        return false;
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
    }
}
