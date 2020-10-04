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
			User userTemp;

			while (!file.EndOfStream)
			{
				userTemp = new User();
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
	}
}
