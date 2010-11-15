/*
 * User: Axel
 * Date: 2010-11-14
 * Time: 22:06
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using glass.config;

namespace glass.config {
	public enum Difficulty {
			easy,
			normal,
			hard,
		};
	public struct UserList {
		public int id;
		public string name;
		public Bitmap picture;
		public int score;
		public Difficulty difficulty;
	};
	
	//application constants
	public static class app {
		public const string name="glass";
		public const double version=0.1;
		public static string confdir=Environment.GetEnvironmentVariable("APPDATA")+"\\"+name;
	}
	
	//yes, it is ugly but it works.. global configuration settings
	public static class Config {
		public static List<UserList> Users = new List<UserList>();
		public static List<PictureBox> UserFaces = new List<PictureBox>();
		
		public static void SaveConfig() {
			throw new NotImplementedException();
		}
		public static void SaveUser(int id) {
			UserList ul=Users[id];
			ul.picture.Save(app.confdir+"\\images\\"+Convert.ToString(ul.id)+".png");
			RegistryKey reg=Registry.CurrentUser.OpenSubKey("Software\\"+app.name,true);
			RegistryKey regUsers=reg.OpenSubKey("Users",true);
			RegistryKey u=regUsers.CreateSubKey(ul.id.ToString("000"));
			u.SetValue("id",ul.id);
			u.SetValue("image",Convert.ToString(ul.id)+".png");
			u.SetValue("name",ul.name);
			u.SetValue("difficulty",Convert.ToInt32(ul.difficulty));
			u.SetValue("score",ul.score);
			
		}
		public static void LoadConfig() {
			RegistryKey reg=Registry.CurrentUser.OpenSubKey("Software\\"+app.name,false);
			RegistryKey regUsers=reg.OpenSubKey("Users",false);
			foreach (string s in regUsers.GetSubKeyNames()) {
				RegistryKey u = regUsers.OpenSubKey(s);
				UserList temp = new UserList();
				temp.id=(int)u.GetValue("id",Users.Count);temp.picture=new Bitmap(app.confdir+"\\images\\"+(string)u.GetValue("image",u.Name+".png"));temp.score=(int)u.GetValue("score",0);temp.difficulty=(Difficulty)u.GetValue("difficulty",Difficulty.easy);temp.name=(string)u.GetValue("name","");
				Users.Insert(temp.id,temp);
			}
			
		}
	}
}