/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 23:28
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using glass.framework;
using glass.config;
using System.Collections.Generic;

namespace glass.Screens {
	struct Items {
		private string name;
		private string ending;
		private Bitmap image;
		public string Name {
			get{return(name);}
			set{name=value;}
		}
		public string Ending {
			get{return(ending);}
			set{ending=value;}
		}
		public Bitmap Image {
			get{return(image);}
			set{image=value;}
		}
		public Items(string n, string end, Bitmap img) {
			image=img;
			name=n;
			ending=end;
		}
	};
	struct Places {
		private string name;
		private Point[] poly;
		public string Name {
			get{return(name);}
			set{name=value;}
		}
		public Point[] Polygon {
			get{return(poly);}
			set{poly=value;}
		}
		public Places(string n, Point[] p) {
			name=n;
			poly=p;
		}
	};
	
	public partial class GamePrepositions : Form {
		private int correct=0;
		private int total=10+(5*((int)Config.LoggedInUser.difficulty));
		private Point offset;
		private bool dragging=false;
		private Places goal;
		private Items[] ItemCollection={
			new Items("fotboll", "en", global::glass.Resources.boll_fotboll),
			new Items("kamera", "n", global::glass.Resources.camera),
			new Items("äpple", "t", global::glass.Resources.frukt_apple),
			new Items("bil", "en", global::glass.Resources.bil_rod),
		};
		private Dictionary<Difficulty, Places[]> PlaceCollection=new Dictionary<Difficulty, Places[]>{
			{Difficulty.easy,
				new Places[]{
					new Places("på bordet",new Point[] {new Point(570,326), new Point(812,334), new Point(780,410), new Point(504,400)}),
					new Places("under bordet",new Point[] {new Point(581,475), new Point(692,476), new Point(692,534), new Point(571,527)}),
					new Places("på stolen",new Point[] {new Point(463,373), new Point(508,380), new Point(480,410), new Point(417,401)}),
					new Places("i bokhyllan",new Point[] {new Point(252,54), new Point(374,-23), new Point(375,324), new Point(248,428)}),
				}
			},{Difficulty.normal,
				new Places[]{
					new Places("på bordet",new Point[] {new Point(570,326), new Point(812,334), new Point(780,410), new Point(504,400)}),
					new Places("under bordet",new Point[] {new Point(581,475), new Point(692,476), new Point(692,534), new Point(571,527)}),
					new Places("på stolen",new Point[] {new Point(463,373), new Point(508,380), new Point(480,410), new Point(417,401)}),
					new Places("på översta hyllan",new Point[] {new Point(252,54), new Point(374,-23), new Point(375,25), new Point(248,90)}),
					new Places("på understa hyllan",new Point[] {new Point(252,382), new Point(374,296), new Point(375,324), new Point(248,428)}),
				}
			},{Difficulty.hard,
				new Places[]{
					new Places("på bordet",new Point[] {new Point(570,326), new Point(812,334), new Point(780,410), new Point(504,400)}),
					new Places("under bordet",new Point[] {new Point(581,475), new Point(692,476), new Point(692,534), new Point(571,527)}),
					new Places("på stolen",new Point[] {new Point(463,373), new Point(508,380), new Point(480,410), new Point(417,401)}),
					new Places("på översta hyllan",new Point[] {new Point(252,54), new Point(374,-23), new Point(375,25), new Point(248,90)}),
					new Places("på understa hyllan",new Point[] {new Point(252,382), new Point(374,296), new Point(375,324), new Point(248,428)}),
					new Places("på hyllan i mitten",new Point[] {new Point(252,218), new Point(374,128), new Point(375,184), new Point(248,270)}),
					new Places("mellan bokhyllan och stolen",new Point[] {new Point(378,350), new Point(461,365), new Point(384,485), new Point(242,448)}),
				}
			},
		};
		
