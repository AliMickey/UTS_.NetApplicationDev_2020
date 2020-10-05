using System;

namespace Assignment2
{
	public class User
	{
		private string username, password, type, fName, lName, dateOfBirth;

		public User()
		{
			username = "";
			password = "";
			type = "";
			fName = "";
			lName = "";
			dateOfBirth = "";
		}

		public void LoadUser(string fileLine)
		{
			string[] lines = fileLine.Split(',');
			username = lines[0];
			password = lines[1];
			type = lines[2];
			fName = lines[3];
			lName = lines[4];
			dateOfBirth = lines[5];
		}

		public string Username => username;
        public string Password => password;
        public string AccountType => type;
    }
}