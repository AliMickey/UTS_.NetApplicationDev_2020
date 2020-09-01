using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Net.Mail;

namespace Assignment1
{
    class Bank
    {
        public void LoginInit()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║  WELCOME TO SIMPLE BANKING SYSTEM  ║");
            Console.WriteLine("║════════════════════════════════════║");
            Console.WriteLine("║          LOGIN TO START            ║");
            Console.WriteLine("║                                    ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Login();
        }

        public void Login()
        {
            try
            {
                string[] userID = File.ReadAllLines("login.txt");
                Boolean valid = false;
                Bank bank = new Bank();
                String userName;
                String password;
                while (valid == false)
                {
                    Console.Write("USER NAME: ");
                    userName = Console.ReadLine();
                    Console.Write("PASSWORD: ");
                    password = null;
                    //Mask password characters.
                    while (true)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            break;
                        }
                        //Backspace removes the '*' and removes last character from password.
                        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                        {
                            Console.Write("\b \b");
                            password = password.Substring(0, password.Length - 1);
                        }
                        else if (key.Key != ConsoleKey.Backspace)
                        {
                            password += key.KeyChar;
                            Console.Write("*");
                        }
                    }
                    //Go through each entry and check for validity.
                    foreach (string i in userID)
                    {
                        string[] tempID = i.Split('|');
                        if (userName == tempID[0] && password == tempID[1])
                        {
                            Console.WriteLine("Valid credentials!.. Please enter.");
                            valid = true;
                            Console.ReadKey();
                            MainMenu();
                            break;
                        }
                    }
                    Console.WriteLine("Invalid credentials!.. Please try again\n");
                    //Append new credentials to file and return to login menu.
                    if (bank.YNChoice("Username: " + userName + ", Password: " + password + "\nCreate a new user using supplied information (y/n)?"))
                    {
                        using StreamWriter file = new StreamWriter("login.txt", true);
                        file.WriteLine(userName + "|" + password);
                        Console.WriteLine("Account created...");
                        Console.ReadKey();
                    }
                    LoginInit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }

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

            //Switch command to take user input, validate it and then call the appropiate method.
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
                                LoginInit();
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

            //Validation to check if length constraints and whether it is an integer.
            Console.Write("Phone: ");
            string phoneTemp = Console.ReadLine();
            while (phoneTemp.Length > 10 || phoneTemp.Length < 1 || !phoneTemp.All(char.IsDigit))
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Phone: ");
                phoneTemp = Console.ReadLine();
            }
            int phone = Convert.ToInt32(phoneTemp);

            //Check if the '@' symbol exists, also check if the uts domain is in email.
            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (!email.Contains('@')) /*|| !email.Contains("uts.edu.au"))*/
            {
                Console.WriteLine("Invalid input, try again.");
                Console.Write("Email: ");
                email = Console.ReadLine();
            }

