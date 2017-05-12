using System;
using Gtk;
namespace hotelmanagementsystem.lazurniy.housekeeping
{
	public class MessageDialogue : Gtk.MessageDialog
	{
		public MessageDialogue(string message, MessageType type)
		{
			MessageDialog md = new MessageDialog(this, DialogFlags.DestroyWithParent, type, ButtonsType.Ok, message);
			md.Run();
			md.Destroy();
		}
	}
}
