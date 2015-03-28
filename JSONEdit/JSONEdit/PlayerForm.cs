/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/20/2015
 * Time: 12:15 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace JSONEdit
{
	/// <summary>
	/// Description of PlayerForm.
	/// </summary>
	public partial class PlayerForm : Form
	{
		public string[] MemberList
		{
			get;
			private set;
		}
		
		public PlayerForm(JSONGroupFile json)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string[] mem = json.GetMembers();
			if(mem != null)
			{
				MemberList = new string[mem.Length];
				Array.Copy(mem, MemberList, mem.Length);
			}
			FillListBox();
		}
		
		public PlayerForm(JSONUserFile json)
		{
			InitializeComponent();
			MemberList = json.UUID;
			FillListBox();
		}
		
		void FillListBox()
		{
			lstMembers.Items.Clear();
			if(MemberList != null)
			{
				lstMembers.Items.AddRange(MemberList);
			}
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			txtUUID.ReadOnly = false;
			txtUsername.ReadOnly = false;
			btnOK.Enabled = true;
			btnAdd.Enabled = false;
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(MemberList == null) return;
			if(lstMembers.SelectedIndex < 0) return;
			List<string> list = new List<string>();
			list.AddRange(MemberList);
			list.RemoveAt(lstMembers.SelectedIndex);
			MemberList = null;
			if(list.Count != 0)
			{
				MemberList = list.ToArray();
			}
			FillListBox();
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			string uuid = txtUUID.Text;
			string user = txtUsername.Text;
			txtUsername.Text = "";
			txtUUID.Text = "";
			txtUUID.ReadOnly = true;
			txtUsername.ReadOnly = true;
			btnOK.Enabled = false;
			btnAdd.Enabled = true;
			List<string> list = new List<string>();
			if(MemberList != null)
			{
				list.AddRange(MemberList);
			}
			MemberList = null;
			GC.Collect();
			list.Add(uuid);
			MemberList = list.ToArray();
			FillListBox();
		}
		
		void TxtUsernameKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string uri = "https://api.mojang.com/users/profiles/minecraft/" + txtUsername.Text;
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create (uri);
				request.MaximumAutomaticRedirections = 4;
            	request.MaximumResponseHeadersLength = 4;
            	HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            	Stream receive = response.GetResponseStream();
            	StreamReader read = new StreamReader(receive);
            	string json = read.ReadToEnd();
            	json = json.Replace("{", "").Replace("}", "").Replace("\"", "");
            	string[] elements = json.Split(',');
            	Dictionary<string, string> dict = new Dictionary<string, string>();
            	foreach(string elem in elements)
            	{
            		string[] s = elem.Split(':');
            		if(s[0] == "id")
            		{
            			s[1] = new Guid(s[1]).ToString("D");
            		}
            		dict.Add(s[0], s[1]);
            	}
            	response.Close();
            	read.Close();
            	txtUUID.Text = dict["id"];
            	txtUsername.Text = dict["name"];
			}
		}
	}
}
