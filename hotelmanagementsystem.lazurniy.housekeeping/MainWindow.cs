using System;
using Gtk;
using hotelmanagementsystem.lazurniy.housekeeping;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
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
		HouseKeeping.Reveal();
	}

	protected void OnSaveClicked(object sender, EventArgs e)
	{
		HouseKeepingData.SaveData();
	}

	protected void OnExitClicked(object sender, EventArgs e)
	{
		Application.Quit();
	}

	protected void OnPathChanged(object sender, EventArgs e)
	{
		HouseKeeping.sourcePath = pathOfASource.Filename;
	}

	protected void OnDefaultActivated(object sender, EventArgs e)
	{
		spinSheets.Value = HouseKeepingData.sheets;
        spinRobes.Value = HouseKeepingData.robes;
        spinTowels.Value = HouseKeepingData.towels;
	}
}
