using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment2
{
	public class UserList
	{
		public static List<User> users;

		public UserList()
		{
			users = new List<User>();
		}

		public void LoadUsers(string fileLocation)
		{
			if (File.Exists(fileLocation))
			{
				users.Clear();
				StreamReader file = new StreamReader(fileLocation);
				while (!file.EndOfStream)
				{
					User userTemp = new User();
					string line = file.ReadLine();
					userTemp.LoadUser(line);
					users.Add(userTemp);
				}
				file.Close();
			}

			else
			{
				var newFile = File.Create(fileLocation);
				newFile.Close();
			}
		}

		public void SaveUsers() 
        {
			// Clear out file.
			File.WriteAllText("login.txt", String.Empty);
			// Add all users back into file.
            using StreamWriter file = new StreamWriter("login.txt");
            foreach (User user in users)
            {
                file.WriteLine(user.ToString());
            }

        }

		public bool UserExists(string username, string password)
		{
			// Check if user exists with password in list.
			foreach (User user in users)
			{
				if ((user.Username == username) && (user.Password == password))
				{
					return true;
				}
			}
			return false;
		}

		public bool UserNameExists(string username)
        {
			// Check if username exists.
			foreach (User user in users)
			{
				if ((user.Username == username))
				{
					return true;
				}
			}
			return false;
		}

		public string UserType(string username)
		{
			// Get account type.
			foreach (User user in users)
			{
				if (user.Username == username)
				{
					return user.AccountType;
				}
			}
			return "";
		}

		public void NewUser(string username, string password, string type, string fName, string lName, string DOB)
		{
			User tempUser = new User();
			string tempLine = (username + "," + password + "," + type + "," + fName + "," + lName + "," + DOB);
			tempUser.LoadUser(tempLine);
			users.Add(tempUser);
			SaveUsers();
		}
	}
}