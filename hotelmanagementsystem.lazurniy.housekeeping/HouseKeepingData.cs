using System;
using System.IO;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public static class HouseKeepingData
	{
		public static double towels;
		public static double sheets;
		public static double robes;

		private static string[] housekeepingInterval;

		static HouseKeepingData()
		{
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
			System.IO.File.WriteAllLines(HouseKeeping.path + "\\DaysOptions.txt", housekeepingInterval);
		}

		public static void LoadData()
		{
			var file = Directory.GetFiles(HouseKeeping.path, "DaysOptions.txt");
			if (file == null)
			{
				System.IO.File.WriteAllLines(HouseKeeping.path + "\\DaysOptions.txt", housekeepingInterval);
				towels = 0;
				sheets = 0;
				robes = 0;
			}
			else
			{
				housekeepingInterval = File.ReadAllLines(HouseKeeping.path + "\\DaysOptions.txt");
				towels = Double.Parse(housekeepingInterval[0]);
				sheets = Double.Parse(housekeepingInterval[1]);
				robes = Double.Parse(housekeepingInterval[2]);

			}
		}


	}
}
