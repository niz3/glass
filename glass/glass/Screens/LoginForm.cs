/*
 * User: Axel
 * Date: 2010-11-08
 * Time: 18:49
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using glass.config;
using glass.framework;

namespace glass {
	public partial class LoginForm : Form {
		private int scroll=0;
		public LoginForm() {
			InitializeComponent();
			
			this.pctUp.MouseEnter += new System.EventHandler(Framework.EnterClickable);
			this.pctUp.MouseLeave += new System.EventHandler(Framework.LeaveClickable);
			this.pctDown.MouseEnter += new System.EventHandler(Framework.EnterClickable);
			this.pctDown.MouseLeave += new System.EventHandler(Framework.LeaveClickable);
			this.picExit.MouseEnter += new System.EventHandler(Framework.EnterClickable);
			this.picExit.MouseLeave += new System.EventHandler(Framework.LeaveClickable);
			
			this.MouseWheel+= new MouseEventHandler(ScrollEvent);
			
			PictureBox pct=new PictureBox();
			pct.Image=Resources.new_user;
			pct.SizeMode=PictureBoxSizeMode.StretchImage;
			pct.Dock=DockStyle.Fill;
			pct.MouseEnter+=new EventHandler(Framework.EnterClickable);
			pct.MouseLeave+=new EventHandler(Framework.LeaveClickable);
			pct.Click+=new EventHandler(AddUser);
			pct.TabIndex=0;
			Config.UserFaces.Insert(0,pct);
			foreach (UserList user in Config.Users) {
				pct=new PictureBox();
				pct.Image=user.picture;
				pct.Dock=DockStyle.Fill;
				pct.SizeMode=PictureBoxSizeMode.StretchImage;
				pct.MouseEnter+=new EventHandler(Framework.EnterClickable);
				pct.MouseLeave+=new EventHandler(Framework.LeaveClickable);
				pct.Click+=new EventHandler(ClickFace);
				pct.TabIndex=Config.UserFaces.Count;
				Config.UserFaces.Add(pct);
			}
			DrawLogin();
			Framework.sndPlay.SoundLocation=@"Sounds\login.wav";
			Framework.sndPlay.Play();
		}
		void AddUser(object sender, EventArgs e) {
			Dialog.WebcamDialog frmWebcam=new Dialog.WebcamDialog();
			frmWebcam.ShowDialog(this);
			if(frmWebcam.b!=null) {
				
				Framework.AddUser("",frmWebcam.b,Difficulty.easy ,0);
				PictureBox pct=new PictureBox();
				pct.Image=frmWebcam.b;
				pct.Dock=DockStyle.Fill;
				pct.SizeMode=PictureBoxSizeMode.StretchImage;
				pct.MouseEnter+=new EventHandler(Framework.EnterClickable);
				pct.MouseLeave+=new EventHandler(Framework.LeaveClickable);
				pct.Click+=new EventHandler(ClickFace);
				pct.TabIndex=Config.UserFaces.Count;
				Config.UserFaces.Add(pct);
				DrawLogin();
			}
		}
		
		//function to draw profile pictures based on scroll value
		private void DrawLogin() {
			tableLayoutPanel1.Controls.Clear();
			int length=Convert.ToInt32(Config.UserFaces.Count)-scroll<9?Convert.ToInt32(Config.UserFaces.Count)-scroll:9;
			for(int i=0;i<length;i++) {
				tableLayoutPanel1.Controls.Add(Config.UserFaces[scroll+i]);
			}
		}
		
		void PctUpClick(object sender, EventArgs e) {
			if(scroll>0) {
				scroll-=3;
				DrawLogin();
			}
		}
		void PctDownClick(object sender, EventArgs e){
			if(Config.UserFaces.Count-scroll>9) {
				scroll+=3;
				DrawLogin();
			}
		}
		
		public void ClickFace(object sender, EventArgs e) {
			PictureBox pct=(PictureBox)sender;
			Config.LoggedInUser=Config.Users[pct.TabIndex-1];
			glass.Screens.MainMenuScreen frmMainMenu =new glass.Screens.MainMenuScreen();
			frmMainMenu.Show(this);
		}
		
		public void PicExitClick(object sender, EventArgs e) {
			Application.Exit();
		}
		private void ScrollEvent(object sender, MouseEventArgs e) {
			if((e.Delta>0)&&(scroll>0)) {
				scroll-=3;
				DrawLogin();
			} else if((e.Delta<0)&&(Config.UserFaces.Count-scroll>9)) {
				scroll+=3;
				DrawLogin();
			}
		}
	}
}
