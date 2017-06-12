using System;
using Gtk;

namespace hotelmanagementsystem.lazurniy.housekeeping
{
	class MainClass
	{
		public static void Main(string[] args)
		{


			Application.Init();
			MainWindow win = new MainWindow();
			win.Show();

			#region Including Libglib as embedded resource
			AppDomain.CurrentDomain.AssemblyResolve += (object sender, ResolveEventArgs arg) =>
				  {
					  String thisExe = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
					  System.Reflection.AssemblyName embeddedAssembly = new System.Reflection.AssemblyName(arg.Name);
					  String resourceName = thisExe + "." + embeddedAssembly.Name + ".dll";

					  using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
					  {
						  Byte[] assemblyData = new Byte[stream.Length];
						  stream.Read(assemblyData, 0, assemblyData.Length);
						  return System.Reflection.Assembly.Load(assemblyData);
					  }
				  };
			#endregion
    
			Application.Run();

		}
	}
}
