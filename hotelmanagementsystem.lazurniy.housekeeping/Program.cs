using System;
using Gtk;

namespace hotelmanagementsystem.lazurniy.housekeeping
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();
			Application.Run();

		}
	}
}
