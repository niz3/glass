/*
 * Created by SharpDevelop.
 * User: Axel
 * Date: 2010-11-08
 * Time: 19:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace glass.Dialog
{
	partial class WebcamDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>

		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebcamDialog));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pctCam = new System.Windows.Forms.PictureBox();
			this.btnSnap = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctCam)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.pctCam, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSnap, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 480);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pctCam
			// 
			this.pctCam.BackColor = System.Drawing.Color.Black;
			this.pctCam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctCam.ErrorImage = null;
			this.pctCam.Image = ((System.Drawing.Image)(resources.GetObject("pctCam.Image")));
			this.pctCam.InitialImage = null;
			this.pctCam.Location = new System.Drawing.Point(3, 3);
			this.pctCam.Name = "pctCam";
			this.pctCam.Size = new System.Drawing.Size(634, 442);
			this.pctCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pctCam.TabIndex = 1;
			this.pctCam.TabStop = false;
			// 
			// btnSnap
			// 
			this.btnSnap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSnap.Enabled = false;
			this.btnSnap.Location = new System.Drawing.Point(3, 451);
			this.btnSnap.Name = "btnSnap";
			this.btnSnap.Size = new System.Drawing.Size(634, 26);
			this.btnSnap.TabIndex = 2;
			this.btnSnap.Text = "Ta Kort";
			this.btnSnap.UseVisualStyleBackColor = true;
			this.btnSnap.Click += new System.EventHandler(this.BtnSnapClick);
			// 
			// WebcamDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 480);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WebcamDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ta Kort";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WebcamDialogFormClosed);
			this.Shown += new System.EventHandler(this.WebcamDialogShown);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctCam)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSnap;
		private System.Windows.Forms.PictureBox pctCam;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
