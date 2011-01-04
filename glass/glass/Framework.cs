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
using System.Media;
using Microsoft.Win32;
using glass.config;
using System.Drawing.Drawing2D;

namespace glass.framework {
	public class DrawableItems {
		#region Declarations
		public delegate void ItemEventHandler(DrawableItems sender,EventArgs e);
		public delegate void ItemMouseEventHandler(DrawableItems sender, MouseEventArgs e);
		private Rectangle bounds;
		private Bitmap image;
		private DrawArea parent;
		private bool enabled=true;
		public int Tag;
		#endregion
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
		public bool Enabled {
			get {return(enabled);}
			set {enabled=value;}
		}
		#endregion
		#region Events
		public event ItemEventHandler MouseEnter;
		public event ItemEventHandler MouseLeave;
		public event ItemMouseEventHandler MouseDown;
		public event ItemMouseEventHandler MouseUp;
		public event ItemMouseEventHandler MouseMove;
		#endregion
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
		#region Stubs
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
	    public DrawableItems ActiveItem=null;
	    
	    //setting control bits for transparency
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
	    	//Make sure the background does not flicker by setting a few control bits
	    	this.SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.UserPaint|ControlStyles.DoubleBuffer,true);
		}
	    #region MouseStubs
	    private void stubMouseMove(object sender,MouseEventArgs e) {
	    	EventArgs ee=new EventArgs();
	    	if(this.ActiveItem!=null) {
	    		MouseEventArgs me=new MouseEventArgs(e.Button,e.Clicks,e.X-ActiveItem.Bounds.X,e.Y-ActiveItem.Bounds.Y,e.Delta);
	    		this.ActiveItem.RaiseMouseMove(sender,me);
	    	}else{
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
	    //This method does not work with the flicker-reducing style bits set
	    /*protected override void OnPaintBackground(PaintEventArgs e) {
	    	this.g = e.Graphics;
	    	Rectangle rect=new Rectangle(0,0,this.Width,this.Height);
	    	if(this.BackColor!=Color.Transparent) {
	    		Brush b=new SolidBrush(this.BackColor);
	    		this.g.FillRectangle(b,rect);
	    	}
	    	if(this.BackgroundImage!=null) {
				this.g.DrawImage((Image)this.BackgroundImage,e.ClipRectangle,rect,GraphicsUnit.Pixel);
			}
	    	g.Dispose();
	    }*/
	    protected override void OnPaint(PaintEventArgs e) {
			//reverse the order so the item on top gets drawn last
			Items.Reverse();
			foreach (DrawableItems item in Items) {
				e.Graphics.DrawImage(item.Image,item.Bounds);
			}
			//and restore the normal order
			Items.Reverse();
	    }
	}

	public static class Framework {
		public static SoundPlayer sndPlay=new SoundPlayer();
		private static Random rnd=new Random(DateTime.Now.Millisecond);
		public enum LevelScores {
			Prepositons=1<<0,
			Clothes=1<<3,
			Fruits=1<<6,
			Colors=1<<9,
		};
		public static int rndInt() {
			return((int)rnd.Next());
		}
		public static int rndInt(int min, int max) {
			return((int)rnd.Next(min, max));
		}
		public static void EnterClickable(object sender, EventArgs e){
			Control sndr=(Control)sender;
			sndr.Cursor=Cursors.Hand;
		}
		public static void LeaveClickable(object sender, EventArgs e) {
			Control sndr=(Control)sender;
			sndr.Cursor=Cursors.Default;
		}
		public static void EnterClickable(DrawableItems sender, EventArgs e){
			sender.Parent.Cursor=Cursors.Hand;
		}
		public static void LeaveClickable(DrawableItems sender, EventArgs e) {
			sender.Parent.Cursor=Cursors.Default;
		}
		
		public static int AddUser(string name, Bitmap picture,Difficulty difficulty,uint score) {
			UserList temp = new UserList();
			temp.id=Config.Users.Count;temp.picture=picture;temp.score=score;temp.difficulty=difficulty;temp.name=name;
			Config.Users.Add(temp);
			Config.SaveUser(temp.id);
			return(temp.id);
	    }
		
		//Function for checking if a point is inside a polygon, using the ray casting method.
		public static bool PointInPolygon(Point p, Point[] poly) {
			bool inside=false;
			Point p1, p2;
			//make sure the polygon has at least 3 vertecies
			if(poly.Length<3) {
				throw new ArgumentOutOfRangeException("poly","A polygon requires at least 3 vertecies");
				//return(false);
			}
			Point oldPoint = new Point(poly[poly.Length - 1].X, poly[poly.Length - 1].Y);
			foreach(Point pt in poly) {
				 if (pt.X > oldPoint.X) {
					p1 = oldPoint;
					p2 = pt;
		        } else {
					p1 = pt;
					p2 = oldPoint;
		        }
				if ((pt.X < p.X) == (p.X <= oldPoint.X) && ((long)p.Y - (long)p1.Y) * (long)(p2.X - p1.X) < ((long)p2.Y - (long)p1.Y) * (long)(p.X - p1.X)) {
					inside=!inside;
				}
				oldPoint=new Point(pt.X,pt.Y);
			}
			return(inside);
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
		public uint score;
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
		public const string name="LoL";
		public const double version=0.9;
		public static string confdir=Environment.GetEnvironmentVariable("APPDATA")+"\\"+name;
	}
	
	//yes, it is ugly but it works.. global configuration settings
	public static class Config {
		public static List<UserList> Users = new List<UserList>();
		public static List<PictureBox> UserFaces = new List<PictureBox>();
		public static UserList LoggedInUser;
		
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
			u.SetValue("score",Convert.ToInt32(ul.score));
		}
		public static void UpdateScore(UserList ul) {
			RegistryKey reg=Registry.CurrentUser.OpenSubKey("Software\\"+app.name,true);
			RegistryKey regUsers=reg.OpenSubKey("Users",true);
			RegistryKey u=regUsers.CreateSubKey(ul.id.ToString("000"));
			u.SetValue("score",Convert.ToInt32(ul.score));
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
				temp.id=(int)u.GetValue("id",Users.Count);temp.picture=new Bitmap(app.confdir+"\\images\\"+(string)u.GetValue("image",""));temp.difficulty=(Difficulty)u.GetValue("difficulty",Difficulty.easy);temp.name=(string)u.GetValue("name","");
				uint iii=Convert.ToUInt32(u.GetValue("score",0));
				temp.score=iii;
				Users.Insert(temp.id,temp);
			}
			
		}
		public static void SetUp() {
			RegistryKey regConfig=Registry.CurrentUser.CreateSubKey("Software\\"+app.name);
			RegistryKey regUsers=regConfig.CreateSubKey("Users");
			if(!Directory.Exists(app.confdir+@"\images")) {
				Directory.CreateDirectory(app.confdir);
				Directory.CreateDirectory(app.confdir+@"\images");
			}
			if(Convert.ToInt32(regConfig.GetValue("WebCamId",-1))==-1) {
				Dialog.WebcamSetup frmWebcamSetup = new glass.Dialog.WebcamSetup();
				frmWebcamSetup.ShowDialog();
				int index=Convert.ToInt32(((DomainUpDown)frmWebcamSetup.Controls.Find("dmnIndex",true)[0]).Text);
				int w=Convert.ToInt32(((DomainUpDown)frmWebcamSetup.Controls.Find("dmnWidth",true)[0]).Text);
				int h=Convert.ToInt32(((DomainUpDown)frmWebcamSetup.Controls.Find("dmnHeight",true)[0]).Text);
				int bpp=Convert.ToInt32(((DomainUpDown)frmWebcamSetup.Controls.Find("dmnBpp",true)[0]).Text);
				regConfig.SetValue("WebCamId", index);
				regConfig.SetValue("WebCamWidth", w);
				regConfig.SetValue("WebCamHeight", h);
				regConfig.SetValue("WebCamBpp", bpp);
			}
		}
	}
}