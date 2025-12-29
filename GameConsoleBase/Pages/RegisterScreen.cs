using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
	internal class RegisterScreen : Screen
	{
		public RegisterScreen() : base("Register Page")
		{
		}
		public override void Show()
		{
			base.Show();
			Console.ReadKey();
			Console.Clear();
		}
	}
}
