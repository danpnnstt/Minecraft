/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/19/2015
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JSONEdit
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static string BASE_DIRECTORY = @"";
		private ServerPropertiesFile propertiesFile;
		private Dictionary<string, KeyValuePair<JSONGroupFile, string>> groups;
		private Dictionary<string, CheckBox> propertyBoxes;
		private Dictionary<string, TextBox> propertyTextfields;
		private Dictionary<string, CheckBox> permissionBoxes;
		private JSONUserFile whitelist;
		private JSONUserFile oplist;
		
		public MainForm()
		{
			InitializeComponent();
			Console.Error.WriteLine("Initialized Components.");
			Console.Error.Write("Attempting to initialize objects........");
			whitelist = new JSONUserFile();
			oplist = new JSONUserFile();
			propertiesFile = new ServerPropertiesFile();
			propertyTextfields = new Dictionary<string, TextBox>();
			propertyBoxes = new Dictionary<string, CheckBox>();
			cboParent.Items.Add("None");
			permissionBoxes = new Dictionary<string, CheckBox>();
			groups = new Dictionary<string, KeyValuePair<JSONGroupFile, string>>();
			Console.Error.WriteLine("done.");
			Console.Error.Write("Setting Tool Tips.....");
			SetToolTips();
			Console.Error.WriteLine("done.");
			Console.Error.Write("Setting CheckBox Groups......");
			SetCheckboxGroups();
			Console.Error.WriteLine("done.");
			Console.Error.Write("Loading groups........");
			LoadGroups();Console.Error.WriteLine("done.");
			Console.Error.Write("Loading properties......");
			LoadProperties();
			Console.Error.WriteLine("done.");
			Console.Error.Write("Validating groups.......");
			ValidateGroups();
			Console.Error.WriteLine("done.");
			Console.Error.Write("Loading user files....");
			LoadUserFiles();
			Console.Error.WriteLine("done.");
		}
		
		private void LoadUserFiles()
		{
			string path1 = BASE_DIRECTORY + "whitelist.json";
			string path2 = BASE_DIRECTORY + "ops.json";
			try
			{
				if(!File.Exists(path1))
				{
					throw new Exception(path1);
				}
				if(!File.Exists(path2))
				{
					throw new Exception(path2);
				}
				whitelist.ReadFile(path1);
				oplist.ReadFile(path2);
				FillOpUsersList();
				FillWhiteListUsers();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error: failed to load " + Path.GetFileName(ex.Message) + ".  Please ensure minecraft is properly installed and try again.  Fatal error code 0x00000002", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Dispose();
			}
		}
		
		private void FillOpUsersList()
		{
			lstOpUsers.Items.Clear();
			string[] uuid = oplist.UUID;
			string[] names = oplist.Name;
			int[] level = oplist.OpLevel;
			if(uuid == null) return;
			for(int idx = 0; idx < uuid.Length; idx++)
			{
				lstOpUsers.Items.Add(uuid[idx] + " : " + names[idx] + " : " + level[idx]);
			}
		}
		
		private void FillWhiteListUsers()
		{
			lstWhitelistUsers.Items.Clear();
			string[] uuid = whitelist.UUID;
			string[] names = whitelist.Name;
			if(uuid == null) return;
			for(int idx = 0; idx < uuid.Length; idx++)
			{
				lstWhitelistUsers.Items.Add(uuid[idx] + " : " + names[idx]);
			}
		}
		
		private void ValidateGroups()
		{
			try
			{
				string[] files = groups.Keys.ToArray<string>();
				foreach(string f in files)
				{
					string pg = groups[f].Key.ParentGroup;
					while(!string.IsNullOrWhiteSpace(pg))
					{
						if(!File.Exists(BASE_DIRECTORY + "servertools//permission//groups//" + pg + ".json"))
						{
							throw new FileNotFoundException();
						}
						pg = groups[pg].Key.ParentGroup;
					}
				}
			}
			catch
			{
				MessageBox.Show("Error: Failed to validate group paths.  Disabling permissions tab for system stability.", "Failed to verify group paths", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tcContent.TabPages.Remove(tpPermissions);
			}
		}
		
		private void LoadProperties()
		{
			try
			{
				string path = BASE_DIRECTORY + "server.properties";
				if(!File.Exists(path))
				{
					throw new Exception();
				}
				ServerPropertiesFile spf = new ServerPropertiesFile();
				if(!spf.ReadFile(path))
				{
					throw new Exception();
				}
				else
				{
					string[] textKeys = propertyTextfields.Keys.ToArray<string>();
					string[] chkKeys = propertyBoxes.Keys.ToArray<string>();
					foreach(string k in textKeys)
					{
						propertyTextfields[k].Text = spf[k];
					}
					foreach(string k in chkKeys)
					{
						if(string.IsNullOrWhiteSpace(spf[k].Trim()))
						{
							propertyBoxes[k].Checked = false;
						}
						else if(spf[k].Trim().ToLower() == "false")
						{
							propertyBoxes[k].Checked = false;
						}
						else
						{
							propertyBoxes[k].Checked = true;
						}
					}
					propertiesFile = spf;
				}
			}
			catch
			{
				MessageBox.Show("Error: cannot find 'server.properties' file.  Please verify minecraft is properly installed and re-execute this program.  Fatal error 0x00000001", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Dispose();
			}
		}
		
		private void LoadGroups()
		{
			try
			{
				string[] files = Directory.GetFiles(BASE_DIRECTORY + "servertools//permission//groups", "*.json", SearchOption.AllDirectories);
				foreach(string f in files)
				{
					if(JSONFile.GetFileType(f) == typeof(JSONGroupFile))
					{
						JSONGroupFile jgf = new JSONGroupFile();
						if(jgf.ReadFile(f) == true)
						{
							groups.Add(Path.GetFileNameWithoutExtension(f), new KeyValuePair<JSONGroupFile, string>(jgf, f));
							cboGroup.Items.Add(Path.GetFileNameWithoutExtension(f));
							cboParent.Items.Add(Path.GetFileNameWithoutExtension(f));
						}
					}
				}
			}
			catch
			{
				MessageBox.Show("Failed to load group files!  Disabling permissions tab....", "Error loading file", MessageBoxButtons.OK, MessageBoxIcon.Error);
				tcContent.TabPages.Remove(tpPermissions);
			}
		}
		
		private void SetToolTips()
		{
			toolTip1.SetToolTip(chkAchievement, "Gives or removes an achievement from a player.");
			toolTip1.SetToolTip(chkBan, "Adds player to banlist.");
			toolTip1.SetToolTip(chkBanIP, "Adds IP address to banlist.");
			toolTip1.SetToolTip(chkBanList, "Displays banlist.");
			toolTip1.SetToolTip(chkBlockData, "Modifies the data tag of a block.");
			toolTip1.SetToolTip(chkClear, "Clears items from player inventory.");
			toolTip1.SetToolTip(chkClone, "Copies blocks from one place to another.");
			toolTip1.SetToolTip(chkDebug, "Starts or stops a debugging session.");
			toolTip1.SetToolTip(chkDefaultGameMode, "Sets the default game mode.");
			toolTip1.SetToolTip(chkDeop, "Revoke operator status from a player.");
			toolTip1.SetToolTip(chkDifficulty, "Sets the difficulty level.");
			toolTip1.SetToolTip(chkEffect, "Add or remove status effects.");
			toolTip1.SetToolTip(chkEnchant, "Enchants a player item.");
			toolTip1.SetToolTip(chkEntityData, "Modifies the data tag of an entity.");
			toolTip1.SetToolTip(chkExecute, "Executes another command.");
			toolTip1.SetToolTip(chkFill, "Fills a region with a specific block.");
			toolTip1.SetToolTip(chkGameMode, "Sets a player's game mode.");
			toolTip1.SetToolTip(chkGameRule, "Sets or queries a game rule value.");
			toolTip1.SetToolTip(chkGive, "Gives an item to a player.");
			toolTip1.SetToolTip(chkHelp, "Provides help for commands.");
			toolTip1.SetToolTip(chkKick, "Kicks a player off a server.");
			toolTip1.SetToolTip(chkKill, "Kills entities (players, mobs, items, etc.).");
			toolTip1.SetToolTip(chkList, "Lists players on the server.");
			toolTip1.SetToolTip(chkMe, "Displays a message about yourself.");
			toolTip1.SetToolTip(chkOp, "Grants operator status to a player.");
			toolTip1.SetToolTip(chkPardon, "Removes entries from the banlist.");
			toolTip1.SetToolTip(chkParticle, "Creates particles.");
			toolTip1.SetToolTip(chkPlaySound, "Plays a sound.");
			toolTip1.SetToolTip(chkPublish, "Opens single-player world to local network.");
			toolTip1.SetToolTip(chkReplaceItem, "Replaces items in inventories.");
			toolTip1.SetToolTip(chkSaveAll, "Saves the server to disk.");
			toolTip1.SetToolTip(chkSaveOff, "Disables automatic server saves.");
			toolTip1.SetToolTip(chkSaveOn, "Enables automatic server saves.");
			toolTip1.SetToolTip(chkSay, "Displays a message to multiple players.");
			toolTip1.SetToolTip(chkScoreBoard, "Manages objectives, players, and teams.");
			toolTip1.SetToolTip(chkSeed, "Displays the world seed.");
			toolTip1.SetToolTip(chkSetBlock, "Changes a block to another block.");
			toolTip1.SetToolTip(chkSetIdleTimeout, "Sets the time before idle players are kicked.");
			toolTip1.SetToolTip(chkSetWorldSpawn, "Sets the world spawn.");
			toolTip1.SetToolTip(chkSpawnPoint, "Sets the spawn point for a player.");
			toolTip1.SetToolTip(chkSpreadPlayers, "Teleports entities to random locations.");
			toolTip1.SetToolTip(chkStats, "Update objectives from command results.");
			toolTip1.SetToolTip(chkStop, "Stops a server.");
			toolTip1.SetToolTip(chkSummon, "Summons an entity.");
			toolTip1.SetToolTip(chkTell, "Displays a private message to other players.");
			toolTip1.SetToolTip(chkTellRaw, "Displays a JSON message to players.");
			toolTip1.SetToolTip(chkTestFor, "Counts entities matching specified conditions.");
			toolTip1.SetToolTip(chkTestForBlock, "Tests whether a block is in a location.");
			toolTip1.SetToolTip(chkTestForBlocks, "Tests whether the blocks in two regions match.");
			toolTip1.SetToolTip(chkTime, "Changes or queries the world's game time.");
			toolTip1.SetToolTip(chkTitle, "Manages screen titles.");
			toolTip1.SetToolTip(chkToggleDownfall, "Toggles the weather.");
			toolTip1.SetToolTip(chkTp, "Teleports entities.");
			toolTip1.SetToolTip(chkTrigger, "Sets a trigger to be activated.");
			toolTip1.SetToolTip(chkWeather, "Sets the weather.");
			toolTip1.SetToolTip(chkWhiteList, "Manages server whitelist.");
			toolTip1.SetToolTip(chkWorldBorder, "Manages the world border.");
			toolTip1.SetToolTip(chkXp, "Adds or removes player experience.");
		}
		
		private void SetCheckboxGroups()
		{
			#region
			propertyBoxes.Add("allow-flight", chkAllowFlight);
			propertyBoxes.Add("allow-nether", chkAllowNether);
			propertyBoxes.Add("announce-player-achievements", chkAnnouncePlayerAchievements);
			propertyBoxes.Add("enable-command-block", chkEnableCommandBlock);
			propertyBoxes.Add("enable-query", chkEnableQuery);
			propertyBoxes.Add("enable-rcon", chkEnableRCON);
			propertyBoxes.Add("force-gamemode", chkForceGamemode);
			propertyBoxes.Add("generate-structures", chkGenerateStructures);
			propertyBoxes.Add("hardcore", chkHardcore);
			propertyBoxes.Add("online-mode", chkOnlineMode);
			propertyBoxes.Add("pvp", chkPVP);
			propertyBoxes.Add("snooper-enabled", chkSnooperEnabled);
			propertyBoxes.Add("spawn-animals", chkSpawnAnimals);
			propertyBoxes.Add("spawn-monsters", chkSpawnMonsters);
			propertyBoxes.Add("spawn-npcs", chkSpawnNPCs);
			propertyBoxes.Add("white-list", chkWhiteListEnable);
			propertyTextfields.Add("difficulty", txtDifficulty);
			propertyTextfields.Add("gamemode", txtGamemode);
			propertyTextfields.Add("generator-settings", txtGeneratorSettings);
			propertyTextfields.Add("level-name", txtLevelName);
			propertyTextfields.Add("level-seed", txtLevelSeed);
			propertyTextfields.Add("level-type", txtLevelType);
			propertyTextfields.Add("max-build-height", txtMaxBuildHeight);
			propertyTextfields.Add("max-players", txtMaxPlayers);
			propertyTextfields.Add("motd", txtMOTD);
			propertyTextfields.Add("op-permission-level", txtOpPermissionLevel);
			propertyTextfields.Add("player-idle-timeout", txtPlayerIdleTimeout);
			propertyTextfields.Add("resource-pack", txtResourcePack);
			propertyTextfields.Add("server-ip", txtServerIP);
			propertyTextfields.Add("server-port", txtServerPort);
			propertyTextfields.Add("view-distance", txtViewDistance);
			#endregion
			permissionBoxes.Add("achievement", chkAchievement);
			permissionBoxes.Add("ban", chkBan);
			permissionBoxes.Add("banip", chkBanIP);
			permissionBoxes.Add("banlist", chkBanList);
			permissionBoxes.Add("blockdata", chkBlockData);
			permissionBoxes.Add("clear", chkClear);
			permissionBoxes.Add("clone", chkClone);
			permissionBoxes.Add("debug", chkDebug);
			permissionBoxes.Add("defaultgamemode", chkDefaultGameMode);
			permissionBoxes.Add("deop", chkDeop);
			permissionBoxes.Add("difficulty", chkDifficulty);
			permissionBoxes.Add("effect", chkEffect);
			permissionBoxes.Add("enchant", chkEnchant);
			permissionBoxes.Add("entitydata", chkEntityData);
			permissionBoxes.Add("execute", chkExecute);
			permissionBoxes.Add("fill", chkFill);
			permissionBoxes.Add("gamemode", chkGameMode);
			permissionBoxes.Add("gamerule", chkGameRule);
			permissionBoxes.Add("give", chkGive);
			permissionBoxes.Add("help", chkHelp);
			permissionBoxes.Add("kick", chkKick);
			permissionBoxes.Add("kill", chkKill);
			permissionBoxes.Add("list", chkList);
			permissionBoxes.Add("me", chkMe);
			permissionBoxes.Add("op", chkOp);
			permissionBoxes.Add("pardon", chkPardon);
			permissionBoxes.Add("particle", chkParticle);
			permissionBoxes.Add("playsound", chkPlaySound);
			permissionBoxes.Add("publish", chkPublish);
			permissionBoxes.Add("replaceitem", chkReplaceItem);
			permissionBoxes.Add("saveall", chkSaveAll);
			permissionBoxes.Add("saveoff", chkSaveOff);
			permissionBoxes.Add("saveon", chkSaveOn);
			permissionBoxes.Add("say", chkSay);
			permissionBoxes.Add("scoreboard", chkScoreBoard);
			permissionBoxes.Add("seed", chkSeed);
			permissionBoxes.Add("setblock", chkSetBlock);
			permissionBoxes.Add("setidletimeout", chkSetIdleTimeout);
			permissionBoxes.Add("setworldspawn", chkSetWorldSpawn);
			permissionBoxes.Add("spawnpoint", chkSpawnPoint);
			permissionBoxes.Add("spreadplayers", chkSpreadPlayers);
			permissionBoxes.Add("stats", chkStats);
			permissionBoxes.Add("stop", chkStop);
			permissionBoxes.Add("summon", chkSummon);
			permissionBoxes.Add("tell", chkTell);
			permissionBoxes.Add("tellraw", chkTellRaw);
			permissionBoxes.Add("testfor", chkTestFor);
			permissionBoxes.Add("testforblock", chkTestForBlock);
			permissionBoxes.Add("testforblocks", chkTestForBlocks);
			permissionBoxes.Add("time", chkTime);
			permissionBoxes.Add("title", chkTitle);
			permissionBoxes.Add("toggledownfall", chkToggleDownfall);
			permissionBoxes.Add("tp", chkTp);
			permissionBoxes.Add("trigger", chkTrigger);
			permissionBoxes.Add("weather", chkWeather);
			permissionBoxes.Add("whitelist", chkWhiteList);
			permissionBoxes.Add("worldborder", chkWorldBorder);
			permissionBoxes.Add("xp", chkXp);
		}
		
		private void SetPermissions(bool value)
		{
			string[] boxes = permissionBoxes.Keys.ToArray<string>();
			foreach(string b in boxes)
			{
				permissionBoxes[b].Checked = value;
				permissionBoxes[b].Enabled = true;
			}
		}
		
		private void SetPermissions(string[] permissions, JSONGroupFile parent)
		{
			SetPermissions(false);
			foreach(string p in permissions)
			{
				permissionBoxes[p].Checked = true;
			}
			while(parent != null)
			{
				string[] perms = parent.GetPermissions();
				if(perms != null)
				{
					foreach(string p in perms)
					{
						permissionBoxes[p].Checked = true;
						permissionBoxes[p].Enabled = false; //shows this is an inherited permission and cannot be revoked
					}
				}
				string name = parent.ParentGroup;
				parent = null;
				GC.Collect();
				if(!string.IsNullOrWhiteSpace(name))
				{
					parent = groups[name].Key;
				}
			}
		}
		
		void BtnCreateClick(object sender, EventArgs e)
		{
			KeyValuePair<JSONGroupFile, string>[] arr = groups.Values.ToArray<KeyValuePair<JSONGroupFile, string>>();
			List<JSONGroupFile> arr2 = new List<JSONGroupFile>();
			for(int idx = 0; idx < arr.Length; idx++)
			{
				arr2.Add(arr[idx].Key);
			}
			GroupForm gf = new GroupForm(arr2.ToArray());
			gf.ShowDialog();
			if(gf.GroupName == null) return;
			JSONGroupFile parent = null;
			if(gf.ParentGroup != null)
			{
				if(gf.ParentGroup.Length > 0)
				{
					parent = groups[gf.ParentGroup].Key;
				}
			}
			JSONGroupFile jgf = JSONGroupFile.CreateFile(gf.GroupName, parent);
			groups.Add(jgf.GroupName, new KeyValuePair<JSONGroupFile, string>(jgf, BASE_DIRECTORY + "servertools\\permission\\groups\\" + jgf.GroupName + ".json"));
			cboGroup.Items.Add(jgf.GroupName);
			cboParent.Items.Add(jgf.GroupName);
			jgf.SaveFile(groups[jgf.GroupName].Value);
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			string key = cboGroup.SelectedItem.ToString();
			File.Delete(groups[key].Value);
			groups.Remove(key);
			cboGroup.Items.Remove(key);
			cboParent.Items.Remove(key);
		}
		
		void BtnPlayersClick(object sender, EventArgs e)
		{
			string key = cboGroup.SelectedItem.ToString();
			PlayerForm pf = new PlayerForm(groups[key].Key);
			pf.ShowDialog();
			if(pf.MemberList == null)
			{
				groups[key].Key.RebuildMembers(new string[] {});
			}
			else
			{
				groups[key].Key.RebuildMembers(pf.MemberList);
			}
		}
		
		void BtnSaveChangesClick(object sender, EventArgs e)
		{
			string key = cboGroup.SelectedItem.ToString();
			string[] prms = permissionBoxes.Keys.ToArray<string>();
			Dictionary<string, bool> dict = new Dictionary<string, bool>();
			foreach(string p in prms)
			{
				dict.Add(p, permissionBoxes[p].Checked);
			}
			groups[key].Key.RebuildPermissions(dict);
			groups[key].Key.SaveFile(groups[key].Value);
		}
		
		void BtnGrantAllClick(object sender, EventArgs e)
		{
			SetPermissions(true);
		}
		
		void BtnRemoveAllClick(object sender, EventArgs e)
		{
			SetPermissions(false);
		}
		
		void CboGroupSelectedIndexChanged(object sender, EventArgs e)
		{
			string key = cboGroup.SelectedItem.ToString();
			txtGroupName.Text = groups[key].Key.GroupName;
			string[] permissions = groups[key].Key.GetPermissions();
			string parentName = groups[key].Key.ParentGroup;
			JSONGroupFile parent = null;
			cboParent.SelectedIndex = 0;
			if(parentName != null)
			{
				if(parentName.Trim() != "")
				{
					cboParent.SelectedItem = parentName;
					parent = groups[parentName].Key;
				}
			}
			if(permissions != null)
			{
				SetPermissions(permissions, parent);
			}
			else
			{
				SetPermissions(false);
			}
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			string[] gps = groups.Keys.ToArray<string>();
			foreach(string g in gps)
			{
				groups[g].Key.SaveFile(groups[g].Value);
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void BtnReloadFileClick(object sender, EventArgs e)
		{
			LoadProperties();
		}
		
		void BtnSaveFileClick(object sender, EventArgs e)
		{
			string[] keysT = propertyTextfields.Keys.ToArray<string>();
			string[] keysC = propertyBoxes.Keys.ToArray<string>();
			foreach(string k in keysT)
			{
				propertiesFile[k] = propertyTextfields[k].Text;
			}
			foreach(string k in keysC)
			{
				propertiesFile[k] = propertyBoxes[k].Checked.ToString().ToLower();
			}
			propertiesFile.SaveFile(BASE_DIRECTORY + "server.properties");
		}
		
		void BtnAddOpUserClick(object sender, EventArgs e)
		{
			PlayerForm pf = new PlayerForm(oplist);
			List<string> mems = new List<string>();
			if(oplist.UUID != null) mems.AddRange(oplist.UUID);
			pf.ShowDialog();
			List<string> new_mems = new List<string>();
			new_mems.AddRange(pf.MemberList);
			foreach(string m in mems)
			{
				if(new_mems.Contains(m))
				{
					new_mems.Remove(m);
				}
			}
			foreach(string m in new_mems)
			{
				string uuid = m;
				string uri = "https://api.mojang.com/user/profiles/" + uuid.Replace("-", "") + "/names";
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create (uri);
				request.MaximumAutomaticRedirections = 4;
            	request.MaximumResponseHeadersLength = 4;
            	HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            	Stream receive = response.GetResponseStream();
            	StreamReader read = new StreamReader(receive);
            	string json = read.ReadToEnd();
            	json = json.Replace("{", "").Replace("}", "").Replace("\"", "").Replace("[", "").Replace("]", "");
            	string[] elements = json.Split(',');
            	string username = elements[0].Split(':')[1].Trim();
            	oplist.AddPlayer(uuid, username, 4);
			}
			FillOpUsersList();
			oplist.SaveFile(BASE_DIRECTORY + "ops.json");
		}
		
		void BtnEditOpUserClick(object sender, EventArgs e)
		{
			int idx = lstOpUsers.SelectedIndex;
			if(idx < 0) return;
			string item = lstOpUsers.Items[idx].ToString();
			FillOpUsersList();
			oplist.SaveFile(BASE_DIRECTORY + "ops.json");
		}
		
		void BtnDeleteOpUserClick(object sender, EventArgs e)
		{
			int idx = lstOpUsers.SelectedIndex;
			if(idx < 0) return;
			string item = lstOpUsers.Items[idx].ToString();
			bool removed = oplist.RemovePlayer(item.Replace(" : ", "|").Split('|')[0]);
			if(removed)
			{
				MessageBox.Show("User removed successfully from OP list.", "Remove from OP list", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Failed to remove user from the OP list.", "Remove from OP list", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			FillOpUsersList();
			oplist.SaveFile(BASE_DIRECTORY + "ops.json");
		}
		
		void BtnAddWhitelistUserClick(object sender, EventArgs e)
		{
			PlayerForm pf = new PlayerForm(whitelist);
			List<string> mems = new List<string>();
			if(whitelist.UUID != null) mems.AddRange(whitelist.UUID);
			pf.ShowDialog();
			List<string> new_mems = new List<string>();
			new_mems.AddRange(pf.MemberList);
			foreach(string m in mems)
			{
				if(new_mems.Contains(m))
				{
					new_mems.Remove(m);
				}
			}
			foreach(string m in new_mems)
			{
				string uuid = m;
				string uri = "https://api.mojang.com/user/profiles/" + uuid.Replace("-", "") + "/names";
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create (uri);
				request.MaximumAutomaticRedirections = 4;
            	request.MaximumResponseHeadersLength = 4;
            	HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            	Stream receive = response.GetResponseStream();
            	StreamReader read = new StreamReader(receive);
            	string json = read.ReadToEnd();
            	json = json.Replace("{", "").Replace("}", "").Replace("\"", "").Replace("[", "").Replace("]", "");
            	string[] elements = json.Split(',');
            	string username = elements[0].Split(':')[1].Trim();
            	whitelist.AddPlayer(uuid, username);
			}
			FillWhiteListUsers();
			whitelist.SaveFile(BASE_DIRECTORY + "whitelist.json");
		}
		
		void BtnDeleteWhitelistUserClick(object sender, EventArgs e)
		{
			int idx = lstWhitelistUsers.SelectedIndex;
			if(idx < 0) return;
			string item = lstWhitelistUsers.Items[idx].ToString();
			bool removed = whitelist.RemovePlayer(item.Replace(" : ", "|").Split('|')[0]);
			if(removed)
			{
				MessageBox.Show("User removed successfully from whitelist.", "Remove from whitelist", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Failed to remove user from the whitelist.", "Remove from whitelist", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			FillWhiteListUsers();
			whitelist.SaveFile(BASE_DIRECTORY + "whitelist.json");
		}
		
		private void BtnReloadPermissionsClick(object sender, EventArgs e)
		{
			int idx = cboGroup.SelectedIndex;
			cboGroup.Items.Clear();
			cboParent.Items.Clear();
			cboParent.Items.Add("None");
			SetPermissions(false);
			groups.Clear();
			LoadGroups();
			ValidateGroups();
			if(idx >= 0) cboGroup.SelectedIndex = idx;
		}
	}
}
