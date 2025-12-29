using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}
		public override void Show()
		{
			base.Show();
			Console.ReadKey();
			Console.Clear();
			Screen next = new GameMenuScreen();
			next.Show();
		}
	}
}
