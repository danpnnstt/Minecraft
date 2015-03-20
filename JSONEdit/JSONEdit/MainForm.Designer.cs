/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/19/2015
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JSONEdit
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.TabControl tcContent;
		private System.Windows.Forms.TabPage tpPermissions;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPlayers;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSaveChanges;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ComboBox cboGroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboParent;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGroupName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox grpPermissions;
		private System.Windows.Forms.CheckBox chkAchievement;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox chkBan;
		private System.Windows.Forms.CheckBox chkClear;
		private System.Windows.Forms.CheckBox chkBlockData;
		private System.Windows.Forms.CheckBox chkBanList;
		private System.Windows.Forms.CheckBox chkBanIP;
		private System.Windows.Forms.CheckBox chkClone;
		private System.Windows.Forms.CheckBox chkEntityData;
		private System.Windows.Forms.CheckBox chkEnchant;
		private System.Windows.Forms.CheckBox chkEffect;
		private System.Windows.Forms.CheckBox chkDifficulty;
		private System.Windows.Forms.CheckBox chkDeop;
		private System.Windows.Forms.CheckBox chkDefaultGameMode;
		private System.Windows.Forms.CheckBox chkDebug;
		private System.Windows.Forms.CheckBox chkKick;
		private System.Windows.Forms.CheckBox chkHelp;
		private System.Windows.Forms.CheckBox chkGive;
		private System.Windows.Forms.CheckBox chkGameRule;
		private System.Windows.Forms.CheckBox chkGameMode;
		private System.Windows.Forms.CheckBox chkFill;
		private System.Windows.Forms.CheckBox chkExecute;
		private System.Windows.Forms.CheckBox chkPlaySound;
		private System.Windows.Forms.CheckBox chkParticle;
		private System.Windows.Forms.CheckBox chkPardon;
		private System.Windows.Forms.CheckBox chkOp;
		private System.Windows.Forms.CheckBox chkMe;
		private System.Windows.Forms.CheckBox chkList;
		private System.Windows.Forms.CheckBox chkKill;
		private System.Windows.Forms.CheckBox chkStats;
		private System.Windows.Forms.CheckBox chkSpreadPlayers;
		private System.Windows.Forms.CheckBox chkSpawnPoint;
		private System.Windows.Forms.CheckBox chkSetWorldSpawn;
		private System.Windows.Forms.CheckBox chkSetIdleTimeout;
		private System.Windows.Forms.CheckBox chkSetBlock;
		private System.Windows.Forms.CheckBox chkSeed;
		private System.Windows.Forms.CheckBox chkScoreBoard;
		private System.Windows.Forms.CheckBox chkSay;
		private System.Windows.Forms.CheckBox chkSaveOn;
		private System.Windows.Forms.CheckBox chkSaveOff;
		private System.Windows.Forms.CheckBox chkSaveAll;
		private System.Windows.Forms.CheckBox chkReplaceItem;
		private System.Windows.Forms.CheckBox chkPublish;
		private System.Windows.Forms.CheckBox chkXp;
		private System.Windows.Forms.CheckBox chkWorldBorder;
		private System.Windows.Forms.CheckBox chkWhiteList;
		private System.Windows.Forms.CheckBox chkWeather;
		private System.Windows.Forms.CheckBox chkTrigger;
		private System.Windows.Forms.CheckBox chkTp;
		private System.Windows.Forms.CheckBox chkToggleDownfall;
		private System.Windows.Forms.CheckBox chkTitle;
		private System.Windows.Forms.CheckBox chkTime;
		private System.Windows.Forms.CheckBox chkTestForBlocks;
		private System.Windows.Forms.CheckBox chkTestForBlock;
		private System.Windows.Forms.CheckBox chkTestFor;
		private System.Windows.Forms.CheckBox chkTellRaw;
		private System.Windows.Forms.CheckBox chkTell;
		private System.Windows.Forms.CheckBox chkSummon;
		private System.Windows.Forms.CheckBox chkStop;
		private System.Windows.Forms.Button btnRemoveAll;
		private System.Windows.Forms.Button btnGrantAll;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tcContent = new System.Windows.Forms.TabControl();
			this.tpPermissions = new System.Windows.Forms.TabPage();
			this.btnRemoveAll = new System.Windows.Forms.Button();
			this.btnGrantAll = new System.Windows.Forms.Button();
			this.grpPermissions = new System.Windows.Forms.GroupBox();
			this.chkXp = new System.Windows.Forms.CheckBox();
			this.chkWorldBorder = new System.Windows.Forms.CheckBox();
			this.chkWhiteList = new System.Windows.Forms.CheckBox();
			this.chkWeather = new System.Windows.Forms.CheckBox();
			this.chkTrigger = new System.Windows.Forms.CheckBox();
			this.chkTp = new System.Windows.Forms.CheckBox();
			this.chkToggleDownfall = new System.Windows.Forms.CheckBox();
			this.chkTitle = new System.Windows.Forms.CheckBox();
			this.chkTime = new System.Windows.Forms.CheckBox();
			this.chkTestForBlocks = new System.Windows.Forms.CheckBox();
			this.chkTestForBlock = new System.Windows.Forms.CheckBox();
			this.chkTestFor = new System.Windows.Forms.CheckBox();
			this.chkTellRaw = new System.Windows.Forms.CheckBox();
			this.chkTell = new System.Windows.Forms.CheckBox();
			this.chkSummon = new System.Windows.Forms.CheckBox();
			this.chkStop = new System.Windows.Forms.CheckBox();
			this.chkStats = new System.Windows.Forms.CheckBox();
			this.chkSpreadPlayers = new System.Windows.Forms.CheckBox();
			this.chkSpawnPoint = new System.Windows.Forms.CheckBox();
			this.chkSetWorldSpawn = new System.Windows.Forms.CheckBox();
			this.chkSetIdleTimeout = new System.Windows.Forms.CheckBox();
			this.chkSetBlock = new System.Windows.Forms.CheckBox();
			this.chkSeed = new System.Windows.Forms.CheckBox();
			this.chkScoreBoard = new System.Windows.Forms.CheckBox();
			this.chkSay = new System.Windows.Forms.CheckBox();
			this.chkSaveOn = new System.Windows.Forms.CheckBox();
			this.chkSaveOff = new System.Windows.Forms.CheckBox();
			this.chkSaveAll = new System.Windows.Forms.CheckBox();
			this.chkReplaceItem = new System.Windows.Forms.CheckBox();
			this.chkPublish = new System.Windows.Forms.CheckBox();
			this.chkPlaySound = new System.Windows.Forms.CheckBox();
			this.chkParticle = new System.Windows.Forms.CheckBox();
			this.chkPardon = new System.Windows.Forms.CheckBox();
			this.chkOp = new System.Windows.Forms.CheckBox();
			this.chkMe = new System.Windows.Forms.CheckBox();
			this.chkList = new System.Windows.Forms.CheckBox();
			this.chkKill = new System.Windows.Forms.CheckBox();
			this.chkKick = new System.Windows.Forms.CheckBox();
			this.chkHelp = new System.Windows.Forms.CheckBox();
			this.chkGive = new System.Windows.Forms.CheckBox();
			this.chkGameRule = new System.Windows.Forms.CheckBox();
			this.chkGameMode = new System.Windows.Forms.CheckBox();
			this.chkFill = new System.Windows.Forms.CheckBox();
			this.chkExecute = new System.Windows.Forms.CheckBox();
			this.chkEntityData = new System.Windows.Forms.CheckBox();
			this.chkEnchant = new System.Windows.Forms.CheckBox();
			this.chkEffect = new System.Windows.Forms.CheckBox();
			this.chkDifficulty = new System.Windows.Forms.CheckBox();
			this.chkDeop = new System.Windows.Forms.CheckBox();
			this.chkDefaultGameMode = new System.Windows.Forms.CheckBox();
			this.chkDebug = new System.Windows.Forms.CheckBox();
			this.chkClone = new System.Windows.Forms.CheckBox();
			this.chkClear = new System.Windows.Forms.CheckBox();
			this.chkBlockData = new System.Windows.Forms.CheckBox();
			this.chkBanList = new System.Windows.Forms.CheckBox();
			this.chkBanIP = new System.Windows.Forms.CheckBox();
			this.chkBan = new System.Windows.Forms.CheckBox();
			this.chkAchievement = new System.Windows.Forms.CheckBox();
			this.cboParent = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGroupName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnPlayers = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.cboGroup = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.tcContent.SuspendLayout();
			this.tpPermissions.SuspendLayout();
			this.grpPermissions.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(934, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// tcContent
			// 
			this.tcContent.Controls.Add(this.tpPermissions);
			this.tcContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcContent.Location = new System.Drawing.Point(0, 24);
			this.tcContent.Name = "tcContent";
			this.tcContent.SelectedIndex = 0;
			this.tcContent.Size = new System.Drawing.Size(934, 419);
			this.tcContent.TabIndex = 1;
			// 
			// tpPermissions
			// 
			this.tpPermissions.Controls.Add(this.btnRemoveAll);
			this.tpPermissions.Controls.Add(this.btnGrantAll);
			this.tpPermissions.Controls.Add(this.grpPermissions);
			this.tpPermissions.Controls.Add(this.cboParent);
			this.tpPermissions.Controls.Add(this.label4);
			this.tpPermissions.Controls.Add(this.txtGroupName);
			this.tpPermissions.Controls.Add(this.label3);
			this.tpPermissions.Controls.Add(this.btnPlayers);
			this.tpPermissions.Controls.Add(this.btnDelete);
			this.tpPermissions.Controls.Add(this.btnSaveChanges);
			this.tpPermissions.Controls.Add(this.btnCreate);
			this.tpPermissions.Controls.Add(this.cboGroup);
			this.tpPermissions.Controls.Add(this.label2);
			this.tpPermissions.Controls.Add(this.label1);
			this.tpPermissions.Location = new System.Drawing.Point(4, 22);
			this.tpPermissions.Name = "tpPermissions";
			this.tpPermissions.Padding = new System.Windows.Forms.Padding(3);
			this.tpPermissions.Size = new System.Drawing.Size(926, 393);
			this.tpPermissions.TabIndex = 0;
			this.tpPermissions.Text = "Permissions";
			this.tpPermissions.UseVisualStyleBackColor = true;
			// 
			// btnRemoveAll
			// 
			this.btnRemoveAll.Location = new System.Drawing.Point(161, 164);
			this.btnRemoveAll.Name = "btnRemoveAll";
			this.btnRemoveAll.Size = new System.Drawing.Size(149, 23);
			this.btnRemoveAll.TabIndex = 13;
			this.btnRemoveAll.Text = "Remove all permissions";
			this.btnRemoveAll.UseVisualStyleBackColor = true;
			this.btnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAllClick);
			// 
			// btnGrantAll
			// 
			this.btnGrantAll.Location = new System.Drawing.Point(6, 164);
			this.btnGrantAll.Name = "btnGrantAll";
			this.btnGrantAll.Size = new System.Drawing.Size(149, 23);
			this.btnGrantAll.TabIndex = 12;
			this.btnGrantAll.Text = "Grant all permissions";
			this.btnGrantAll.UseVisualStyleBackColor = true;
			this.btnGrantAll.Click += new System.EventHandler(this.BtnGrantAllClick);
			// 
			// grpPermissions
			// 
			this.grpPermissions.Controls.Add(this.chkXp);
			this.grpPermissions.Controls.Add(this.chkWorldBorder);
			this.grpPermissions.Controls.Add(this.chkWhiteList);
			this.grpPermissions.Controls.Add(this.chkWeather);
			this.grpPermissions.Controls.Add(this.chkTrigger);
			this.grpPermissions.Controls.Add(this.chkTp);
			this.grpPermissions.Controls.Add(this.chkToggleDownfall);
			this.grpPermissions.Controls.Add(this.chkTitle);
			this.grpPermissions.Controls.Add(this.chkTime);
			this.grpPermissions.Controls.Add(this.chkTestForBlocks);
			this.grpPermissions.Controls.Add(this.chkTestForBlock);
			this.grpPermissions.Controls.Add(this.chkTestFor);
			this.grpPermissions.Controls.Add(this.chkTellRaw);
			this.grpPermissions.Controls.Add(this.chkTell);
			this.grpPermissions.Controls.Add(this.chkSummon);
			this.grpPermissions.Controls.Add(this.chkStop);
			this.grpPermissions.Controls.Add(this.chkStats);
			this.grpPermissions.Controls.Add(this.chkSpreadPlayers);
			this.grpPermissions.Controls.Add(this.chkSpawnPoint);
			this.grpPermissions.Controls.Add(this.chkSetWorldSpawn);
			this.grpPermissions.Controls.Add(this.chkSetIdleTimeout);
			this.grpPermissions.Controls.Add(this.chkSetBlock);
			this.grpPermissions.Controls.Add(this.chkSeed);
			this.grpPermissions.Controls.Add(this.chkScoreBoard);
			this.grpPermissions.Controls.Add(this.chkSay);
			this.grpPermissions.Controls.Add(this.chkSaveOn);
			this.grpPermissions.Controls.Add(this.chkSaveOff);
			this.grpPermissions.Controls.Add(this.chkSaveAll);
			this.grpPermissions.Controls.Add(this.chkReplaceItem);
			this.grpPermissions.Controls.Add(this.chkPublish);
			this.grpPermissions.Controls.Add(this.chkPlaySound);
			this.grpPermissions.Controls.Add(this.chkParticle);
			this.grpPermissions.Controls.Add(this.chkPardon);
			this.grpPermissions.Controls.Add(this.chkOp);
			this.grpPermissions.Controls.Add(this.chkMe);
			this.grpPermissions.Controls.Add(this.chkList);
			this.grpPermissions.Controls.Add(this.chkKill);
			this.grpPermissions.Controls.Add(this.chkKick);
			this.grpPermissions.Controls.Add(this.chkHelp);
			this.grpPermissions.Controls.Add(this.chkGive);
			this.grpPermissions.Controls.Add(this.chkGameRule);
			this.grpPermissions.Controls.Add(this.chkGameMode);
			this.grpPermissions.Controls.Add(this.chkFill);
			this.grpPermissions.Controls.Add(this.chkExecute);
			this.grpPermissions.Controls.Add(this.chkEntityData);
			this.grpPermissions.Controls.Add(this.chkEnchant);
			this.grpPermissions.Controls.Add(this.chkEffect);
			this.grpPermissions.Controls.Add(this.chkDifficulty);
			this.grpPermissions.Controls.Add(this.chkDeop);
			this.grpPermissions.Controls.Add(this.chkDefaultGameMode);
			this.grpPermissions.Controls.Add(this.chkDebug);
			this.grpPermissions.Controls.Add(this.chkClone);
			this.grpPermissions.Controls.Add(this.chkClear);
			this.grpPermissions.Controls.Add(this.chkBlockData);
			this.grpPermissions.Controls.Add(this.chkBanList);
			this.grpPermissions.Controls.Add(this.chkBanIP);
			this.grpPermissions.Controls.Add(this.chkBan);
			this.grpPermissions.Controls.Add(this.chkAchievement);
			this.grpPermissions.Location = new System.Drawing.Point(8, 193);
			this.grpPermissions.Name = "grpPermissions";
			this.grpPermissions.Size = new System.Drawing.Size(900, 193);
			this.grpPermissions.TabIndex = 11;
			this.grpPermissions.TabStop = false;
			this.grpPermissions.Text = "Permissions to grant:";
			// 
			// chkXp
			// 
			this.chkXp.AutoSize = true;
			this.chkXp.Location = new System.Drawing.Point(805, 42);
			this.chkXp.Name = "chkXp";
			this.chkXp.Size = new System.Drawing.Size(39, 17);
			this.chkXp.TabIndex = 57;
			this.chkXp.Text = "Xp";
			this.toolTip1.SetToolTip(this.chkXp, "Adds player to banlist.");
			this.chkXp.UseVisualStyleBackColor = true;
			// 
			// chkWorldBorder
			// 
			this.chkWorldBorder.AutoSize = true;
			this.chkWorldBorder.Location = new System.Drawing.Point(805, 19);
			this.chkWorldBorder.Name = "chkWorldBorder";
			this.chkWorldBorder.Size = new System.Drawing.Size(84, 17);
			this.chkWorldBorder.TabIndex = 56;
			this.chkWorldBorder.Text = "Worldborder";
			this.toolTip1.SetToolTip(this.chkWorldBorder, "Gives or removes an achievement from a player");
			this.chkWorldBorder.UseVisualStyleBackColor = true;
			// 
			// chkWhiteList
			// 
			this.chkWhiteList.AutoSize = true;
			this.chkWhiteList.Location = new System.Drawing.Point(684, 157);
			this.chkWhiteList.Name = "chkWhiteList";
			this.chkWhiteList.Size = new System.Drawing.Size(66, 17);
			this.chkWhiteList.TabIndex = 55;
			this.chkWhiteList.Text = "Whitelist";
			this.toolTip1.SetToolTip(this.chkWhiteList, "Gives or removes an achievement from a player");
			this.chkWhiteList.UseVisualStyleBackColor = true;
			// 
			// chkWeather
			// 
			this.chkWeather.AutoSize = true;
			this.chkWeather.Location = new System.Drawing.Point(684, 134);
			this.chkWeather.Name = "chkWeather";
			this.chkWeather.Size = new System.Drawing.Size(67, 17);
			this.chkWeather.TabIndex = 54;
			this.chkWeather.Text = "Weather";
			this.toolTip1.SetToolTip(this.chkWeather, "Gives or removes an achievement from a player");
			this.chkWeather.UseVisualStyleBackColor = true;
			// 
			// chkTrigger
			// 
			this.chkTrigger.AutoSize = true;
			this.chkTrigger.Location = new System.Drawing.Point(684, 111);
			this.chkTrigger.Name = "chkTrigger";
			this.chkTrigger.Size = new System.Drawing.Size(59, 17);
			this.chkTrigger.TabIndex = 53;
			this.chkTrigger.Text = "Trigger";
			this.toolTip1.SetToolTip(this.chkTrigger, "Gives or removes an achievement from a player");
			this.chkTrigger.UseVisualStyleBackColor = true;
			// 
			// chkTp
			// 
			this.chkTp.AutoSize = true;
			this.chkTp.Location = new System.Drawing.Point(684, 88);
			this.chkTp.Name = "chkTp";
			this.chkTp.Size = new System.Drawing.Size(39, 17);
			this.chkTp.TabIndex = 52;
			this.chkTp.Text = "Tp";
			this.toolTip1.SetToolTip(this.chkTp, "Gives or removes an achievement from a player");
			this.chkTp.UseVisualStyleBackColor = true;
			// 
			// chkToggleDownfall
			// 
			this.chkToggleDownfall.AutoSize = true;
			this.chkToggleDownfall.Location = new System.Drawing.Point(684, 65);
			this.chkToggleDownfall.Name = "chkToggleDownfall";
			this.chkToggleDownfall.Size = new System.Drawing.Size(98, 17);
			this.chkToggleDownfall.TabIndex = 51;
			this.chkToggleDownfall.Text = "Toggledownfall";
			this.toolTip1.SetToolTip(this.chkToggleDownfall, "Gives or removes an achievement from a player");
			this.chkToggleDownfall.UseVisualStyleBackColor = true;
			// 
			// chkTitle
			// 
			this.chkTitle.AutoSize = true;
			this.chkTitle.Location = new System.Drawing.Point(684, 42);
			this.chkTitle.Name = "chkTitle";
			this.chkTitle.Size = new System.Drawing.Size(46, 17);
			this.chkTitle.TabIndex = 50;
			this.chkTitle.Text = "Title";
			this.toolTip1.SetToolTip(this.chkTitle, "Adds player to banlist.");
			this.chkTitle.UseVisualStyleBackColor = true;
			// 
			// chkTime
			// 
			this.chkTime.AutoSize = true;
			this.chkTime.Location = new System.Drawing.Point(684, 19);
			this.chkTime.Name = "chkTime";
			this.chkTime.Size = new System.Drawing.Size(49, 17);
			this.chkTime.TabIndex = 49;
			this.chkTime.Text = "Time";
			this.toolTip1.SetToolTip(this.chkTime, "Gives or removes an achievement from a player");
			this.chkTime.UseVisualStyleBackColor = true;
			// 
			// chkTestForBlocks
			// 
			this.chkTestForBlocks.AutoSize = true;
			this.chkTestForBlocks.Location = new System.Drawing.Point(590, 157);
			this.chkTestForBlocks.Name = "chkTestForBlocks";
			this.chkTestForBlocks.Size = new System.Drawing.Size(90, 17);
			this.chkTestForBlocks.TabIndex = 48;
			this.chkTestForBlocks.Text = "Testforblocks";
			this.toolTip1.SetToolTip(this.chkTestForBlocks, "Gives or removes an achievement from a player");
			this.chkTestForBlocks.UseVisualStyleBackColor = true;
			// 
			// chkTestForBlock
			// 
			this.chkTestForBlock.AutoSize = true;
			this.chkTestForBlock.Location = new System.Drawing.Point(590, 134);
			this.chkTestForBlock.Name = "chkTestForBlock";
			this.chkTestForBlock.Size = new System.Drawing.Size(85, 17);
			this.chkTestForBlock.TabIndex = 47;
			this.chkTestForBlock.Text = "Testforblock";
			this.toolTip1.SetToolTip(this.chkTestForBlock, "Gives or removes an achievement from a player");
			this.chkTestForBlock.UseVisualStyleBackColor = true;
			// 
			// chkTestFor
			// 
			this.chkTestFor.AutoSize = true;
			this.chkTestFor.Location = new System.Drawing.Point(590, 111);
			this.chkTestFor.Name = "chkTestFor";
			this.chkTestFor.Size = new System.Drawing.Size(59, 17);
			this.chkTestFor.TabIndex = 46;
			this.chkTestFor.Text = "Testfor";
			this.toolTip1.SetToolTip(this.chkTestFor, "Gives or removes an achievement from a player");
			this.chkTestFor.UseVisualStyleBackColor = true;
			// 
			// chkTellRaw
			// 
			this.chkTellRaw.AutoSize = true;
			this.chkTellRaw.Location = new System.Drawing.Point(590, 88);
			this.chkTellRaw.Name = "chkTellRaw";
			this.chkTellRaw.Size = new System.Drawing.Size(60, 17);
			this.chkTellRaw.TabIndex = 45;
			this.chkTellRaw.Text = "Tellraw";
			this.toolTip1.SetToolTip(this.chkTellRaw, "Gives or removes an achievement from a player");
			this.chkTellRaw.UseVisualStyleBackColor = true;
			// 
			// chkTell
			// 
			this.chkTell.AutoSize = true;
			this.chkTell.Location = new System.Drawing.Point(590, 65);
			this.chkTell.Name = "chkTell";
			this.chkTell.Size = new System.Drawing.Size(43, 17);
			this.chkTell.TabIndex = 44;
			this.chkTell.Text = "Tell";
			this.toolTip1.SetToolTip(this.chkTell, "Gives or removes an achievement from a player");
			this.chkTell.UseVisualStyleBackColor = true;
			// 
			// chkSummon
			// 
			this.chkSummon.AutoSize = true;
			this.chkSummon.Location = new System.Drawing.Point(590, 42);
			this.chkSummon.Name = "chkSummon";
			this.chkSummon.Size = new System.Drawing.Size(67, 17);
			this.chkSummon.TabIndex = 43;
			this.chkSummon.Text = "Summon";
			this.toolTip1.SetToolTip(this.chkSummon, "Adds player to banlist.");
			this.chkSummon.UseVisualStyleBackColor = true;
			// 
			// chkStop
			// 
			this.chkStop.AutoSize = true;
			this.chkStop.Location = new System.Drawing.Point(590, 19);
			this.chkStop.Name = "chkStop";
			this.chkStop.Size = new System.Drawing.Size(48, 17);
			this.chkStop.TabIndex = 42;
			this.chkStop.Text = "Stop";
			this.toolTip1.SetToolTip(this.chkStop, "Gives or removes an achievement from a player");
			this.chkStop.UseVisualStyleBackColor = true;
			// 
			// chkStats
			// 
			this.chkStats.AutoSize = true;
			this.chkStats.Location = new System.Drawing.Point(486, 157);
			this.chkStats.Name = "chkStats";
			this.chkStats.Size = new System.Drawing.Size(50, 17);
			this.chkStats.TabIndex = 41;
			this.chkStats.Text = "Stats";
			this.toolTip1.SetToolTip(this.chkStats, "Gives or removes an achievement from a player");
			this.chkStats.UseVisualStyleBackColor = true;
			// 
			// chkSpreadPlayers
			// 
			this.chkSpreadPlayers.AutoSize = true;
			this.chkSpreadPlayers.Location = new System.Drawing.Point(486, 134);
			this.chkSpreadPlayers.Name = "chkSpreadPlayers";
			this.chkSpreadPlayers.Size = new System.Drawing.Size(93, 17);
			this.chkSpreadPlayers.TabIndex = 40;
			this.chkSpreadPlayers.Text = "Spreadplayers";
			this.toolTip1.SetToolTip(this.chkSpreadPlayers, "Gives or removes an achievement from a player");
			this.chkSpreadPlayers.UseVisualStyleBackColor = true;
			// 
			// chkSpawnPoint
			// 
			this.chkSpawnPoint.AutoSize = true;
			this.chkSpawnPoint.Location = new System.Drawing.Point(486, 111);
			this.chkSpawnPoint.Name = "chkSpawnPoint";
			this.chkSpawnPoint.Size = new System.Drawing.Size(82, 17);
			this.chkSpawnPoint.TabIndex = 39;
			this.chkSpawnPoint.Text = "Spawnpoint";
			this.toolTip1.SetToolTip(this.chkSpawnPoint, "Gives or removes an achievement from a player");
			this.chkSpawnPoint.UseVisualStyleBackColor = true;
			// 
			// chkSetWorldSpawn
			// 
			this.chkSetWorldSpawn.AutoSize = true;
			this.chkSetWorldSpawn.Location = new System.Drawing.Point(486, 88);
			this.chkSetWorldSpawn.Name = "chkSetWorldSpawn";
			this.chkSetWorldSpawn.Size = new System.Drawing.Size(98, 17);
			this.chkSetWorldSpawn.TabIndex = 38;
			this.chkSetWorldSpawn.Text = "Setworldspawn";
			this.toolTip1.SetToolTip(this.chkSetWorldSpawn, "Gives or removes an achievement from a player");
			this.chkSetWorldSpawn.UseVisualStyleBackColor = true;
			// 
			// chkSetIdleTimeout
			// 
			this.chkSetIdleTimeout.AutoSize = true;
			this.chkSetIdleTimeout.Location = new System.Drawing.Point(486, 65);
			this.chkSetIdleTimeout.Name = "chkSetIdleTimeout";
			this.chkSetIdleTimeout.Size = new System.Drawing.Size(92, 17);
			this.chkSetIdleTimeout.TabIndex = 37;
			this.chkSetIdleTimeout.Text = "Setidletimeout";
			this.toolTip1.SetToolTip(this.chkSetIdleTimeout, "Gives or removes an achievement from a player");
			this.chkSetIdleTimeout.UseVisualStyleBackColor = true;
			// 
			// chkSetBlock
			// 
			this.chkSetBlock.AutoSize = true;
			this.chkSetBlock.Location = new System.Drawing.Point(486, 42);
			this.chkSetBlock.Name = "chkSetBlock";
			this.chkSetBlock.Size = new System.Drawing.Size(68, 17);
			this.chkSetBlock.TabIndex = 36;
			this.chkSetBlock.Text = "Setblock";
			this.toolTip1.SetToolTip(this.chkSetBlock, "Adds player to banlist.");
			this.chkSetBlock.UseVisualStyleBackColor = true;
			// 
			// chkSeed
			// 
			this.chkSeed.AutoSize = true;
			this.chkSeed.Location = new System.Drawing.Point(486, 19);
			this.chkSeed.Name = "chkSeed";
			this.chkSeed.Size = new System.Drawing.Size(51, 17);
			this.chkSeed.TabIndex = 35;
			this.chkSeed.Text = "Seed";
			this.toolTip1.SetToolTip(this.chkSeed, "Gives or removes an achievement from a player");
			this.chkSeed.UseVisualStyleBackColor = true;
			// 
			// chkScoreBoard
			// 
			this.chkScoreBoard.AutoSize = true;
			this.chkScoreBoard.Location = new System.Drawing.Point(395, 157);
			this.chkScoreBoard.Name = "chkScoreBoard";
			this.chkScoreBoard.Size = new System.Drawing.Size(81, 17);
			this.chkScoreBoard.TabIndex = 34;
			this.chkScoreBoard.Text = "Scoreboard";
			this.toolTip1.SetToolTip(this.chkScoreBoard, "Gives or removes an achievement from a player");
			this.chkScoreBoard.UseVisualStyleBackColor = true;
			// 
			// chkSay
			// 
			this.chkSay.AutoSize = true;
			this.chkSay.Location = new System.Drawing.Point(395, 134);
			this.chkSay.Name = "chkSay";
			this.chkSay.Size = new System.Drawing.Size(44, 17);
			this.chkSay.TabIndex = 33;
			this.chkSay.Text = "Say";
			this.toolTip1.SetToolTip(this.chkSay, "Gives or removes an achievement from a player");
			this.chkSay.UseVisualStyleBackColor = true;
			// 
			// chkSaveOn
			// 
			this.chkSaveOn.AutoSize = true;
			this.chkSaveOn.Location = new System.Drawing.Point(395, 111);
			this.chkSaveOn.Name = "chkSaveOn";
			this.chkSaveOn.Size = new System.Drawing.Size(66, 17);
			this.chkSaveOn.TabIndex = 32;
			this.chkSaveOn.Text = "Save-on";
			this.toolTip1.SetToolTip(this.chkSaveOn, "Gives or removes an achievement from a player");
			this.chkSaveOn.UseVisualStyleBackColor = true;
			// 
			// chkSaveOff
			// 
			this.chkSaveOff.AutoSize = true;
			this.chkSaveOff.Location = new System.Drawing.Point(395, 88);
			this.chkSaveOff.Name = "chkSaveOff";
			this.chkSaveOff.Size = new System.Drawing.Size(66, 17);
			this.chkSaveOff.TabIndex = 31;
			this.chkSaveOff.Text = "Save-off";
			this.toolTip1.SetToolTip(this.chkSaveOff, "Gives or removes an achievement from a player");
			this.chkSaveOff.UseVisualStyleBackColor = true;
			// 
			// chkSaveAll
			// 
			this.chkSaveAll.AutoSize = true;
			this.chkSaveAll.Location = new System.Drawing.Point(395, 65);
			this.chkSaveAll.Name = "chkSaveAll";
			this.chkSaveAll.Size = new System.Drawing.Size(64, 17);
			this.chkSaveAll.TabIndex = 30;
			this.chkSaveAll.Text = "Save-all";
			this.toolTip1.SetToolTip(this.chkSaveAll, "Gives or removes an achievement from a player");
			this.chkSaveAll.UseVisualStyleBackColor = true;
			// 
			// chkReplaceItem
			// 
			this.chkReplaceItem.AutoSize = true;
			this.chkReplaceItem.Location = new System.Drawing.Point(395, 42);
			this.chkReplaceItem.Name = "chkReplaceItem";
			this.chkReplaceItem.Size = new System.Drawing.Size(85, 17);
			this.chkReplaceItem.TabIndex = 29;
			this.chkReplaceItem.Text = "Replaceitem";
			this.toolTip1.SetToolTip(this.chkReplaceItem, "Adds player to banlist.");
			this.chkReplaceItem.UseVisualStyleBackColor = true;
			// 
			// chkPublish
			// 
			this.chkPublish.AutoSize = true;
			this.chkPublish.Location = new System.Drawing.Point(395, 19);
			this.chkPublish.Name = "chkPublish";
			this.chkPublish.Size = new System.Drawing.Size(60, 17);
			this.chkPublish.TabIndex = 28;
			this.chkPublish.Text = "Publish";
			this.toolTip1.SetToolTip(this.chkPublish, "Gives or removes an achievement from a player");
			this.chkPublish.UseVisualStyleBackColor = true;
			// 
			// chkPlaySound
			// 
			this.chkPlaySound.AutoSize = true;
			this.chkPlaySound.Location = new System.Drawing.Point(317, 157);
			this.chkPlaySound.Name = "chkPlaySound";
			this.chkPlaySound.Size = new System.Drawing.Size(75, 17);
			this.chkPlaySound.TabIndex = 27;
			this.chkPlaySound.Text = "Playsound";
			this.toolTip1.SetToolTip(this.chkPlaySound, "Gives or removes an achievement from a player");
			this.chkPlaySound.UseVisualStyleBackColor = true;
			// 
			// chkParticle
			// 
			this.chkParticle.AutoSize = true;
			this.chkParticle.Location = new System.Drawing.Point(317, 134);
			this.chkParticle.Name = "chkParticle";
			this.chkParticle.Size = new System.Drawing.Size(61, 17);
			this.chkParticle.TabIndex = 26;
			this.chkParticle.Text = "Particle";
			this.toolTip1.SetToolTip(this.chkParticle, "Gives or removes an achievement from a player");
			this.chkParticle.UseVisualStyleBackColor = true;
			// 
			// chkPardon
			// 
			this.chkPardon.AutoSize = true;
			this.chkPardon.Location = new System.Drawing.Point(317, 111);
			this.chkPardon.Name = "chkPardon";
			this.chkPardon.Size = new System.Drawing.Size(60, 17);
			this.chkPardon.TabIndex = 25;
			this.chkPardon.Text = "Pardon";
			this.toolTip1.SetToolTip(this.chkPardon, "Gives or removes an achievement from a player");
			this.chkPardon.UseVisualStyleBackColor = true;
			// 
			// chkOp
			// 
			this.chkOp.AutoSize = true;
			this.chkOp.Location = new System.Drawing.Point(317, 88);
			this.chkOp.Name = "chkOp";
			this.chkOp.Size = new System.Drawing.Size(40, 17);
			this.chkOp.TabIndex = 24;
			this.chkOp.Text = "Op";
			this.toolTip1.SetToolTip(this.chkOp, "Gives or removes an achievement from a player");
			this.chkOp.UseVisualStyleBackColor = true;
			// 
			// chkMe
			// 
			this.chkMe.AutoSize = true;
			this.chkMe.Location = new System.Drawing.Point(317, 65);
			this.chkMe.Name = "chkMe";
			this.chkMe.Size = new System.Drawing.Size(41, 17);
			this.chkMe.TabIndex = 23;
			this.chkMe.Text = "Me";
			this.toolTip1.SetToolTip(this.chkMe, "Gives or removes an achievement from a player");
			this.chkMe.UseVisualStyleBackColor = true;
			// 
			// chkList
			// 
			this.chkList.AutoSize = true;
			this.chkList.Location = new System.Drawing.Point(317, 42);
			this.chkList.Name = "chkList";
			this.chkList.Size = new System.Drawing.Size(42, 17);
			this.chkList.TabIndex = 22;
			this.chkList.Text = "List";
			this.toolTip1.SetToolTip(this.chkList, "Adds player to banlist.");
			this.chkList.UseVisualStyleBackColor = true;
			// 
			// chkKill
			// 
			this.chkKill.AutoSize = true;
			this.chkKill.Location = new System.Drawing.Point(317, 19);
			this.chkKill.Name = "chkKill";
			this.chkKill.Size = new System.Drawing.Size(39, 17);
			this.chkKill.TabIndex = 21;
			this.chkKill.Text = "Kill";
			this.toolTip1.SetToolTip(this.chkKill, "Gives or removes an achievement from a player");
			this.chkKill.UseVisualStyleBackColor = true;
			// 
			// chkKick
			// 
			this.chkKick.AutoSize = true;
			this.chkKick.Location = new System.Drawing.Point(231, 157);
			this.chkKick.Name = "chkKick";
			this.chkKick.Size = new System.Drawing.Size(47, 17);
			this.chkKick.TabIndex = 20;
			this.chkKick.Text = "Kick";
			this.toolTip1.SetToolTip(this.chkKick, "Gives or removes an achievement from a player");
			this.chkKick.UseVisualStyleBackColor = true;
			// 
			// chkHelp
			// 
			this.chkHelp.AutoSize = true;
			this.chkHelp.Location = new System.Drawing.Point(231, 134);
			this.chkHelp.Name = "chkHelp";
			this.chkHelp.Size = new System.Drawing.Size(48, 17);
			this.chkHelp.TabIndex = 19;
			this.chkHelp.Text = "Help";
			this.toolTip1.SetToolTip(this.chkHelp, "Gives or removes an achievement from a player");
			this.chkHelp.UseVisualStyleBackColor = true;
			// 
			// chkGive
			// 
			this.chkGive.AutoSize = true;
			this.chkGive.Location = new System.Drawing.Point(231, 111);
			this.chkGive.Name = "chkGive";
			this.chkGive.Size = new System.Drawing.Size(48, 17);
			this.chkGive.TabIndex = 18;
			this.chkGive.Text = "Give";
			this.toolTip1.SetToolTip(this.chkGive, "Gives or removes an achievement from a player");
			this.chkGive.UseVisualStyleBackColor = true;
			// 
			// chkGameRule
			// 
			this.chkGameRule.AutoSize = true;
			this.chkGameRule.Location = new System.Drawing.Point(231, 88);
			this.chkGameRule.Name = "chkGameRule";
			this.chkGameRule.Size = new System.Drawing.Size(71, 17);
			this.chkGameRule.TabIndex = 17;
			this.chkGameRule.Text = "Gamerule";
			this.toolTip1.SetToolTip(this.chkGameRule, "Gives or removes an achievement from a player");
			this.chkGameRule.UseVisualStyleBackColor = true;
			// 
			// chkGameMode
			// 
			this.chkGameMode.AutoSize = true;
			this.chkGameMode.Location = new System.Drawing.Point(231, 65);
			this.chkGameMode.Name = "chkGameMode";
			this.chkGameMode.Size = new System.Drawing.Size(80, 17);
			this.chkGameMode.TabIndex = 16;
			this.chkGameMode.Text = "Gamemode";
			this.toolTip1.SetToolTip(this.chkGameMode, "Gives or removes an achievement from a player");
			this.chkGameMode.UseVisualStyleBackColor = true;
			// 
			// chkFill
			// 
			this.chkFill.AutoSize = true;
			this.chkFill.Location = new System.Drawing.Point(231, 42);
			this.chkFill.Name = "chkFill";
			this.chkFill.Size = new System.Drawing.Size(38, 17);
			this.chkFill.TabIndex = 15;
			this.chkFill.Text = "Fill";
			this.toolTip1.SetToolTip(this.chkFill, "Adds player to banlist.");
			this.chkFill.UseVisualStyleBackColor = true;
			// 
			// chkExecute
			// 
			this.chkExecute.AutoSize = true;
			this.chkExecute.Location = new System.Drawing.Point(231, 19);
			this.chkExecute.Name = "chkExecute";
			this.chkExecute.Size = new System.Drawing.Size(65, 17);
			this.chkExecute.TabIndex = 14;
			this.chkExecute.Text = "Execute";
			this.toolTip1.SetToolTip(this.chkExecute, "Gives or removes an achievement from a player");
			this.chkExecute.UseVisualStyleBackColor = true;
			// 
			// chkEntityData
			// 
			this.chkEntityData.AutoSize = true;
			this.chkEntityData.Location = new System.Drawing.Point(113, 157);
			this.chkEntityData.Name = "chkEntityData";
			this.chkEntityData.Size = new System.Drawing.Size(73, 17);
			this.chkEntityData.TabIndex = 13;
			this.chkEntityData.Text = "Entitydata";
			this.toolTip1.SetToolTip(this.chkEntityData, "Gives or removes an achievement from a player");
			this.chkEntityData.UseVisualStyleBackColor = true;
			// 
			// chkEnchant
			// 
			this.chkEnchant.AutoSize = true;
			this.chkEnchant.Location = new System.Drawing.Point(113, 134);
			this.chkEnchant.Name = "chkEnchant";
			this.chkEnchant.Size = new System.Drawing.Size(66, 17);
			this.chkEnchant.TabIndex = 12;
			this.chkEnchant.Text = "Enchant";
			this.toolTip1.SetToolTip(this.chkEnchant, "Gives or removes an achievement from a player");
			this.chkEnchant.UseVisualStyleBackColor = true;
			// 
			// chkEffect
			// 
			this.chkEffect.AutoSize = true;
			this.chkEffect.Location = new System.Drawing.Point(113, 111);
			this.chkEffect.Name = "chkEffect";
			this.chkEffect.Size = new System.Drawing.Size(54, 17);
			this.chkEffect.TabIndex = 11;
			this.chkEffect.Text = "Effect";
			this.toolTip1.SetToolTip(this.chkEffect, "Gives or removes an achievement from a player");
			this.chkEffect.UseVisualStyleBackColor = true;
			// 
			// chkDifficulty
			// 
			this.chkDifficulty.AutoSize = true;
			this.chkDifficulty.Location = new System.Drawing.Point(113, 88);
			this.chkDifficulty.Name = "chkDifficulty";
			this.chkDifficulty.Size = new System.Drawing.Size(66, 17);
			this.chkDifficulty.TabIndex = 10;
			this.chkDifficulty.Text = "Difficulty";
			this.toolTip1.SetToolTip(this.chkDifficulty, "Gives or removes an achievement from a player");
			this.chkDifficulty.UseVisualStyleBackColor = true;
			// 
			// chkDeop
			// 
			this.chkDeop.AutoSize = true;
			this.chkDeop.Location = new System.Drawing.Point(113, 65);
			this.chkDeop.Name = "chkDeop";
			this.chkDeop.Size = new System.Drawing.Size(52, 17);
			this.chkDeop.TabIndex = 9;
			this.chkDeop.Text = "Deop";
			this.toolTip1.SetToolTip(this.chkDeop, "Gives or removes an achievement from a player");
			this.chkDeop.UseVisualStyleBackColor = true;
			// 
			// chkDefaultGameMode
			// 
			this.chkDefaultGameMode.AutoSize = true;
			this.chkDefaultGameMode.Location = new System.Drawing.Point(113, 42);
			this.chkDefaultGameMode.Name = "chkDefaultGameMode";
			this.chkDefaultGameMode.Size = new System.Drawing.Size(112, 17);
			this.chkDefaultGameMode.TabIndex = 8;
			this.chkDefaultGameMode.Text = "Defaultgamemode";
			this.toolTip1.SetToolTip(this.chkDefaultGameMode, "Adds player to banlist.");
			this.chkDefaultGameMode.UseVisualStyleBackColor = true;
			// 
			// chkDebug
			// 
			this.chkDebug.AutoSize = true;
			this.chkDebug.Location = new System.Drawing.Point(113, 19);
			this.chkDebug.Name = "chkDebug";
			this.chkDebug.Size = new System.Drawing.Size(58, 17);
			this.chkDebug.TabIndex = 7;
			this.chkDebug.Text = "Debug";
			this.toolTip1.SetToolTip(this.chkDebug, "Gives or removes an achievement from a player");
			this.chkDebug.UseVisualStyleBackColor = true;
			// 
			// chkClone
			// 
			this.chkClone.AutoSize = true;
			this.chkClone.Location = new System.Drawing.Point(19, 157);
			this.chkClone.Name = "chkClone";
			this.chkClone.Size = new System.Drawing.Size(53, 17);
			this.chkClone.TabIndex = 6;
			this.chkClone.Text = "Clone";
			this.toolTip1.SetToolTip(this.chkClone, "Gives or removes an achievement from a player");
			this.chkClone.UseVisualStyleBackColor = true;
			// 
			// chkClear
			// 
			this.chkClear.AutoSize = true;
			this.chkClear.Location = new System.Drawing.Point(19, 134);
			this.chkClear.Name = "chkClear";
			this.chkClear.Size = new System.Drawing.Size(50, 17);
			this.chkClear.TabIndex = 5;
			this.chkClear.Text = "Clear";
			this.toolTip1.SetToolTip(this.chkClear, "Gives or removes an achievement from a player");
			this.chkClear.UseVisualStyleBackColor = true;
			// 
			// chkBlockData
			// 
			this.chkBlockData.AutoSize = true;
			this.chkBlockData.Location = new System.Drawing.Point(19, 111);
			this.chkBlockData.Name = "chkBlockData";
			this.chkBlockData.Size = new System.Drawing.Size(74, 17);
			this.chkBlockData.TabIndex = 4;
			this.chkBlockData.Text = "Blockdata";
			this.toolTip1.SetToolTip(this.chkBlockData, "Gives or removes an achievement from a player");
			this.chkBlockData.UseVisualStyleBackColor = true;
			// 
			// chkBanList
			// 
			this.chkBanList.AutoSize = true;
			this.chkBanList.Location = new System.Drawing.Point(19, 88);
			this.chkBanList.Name = "chkBanList";
			this.chkBanList.Size = new System.Drawing.Size(57, 17);
			this.chkBanList.TabIndex = 3;
			this.chkBanList.Text = "Banlist";
			this.toolTip1.SetToolTip(this.chkBanList, "Gives or removes an achievement from a player");
			this.chkBanList.UseVisualStyleBackColor = true;
			// 
			// chkBanIP
			// 
			this.chkBanIP.AutoSize = true;
			this.chkBanIP.Location = new System.Drawing.Point(19, 65);
			this.chkBanIP.Name = "chkBanIP";
			this.chkBanIP.Size = new System.Drawing.Size(56, 17);
			this.chkBanIP.TabIndex = 2;
			this.chkBanIP.Text = "Ban-ip";
			this.toolTip1.SetToolTip(this.chkBanIP, "Gives or removes an achievement from a player");
			this.chkBanIP.UseVisualStyleBackColor = true;
			// 
			// chkBan
			// 
			this.chkBan.AutoSize = true;
			this.chkBan.Location = new System.Drawing.Point(19, 42);
			this.chkBan.Name = "chkBan";
			this.chkBan.Size = new System.Drawing.Size(45, 17);
			this.chkBan.TabIndex = 1;
			this.chkBan.Text = "Ban";
			this.toolTip1.SetToolTip(this.chkBan, "Adds player to banlist.");
			this.chkBan.UseVisualStyleBackColor = true;
			// 
			// chkAchievement
			// 
			this.chkAchievement.AutoSize = true;
			this.chkAchievement.Location = new System.Drawing.Point(19, 19);
			this.chkAchievement.Name = "chkAchievement";
			this.chkAchievement.Size = new System.Drawing.Size(88, 17);
			this.chkAchievement.TabIndex = 0;
			this.chkAchievement.Text = "Achievement";
			this.toolTip1.SetToolTip(this.chkAchievement, "Gives or removes an achievement from a player");
			this.chkAchievement.UseVisualStyleBackColor = true;
			// 
			// cboParent
			// 
			this.cboParent.Enabled = false;
			this.cboParent.FormattingEnabled = true;
			this.cboParent.Location = new System.Drawing.Point(84, 134);
			this.cboParent.Name = "cboParent";
			this.cboParent.Size = new System.Drawing.Size(195, 21);
			this.cboParent.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Parent:";
			// 
			// txtGroupName
			// 
			this.txtGroupName.Location = new System.Drawing.Point(84, 108);
			this.txtGroupName.Name = "txtGroupName";
			this.txtGroupName.ReadOnly = true;
			this.txtGroupName.Size = new System.Drawing.Size(195, 20);
			this.txtGroupName.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name:";
			// 
			// btnPlayers
			// 
			this.btnPlayers.Location = new System.Drawing.Point(447, 67);
			this.btnPlayers.Name = "btnPlayers";
			this.btnPlayers.Size = new System.Drawing.Size(75, 23);
			this.btnPlayers.TabIndex = 6;
			this.btnPlayers.Text = "Players";
			this.btnPlayers.UseVisualStyleBackColor = true;
			this.btnPlayers.Click += new System.EventHandler(this.BtnPlayersClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(366, 67);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.Location = new System.Drawing.Point(316, 164);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(94, 23);
			this.btnSaveChanges.TabIndex = 4;
			this.btnSaveChanges.Text = "Save changes";
			this.btnSaveChanges.UseVisualStyleBackColor = true;
			this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChangesClick);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(285, 67);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 3;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// cboGroup
			// 
			this.cboGroup.FormattingEnabled = true;
			this.cboGroup.Location = new System.Drawing.Point(84, 69);
			this.cboGroup.Name = "cboGroup";
			this.cboGroup.Size = new System.Drawing.Size(195, 21);
			this.cboGroup.TabIndex = 2;
			this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.CboGroupSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Active group:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(910, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 443);
			this.Controls.Add(this.tcContent);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JSONEdit for Minecraft";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tcContent.ResumeLayout(false);
			this.tpPermissions.ResumeLayout(false);
			this.tpPermissions.PerformLayout();
			this.grpPermissions.ResumeLayout(false);
			this.grpPermissions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
