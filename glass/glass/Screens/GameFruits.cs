/*
 * Created by SharpDevelop.
 * User: NILSS
 * Date: 2010-11-22
 * Time: 10:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using glass.framework;

namespace glass.Screens
{
	/// <summary>
	/// A fun game with fruits :D
	/// </summary>
	public partial class GameFruits : Form
	{
		DrawableItems banan=new DrawableItems();
		DrawableItems apple=new DrawableItems();
		private Point offset;
		private bool dragging=false;
		public GameFruits(){
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.plate;
			d.Bounds=new Rectangle(0,300,250,250);
			drawArea1.Items.Add(d);
			
			DrawableItems fuu=new DrawableItems();
			
			fuu.Parent=drawArea1;
			fuu.Image=global::glass.Resources.plate;
			fuu.Bounds=new Rectangle(550,300,250,250);
			drawArea1.Items.Add(fuu);
			
			DrawableItems apple=new DrawableItems();
			apple.MouseDown+=new DrawableItems.ItemMouseEventHandler(ClickMovable);
			apple.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
			apple.Parent=drawArea1;
			apple.Image=global::glass.Resources.frukt_apple;
			apple.Bounds=new Rectangle(300,300,100,100);
			drawArea1.Items.Add(apple);
			
			DrawableItems banan=new DrawableItems();
			banan.MouseDown+=new DrawableItems.ItemMouseEventHandler(ClickMovable);
			banan.MouseMove+=new DrawableItems.ItemMouseEventHandler(MoveMovable);
			banan.Parent=drawArea1;
			banan.Image=global::glass.Resources.frukt_banan;
			banan.Bounds=new Rectangle(200,200,100,67);
			drawArea1.Items.Add(banan);
			
			
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
	}
}