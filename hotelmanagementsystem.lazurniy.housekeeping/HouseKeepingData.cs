using System;
using System.IO;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public static class HouseKeepingData
	{
		public static DateTime dateNow;

		public static double towels;
		public static double sheets;
		public static double robes;

		public static string path;
		public static string sourcePath;
        public static string csvSourcePath;
        public static string convertingScriptPath;

		private static string[] housekeepingInterval;

		static HouseKeepingData()
		{
            sourcePath = System.IO.Directory.GetCurrentDirectory();
            convertingScriptPath = System.IO.Directory.GetCurrentDirectory() + "/XLTOCSV.vbs";
            dateNow = DateTime.Now.Date.AddHours(15.0);
            csvSourcePath = System.IO.Directory.GetCurrentDirectory() + "/residents.csv";
			path = System.IO.Directory.GetCurrentDirectory();
			housekeepingInterval = new string[3];
			Array.Clear(housekeepingInterval, 0, housekeepingInterval.Length);
			LoadData();
		}

		private static void Convert()
		{
			housekeepingInterval[0] = towels.ToString();
			housekeepingInterval[1] = sheets.ToString();
			housekeepingInterval[2] = robes.ToString();
		}

		public static void SaveData()
		{ 
			Convert();
			File.WriteAllLines(HouseKeepingData.path + "\\DaysOptions.txt", housekeepingInterval);

		}

		public static void LoadData()
		{ //works
			string file = HouseKeepingData.path + "\\DaysOptions.txt";
			if (!File.Exists(file)) 
			{
				//Console.Error.Write("file is not found");
				towels = 1;
				sheets = 1;
				robes = 1;
				Convert();
				System.IO.File.WriteAllLines(HouseKeepingData.path + "\\DaysOptions.txt", housekeepingInterval);

			}
			else
			{
				housekeepingInterval = File.ReadAllLines(HouseKeepingData.path + "\\DaysOptions.txt");
				towels = Double.Parse(housekeepingInterval[0]);
				sheets = Double.Parse(housekeepingInterval[1]);
				robes = Double.Parse(housekeepingInterval[2]);

			}
		}


	}
}
