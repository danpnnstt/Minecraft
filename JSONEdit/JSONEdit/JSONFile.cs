/*
 * Created by SharpDevelop.
 * User: dhartenbach
 * Date: 3/19/2015
 * Time: 1:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace JSONEdit
{
	/// <summary>
	/// Description of JSONFile.
	/// </summary>
	[Serializable]
	public class JSONFile : ISerializable
	{
		protected JSONFile()
		{
			
		}
		
		public static Type GetFileType(string fileName)
		{
			if(Path.GetDirectoryName(fileName).EndsWith("groups"))
			{
				return typeof(JSONGroupFile);
			}
			else if(Path.GetFileName(fileName) == "server.properties")
			{
				return typeof(ServerPropertiesFile);
			}
			else
			{
				return typeof(JSONFile);
			}
		}
		
		public virtual bool ReadFile(string filePath) { return false; }
		public virtual bool SaveFile(string filePath) { return false; }
		[SecurityPermission(SecurityAction.LinkDemand,
            Flags = SecurityPermissionFlag.SerializationFormatter)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	}
	
	public class ServerPropertiesFile
	{
		private Dictionary<string, string> properties;
		private string timestamp;

		public string this[string key]
		{
			get { return properties[key]; }
			set { properties[key] = value; }
		}

		public string[] PropertyList
		{
			get { return properties.Keys.ToArray<string>(); }
		}

		public ServerPropertiesFile()
		{
			timestamp = "";
			properties = new Dictionary<string, string>();
			FillDictionary();
		}

		private void FillDictionary()
		{
			properties.Clear();
			properties.Add("generator-settings", "");
			properties.Add("op-permission-level", "");
			properties.Add("allow-nether", "");
			properties.Add("level-name", "");
			properties.Add("enable-query", "");
			properties.Add("allow-flight", "");
			properties.Add("announce-player-achievements", "");
			properties.Add("server-port", "");
			properties.Add("level-type", "");
			properties.Add("enable-rcon", "");
			properties.Add("force-gamemode", "");
			properties.Add("level-seed", "");
			properties.Add("server-ip", "");
			properties.Add("spawn-npcs", "");
			properties.Add("white-list", "");
			properties.Add("spawn-animals", "");
			properties.Add("snooper-enabled", "");
			properties.Add("hardcore", "false");
			properties.Add("online-mode", "");
			properties.Add("resource-pack", "");
			properties.Add("pvp", "");
			properties.Add("difficulty", "");
			properties.Add("enable-command-block", "");
			properties.Add("player-idle-timeout", "");
			properties.Add("gamemode", "");
			properties.Add("max-players", "");
			properties.Add("spawn-monsters", "");
			properties.Add("view-distance", "");
			properties.Add("generate-structures", "");
			properties.Add("motd", "");
		}
		
		public bool ReadFile(string filePath)
		{
			try 
			{
				FillDictionary();
				using(FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					using(StreamReader reader = new StreamReader(stream))
					{
						reader.ReadLine();
						timestamp = reader.ReadLine();
						while(!reader.EndOfStream)
						{
							string line = reader.ReadLine();
							string key = line.Split('=')[0];
							string value = line.Split('=')[1];
							properties[key] = value;
						}
					}
				}
				return true;
			} 
			catch (System.Exception e) 
			{
				return false;
			} 
			finally 
			{
				
			}
		}
		
		public bool SaveFile(string filePath)
		{
			try 
			{
				using(FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
				{
					using(StreamWriter writer = new StreamWriter(stream))
					{
						writer.WriteLine("#Minecraft server properties");
						writer.WriteLine(timestamp);
						string[] keys = properties.Keys.ToArray<string>();
						foreach(string key in keys)
						{
							string value = properties[key];
							writer.WriteLine(key + "=" + value);
						}
					}
				}
				return true;
			} 
			catch (System.Exception e) 
			{
				return false;
			}
			finally 
			{
				
			}
		}
	}
	
	public class JSONGroupFile : JSONFile
	{
		private string groupName;
		private string parentGroup;
		private string chatColor;
		private string[] members;
		private string[] perms;
		
		public string GroupName
		{
			get { return groupName; }
			set { groupName = value; }
		}
		
		public string ParentGroup
		{
			get { return parentGroup; }
			set { parentGroup = value; }
		}
		
		public string ChatColor
		{
			get { return chatColor; }
			set { chatColor = value; }
		}
		
		public string[] GetMembers()
		{
			if(members == null) return null;
			return members;
		}
		
		public void RebuildMembers(string[] mems)
		{
			members = null;
			GC.Collect();
			members = new string[mems.Length];
			Array.Copy(mems, members, mems.Length);
		}
		
		public void RebuildPermissions(Dictionary<string, bool> dict)
		{
			perms = null;
			GC.Collect();
			List<string> list = new List<string>();
			string[] keys = dict.Keys.ToArray<string>();
			foreach(string k in keys)
			{
				if(dict[k])
				{
					list.Add(k);
				}
			}
			perms = list.ToArray();
		}
		
		public string[] GetPermissions()
		{
			if(perms == null) return null;
			List<string> list = new List<string>();
			foreach(string s in perms)
			{
				if(s == "*")
				{
					#region
					list.Add("achievement");
					list.Add("ban");
					list.Add("banip");
					list.Add("banlist");
					list.Add("blockdata");
					list.Add("clear");
					list.Add("clone");
					list.Add("debug");
					list.Add("defaultgamemode");
					list.Add("deop");
					list.Add("difficulty");
					list.Add("effect");
					list.Add("enchant");
					list.Add("entitydata");
					list.Add("execute");
					list.Add("fill");
					list.Add("gamemode");
					list.Add("gamerule");
					list.Add("give");
					list.Add("help");
					list.Add("kick");
					list.Add("kill");
					list.Add("list");
					list.Add("me");
					list.Add("op");
					list.Add("pardon");
					list.Add("particle");
					list.Add("playsound");
					list.Add("publish");
					list.Add("replaceitem");
					list.Add("saveall");
					list.Add("saveoff");
					list.Add("saveon");
					list.Add("say");
					list.Add("scoreboard");
					list.Add("seed");
					list.Add("setblock");
					list.Add("setidletimeout");
					list.Add("setworldspawn");
					list.Add("spawnpoint");
					list.Add("spreadplayers");
					list.Add("stats");
					list.Add("stop");
					list.Add("summon");
					list.Add("tell");
					list.Add("tellraw");
					list.Add("testfor");
					list.Add("testforblock");
					list.Add("testforblocks");
					list.Add("time");
					list.Add("title");
					list.Add("toggledownfall");
					list.Add("tp");
					list.Add("trigger");
					list.Add("weather");
					list.Add("whitelist");
					list.Add("worldborder");
					list.Add("xp");
					#endregion
					break;
				}
				else
				{
					list.Add(s);
				}
			}
			return list.ToArray();
		}
		
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if(info == null) throw new System.ArgumentNullException("info");
			info.AddValue("groupName", groupName, typeof(string));
			info.AddValue("parentGroup", parentGroup, typeof(string));
			info.AddValue("chatColor", chatColor, typeof(string));
			info.AddValue("members", members, typeof(string[]));
			info.AddValue("perms", perms, typeof(string[]));
		}
		
		public JSONGroupFile()
		{
			members = perms = null;
			groupName = parentGroup = chatColor = "";
		}
		
		private JSONGroupFile(SerializationInfo info, StreamingContext context)
		{
			members = perms = null;
			groupName = parentGroup = chatColor = "";
			if(info != null)
			{
				try
				{
					groupName = (string)info.GetValue("groupName", typeof(string));
				}
				catch 
				{
					groupName = "";
				}
				try
				{
					parentGroup = (string)info.GetValue("parentGroup", typeof(string));
				}
				catch
				{
					parentGroup = "";
				}
				try
				{
					chatColor = (string)info.GetValue("chatColor", typeof(string));
				}
				catch
				{
					chatColor = "";
				}
				string[] arr1 = (string[])info.GetValue("members", typeof(string[]));
				string[] arr2 = (string[])info.GetValue("perms", typeof(string[]));
				if(arr1.Length > 0)
				{
					this.members = new string[arr1.Length];
					Array.Copy(arr1, this.members, this.members.Length);
				}
				if(arr2.Length > 0)
				{
					this.perms = new string[arr2.Length];
					Array.Copy(arr2, this.perms, this.perms.Length);
				}
			}
		}
		
		public static JSONGroupFile CreateFile(string name, JSONGroupFile parent)
		{
			JSONGroupFile file = new JSONGroupFile();
			file.groupName = name;
			file.chatColor = "white";
			string filePath = MainForm.BASE_DIRECTORY + name + ".json";
			if(parent != null)
			{
				file.parentGroup = parent.groupName;
			}
			return file;
		}
		
		public override bool ReadFile(string filePath)
		{
			try
			{
				string line = "";
				using(FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
				{
					using(StreamReader reader = new StreamReader(stream))
					{
						while(!reader.EndOfStream)
						{
							line += reader.ReadLine();
						}
					}
				}
				JSONGroupFile jgf = JsonConvert.DeserializeObject<JSONGroupFile>(line);
				this.groupName = jgf.groupName;
				this.parentGroup = jgf.parentGroup;
				this.chatColor = jgf.chatColor;
				if(jgf.members != null)
				{
					if(jgf.members.Length > 0)
					{
						this.members = new string[jgf.members.Length];
						Array.Copy(jgf.members, this.members, this.members.Length);
					}
				}
				if(jgf.perms != null)
				{
					if(jgf.perms.Length > 0)
					{
						this.perms = new string[jgf.perms.Length];
						Array.Copy(jgf.perms, this.perms, this.perms.Length);
					}
				}
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
		
		public override bool SaveFile(string filePath)
		{
			try
			{
				if(members == null)
				{
					members = new string[]{};
				}
				if(perms == null)
				{
					perms = new string[]{};
				}
				string json = JsonConvert.SerializeObject(this);
				Console.WriteLine(json);
				using(FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
				{
					using(StreamWriter writer = new StreamWriter(stream))
					{
						writer.Write(json);
					}
				}
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
		}
	}
}
