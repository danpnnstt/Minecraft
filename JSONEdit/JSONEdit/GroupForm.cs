/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/20/2015
 * Time: 4:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSONEdit
{
	/// <summary>
	/// Description of GroupForm.
	/// </summary>
	public partial class GroupForm : Form
	{
		public string GroupName
		{
			get;
			private set;
		}
		
		public string ParentGroup
		{
			get;
			private set;
		}
		
		public GroupForm(JSONGroupFile[] groups)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			cboParent.Items.Add("None");
			for(int idx = 0; idx < groups.Length; idx++)
			{
				cboParent.Items.Add(groups[idx].GroupName);
			}
			cboParent.SelectedIndex = 0;
			GroupName = ParentGroup = null;
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			if(cboParent.SelectedIndex != 0) ParentGroup = cboParent.SelectedItem.ToString();
			GroupName = txtGroupName.Text.Trim();
			if(GroupName.Length == 0) 
			{
				MessageBox.Show("Error: you must provide a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Dispose();
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			GroupName = ParentGroup = null;
			this.Dispose();
		}
	}
}
