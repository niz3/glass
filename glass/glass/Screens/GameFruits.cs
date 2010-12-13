/*
 * Created by SharpDevelop.
 * User: NILS
 * Date: 2010-11-22
 * Time: 10:36
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
	/// A fun game with fruits :D
	/// </summary>
	public partial class GameFruits : Form
	{
		int t1; int t2;
		enum fruitType {
			banan,
			apple,
			apelsin,
			paron,
		};
		Bitmap[] fruitImg=new Bitmap[] {
			global::glass.Resources.frukt_banan,
			global::glass.Resources.frukt_apple,
			global::glass.Resources.bil_bla,
			global::glass.Resources.boll_fotboll,
		};
		struct fruit {
			public DrawableItems Item;
			public fruitType Type;
			public fruit(DrawableItems it, fruitType ft) {
				Item=it;
				Type=ft;
			}
		};
		List<fruit> Fruits = new List<GameFruits.fruit>();
		
		DrawableItems[] plate=new DrawableItems[4];
		Rectangle[] platePositions=new Rectangle[] {
			new Rectangle(0,32,250,250),
			new Rectangle(800-250,32,250,250),
			new Rectangle(0,300,250,250),
			new Rectangle(800-250,300,250,250),
		};
		private Point offset;
		private bool dragging=false;
		public GameFruits(){
			InitializeComponent();
			for(int i=0;i<((int)Config.LoggedInUser.difficulty)+2;i++) {
				plate[i]=new DrawableItems();
				plate[i].Parent=drawArea1;
				plate[i].Image=global::glass.Resources.plate;
				plate[i].Bounds=platePositions[i];
				drawArea1.Items.Add(plate[i]);
			}
			SpawnItems();
			}
		void PicBackClick(object sender, EventArgs e){
			Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
			AreYouSure.ShowDialog();
			if(AreYouSure.Answer){
				this.Close();
			}
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
				//Rectangle InvalidateRect=new Rectangle(Math.Min(sender.Bounds.X,p.X),Math.Min(sender.Bounds.Y,p.Y),sender.Bounds.Width+Math.Abs(sender.Bounds.X-p.X),sender.Bounds.Height+Math.Abs(sender.Bounds.Y-p.Y));
				drawArea1.Invalidate();
				this.Cursor=Cursors.SizeAll;
			} else {
				this.Cursor=Cursors.Default;
			}
		}
		private void SpawnItems(){
			Fruits.Clear();
			int f1=Framework.rndInt(0,fruitImg.Length);
			int f2=f1;
			while(f2==f1) {
				f2=Framework.rndInt(0,fruitImg.Length);
			}
			t1=f1;t2=f2;
			if (Config.LoggedInUser.difficulty== Difficulty.easy){
				int r=(((int)Config.LoggedInUser.difficulty+2)*(Framework.rndInt(1,4)));
				for (int i = 0; i<r;i++) {
					DrawableItems d=new DrawableItems();
			     	d.MouseDown+=new DrawableItems.ItemMouseEventHandler(ClickMovable);
					d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
					d.Parent=drawArea1;
					d.Image=fruitImg[f1];
					d.Bounds=new Rectangle(Framework.rndInt(200,400),Framework.rndInt(100,400),100,100);
					Fruits.Add(new fruit(d,(fruitType)f1));
			     	drawArea1.Items.Add(d);
				}
			}else {
				int r;
				r=(((int)Config.LoggedInUser.difficulty+2)*(Framework.rndInt(1,4)));
				for (int i = 0; i<r;i++) {
					DrawableItems d=new DrawableItems();
			     	d.MouseDown+=new DrawableItems.ItemMouseEventHandler(ClickMovable);
					d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
					d.Parent=drawArea1;
					d.Image=fruitImg[f1];
					d.Bounds=new Rectangle(Framework.rndInt(200,400),Framework.rndInt(100,400),100,100);
					Fruits.Add(new fruit(d,(fruitType)f1));
			     	drawArea1.Items.Add(d);
				}
				r=(((int)Config.LoggedInUser.difficulty+2)*(Framework.rndInt(1,4)));
				for (int i = 0; i<r;i++) {
					DrawableItems d=new DrawableItems();
			     	d.MouseDown+=new DrawableItems.ItemMouseEventHandler(ClickMovable);
					d.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
					d.Parent=drawArea1;
					d.Image=fruitImg[f2];
					d.Bounds=new Rectangle(Framework.rndInt(200,400),Framework.rndInt(100,400),100,100);
					Fruits.Add(new fruit(d,(fruitType)f2));
			     	drawArea1.Items.Add(d);
				}
			}
		}
		
		void PicKlarClick(object sender, EventArgs e){
			int[] f1=new int[fruitImg.Length];
			int[] ppp=new int[fruitImg.Length];
			foreach (fruit f in Fruits) {
				for(int i=0;i<(((int)Config.LoggedInUser.difficulty+2));i++) {
					//MessageBox.Show(plate[i].ToString());
					if (f.Item.Bounds.IntersectsWith(plate[i].Bounds)) {
						f1[(int)f.Type]+=(1<<i);
					}
				}
			}
			if(Config.LoggedInUser.difficulty== Difficulty.easy) {
				if(f1[t1]==(((Fruits.Count/2)<<0)+(((Fruits.Count/2)<<1)))) {
					MessageBox.Show("du vannnnannanananannas");
					this.Close();
				}
			}else{
				ppp[0]=0;ppp[1]=0;
				int i=0;
				foreach (fruit f in Fruits) {
					ppp[(int)f.Type]+=(1<<(i%((int)Config.LoggedInUser.difficulty+2)));
					i++;
				}
				
				//MessageBox.Show(ppp[t1].ToString()+" "+ppp[t2].ToString());
				if(f1[t1]==ppp[t1]&&f1[t2]==ppp[t2]) {
					MessageBox.Show("du vannnnannanananannas");
					this.Close();
				}
			}
		}
	}
}