            if (YNChoice("Is the information correct? (y/n)"))
            {
                //Add provided information to file with '|' as delimiter in a set format and order.
                int accNo = GenerateAccountNumber();
                string[] tempText = { "fName|" + fName, "lName|" + lName, "address|" + address, "phone|" + phone, "email|" + email, "accountNo|" + accNo, "balance|0" };
                File.WriteAllLines("accounts/" + accNo + ".txt", tempText);
                Console.WriteLine();
                Console.WriteLine("Account Created! Details will be provided by email.");
                Console.WriteLine("Account Number is: {0}", accNo);
                Console.WriteLine("Please wait, sending email...");
                SendEmail(email, GetAccount("accounts/" + accNo + ".txt"));
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
                        string currentAccount = GetAccountLocation(number);
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
                        string currentAccount = GetAccountLocation(number);
                        if (currentAccount != "Null")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Account found!");
                            Console.Write("Enter the amount: ");
                            string amountTemp = Console.ReadLine();
                            while (!amountTemp.All(char.IsDigit))
                            {
                                Console.WriteLine("Invalid input, try again.");
                                Console.Write("Enter the amount: ");
                                amountTemp = Console.ReadLine();
                            }
                            //Replace the balance line in the account file with the updated balance information. 
                            //Add a log into account file.
                            int amount = Convert.ToInt32(amountTemp);
                            int balance = BalanceUpdate(currentAccount, amount, true);
                            ReplaceLine("balance|" + balance, currentAccount, 6);
                            WriteToAccountFile(currentAccount, "Deposit", amount, balance);
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
                        string currentAccount = GetAccountLocation(number);
                        if (currentAccount != "Null")
                        {
                            Console.WriteLine();
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
                            int balance = BalanceUpdate(currentAccount, amount, false);
                            if (balance == -1)
                            {
                                Console.WriteLine("You do not have sufficient funds.");
                                Console.ReadKey();
                                Withdraw();
                            }
                            else
                            {
                                //Replace the balance line in the account file with the updated balance information. 
                                //Add a log into account file.
                                ReplaceLine("balance|" + balance, currentAccount, 6);
                                WriteToAccountFile(currentAccount, "Withdraw", amount, balance);
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
            while (true)
            {
                try
                {
                    Console.Write("Account Number: ");
                    string number = Console.ReadLine();
                    if (Int32.TryParse(number, out _) && (number.Length > 0 && number.Length < 11))
                    {
                        string currentAccount = GetAccountLocation(number);
                        if (currentAccount != "Null")
                        {
                            string[] accountDetails = GetAccount(currentAccount);
                            DisplayAccount(currentAccount);
                            //If transaction history exists display last 5 transactions.
                            if (accountDetails.Count() > 7)
                            {
                                Console.WriteLine("Last 5 Transactions:");
                                Console.WriteLine("Date - Type - Amount - Balance");
                                for (int i = accountDetails.Count() - 1; i > accountDetails.Count() - 6; i--)
                                {
                                    Console.WriteLine(accountDetails[i]);
                                }
                            }
                            Console.WriteLine();
                            if (YNChoice("Email Statement (y/n)?"))
                            {
                                Console.WriteLine("Please wait, sending email...");
                                SendEmail(GetAccount(currentAccount)[4], accountDetails);
                                Console.ReadKey();
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
                            Statement();
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
                        string currentAccount = GetAccountLocation(number);
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
            //Generate a unique random number that isn't already used by an account.
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
            //Take a string as an argument and provide the user a y/n option.
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
        public void ReplaceLine(string text, string file, int lineNumber)
        {
            //Replace the line with provided arguments.
            string[] tempArray = File.ReadAllLines(file);
            List<string> tempList = tempArray.ToList();
            tempList.RemoveAt(lineNumber);
            tempArray[lineNumber] = text;
            File.WriteAllLines(file, tempArray);
        }

        public int BalanceUpdate(string account, int amount, bool deposit)
        {
            //Either add or subtract the balance from provided amount based on boolean.
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

        public string GetAccountLocation(string accNo)
        {
            //Get the account dir location.
            string[] accounts = Directory.GetFiles("accounts");
            foreach (string i in accounts)
            {
                if (i == "accounts\\" + accNo + ".txt")
                {
                    return i;
                }
            }
            return ("Null");
        }

        public void DisplayAccount(string accNo)
        {
            //Display the account details from a file location.
            string[] accountFile = File.ReadAllLines(accNo);
            for (int j = 0; j < accountFile.Count(); j++)
            {
                accountFile[j] = accountFile[j].Substring(accountFile[j].IndexOf(@"|") + 1);
            }
            Console.WriteLine();
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
            Console.WriteLine();
        }

        public string[] GetAccount(string accLocation)
        {
            string[] accountFile = File.ReadAllLines(accLocation);
            for (int j = 0; j < accountFile.Count(); j++)
            {
                accountFile[j] = accountFile[j].Substring(accountFile[j].IndexOf(@"|") + 1);
            }
            return accountFile;
        }

        public void WriteToAccountFile(string accNo, string type, int amount, int balance)
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            using StreamWriter file = new StreamWriter(accNo, true);
            file.WriteLine("{0} - {1} - {2} - {3}", date, type, amount, balance);
        }

        public void SendEmail(string address, string[] details)
        {
            try
            {
                string password = "utsnetprogtemp";
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("utsnetprog@gmail.com");
                mail.To.Add(address);
                mail.Subject = "Account Details";
                mail.Body = "Please find following details for your new bank account. \n\n Account Number: " + details[5] + "\n First Name: " + details[0] + "\n Last Name: " + details[1] + "\n Address: " + details[2] + "\n Phone: " + details[3] + "\n Email: " + details[4] + "\n Balance: $" + details[6];
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("utsnetprog@gmail.com", password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Console.WriteLine("Sent!");
            }
            catch (SmtpException e)
            {
                Console.WriteLine("Mail send error, try again later.");
                Console.WriteLine(e);

            }
        }
    }
}
