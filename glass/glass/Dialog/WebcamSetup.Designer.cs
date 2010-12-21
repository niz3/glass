/*
 * User: Axel
 * Date: 2010-12-13
 * Time: 15:00
 */
namespace glass.Dialog
{
	partial class WebcamSetup
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
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dmnWidth = new System.Windows.Forms.DomainUpDown();
			this.dmnHeight = new System.Windows.Forms.DomainUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.dmnIndex = new System.Windows.Forms.DomainUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.dmnBpp = new System.Windows.Forms.DomainUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(151, 138);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(93, 22);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Bredd";
			// 
			// dmnWidth
			// 
			this.dmnWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dmnWidth.Location = new System.Drawing.Point(151, 33);
			this.dmnWidth.Name = "dmnWidth";
			this.dmnWidth.Size = new System.Drawing.Size(93, 20);
			this.dmnWidth.TabIndex = 3;
			this.dmnWidth.Text = "320";
			// 
			// dmnHeight
			// 
			this.dmnHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dmnHeight.Location = new System.Drawing.Point(151, 59);
			this.dmnHeight.Name = "dmnHeight";
			this.dmnHeight.Size = new System.Drawing.Size(93, 20);
			this.dmnHeight.TabIndex = 5;
			this.dmnHeight.Text = "240";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Höjd";
			// 
			// dmnIndex
			// 
			this.dmnIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dmnIndex.Location = new System.Drawing.Point(151, 7);
			this.dmnIndex.Name = "dmnIndex";
			this.dmnIndex.Size = new System.Drawing.Size(93, 20);
			this.dmnIndex.TabIndex = 7;
			this.dmnIndex.Text = "0";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Index";
			// 
			// dmnBpp
			// 
			this.dmnBpp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dmnBpp.Location = new System.Drawing.Point(151, 85);
			this.dmnBpp.Name = "dmnBpp";
			this.dmnBpp.Size = new System.Drawing.Size(93, 20);
			this.dmnBpp.TabIndex = 9;
			this.dmnBpp.Text = "24";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(12, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Färgdjup";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(231, 26);
			this.label5.TabIndex = 10;
			this.label5.Text = "Om du är osäker bör du klicka OK och använda standardinställningarna.";
			// 
			// WebcamSetup
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 172);
			this.ControlBox = false;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dmnBpp);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dmnIndex);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dmnHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dmnWidth);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WebcamSetup";
			this.Text = "Ställ in webkamera";
			this.TopMost = true;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DomainUpDown dmnBpp;
		private System.Windows.Forms.DomainUpDown dmnIndex;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DomainUpDown dmnHeight;
		private System.Windows.Forms.DomainUpDown dmnWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOK;
	}
}
