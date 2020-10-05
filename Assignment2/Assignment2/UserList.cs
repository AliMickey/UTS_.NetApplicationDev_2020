using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Assignment2
{
	public class UserList
	{
		private List<User> users;

		public UserList()
		{
			users = new List<User>();
		}

		public void LoadUsers(string fileLocation)
		{
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

		public bool UserExists(string username, string password)
        {
			foreach (User user in users)
            {
				if ((user.GetUsername() == username) && (user.GetPassword() == password))
				{
					return true;
                }
            }
			return false;
		}

		public string UserType(string username)
		{
			foreach (User user in users)
			{
				if (user.GetUsername() == username)
				{
					return user.GetAccountType();
				}
			}
			return "";
		}

		public void NewUser(string username, string password, string type, string fName, string lName, string DOB)
        {
			User tempUser = new User();
			string tempLine = ("\n" + username + "," + password + "," + type + "," + fName + "," + lName + "," + DOB);

			tempUser.LoadUser(tempLine);
			users.Add(tempUser);
			using StreamWriter file = new StreamWriter("login.txt", true);
			file.WriteLine(tempLine);
		}
	}
}
