using System;
using Gtk;
using hotelmanagementsystem.lazurniy.housekeeping;

public partial class MainWindow : Gtk.Window
{

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
		spinSheets.Value = HouseKeepingData.sheets;
        spinRobes.Value = HouseKeepingData.robes;
        spinTowels.Value = HouseKeepingData.towels;
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnDoneClicked(object sender, EventArgs e)
	{
		if (HouseKeepingData.sourcePath.EndsWith(".csv",StringComparison.OrdinalIgnoreCase))
		{
			LoadFromCSVFile loadFromFile = new LoadFromCSVFile();
			HouseKeeping hk = new HouseKeeping();
//System.Diagnostics.Process.Start(System.IO.Directory.GetCurrentDirectory() + "/XLTOCSV.vbs",
//                               HouseKeepingData.sourcePath + "/residents.csv");

			hk.Calculate();
			PrintWindow pw = new PrintWindow(hk.sortedLaundry);
		}
		else
		{
			MessageDialogue md = new MessageDialogue("Выберете файл", MessageType.Info);
				
		}
	}

	protected void OnSaveClicked(object sender, EventArgs e)
	{
		HouseKeepingData.sheets = spinSheets.ValueAsInt;
		HouseKeepingData.robes = spinRobes.ValueAsInt;
		HouseKeepingData.towels = spinTowels.ValueAsInt;
		HouseKeepingData.SaveData();
	}


	protected void OnExitClicked(object sender, EventArgs e)
	{
		Application.Quit();
	}

	protected void OnPathChanged(object sender, EventArgs e)
	{
		HouseKeepingData.sourcePath = pathOfASource.CurrentFolder + pathOfASource.Filename;
	}

	protected void OnLoadClicked(object sender, EventArgs e)
	{
		HouseKeepingData.LoadData();
		spinSheets.Value = HouseKeepingData.sheets;
        spinRobes.Value = HouseKeepingData.robes;
        spinTowels.Value = HouseKeepingData.towels;
	}

	protected void OnPathOfASourceFileActivated(object sender, EventArgs e)
	{
		HouseKeepingData.sourcePath = pathOfASource.CurrentFolder + pathOfASource.Filename;
		
	}

}
