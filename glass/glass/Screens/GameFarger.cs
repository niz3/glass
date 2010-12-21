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
using glass.config;

namespace glass.Screens
{
	/// <summary>
	/// Description of farger.
	/// </summary>
	public partial class GameFarger : Form
	{
		PictureBox p;
		string[] FargerEasy = {
			"Gul",
			"Blå",
			"Grön",
			"Röd",
			"Vit",
		};
		Bitmap[] BilderEasy = {
			global::glass.Resources.bil_gul,
			global::glass.Resources.bil_bla,
			global::glass.Resources.bil_gron,
			global::glass.Resources.bil_rod,
			global::glass.Resources.bil_vit,
		};
		
		string[] FargerNormal = {
			"Blå",
			"Ros",
			"Röd",
			"Vit",
			"Grön",
			"Brun",
			"Gul",
			"Gul",
		};
		string[] ObjektNormal= {
			"Bilen",
			"Huset",
			"Bilen",
			"Bilen",
			"Bilen",
			"Huset",
			"Bilen",
			"Huset",
		};
		Bitmap[] BilderNormal = {
			global::glass.Resources.bil_bla,
			global::glass.Resources.hus_rosa,
			global::glass.Resources.bil_rod,
			global::glass.Resources.bil_vit,
			global::glass.Resources.bil_gron,
			global::glass.Resources.hus_brun,
			global::glass.Resources.bil_gul,
			global::glass.Resources.hus_gul,
		};
		string[] FargerHard = {
			"Vitprickig",
			"Ros",
			"Röd",
			"Vit",
			"Grön",
			"Brun",
			"Gul",
			"Randig",
			"Rödprickig",
			"Gul",
			"Blå"
		};
		string[] ObjektHard= {
			"Huset",
			"Huset"	,
			"Bilen",
			"Bilen",
			"Bilen",
			"Huset",
			"Bilen",
			"Bilen",
			"Huset",
			"Huset",
			"Bilen",
		};
		Bitmap[] BilderHard = {
			global::glass.Resources.hus_vitprick,
			global::glass.Resources.hus_rosa,
			global::glass.Resources.bil_rod,
			global::glass.Resources.bil_vit,
			global::glass.Resources.bil_gron,
			global::glass.Resources.hus_brun,
			global::glass.Resources.bil_gul,
			global::glass.Resources.bil_randig,
			global::glass.Resources.hus_rodprick,
			global::glass.Resources.hus_gul,
			global::glass.Resources.bil_bla,
		};
		int farg;
		public GameFarger()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			
			if(Config.LoggedInUser.difficulty==Difficulty.easy) {
				prgProgress.Maximum=10;
				int i;
				for (i=0;i <=4;i++){
					p=new PictureBox();
					p.Image=BilderEasy[i];
					p.Location=new Point(5+(150*i),400);
					p.Width=150;
					p.Height=60;
					p.Tag=i;
					p.Click+=new EventHandler(ClickCarEasy);
					p.Cursor=Cursors.Hand;
					panel1.Controls.Add(p);
				}
				farg = Framework.rndInt(1,5);
				labelinstruktion.Text="Klicka på den "+FargerEasy[farg]+"a bilen";
			}
			
			else if (Config.LoggedInUser.difficulty== Difficulty.normal) {
				prgProgress.Maximum=15;
				SpawnNormal();
			}else if (Config.LoggedInUser.difficulty== Difficulty.hard) {
				prgProgress.Maximum=20;
				SpawnHard();
			}
			
		}
			void PicBackClick(object sender, EventArgs e) {
				Dialog.YesNoDialog AreYouSure =new glass.Dialog.YesNoDialog();
				AreYouSure.ShowDialog();
				if(AreYouSure.Answer){
					this.Close(); }
			
		}
		
			void ClickCarEasy(object sender,EventArgs e) {
				PictureBox PictureBoxCar=(PictureBox) sender;
				if(farg==Convert.ToInt32(PictureBoxCar.Tag))
				{
					prgProgress.PerformStep();
					farg = Framework.rndInt(1,5);
					labelinstruktion.Text="Klicka på den "+FargerEasy[farg]+"a bilen";
					CheckWin();
				}
			}
		void ClickCarNormal(object sender,EventArgs e) {
				PictureBox PictureBoxCar=(PictureBox) sender;
				if(farg==Convert.ToInt32(PictureBoxCar.Tag))
				{
					prgProgress.PerformStep();
					SpawnNormal();
					CheckWin();
				}
			}
		void ClickCarHard(object sender,EventArgs e) {
				PictureBox PictureBoxCar=(PictureBox) sender;
				if(farg==Convert.ToInt32(PictureBoxCar.Tag))
				{
					prgProgress.PerformStep();
					SpawnHard();
					CheckWin();
				}
			}
			
		void SpawnNormal() {
			int start=Framework.rndInt(0,3);
				int i;
				panel1.Controls.Clear();
				for (i=start;i <=4+start;i++){
					p=new PictureBox();
					p.SizeMode=PictureBoxSizeMode.CenterImage;
					p.Image=BilderNormal[i];
					p.Location=new Point(5+(150*(i-start)),400);
					p.Width=150;
					p.Height=150;
					p.Tag=i;
					p.Click+=new EventHandler(ClickCarNormal);
					p.Cursor=Cursors.Hand;
					panel1.Controls.Add(p);
				}
				farg = Framework.rndInt(start+1,start+5);
				labelinstruktion.Text="Klicka på den "+FargerNormal[farg]+"a "+ObjektNormal[farg];
		}
		void SpawnHard() {
			int start=Framework.rndInt(0,6);
				int i;
				panel1.Controls.Clear();
				for (i=start;i <=4+start;i++){
					p=new PictureBox();
					p.SizeMode=PictureBoxSizeMode.CenterImage;
					p.Image=BilderHard[i];
					p.Location=new Point(5+(150*(i-start)),400);
					p.Width=150;
					p.Height=150;
					p.Tag=i;
					p.Click+=new EventHandler(ClickCarHard);
					p.Cursor=Cursors.Hand;
					panel1.Controls.Add(p);
				}
				farg = Framework.rndInt(start+1,start+5);
				labelinstruktion.Text="Klicka på den "+FargerHard[farg]+"a "+ObjektHard[farg];
		}
		void CheckWin() {
			if(prgProgress.Value==prgProgress.Maximum) {
				if((Config.LoggedInUser.score&((int)Framework.LevelScores.Colors<<(int)Config.LoggedInUser.difficulty))!=((int)Framework.LevelScores.Colors<<(int)Config.LoggedInUser.difficulty)) {
		   			Config.LoggedInUser.score+=(uint)Framework.LevelScores.Colors<<(int)Config.LoggedInUser.difficulty;
		   			Config.UpdateScore(Config.LoggedInUser);
		   		}
				Framework.sndPlay.SoundLocation=@"Sounds/bra.wav";
				Framework.sndPlay.Play();
				MessageBox.Show(Config.LoggedInUser.score.ToString());
				this.Close();
			}
		}
	}
}
