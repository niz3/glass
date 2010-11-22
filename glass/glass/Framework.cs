/*
 * User: Axel
 * Date: 2010-11-14
 * Time: 22:06
 * 
 * Framework for saving config and drawing transparent graphics (*sigh*)
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using glass.config;
using System.Drawing.Drawing2D;

namespace glass.framework {
	public class DrawableItems {
		public delegate void ItemEventHandler(DrawableItems sender,EventArgs e);
		public delegate void ItemMouseEventHandler(DrawableItems sender, MouseEventArgs e);
		private Rectangle bounds;
		private Bitmap image;
		private DrawArea parent;
		#region Properties
		public DrawArea Parent {
			get {return(parent);}
			set {parent=value;}
		}
		public Bitmap Image {
			get {return(image);}
			set {image=value;}
		}
		public Rectangle Bounds {
			get {return(bounds);}
			set {bounds=value;}
		}
		#endregion
		public event ItemEventHandler MouseEnter;
		public event ItemEventHandler MouseLeave;
		public event ItemMouseEventHandler MouseDown;
		public event ItemMouseEventHandler MouseUp;
		public event ItemMouseEventHandler MouseMove;
		#region Overloads
		public DrawableItems() {
			MouseMove+= new ItemMouseEventHandler(stubMouseEvent);
			MouseUp+= new ItemMouseEventHandler(stubMouseEvent);
			MouseDown+= new ItemMouseEventHandler(stubMouseEvent);
			MouseEnter+= new ItemEventHandler(stubEvent);
			MouseLeave+=new ItemEventHandler(stubEvent);
		}
		public DrawableItems(Bitmap img, Rectangle bnd) {
			MouseMove+= new ItemMouseEventHandler(stubMouseEvent);
			MouseUp+= new ItemMouseEventHandler(stubMouseEvent);
			MouseDown+= new ItemMouseEventHandler(stubMouseEvent);
			MouseEnter+= new ItemEventHandler(stubEvent);
			MouseLeave+=new ItemEventHandler(stubEvent);
			this.Image=img;
			this.bounds=bnd;
		}
		#endregion
		#region stubs
		private void stubEvent(DrawableItems sender, EventArgs e) {
		}
		private void stubMouseEvent(DrawableItems sender, MouseEventArgs e) {
		}
		#endregion
		#region EventRaisers
		public void RaiseMouseMove(object sender, MouseEventArgs e) {
			MouseMove.Invoke(this, e);
		}
		public void RaiseMouseUp(object sender, MouseEventArgs e) {
			MouseUp.Invoke(this, e);
		}
		public void RaiseMouseDown(object sender, MouseEventArgs e) {
			MouseDown.Invoke(this, e);
		}
		public void RaiseMouseEnter(object sender, EventArgs e) {
			MouseEnter.Invoke(this, e);
		}
		public void RaiseMouseLeave(object sender, EventArgs e) {
			MouseLeave.Invoke(this, e);
		}
		#endregion
	}
	//Let's handle transparency ourselves.. .NET sucks.
	public class DrawArea:Panel {
		//drawing area
	    protected Graphics g;
	    private Point mousePrevious=new Point(0,0);
	    public List<DrawableItems> Items=new List<DrawableItems>();
	    
	    //setting bits for transparency
	    protected override CreateParams CreateParams {
	        get {
	            CreateParams p = base.CreateParams;
	            p.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT 
	            return(p);
	        }
	    }
	    public DrawArea() {
	    	this.MouseMove+= new MouseEventHandler(stubMouseMove);
	    	this.MouseUp+= new MouseEventHandler(stubMouseUp);
	    	this.MouseDown+= new MouseEventHandler(stubMouseDown);
	    }
	    #region MouseStubs
	    private void stubMouseMove(object sender,MouseEventArgs e) {
	    	EventArgs ee=new EventArgs();
	    	foreach (DrawableItems item in Items) {
	    		if(item.Bounds.Contains(new Point(e.X,e.Y))) {
	    			MouseEventArgs me=new MouseEventArgs(e.Button,e.Clicks,e.X-item.Bounds.X,e.Y-item.Bounds.Y,e.Delta);
	    			item.RaiseMouseMove(sender,me);
	    			if(!item.Bounds.Contains(mousePrevious)) {
	    				item.RaiseMouseEnter(sender,ee);
	    			}
	    			break;
	    		}
	    		else {
	    			if(item.Bounds.Contains(mousePrevious)) {
	    				item.RaiseMouseLeave(sender,ee);
	    			}
	    		}
	    	}
	    	mousePrevious=new Point(e.X,e.Y);
	    }
	    private void stubMouseUp(object sender,MouseEventArgs e) {
	    	foreach (DrawableItems item in Items) {
	    		if(item.Bounds.Contains(new Point(e.X,e.Y))) {
	    			MouseEventArgs me=new MouseEventArgs(e.Button,e.Clicks,e.X-item.Bounds.X,e.Y-item.Bounds.Y,e.Delta);
	    			item.RaiseMouseUp(sender,me);
	    			break;
	    		}
	    	}
	    }
	    private void stubMouseDown(object sender,MouseEventArgs e) {
	    	foreach (DrawableItems item in Items) {
	    		if(item.Bounds.Contains(new Point(e.X,e.Y))) {
	    			MouseEventArgs me=new MouseEventArgs(e.Button,e.Clicks,e.X-item.Bounds.X,e.Y-item.Bounds.Y,e.Delta);
	    			item.RaiseMouseDown(sender,me);
	    			break;
	    		}
	    	}
	    }
	    #endregion
	    public void BringItemToFront(DrawableItems item) {
	    	Items.Remove(item);
	    	Items.Insert(0,item);
	    	Invalidate();
	    }
	    protected override void OnPaintBackground(PaintEventArgs e) {
	    	this.g = e.Graphics;
	    	Rectangle rect=new Rectangle(0,0,this.Width,this.Height);
	    	if(this.BackColor!=Color.Transparent) {
	    		Brush b=new SolidBrush(this.BackColor);
	    		this.g.FillRectangle(b,rect);
	    	}
	    	if(this.BackgroundImage!=null) {
				this.g.DrawImage((Image)this.BackgroundImage,rect);
			}
	    }
	    protected override void OnPaint(PaintEventArgs e) {
			this.g = e.Graphics;
			//reverse the order so the item on top gets drawn last
			Items.Reverse();
			foreach (DrawableItems item in Items) {
				g.DrawImage(item.Image,item.Bounds);
			}
			//and restore the normal order
			Items.Reverse();
	    }
	}

	public static class Framework {
		public static void EnterClickable(object sender, EventArgs e){
			Control sndr=(Control)sender;
			sndr.Cursor=Cursors.Hand;
		}
		public static void LeaveClickable(object sender, EventArgs e) {
			Control sndr=(Control)sender;
			sndr.Cursor=Cursors.Default;
		}
		
		public static int AddUser(string name, Bitmap picture,Difficulty difficulty,int score) {
			UserList temp = new UserList();
			temp.id=Config.Users.Count;temp.picture=picture;temp.score=score;temp.difficulty=difficulty;temp.name=name;
			Config.Users.Add(temp);
			Config.SaveUser(temp.id);
			return(temp.id);
	    }
	}
}

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
	public static class WebCam {
		public static int id;
		public static int width;
		public static int height;
		public static short bpp;
	}
	
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
			RegistryKey regConfig=Registry.CurrentUser.OpenSubKey("Software\\"+app.name,false);
			WebCam.id=(int)regConfig.GetValue("WebCamId",0);
			WebCam.width=(int)regConfig.GetValue("WebCamWidth",320);
			WebCam.height=(int)regConfig.GetValue("WebCamHeight",240);
			WebCam.bpp=Convert.ToInt16((int)regConfig.GetValue("WebCamBpp",24));
			RegistryKey regUsers=regConfig.OpenSubKey("Users",false);
			foreach (string s in regUsers.GetSubKeyNames()) {
				RegistryKey u = regUsers.OpenSubKey(s);
				UserList temp = new UserList();
				temp.id=(int)u.GetValue("id",Users.Count);temp.picture=new Bitmap(app.confdir+"\\images\\"+(string)u.GetValue("image",""));temp.score=(int)u.GetValue("score",0);temp.difficulty=(Difficulty)u.GetValue("difficulty",Difficulty.easy);temp.name=(string)u.GetValue("name","");
				Users.Insert(temp.id,temp);
			}
			
		}
	}
}