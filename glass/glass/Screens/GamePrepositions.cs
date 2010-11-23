/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 23:28
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using glass.framework;

namespace glass.Screens {
	/// <summary>
	/// Description of GamePrepositions.
	/// </summary>
	public partial class GamePrepositions : Form {
		private Point offset;
		private bool dragging=false;
		public GamePrepositions() {
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.boll_fotboll;
			d.Bounds=new Rectangle(5,10,64,64);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
			
			d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.boll_fotboll;
			d.Bounds=new Rectangle(100,10,64,64);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
		}
		private void ClickMovable(DrawableItems sender, MouseEventArgs e) {
			drawArea1.ActiveItem=sender;
			offset=new Point(e.X,e.Y);
			sender.Parent.BringItemToFront(sender);
			dragging=!dragging;
		}
		private void MoveMovable(DrawableItems sender,MouseEventArgs e) {
			if(dragging) {
				Point p=sender.Bounds.Location;
				sender.Bounds=new Rectangle(new Point(p.X+e.X-offset.X,p.Y+e.Y-offset.Y),new Size(sender.Bounds.Width,sender.Bounds.Height));
				Rectangle InvalidateRect=new Rectangle(Math.Min(sender.Bounds.X,p.X),Math.Min(sender.Bounds.Y,p.Y),sender.Bounds.Width+Math.Abs(sender.Bounds.X-p.X),sender.Bounds.Height+Math.Abs(sender.Bounds.Y-p.Y));
				drawArea1.Invalidate(InvalidateRect);
			}
		}
	}
}
