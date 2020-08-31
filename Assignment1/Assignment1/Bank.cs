using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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
                string[] tempText = { "fName|" + fName, "lName|" + lName, "address|" + address, "phone|" + phone, "email|" + email, "accountNo|" + accNo, "balance|0" };
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
                        string currentAccount = GetAccount(number);
                        if (currentAccount != "Null")
                        {
                            DisplayAccount(currentAccount);
                            if (YNChoice("Check another account (y/n)?"))
                            {
                                SearchAccount();
                            }
                            else
                            {
                                MainMenu();
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
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║               DEPOSIT              ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║          ENTER THE DETAILS         ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            while (true)
            {
                try
                {
                    Console.Write("Account Number: ");
                    string number = Console.ReadLine();
                    if (Int32.TryParse(number, out _) && (number.Length > 0 && number.Length < 11))
                    {
                        string currentAccount = GetAccount(number);
                        if (currentAccount != "Null")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Account found!");
                            Console.Write("Enter the amount: ");
                            string amountTemp = Console.ReadLine();
                            while (!amountTemp.All(char.IsDigit))
                            {
                                Console.WriteLine("Invalid input, try again.");
                                Console.Write("Enter the amount: ");
                                amountTemp = Console.ReadLine();
                            }
                            int amount = Convert.ToInt32(amountTemp);
                            replaceLine("balance|" + BalanceUpdate(currentAccount, amount, true), currentAccount, 6);
                            Console.WriteLine("Deposit Successful!");
                            Console.ReadKey();
                            MainMenu();
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

        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║              WITHDRAW              ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║          ENTER THE DETAILS         ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            while (true)
            {
                try
                {
                    Console.Write("Account Number: ");
                    string number = Console.ReadLine();
                    if (Int32.TryParse(number, out _) && (number.Length > 0 && number.Length < 11))
                    {
                        string currentAccount = GetAccount(number);
                        if (currentAccount != "Null")
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Account found!");
                            Console.Write("Enter the amount: ");
                            string amountTemp = Console.ReadLine();
                            while (!amountTemp.All(char.IsDigit))
                            {
                                Console.WriteLine("Invalid input, try again.");
                                Console.Write("Enter the amount: ");
                                amountTemp = Console.ReadLine();
                            }
                            int amount = Convert.ToInt32(amountTemp);
                            int tempBalance = BalanceUpdate(currentAccount, amount, false);
                            if (tempBalance == -1)
                            {
                                Console.WriteLine("You do not have sufficient funds.");
                                Console.ReadKey();
                                Withdraw();
                            }
                            else
                            {
                                replaceLine("balance|" + tempBalance, currentAccount, 6);
                                Console.WriteLine("Withdraw Successful!");
                                Console.ReadKey();
                                MainMenu();
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

        public void Statement()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║             STATEMENT              ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║         ENTER THE DETAILS          ║");
            Console.WriteLine("╚════════════════════════════════════╝");

        }

        public void Delete()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          DELETE AN ACCOUNT         ║");
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
                        string currentAccount = GetAccount(number);
                        if (currentAccount != "Null")
                        {
                            DisplayAccount(currentAccount);
                            if (YNChoice("Delete (y/n)?"))
                            {
                                File.Delete(currentAccount);
                                MainMenu();
                            }
                            else
                            {
                                MainMenu();
                            }
                        }
                        Console.WriteLine("Account not found!");
                        if (YNChoice("Check another account (y/n)?"))
                        {
                            Delete();
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

        public int GenerateAccountNumber()
        {
            Random rnd = new Random();
            int number = rnd.Next(100000, 99999999);
            string[] accounts = Directory.GetFiles("accounts");
            foreach (string i in accounts)
            {
                if (i == "accounts\\" + number + ".txt")
                {
                    GenerateAccountNumber();
                }
            }
            return number;
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
        public void replaceLine(string text, string file, int lineNumber)
        {
            string[] tempArray = File.ReadAllLines(file);
            List<string> tempList = tempArray.ToList();
            tempList.RemoveAt(lineNumber);
            tempArray[lineNumber] = text;
            File.WriteAllLines(file, tempArray);
        }

        public int BalanceUpdate(string account, int amount, bool deposit)
        {
            string balanceLine = File.ReadLines(account).Skip(6).Take(1).First();
            balanceLine = balanceLine.Substring(balanceLine.IndexOf(@"|") + 1);
            int balance = Convert.ToInt32(balanceLine);
            if (deposit)
            {
                return balance += amount;
            }
            else
            {
                if (balance - amount < 0)
                {
                    return -1;
                }
                else
                {
                    return balance -= amount;
                }
            }
        }

        public string GetAccount(string accNo)
        {
            string[] accounts = Directory.GetFiles("accounts");
            foreach (string i in accounts)
            {
                if (i == "accounts\\" + accNo + ".txt")
                {
                    return i;
                }
                else
                {
                    return ("Null");
                }
            }
            return ("Null");
        }

        public void DisplayAccount(string accNo)
        {
            string[] accountFile = File.ReadAllLines(accNo);
            for (int j = 0; j < accountFile.Count(); j++)
            {
                accountFile[j] = accountFile[j].Substring(accountFile[j].IndexOf(@"|") + 1);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Account found!");
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║          ACCOUNT DETAILS           ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.WriteLine("Account No: {0}", accountFile[5]);
            Console.WriteLine("Account Balance: ${0}", accountFile[6]);
            Console.WriteLine("First Name: {0}", accountFile[0]);
            Console.WriteLine("Last Name: {0}", accountFile[1]);
            Console.WriteLine("Address: {0}", accountFile[2]);
            Console.WriteLine("Phone: {0}", accountFile[3]);
            Console.WriteLine("Email: {0}", accountFile[4]);
            Console.WriteLine(" ");
        }
    }
}
