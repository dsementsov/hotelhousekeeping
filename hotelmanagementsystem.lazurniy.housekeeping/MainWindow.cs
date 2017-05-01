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
		HouseKeepingData.sheets = spinSheets.ValueAsInt;
		HouseKeepingData.robes = spinRobes.ValueAsInt;
		HouseKeepingData.towels = spinTowels.ValueAsInt;
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
		HouseKeepingData.sourcePath = pathOfASource.Filename;
	}

	protected void OnLoadClicked(object sender, EventArgs e)
	{
		HouseKeepingData.LoadData();
		spinSheets.Value = HouseKeepingData.sheets;
        spinRobes.Value = HouseKeepingData.robes;
        spinTowels.Value = HouseKeepingData.towels;
	}
}
