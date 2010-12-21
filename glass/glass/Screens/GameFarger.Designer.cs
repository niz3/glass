/*
 * Created by SharpDevelop.
 * User: ma930131
 * Date: 2010-11-15
 * Time: 10:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace glass.Screens
{
	partial class GameFarger
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFarger));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.PicBack = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.labelinstruktion = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::glass.Resources.bil_bla;
			this.pictureBox1.Location = new System.Drawing.Point(162, 521);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(162, 67);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "1";
			this.pictureBox1.Click += new System.EventHandler(this.ClickCar);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::glass.Resources.bil_gron;
			this.pictureBox2.Location = new System.Drawing.Point(330, 521);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(152, 67);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "2";
			this.pictureBox2.Click += new System.EventHandler(this.ClickCar);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::glass.Resources.bil_rod;
			this.pictureBox3.Location = new System.Drawing.Point(488, 521);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(155, 67);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "3";
			this.pictureBox3.Click += new System.EventHandler(this.ClickCar);
			// 
			// PicBack
			// 
			this.PicBack.BackgroundImage = global::glass.Resources.exit;
			this.PicBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PicBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PicBack.Location = new System.Drawing.Point(768, 0);
			this.PicBack.Name = "PicBack";
			this.PicBack.Size = new System.Drawing.Size(32, 32);
			this.PicBack.TabIndex = 5;
			this.PicBack.TabStop = false;
			this.PicBack.Click += new System.EventHandler(this.PicBackClick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Location = new System.Drawing.Point(12, 521);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(144, 67);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Tag = "0";
			this.pictureBox4.Click += new System.EventHandler(this.ClickCar);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Location = new System.Drawing.Point(649, 521);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(159, 67);
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Tag = "4";
			this.pictureBox5.Click += new System.EventHandler(this.ClickCar);
			// 
			// labelinstruktion
			// 
			this.labelinstruktion.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelinstruktion.ForeColor = System.Drawing.Color.Yellow;
			this.labelinstruktion.Location = new System.Drawing.Point(30, 23);
			this.labelinstruktion.Name = "labelinstruktion";
			this.labelinstruktion.Size = new System.Drawing.Size(514, 28);
			this.labelinstruktion.TabIndex = 8;
			this.labelinstruktion.Text = "label1";
			// 
			// GameFarger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.labelinstruktion);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.PicBack);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GameFarger";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "farger";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.GameFargerLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelinstruktion;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox PicBack;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
