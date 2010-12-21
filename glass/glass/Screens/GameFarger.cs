/*
 * Created by SharpDevelop.
 * User: ma930131
 * Date: 2010-11-15
 * Time: 10:27
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
	/// Description of farger.
	/// </summary>
	public partial class GameFarger : Form
	{
		string[] Farger = {
			"Gul",
			"Blå",
			"Grön",
			"Röd",
			"Vit",
		};
		int farg;
		public GameFarger()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			farg = Framework.rndInt(1,5);
			labelinstruktion.Text="Klicka på den "+Farger[farg]+"a bilen";
			}
			void PictureBox1Click(object sender, EventArgs e)
			{
				MessageBox.Show("bra jobbat");
			}
			void PicBackClick(object sender, EventArgs e) {
				Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
				AreYouSure.ShowDialog();
				if(AreYouSure.Answer){
					this.Close(); }
			
		}
		
			void ClickCar(object sender,EventArgs e) {
				PictureBox PictureBoxCar=(PictureBox) sender;
				if(farg==Convert.ToInt32(PictureBoxCar.Tag))
				{
					MessageBox.Show("BRa JOBB");
					farg = Framework.rndInt(1,5);
					labelinstruktion.Text="Klicka på den "+Farger[farg]+"a bilen";
				}
			}
			
		
		void GameFargerLoad(object sender, EventArgs e)
		{
			
		}
	}
}
