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
		public GameFruits(){
			InitializeComponent();
			DrawableItems d=new DrawableItems();
			d.Parent=drawArea1;
			d.Image=global::glass.Resources.Plate;
			d.Bounds=new Rectangle(0,300,100,100);
			drawArea1.Items.Add(d);
			
//			d.Parent=drawArea1;
//			d.Image=global::glass.Resources.Plate;
//			d.Bounds=new Rectangle(700,300,100,100);
//			drawArea1.Items.Add(d);
		}
		void PicBackClick(object sender, EventArgs e){
			Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
			AreYouSure.ShowDialog();
			if(AreYouSure.Answer){
				this.Close();}
		}
	}
}
