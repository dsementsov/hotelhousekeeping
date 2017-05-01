﻿using System;
using System.IO;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public static class HouseKeepingData
	{
		public static double towels;
		public static double sheets;
		public static double robes;

		public static string path;
		public static string sourcePath;

		private static string[] housekeepingInterval;

		static HouseKeepingData()
		{
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
			System.IO.File.WriteAllLines(HouseKeepingData.path + "\\DaysOptions.txt", housekeepingInterval);
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
				//Console.Error.Write("file found");
				housekeepingInterval = File.ReadAllLines(HouseKeepingData.path + "\\DaysOptions.txt");
				towels = Double.Parse(housekeepingInterval[0]);
				sheets = Double.Parse(housekeepingInterval[1]);
				robes = Double.Parse(housekeepingInterval[2]);
				//Console.Error.WriteLine("towels = {0}, sheets = {1}, robes = {2}, array = {3} {4} {5}", towels, sheets, robes, housekeepingInterval[0], housekeepingInterval[1], housekeepingInterval[2]);

			}
		}


	}
}
