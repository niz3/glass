/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 23:28
 */
namespace glass.Screens
{
	partial class GamePrepositions
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
			this.drawArea1 = new glass.framework.DrawArea();
			this.prgProgress = new System.Windows.Forms.ProgressBar();
			this.picBack = new System.Windows.Forms.PictureBox();
			this.lblInstruction = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
			this.SuspendLayout();
			// 
			// drawArea1
			// 
			this.drawArea1.BackColor = System.Drawing.Color.Transparent;
			this.drawArea1.BackgroundImage = global::glass.Resources.rum_prepositioner;
			this.drawArea1.Location = new System.Drawing.Point(0, 32);
			this.drawArea1.Name = "drawArea1";
			this.drawArea1.Size = new System.Drawing.Size(800, 570);
			this.drawArea1.TabIndex = 0;
			// 
			// prgProgress
			// 
			this.prgProgress.Location = new System.Drawing.Point(0, 0);
			this.prgProgress.MarqueeAnimationSpeed = 0;
			this.prgProgress.Maximum = 10;
			this.prgProgress.Name = "prgProgress";
			this.prgProgress.Size = new System.Drawing.Size(225, 32);
			this.prgProgress.Step = 1;
			this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgProgress.TabIndex = 2;
			// 
			// picBack
			// 
			this.picBack.Image = global::glass.Resources.exit;
			this.picBack.Location = new System.Drawing.Point(768, 0);
			this.picBack.Name = "picBack";
			this.picBack.Size = new System.Drawing.Size(32, 32);
			this.picBack.TabIndex = 1;
			this.picBack.TabStop = false;
			this.picBack.Click += new System.EventHandler(this.PicBackClick);
			// 
			// lblInstruction
			// 
			this.lblInstruction.BackColor = System.Drawing.SystemColors.Control;
			this.lblInstruction.Location = new System.Drawing.Point(231, 9);
			this.lblInstruction.Name = "lblInstruction";
			this.lblInstruction.Size = new System.Drawing.Size(431, 19);
			this.lblInstruction.TabIndex = 0;
			this.lblInstruction.Text = "Instruktioner";
			// 
			// GamePrepositions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.picBack);
			this.Controls.Add(this.prgProgress);
			this.Controls.Add(this.drawArea1);
			this.Controls.Add(this.lblInstruction);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GamePrepositions";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GamePrepositions";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.GamePrepositionsShown);
			((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
			this.ResumeLayout(false);
		}
		private glass.framework.DrawArea drawArea1;
		private System.Windows.Forms.ProgressBar prgProgress;
		private System.Windows.Forms.PictureBox picBack;
		private System.Windows.Forms.Label lblInstruction;
	}
}
