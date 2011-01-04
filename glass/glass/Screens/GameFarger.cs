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
			"gul",
			"blå",
			"grön",
			"röd",
			"vit",
		};
		Bitmap[] BilderEasy = {
			global::glass.Resources.bil_gul,
			global::glass.Resources.bil_bla,
			global::glass.Resources.bil_gron,
			global::glass.Resources.bil_rod,
			global::glass.Resources.bil_vit,
		};
		
		string[] FargerNormal = {
			"blå",
			"ros",
			"röd",
			"vit",
			"grön",
			"brun",
			"gul",
			"gul",
		};
		string[] ObjektNormal= {
			"bilen",
			"huset",
			"bilen",
			"bilen",
			"bilen",
			"huset",
			"bilen",
			"huset",
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
			"vitprickig",
			"ros",
			"röd",
			"vit",
			"grön",
			"brun",
			"gul",
			"randig",
			"rödprickig",
			"gul",
			"blå"
		};
		string[] ObjektHard= {
			"huset",
			"huset"	,
			"bilen",
			"bilen",
			"bilen",
			"huset",
			"bilen",
			"bilen",
			"huset",
			"huset",
			"bilen",
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
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\klickaden.wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+FargerEasy[farg].Replace('ä','a').Replace('å','a').Replace('ö','o')+".wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\bilen.wav";
				Framework.sndPlay.Play();
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
					Framework.sndPlay.SoundLocation=@"Sounds\Farger\klickaden.wav";
					Framework.sndPlay.PlaySync();
					Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+FargerEasy[farg].Replace('ä','a').Replace('å','a').Replace('ö','o')+".wav";
					Framework.sndPlay.PlaySync();
					Framework.sndPlay.SoundLocation=@"Sounds\Farger\bilen.wav";
					Framework.sndPlay.Play();
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
				labelinstruktion.Text="Klicka på "+(ObjektNormal[farg]=="huset"?"det ":"den ")+FargerNormal[farg]+"a "+ObjektNormal[farg];
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\klicka"+(ObjektNormal[farg]=="huset"?"det":"den")+".wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+FargerNormal[farg].Replace('ä','a').Replace('å','a').Replace('ö','o')+".wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+(ObjektNormal[farg])+".wav";
				Framework.sndPlay.Play();
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
				labelinstruktion.Text="Klicka på "+(ObjektHard[farg]=="huset"?"det ":"den ")+FargerHard[farg]+"a "+ObjektHard[farg];
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\klicka"+(ObjektHard[farg]=="huset"?"det":"den")+".wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+FargerHard[farg].Replace('ä','a').Replace('å','a').Replace('ö','o')+".wav";
				Framework.sndPlay.PlaySync();
				Framework.sndPlay.SoundLocation=@"Sounds\Farger\"+(ObjektHard[farg])+".wav";
				Framework.sndPlay.Play();
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
