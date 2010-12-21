/*
 * Created by SharpDevelop.
 * User: ds930619
 * Date: 2010-11-22
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace glass.Screens
{
	partial class GameClothes
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
			this.picBack = new System.Windows.Forms.PictureBox();
			this.drawArea1 = new glass.framework.DrawArea();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
			this.SuspendLayout();
			// 
			// picBack
			// 
			this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBack.Image = global::glass.Resources.exit;
			this.picBack.Location = new System.Drawing.Point(768, 0);
			this.picBack.Name = "picBack";
			this.picBack.Size = new System.Drawing.Size(32, 32);
			this.picBack.TabIndex = 0;
			this.picBack.TabStop = false;
			this.picBack.Click += new System.EventHandler(this.PicBackClick);
			// 
			// drawArea1
			// 
			this.drawArea1.BackColor = System.Drawing.Color.Transparent;
			this.drawArea1.BackgroundImage = global::glass.Resources.Gubbsovrum;
			this.drawArea1.Location = new System.Drawing.Point(0, 32);
			this.drawArea1.Name = "drawArea1";
			this.drawArea1.Size = new System.Drawing.Size(800, 570);
			this.drawArea1.TabIndex = 1;
			// 
			// GameClothes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.drawArea1);
			this.Controls.Add(this.picBack);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GameClothes";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameClothes";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
			this.ResumeLayout(false);
		}
		private glass.framework.DrawArea drawArea1;
		private System.Windows.Forms.PictureBox picBack;
	}
}
