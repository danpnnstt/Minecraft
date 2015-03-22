/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/19/2015
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace JSONEdit
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new MainForm());
            try
            {
                MainForm.BASE_DIRECTORY = args[0];
            }
            catch
            {
                MainForm.BASE_DIRECTORY = Environment.CurrentDirectory + "/";
            }
            MainForm mf = new MainForm();
            mf.ShowDialog();
		}
		
	}
}
