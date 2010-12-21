/*
 * User: Axel
 * Date: 2010-11-23
 * Time: 20:46
 */
namespace glass.Dialog
{
	partial class DifficultyDialog
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
		private void InitializeComponent() {
			this.btnOk = new System.Windows.Forms.Button();
			this.lblCaption = new System.Windows.Forms.Label();
			this.lblText = new System.Windows.Forms.Label();
			this.trkDifficulty = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.trkDifficulty)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.Lime;
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(151, 237);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(122, 53);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "Klar";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// lblCaption
			// 
			this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaption.ForeColor = System.Drawing.Color.White;
			this.lblCaption.Location = new System.Drawing.Point(29, 22);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(337, 59);
			this.lblCaption.TabIndex = 2;
			this.lblCaption.Text = "Välj svårighetsgrad";
			// 
			// lblText
			// 
			this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(48, 108);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(318, 51);
			this.lblText.TabIndex = 3;
			this.lblText.Text = "Hur svårt vill du att spelet ska vara?";
			// 
			// trkDifficulty
			// 
			this.trkDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trkDifficulty.LargeChange = 1;
			this.trkDifficulty.Location = new System.Drawing.Point(48, 147);
			this.trkDifficulty.Maximum = 2;
			this.trkDifficulty.Name = "trkDifficulty";
			this.trkDifficulty.Size = new System.Drawing.Size(330, 45);
			this.trkDifficulty.TabIndex = 4;
			this.trkDifficulty.Value = 1;
			this.trkDifficulty.Scroll += new System.EventHandler(this.TrkDifficultyScroll);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(38, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Lätt";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(182, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mellan";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(340, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Svårt";
			// 
			// DifficultyDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(424, 302);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trkDifficulty);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DifficultyDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ja eller Nej";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.trkDifficulty)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trkDifficulty;
		public System.Windows.Forms.Label lblText;
		public System.Windows.Forms.Label lblCaption;
	}
}
