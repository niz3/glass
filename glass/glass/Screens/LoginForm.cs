/*
 * User: Axel
 * Date: 2010-11-08
 * Time: 18:49
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using glass.config;

namespace glass {
	public partial class LoginForm : Form {
		private int scroll=0;
		public LoginForm() {
			InitializeComponent();
			
			PictureBox pct=new PictureBox();
			pct.Image=Resources.new_user;
			pct.SizeMode=PictureBoxSizeMode.StretchImage;
			pct.Dock=DockStyle.Fill;
			pct.MouseEnter+=new EventHandler(EnterClickable);
			pct.MouseLeave+=new EventHandler(LeaveClickable);
			pct.Click+=new EventHandler(AddUser);
			pct.TabIndex=0;
			Config.UserFaces.Insert(0,pct);
			foreach (UserList user in Config.Users) {
				pct=new PictureBox();
				pct.Image=user.picture;
				pct.Dock=DockStyle.Fill;
				pct.SizeMode=PictureBoxSizeMode.StretchImage;
				pct.MouseEnter+=new EventHandler(EnterClickable);
				pct.MouseLeave+=new EventHandler(LeaveClickable);
				pct.Click+=new EventHandler(ClickFace);
				pct.TabIndex=Config.UserFaces.Count;
				Config.UserFaces.Add(pct);
			}
			DrawLogin();
		}
		void AddUser(object sender, EventArgs e) {
			Dialog.WebcamDialog frmWebcam=new Dialog.WebcamDialog();
			Cursor=Cursors.WaitCursor;
			frmWebcam.ShowDialog(this);
			if(frmWebcam.b!=null) {
				UserList temp = new UserList();
				temp.id=Config.Users.Count;temp.picture=frmWebcam.b;temp.score=0;temp.difficulty=Difficulty.easy;
				Config.Users.Add(temp);
				PictureBox pct=new PictureBox();
				pct.Image=temp.picture;
				pct.Dock=DockStyle.Fill;
				pct.SizeMode=PictureBoxSizeMode.StretchImage;
				pct.MouseEnter+=new EventHandler(EnterClickable);
				pct.MouseLeave+=new EventHandler(LeaveClickable);
				pct.Click+=new EventHandler(ClickFace);
				pct.TabIndex=Config.UserFaces.Count;
				Config.UserFaces.Add(pct);
				DrawLogin();
				Config.SaveUser(temp.id);
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
		
		//functions to highlight clickable objects by changing cursor
		public void EnterClickable(object sender, EventArgs e){
			Cursor=Cursors.Hand;
		}
		public void LeaveClickable(object sender, EventArgs e) {
			Cursor=Cursors.Default;
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
		void ClickFace(object sender, EventArgs e) {
			PictureBox pct=(PictureBox)sender;
			MessageBox.Show(Config.Users[pct.TabIndex-1].id.ToString());
		}
	}
}
