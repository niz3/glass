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
	
	partial class GameClothes : Form {
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
		
		private ClothPlaces goal;
		//private Bitmap current;
		
		Bitmap[] trojor=new Bitmap[] {
			global::glass.Resources.troja_bla,
			global::glass.Resources.troja_rod,
			global::glass.Resources.troja_gron,
			global::glass.Resources.troja_gul,
		};
		Bitmap[] byxor=new Bitmap[] {
			global::glass.Resources.byxa_bla,
			global::glass.Resources.byxa_rod,
			global::glass.Resources.byxa_gron,
			global::glass.Resources.byxa_gul,
		};
		Bitmap[] mossor=new Bitmap[] {
			global::glass.Resources.mossa_bla,
			global::glass.Resources.mossa_rod,
			global::glass.Resources.mossa_gron,
			global::glass.Resources.mossa_gul,
		};
		Bitmap[] strumpor=new Bitmap[] {
			global::glass.Resources.strumpa_bla,
			global::glass.Resources.strumpa_rod,
			global::glass.Resources.strumpa_gron,
			global::glass.Resources.strumpa_gul,
		};
		Bitmap[] tshirts=new Bitmap[] {
			global::glass.Resources.t_bla,
			global::glass.Resources.t_rod,
			global::glass.Resources.t_gron,
			global::glass.Resources.t_gul,
		};
		Bitmap[] jackor=new Bitmap[] {
			global::glass.Resources.jacka_bla,
			global::glass.Resources.jacka_rod,
			global::glass.Resources.jacka_gron,
			global::glass.Resources.jacka_gul,
		};
		bool dragging;
		Point offset;
		ClothPlaces[] PlaceCollection = new ClothPlaces[]{
			new ClothPlaces("troja",new Point[] {new Point(268,117), new Point(536-236,117), new Point(536-236,326-185), new Point(268,326-185)}),
			new ClothPlaces("byxor",new Point[] {new Point(275,298), new Point(516-213,298), new Point(516-213,500-178), new Point(276,500-178)}),
			new ClothPlaces("strumpor",new Point[] {new Point(251,446), new Point(549-274,446), new Point(549-274,503-38), new Point(251,503-38)}),
			new ClothPlaces("mossa",new Point[] {new Point(336,10), new Point(456-87,10), new Point(456-87,110-60), new Point(336,110-60)}),
		};
		public GameClothes()
		{
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.gubbe;
			d.Bounds=new Rectangle(250,20,300,500);
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
			if((!dragging)&&(sender.Enabled)) {
				MessageBox.Show(goal.Name);
				foreach (ClothPlaces place in PlaceCollection) {
					if((place.Name==goal.Name)&&(Framework.PointInPolygon(new Point(x,y),place.Polygon))) {
						MessageBox.Show("lol");
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
		void SpawnClothes() {
			if(Config.LoggedInUser.difficulty==Difficulty.easy) {
				DrawableItems d=new DrawableItems();
				d.Parent=drawArea1;
				d.Image=trojor[Framework.rndInt(0,trojor.Length)];
				d.Bounds=new Rectangle(0,0,236,185);
				d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
				d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
				drawArea1.Items.Add(d);
				
				d=new DrawableItems();
				d.Parent=drawArea1;
				d.Image=byxor[Framework.rndInt(0,byxor.Length)];
				d.Bounds=new Rectangle(600,100,213,178);
				d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
				d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
				drawArea1.Items.Add(d);
				
				d=new DrawableItems();
				d.Parent=drawArea1;
				d.Image=mossor[Framework.rndInt(0,mossor.Length)];
				d.Bounds=new Rectangle(600,300,87,60);
				d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
				d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
				drawArea1.Items.Add(d);
				
				goal=PlaceCollection[0];
			}
		}
	}
}
