using System;
using Gtk;
using hotelmanagementsystem.lazurniy.housekeeping;

public partial class MainWindow : Gtk.Window
{

    private bool converted;
	LoadFromCSVFile loadFromFile = new LoadFromCSVFile();
	HouseKeeping hk = new HouseKeeping();

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
        converted = false;
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
        if (converted)
        {
            hk.ClearData();
            loadFromFile.LoadGUestData();
			hk.Calculate();
			hk.Sort();
            PrintWindow pw = new PrintWindow(hk.sortedLaundry);
        }
        else
        {
            MessageDialogue md = new MessageDialogue("Пожалуйста нажмите Ковертировать файл!", MessageType.Info);
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
		HouseKeepingData.sourcePath = pathOfASource.Filename;
	}


	protected void OnPathOfASourceFileActivated(object sender, EventArgs e)
	{
		HouseKeepingData.sourcePath = pathOfASource.Filename;
		
	}

    protected void OnConvertClicked(object sender, EventArgs e)
    {
		if (HouseKeepingData.sourcePath.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
		{
            try
            {
                System.Diagnostics.Process.Start(HouseKeepingData.convertingScriptPath,
                                                    HouseKeepingData.sourcePath + " " + HouseKeepingData.csvSourcePath);
            }
			catch (Exception d)
			{
				MessageDialogue md = new MessageDialogue("Указан файл неправильного формата!" + d.ToString(), MessageType.Error);
			}
		
			converted = true;
		}
		else
		{
			MessageDialogue md = new MessageDialogue("Укажите файл XLSX с проживающими в отеле!", MessageType.Info);

		}
    }
}
