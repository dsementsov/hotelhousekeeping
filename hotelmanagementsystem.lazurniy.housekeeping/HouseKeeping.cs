using System;
using Gtk;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public class HouseKeeping
	{
		List<int> towelsNeeded = new List<int>();
		List<int> robesNeeded = new List<int>();
		List<int> sheetsNeeded = new List<int>();
		List<int> generalNeded = new List<int>();

		public Dictionary<string, string> sortedLaundry = new Dictionary<string, string>();

		public HouseKeeping()
		{
			Calculate();
			Sort();
		}

		public void Calculate() 
		{
			foreach (KeyValuePair<int, roomData> entry in ImportedData.rooms)
			{
				//TimeSpan daysPassed = CalculateElapsedDays(entry.Value.checkInDate, HouseKeepingData.dateNow);
				int totalDaysPassed = (HouseKeepingData.dateNow - entry.Value.checkInDate).Days;
				if (HouseKeepingData.dateNow.Date == entry.Value.checkOutDate.Date)
				{ 
					generalNeded.Add(entry.Value.roomNo);
					continue;
				}
				if ((totalDaysPassed % (int)HouseKeepingData.robes) == 0)
				{ 
					robesNeeded.Add(entry.Value.roomNo);
				}
				if ((totalDaysPassed % (int)HouseKeepingData.sheets) == 0)
				{ 
					sheetsNeeded.Add(entry.Value.roomNo);
				}
				if ((totalDaysPassed % (int)HouseKeepingData.towels) == 0)
				{ 
					towelsNeeded.Add(entry.Value.roomNo);
				}
					
			}
		}

		public void Sort()
		{
			sortedLaundry.Add(SortedLaundryKeys.adminTowels, string.Join(", ", towelsNeeded));
			sortedLaundry.Add(SortedLaundryKeys.adminRobes, string.Join(", ", robesNeeded));
			sortedLaundry.Add(SortedLaundryKeys.adminSheets, string.Join(", ", sheetsNeeded));
			sortedLaundry.Add(SortedLaundryKeys.adminGenerals, string.Join(", ", generalNeded));

			sortedLaundry.Add(SortedLaundryKeys.towelsSecond, string.Join(", ", towelsNeeded.Where(s=> s/10 == 2).ToList() ));
			sortedLaundry.Add(SortedLaundryKeys.towelsThird, string.Join(", ", towelsNeeded.Where(s => s / 10 == 3).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.towelsFourth, string.Join(", ", towelsNeeded.Where(s => s/10 == 4).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.towelsFifth, string.Join(", ", towelsNeeded.Where(s => s/10 == 5).ToList()));

			sortedLaundry.Add(SortedLaundryKeys.robesSecond, string.Join(", ", robesNeeded.Where(s => s/10 == 2).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.robesThird, string.Join(", ", robesNeeded.Where(s => s/10 == 3).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.robesFourth, string.Join(", ", robesNeeded.Where(s => s/10 == 4).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.robesFifth, string.Join(", ", robesNeeded.Where(s => s/10 == 5).ToList()));

			sortedLaundry.Add(SortedLaundryKeys.sheetsSecond, string.Join(", ", sheetsNeeded.Where(s => s/10 == 2).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.sheetsThird, string.Join(", ", sheetsNeeded.Where(s => s/10 == 3).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.sheetsFourth, string.Join(", ", sheetsNeeded.Where(s => s/10 == 4).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.sheetsFifth, string.Join(", ", sheetsNeeded.Where(s => s/10 == 5).ToList()));

			sortedLaundry.Add(SortedLaundryKeys.generalsSecond, string.Join(", ", generalNeded.Where(s => s/10 == 2).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.generalsThird, string.Join(", ", generalNeded.Where(s => s/10 == 3).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.generalsFourth, string.Join(", ", generalNeded.Where(s => s/10 == 4).ToList()));
			sortedLaundry.Add(SortedLaundryKeys.generalsFifth, string.Join(", ", generalNeded.Where(s => s/10 == 5).ToList()));

			sortedLaundry.Add(SortedLaundryKeys.towelsAmount, (towelsNeeded.Count + generalNeded.Count).ToString());
			sortedLaundry.Add(SortedLaundryKeys.robesAmount, (robesNeeded.Count + generalNeded.Count).ToString());
			sortedLaundry.Add(SortedLaundryKeys.sheetsAmount, (sheetsNeeded.Count + generalNeded.Count).ToString());
		}
	}

}
