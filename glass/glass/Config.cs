/*
 * User: Axel
 * Date: 2010-11-14
 * Time: 22:06
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
		public Bitmap picture;
		public uint score;
		public Difficulty difficulty;
	};
	
	//application constants
	public static class app {
		public const string name="glass";
		public const double version=0.1;
	}
	
	//yes, it is ugly but it works.. global configuration settings
	public static class Config {
		public static List<UserList> Users = new List<UserList>();
		public static List<PictureBox> UserFaces = new List<PictureBox>();
		public static void SaveConfig(string filename="") {
			if(filename=="") {
				filename=Environment.GetEnvironmentVariable("APPDATA")+"\\"+app.name+"\\settings.ini";
			}
		}
		public static void LoadConfig(string filename="") {
			if(filename=="") {
				filename=Environment.GetEnvironmentVariable("APPDATA")+"\\"+app.name+"\\settings.ini";
			}
		}
	}
}
