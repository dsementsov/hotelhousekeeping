using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.IO;
using System.Text;


namespace hotelmanagementsystem.lazurniy.housekeeping
{
    public partial class PrintWindow : Gtk.Window
    {

    
        public PrintWindow(Dictionary<string, string> sortedLaundry) :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            //PrintText.ModifyFont();
            File.Create(HouseKeepingData.path + "\\Startbuildingwindow.txt");
            PrintText.Buffer.Text += String.Format("\n\tГрафик горничных для администратора" +
                                                   "\n\t\tДата: {0}" +
                                                   "\n\t\tГенералки: {1}" +
                                                   "\n\t\tПолотенца: {2}" +
                                                   "\n\t\tБелье: {3}" +
                                                   "\n\t\tХалаты: {4}\n",
                                                   HouseKeepingData.dateNow,
                                                   sortedLaundry[SortedLaundryKeys.adminGenerals],
                                                   sortedLaundry[SortedLaundryKeys.adminTowels],
                                                   sortedLaundry[SortedLaundryKeys.adminSheets],
                                                   sortedLaundry[SortedLaundryKeys.adminRobes]);
            PrintText.Buffer.Text += "\n\t=================================================================\n";
            PrintText.Buffer.Text += String.Format("\tЭтаж: {0}\t\tДата: {1}" +
                                                   "\n\t\tГенералки: {2}" +
                                                   "\n\t\tПолотенца: {3}" +
                                                   "\n\t\tБелье: {4}" +
                                                   "\n\t\tХалаты: {5}\n",
                                                   "2", HouseKeepingData.dateNow,
                                                   sortedLaundry[SortedLaundryKeys.generalsSecond],
                                                   sortedLaundry[SortedLaundryKeys.towelsSecond],
                                                   sortedLaundry[SortedLaundryKeys.sheetsSecond],
                                                   sortedLaundry[SortedLaundryKeys.robesSecond]);
            PrintText.Buffer.Text += "\n\t=================================================================\n";
            PrintText.Buffer.Text += String.Format("\tЭтаж: {0}\t\tДата: {1}" +
                                                   "\n\t\tГенералки: {2}" +
                                                   "\n\t\tПолотенца: {3}" +
                                                   "\n\t\tБелье: {4}" +
                                                   "\n\t\tХалаты: {5}\n",
                                                   "3", HouseKeepingData.dateNow,
                                                   sortedLaundry[SortedLaundryKeys.generalsThird],
                                                   sortedLaundry[SortedLaundryKeys.towelsThird],
                                                   sortedLaundry[SortedLaundryKeys.sheetsThird],
                                                   sortedLaundry[SortedLaundryKeys.robesThird]);
            PrintText.Buffer.Text += "\n\t=================================================================\n";
            PrintText.Buffer.Text += String.Format("\tЭтаж: {0}\t\tДата: {1}" +
                                                   "\n\t\tГенералки: {2}" +
                                                   "\n\t\tПолотенца: {3}" +
                                                   "\n\t\tБелье: {4}" +
                                                   "\n\t\tХалаты: {5}\n",
                                                   "4", HouseKeepingData.dateNow,
                                                   sortedLaundry[SortedLaundryKeys.generalsFourth],
                                                   sortedLaundry[SortedLaundryKeys.towelsFourth],
                                                   sortedLaundry[SortedLaundryKeys.sheetsFourth],
                                                   sortedLaundry[SortedLaundryKeys.robesFourth]);
            PrintText.Buffer.Text += "\n\t=================================================================\n\n";
            PrintText.Buffer.Text += String.Format("\tЭтаж:{0}\t\tДата:{1}" +
                                                   "\n\t\tГенералки: {2}" +
                                                   "\n\t\tПолотенца: {3}" +
                                                   "\n\t\tБелье: {4}" +
                                                   "\n\t\tХалаты: {5}\n",
                                                   "5", HouseKeepingData.dateNow,
                                                   sortedLaundry[SortedLaundryKeys.generalsFifth],
                                                   sortedLaundry[SortedLaundryKeys.towelsFifth],
                                                   sortedLaundry[SortedLaundryKeys.sheetsFifth],
                                                   sortedLaundry[SortedLaundryKeys.robesFifth]);
            PrintText.Buffer.Text += "\n\t=================================================================\n";      
			PrintText.Buffer.Text += String.Format("\n\tПрачечная:\tДата: {0}" +
                                                 "\n\t\tГенералки: {1}" +
												 "\n\t\tПолотенца: {2}" +
												 "\n\t\tБелье: {3}" +
												 "\n\t\tХалаты: {4}\n",
												 HouseKeepingData.dateNow,
												 sortedLaundry[SortedLaundryKeys.adminGenerals],
												 sortedLaundry[SortedLaundryKeys.adminTowels],
												 sortedLaundry[SortedLaundryKeys.adminSheets],
												 sortedLaundry[SortedLaundryKeys.adminRobes]);
			PrintText.Buffer.Text += String.Format("\n\tИтого:" +
												  "\n\t\tКомплекты белья на выдачу: {1}" +
												  "\n\t\tКомплекты полотенец на выдачу: {2}" +
												  "\n\t\tКомплекты халатов на выдачу: {3}\n",
												  HouseKeepingData.dateNow,
												  sortedLaundry[SortedLaundryKeys.sheetsAmount],
												  sortedLaundry[SortedLaundryKeys.towelsAmount],
												  sortedLaundry[SortedLaundryKeys.robesAmount]);
        }

        protected void OnCancelClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        //protected void OnPrintClicked(object sender, EventArgs e)
        //{
  //          PrintDoc pd = new PrintDoc(PrintText.Buffer.Text, this);
  //          pd.Print();
           
        //}

        protected void OnPreviewClicked(object sender, EventArgs e)
        {
            string outputFile = HouseKeepingData.path + "/Output.txt";
            if (File.Exists(outputFile))
                File.Delete(outputFile);
            using (FileStream fs = File.Create(outputFile))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(PrintText.Buffer.Text);
                fs.Write(info, 0, info.Length);
            }
            System.Diagnostics.Process.Start(outputFile);
        }

    
    }
}
