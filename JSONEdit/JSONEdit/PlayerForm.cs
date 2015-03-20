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
	}
}
