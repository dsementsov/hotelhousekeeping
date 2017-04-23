using System;
using Gtk;
using System.IO;
using System.Runtime.Remoting.Messaging;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public class HouseKeeping
	{
		public static string path;
		public static string sourcePath;


		public HouseKeeping()
		{
			path = System.IO.Directory.GetCurrentDirectory();

		}

		public void Calculate() 
		{ 
		
		}

		public static void Reveal()
		{
			HouseKeeping hk = new HouseKeeping();
			hk.Calculate();

		}
	
	}

}
