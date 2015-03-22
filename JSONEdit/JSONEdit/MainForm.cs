/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/19/2015
 * Time: 8:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
		private Dictionary<string, KeyValuePair<JSONGroupFile, string>> groups;
		private Dictionary<string, CheckBox> permissionBoxes;
		
		public MainForm()
		{
			InitializeComponent();
			cboParent.Items.Add("None");
			permissionBoxes = new Dictionary<string, CheckBox>();
			groups = new Dictionary<string, KeyValuePair<JSONGroupFile, string>>();
			SetToolTips();
			SetCheckboxGroups();
			LoadGroups();
		}
		
		private void LoadGroups()
		{
			string[] files = Directory.GetFiles(BASE_DIRECTORY, "*.json", SearchOption.AllDirectories);
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
	}
}
