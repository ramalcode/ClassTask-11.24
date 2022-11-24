using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.NewFolder
{
    internal class User
    {
		private Product[] _product;
		private string _username;

		public string Username
		{
			get => _username; 
			set 
			{
				if (value.Trim().Length>=6 && value.Trim().Length <= 25)

				{
					_username = value.Trim();

				}
				
			}
		}

		private string _password;

		public string Password
		{
			get => _password; 
			set 
			{
				if (value.Trim().Length >= 8 && value.Trim().Length <= 25 && CheckDigit(value) && CheckLower(value) && CheckUpper(value))
				{
					_password = value.Trim(); 

				}
				
			}
		}

		private bool _isSignedIn;

		public bool IsSignedIn
		{
			get =>_isSignedIn; 
			set 
			{ 
				_isSignedIn = value;
			}
		}


		public bool CheckDigit(string password)
		{
			for (int i = 0; i < password.Length; i++)
			{
				var result= Char.IsDigit(password[i]);

				if (result)
				{
					return true;
				}
				else
				{
					Console.WriteLine("wrong input");
				}
			} return false;


		}
		public bool CheckLower( string password)
		{
			for (int i = 0; i < password.Length; i++)
			{
				var result = Char.IsLower(password[i]);

				if (result)
				{
					return true;
				}
				else
				{
					Console.WriteLine("Wrong input");
				}
			} return false;
		}

		public bool CheckUpper(string password)
		{
			for (int i = 0; i < password.Length; i++)
			{
				var result =Char.IsUpper(password[i]);

				if (result)
				{
					return true;

				}
				else
				{
					
				}
			} return false;
		}

		public void Login()
		{
			Username = Console.ReadLine();
			Password = Console.ReadLine();
		}

		public void Add()
		{
			if (Username!=null  && Password!=null)
			{

			}

			else
			{
				Login();
			}
		}


	}
}
