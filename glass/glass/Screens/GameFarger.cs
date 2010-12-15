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
		public GameFarger()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			int farg;
			InitializeComponent();
			farg = Framework.rndInt(1,3);
			MessageBox.Show(farg.ToString());
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
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			
		}
	}
}
