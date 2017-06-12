using System;
using System.Collections.Generic;
using Gtk;
using System.IO;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;


namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public class LoadFromCSVFile
	{
        public string pathToCSV = HouseKeepingData.csvSourcePath;


		public void LoadGUestData()
		{
            ImportedData.rooms.Clear();
			var lineCounter = 0;
			var roomNo = 0;
			string[] s;
			StreamReader importFile;
			if (File.Exists(pathToCSV))
			{
				ImportedData.rooms.Clear();
				importFile = File.OpenText(pathToCSV);
				string dateFormat = "dd.MM.yy HH:mm";
				while (!importFile.EndOfStream)
				{
					try
					{
						s = new string[10];
                        int roomIndex, inIndex, outIndex;
                        roomIndex = 6;
                        inIndex = 2;
                        outIndex = 3;
                        s = importFile.ReadLine().Split(new Char[] { ';', ','} );
                        var validLineStartCheck = s[0];
                        if (!Int32.TryParse(validLineStartCheck.Substring(0,1), out int b))
                        {
                            roomIndex = 5;
                            inIndex = 1;
                            outIndex = 2;
                        }
                        if (s.Length <= roomIndex)
                            continue;
                        if (Int32.TryParse(s[roomIndex], out roomNo))
						{
							ImportedData.rooms.Add(lineCounter, new roomData(roomNo,
                                                                             DateTime.ParseExact(s[inIndex], dateFormat, null),
                                                                             DateTime.ParseExact(s[outIndex], dateFormat, null)));

						}
					}
					catch (NullReferenceException e)
					{
						MessageDialogue md = new MessageDialogue("Указан файл неправильного формата!" + e.ToString(), MessageType.Error);
					}
                    catch (IndexOutOfRangeException e)
                    {
                        MessageDialogue md = new MessageDialogue("oops" + e.ToString(), MessageType.Error);
                    }
					lineCounter++;
				}
				importFile.Close();
			}
			else
			{
				MessageDialogue md = new MessageDialogue("File doesnt exist!", MessageType.Error);
			}
		}

		//public void FilterGuestDate()
		//{
		//	// takes imported data and removes every guest that already checkedOut or havent checked in yet
		//	foreach (KeyValuePair<int, roomData> entry in ImportedData.rooms)
		//	{
		//		if (DateTime.Compare(entry.Value.checkInDate, HouseKeepingData.dateNow) > 0 )
		//		{ 
		//			ImportedData.rooms.Remove(entry.Key);
		//		}
		//		if (DateTime.Compare(entry.Value.checkOutDate, HouseKeepingData.dateNow) < 0)
		//		{ 
		//			ImportedData.rooms.Remove(entry.Key);
		//		}
		//	}
		//}
	}

	public struct roomData
	{
		public int roomNo;
		public DateTime checkInDate;
		public DateTime checkOutDate;

		public roomData(int roomNo, DateTime checkIn, DateTime checkOut)
		{
			this.roomNo = roomNo;
			this.checkInDate = checkIn;
			this.checkOutDate = checkOut;
		}

	}

	public static class ImportedData
	{
		// int here is a booking number/any suitable for a Key number (e.g no of a row in excel file)
		public static Dictionary<int, roomData> rooms = new Dictionary<int, roomData>();
	}

}