		public GamePrepositions() {
			InitializeComponent();
			picBack.MouseEnter+= new EventHandler(Framework.EnterClickable);
			picBack.MouseLeave+= new EventHandler(Framework.LeaveClickable);
			prgProgress.Maximum=total;
			SpawnItem();		
		}
		private void ClickMovable(DrawableItems sender, MouseEventArgs e) {
			drawArea1.ActiveItem=sender;
			offset=new Point(e.X,e.Y);
			int x=(int)((sender.Bounds.X+sender.Bounds.X+sender.Bounds.Width)/2);
			int y=(int)((sender.Bounds.Y+sender.Bounds.Y+sender.Bounds.Height)/2);
			sender.Parent.BringItemToFront(sender);
			dragging=(!dragging)&sender.Enabled;
			if((!dragging)&&(sender.Enabled)) {
				foreach (Places place in PlaceCollection[Config.LoggedInUser.difficulty]) {
					if((place.Name==goal.Name)&&(Framework.PointInPolygon(new Point(x,y),place.Polygon))) {
					   	sender.Enabled=false;
					   	Rectangle InvalidateRect=new Rectangle(sender.Bounds.X,sender.Bounds.Y,sender.Bounds.Width,sender.Bounds.Height);
					   	correct++;
					   	prgProgress.PerformStep();
					   	drawArea1.Items.Remove(sender);
					   	if(correct>=total) {
					   		if((Config.LoggedInUser.score&((int)Framework.LevelScores.Prepositons<<(int)Config.LoggedInUser.difficulty))!=((int)Framework.LevelScores.Prepositons<<(int)Config.LoggedInUser.difficulty)) {
					   			Config.LoggedInUser.score+=(uint)Framework.LevelScores.Prepositons<<(int)Config.LoggedInUser.difficulty;
					   			Config.UpdateScore(Config.LoggedInUser);
					   		}
					   		MessageBox.Show("Bra jobbat!");
					   		this.Close();
					   	}
					   	SpawnItem();
					   	Invalidate(InvalidateRect);
					}
				}
			}
		}
		private void MoveMovable(DrawableItems sender,MouseEventArgs e) {
			if(dragging&&sender.Enabled) {
				Point p=sender.Bounds.Location;
				sender.Bounds=new Rectangle(new Point(p.X+e.X-offset.X,p.Y+e.Y-offset.Y),new Size(sender.Bounds.Width,sender.Bounds.Height));
				Rectangle InvalidateRect=new Rectangle(Math.Min(sender.Bounds.X,p.X),Math.Min(sender.Bounds.Y,p.Y),sender.Bounds.Width+Math.Abs(sender.Bounds.X-p.X),sender.Bounds.Height+Math.Abs(sender.Bounds.Y-p.Y));
				drawArea1.Invalidate(InvalidateRect);
				this.Cursor=Cursors.SizeAll;
			} else {
				this.Cursor=Cursors.Default;
			}
		}
		#region SpawnItem Overloads
		public void SpawnItem() {
			DrawableItems d=new DrawableItems();
			Items item=ItemCollection[Framework.rndInt(0,ItemCollection.Length)];
			Places place=PlaceCollection[Config.LoggedInUser.difficulty][Framework.rndInt(0,PlaceCollection[Config.LoggedInUser.difficulty].Length)];
			d.Parent=drawArea1;
			d.Image=item.Image;
			d.Bounds=new Rectangle(Framework.rndInt(64,736),Framework.rndInt(500,506),d.Image.Width,d.Image.Height);
			//d.MouseEnter+= new DrawableItems.ItemEventHandler(Framework.EnterClickable);
			//d.MouseLeave+= new DrawableItems.ItemEventHandler(Framework.LeaveClickable);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
			goal=place;
			lblInstruction.Text="Lägg "+item.Name+item.Ending+" "+place.Name+"; "+Convert.ToString(total-correct)+" kvar";
		}
		#endregion
		
		void PicBackClick(object sender, EventArgs e) {
			Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
			AreYouSure.ShowDialog();
			if(AreYouSure.Answer) {
				this.Close();
			}
		}
	}
}