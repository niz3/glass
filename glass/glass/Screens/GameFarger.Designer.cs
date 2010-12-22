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
			this.PicBack = new System.Windows.Forms.PictureBox();
			this.labelinstruktion = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.prgProgress = new System.Windows.Forms.ProgressBar();
			((System.ComponentModel.ISupportInitialize)(this.PicBack)).BeginInit();
			this.SuspendLayout();
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
			// labelinstruktion
			// 
			this.labelinstruktion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelinstruktion.Location = new System.Drawing.Point(231, 9);
			this.labelinstruktion.Name = "labelinstruktion";
			this.labelinstruktion.Size = new System.Drawing.Size(514, 25);
			this.labelinstruktion.TabIndex = 8;
			this.labelinstruktion.Text = "label1";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panel1.Location = new System.Drawing.Point(0, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 568);
			this.panel1.TabIndex = 9;
			// 
			// prgProgress
			// 
			this.prgProgress.Location = new System.Drawing.Point(0, 0);
			this.prgProgress.Name = "prgProgress";
			this.prgProgress.Size = new System.Drawing.Size(225, 32);
			this.prgProgress.Step = 1;
			this.prgProgress.TabIndex = 10;
			// 
			// GameFarger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.prgProgress);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.labelinstruktion);
			this.Controls.Add(this.PicBack);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GameFarger";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "farger";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.PicBack)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar prgProgress;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelinstruktion;
		private System.Windows.Forms.PictureBox PicBack;
	}
}
