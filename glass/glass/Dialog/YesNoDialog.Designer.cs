/*
 * User: Axel
 * Date: 2010-11-23
 * Time: 20:46
 */
namespace glass.Dialog
{
	partial class YesNoDialog
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
			this.btnNo = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.lblCaption = new System.Windows.Forms.Label();
			this.lblText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.Red;
			this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNo.Location = new System.Drawing.Point(12, 211);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(122, 79);
			this.btnNo.TabIndex = 0;
			this.btnNo.Text = "Nej";
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Click += new System.EventHandler(this.BtnNoClick);
			// 
			// btnYes
			// 
			this.btnYes.BackColor = System.Drawing.Color.Lime;
			this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYes.Location = new System.Drawing.Point(290, 211);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(122, 79);
			this.btnYes.TabIndex = 1;
			this.btnYes.Text = "Ja";
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Click += new System.EventHandler(this.BtnYesClick);
			// 
			// lblCaption
			// 
			this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaption.ForeColor = System.Drawing.Color.White;
			this.lblCaption.Location = new System.Drawing.Point(29, 22);
			this.lblCaption.Name = "lblCaption";
			this.lblCaption.Size = new System.Drawing.Size(337, 59);
			this.lblCaption.TabIndex = 2;
			this.lblCaption.Text = "Vill du avsluta?";
			// 
			// lblText
			// 
			this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(48, 108);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(318, 51);
			this.lblText.TabIndex = 3;
			this.lblText.Text = "Om du avslutar nu måste du göra om denna del senare.";
			// 
			// YesNoDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(424, 302);
			this.Controls.Add(this.lblText);
			this.Controls.Add(this.lblCaption);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.btnNo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "YesNoDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ja eller Nej";
			this.TopMost = true;
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label lblText;
		public System.Windows.Forms.Label lblCaption;
		public System.Windows.Forms.Button btnYes;
		public System.Windows.Forms.Button btnNo;
	}
}
