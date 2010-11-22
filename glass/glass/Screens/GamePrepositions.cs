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
		public GamePrepositions() {
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.exit;
			d.Bounds=new Rectangle(5,10,64,64);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
			d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.camera;
			d.Bounds=new Rectangle(20,20,64,64);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
			d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.up;
			d.Bounds=new Rectangle(100,100,d.Image.Width,d.Image.Height);
			d.MouseDown+= new DrawableItems.ItemMouseEventHandler(ClickMovable);
			d.MouseMove+= new DrawableItems.ItemMouseEventHandler(MoveMovable);
			drawArea1.Items.Add(d);
		}
		private void ClickMovable(DrawableItems sender, MouseEventArgs e) {
			offset=new Point(e.X,e.Y);
			sender.Parent.BringItemToFront(sender);
		}
		private void MoveMovable(DrawableItems sender,MouseEventArgs e) {
			if(e.Button==MouseButtons.Left) {
				Point p=sender.Bounds.Location;
				sender.Bounds=new Rectangle(new Point(p.X+e.X-offset.X,p.Y+e.Y-offset.Y),new Size(sender.Bounds.Width,sender.Bounds.Height));
				drawArea1.Invalidate();
			}
		}
	}
}
