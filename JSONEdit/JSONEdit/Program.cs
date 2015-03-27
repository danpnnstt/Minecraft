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
                //MainForm.BASE_DIRECTORY = args[0];
                MainForm.BASE_DIRECTORY = @"C:\Users\dhartenbach\My Documents\GitHub\Minecraft\GameBackup\minecraft\";
            }
            catch
            {
            	FolderBrowserDialog diag = new FolderBrowserDialog();
            	diag.Description = "Set working directory";
            	diag.RootFolder = Environment.SpecialFolder.Desktop;
            	if(diag.ShowDialog() == DialogResult.OK)
            	{
            		MainForm.BASE_DIRECTORY = diag.SelectedPath + "/";
            	}
            	else
            	{
            		MessageBox.Show("Error: no working directory provided.  Using current directory.", "No working directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            		MainForm.BASE_DIRECTORY = Environment.CurrentDirectory + "/";
            	}
            }
            MainForm mf = new MainForm();
            mf.ShowDialog();
		}
		
	}
}
