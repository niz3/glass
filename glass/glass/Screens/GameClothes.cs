/*
 * Created by SharpDevelop.
 * User: ds930619
 * Date: 2010-11-22
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using glass.framework;
using glass.config;

namespace glass.Screens
{
	/// <summary>
	/// Description of GameClothes.
	/// </summary>
	/// 
	
	struct ClothPlaces {
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
		public ClothPlaces(string n, Point[] p) {
			name=n;
			poly=p;
		}
	};
	
	public partial class GameClothes : Form
	{
		bool dragging;
		Point offset;
		private List<ClothPlaces[]> PlaceCollection =new List<ClothPlaces[]>{
			new ClothPlaces[]{
				new ClothPlaces("troja",new Point[] {new Point(5,137), new Point(296,257), new Point(5,291), new Point(504,400)}),
				new ClothPlaces("byxor",new Point[] {new Point(7,320), new Point(293,320), new Point(7,496), new Point(298,478)}),
				new ClothPlaces("strumpor",new Point[] {new Point(463,373), new Point(508,380), new Point(480,410), new Point(417,401)}),
				new ClothPlaces("mossa",new Point[] {new Point(252,54), new Point(374,-23), new Point(375,324), new Point(248,428)}),
			}
		};
		public GameClothes()
		{
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.gubbe;
			d.Bounds=new Rectangle(250,20,300,550);
			drawArea1.Items.Add(d);
			
			SpawnClothes();
		}
		
		void PicBackClick(object sender, EventArgs e)
		{
			Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
			AreYouSure.ShowDialog();
			if(AreYouSure.Answer)
				this.Close();
		}
		private void ClickMovable(DrawableItems sender, MouseEventArgs e) {
			drawArea1.ActiveItem=sender;
			offset=new Point(e.X,e.Y);
			int x=(int)((sender.Bounds.X+sender.Bounds.X+sender.Bounds.Width)/2);
			int y=(int)((sender.Bounds.Y+sender.Bounds.Y+sender.Bounds.Height)/2);
			sender.Parent.BringItemToFront(sender);
			dragging=(!dragging)&sender.Enabled;
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
		void SpawnClothes() {
			Bitmap[] trojor=new Bitmap[] {
				global::glass.Resources.troja_bla,
				global::glass.Resources.troja_rod,
				global::glass.Resources.troja_gron,
				global::glass.Resources.troja_gul,
			};
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=trojor[Framework.rndInt(0,trojor.Length)];
			d.Bounds=new Rectangle(0,0,200,200);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
			
			Bitmap[] byxor=new Bitmap[] {
				global::glass.Resources.byxor_bla,
				global::glass.Resources.byxor_rod,
				global::glass.Resources.byxor_gron,
				global::glass.Resources.byxor_gul,
			};
			d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=byxor[Framework.rndInt(0,byxor.Length)];
			d.Bounds=new Rectangle(600,100,200,200);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
		}
	}
}
