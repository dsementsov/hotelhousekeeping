using System;
using System.Drawing;
using System.Drawing.Printing;
using System.CodeDom;
using Gdk;
using Gtk;

namespace hotelmanagementsystem.lazurniy.housekeeping
{
    public class PrintDoc
    {

        public Gtk.Window parent;
        public string _textToPrint;

        public PrintDoc(string textToPrint, Gtk.Window parent)
        {
            this._textToPrint = textToPrint;
            this.parent = parent;
        }

        public void Print()
        {
			PrintDocument p = new PrintDocument();
			p.DocumentName = "График горничных";
			p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
			{
				System.Drawing.Font myFont = new System.Drawing.Font("Times New Roman", 14, FontStyle.Regular);
				e1.Graphics.DrawString(_textToPrint, myFont,
									   new SolidBrush(System.Drawing.Color.Black),
									  new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

			};
				try
				{
					p.Print();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
            p.Dispose();
		}



    }
}
