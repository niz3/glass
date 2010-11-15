/*
 * Created by SharpDevelop.
 * User: Axel
 * Date: 2010-11-08
 * Time: 18:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace glass
{
	partial class LoginForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pctUp = new System.Windows.Forms.PictureBox();
			this.pctDown = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pctUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctDown)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 22);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 519);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// pctUp
			// 
			this.pctUp.Image = global::glass.Resources.up;
			this.pctUp.Location = new System.Drawing.Point(720, 64);
			this.pctUp.Name = "pctUp";
			this.pctUp.Size = new System.Drawing.Size(64, 64);
			this.pctUp.TabIndex = 2;
			this.pctUp.TabStop = false;
			this.pctUp.Click += new System.EventHandler(this.PctUpClick);
			this.pctUp.MouseEnter += new System.EventHandler(this.EnterClickable);
			this.pctUp.MouseLeave += new System.EventHandler(this.LeaveClickable);
			// 
			// pctDown
			// 
			this.pctDown.Image = global::glass.Resources.down;
			this.pctDown.Location = new System.Drawing.Point(720, 472);
			this.pctDown.Name = "pctDown";
			this.pctDown.Size = new System.Drawing.Size(64, 64);
			this.pctDown.TabIndex = 3;
			this.pctDown.TabStop = false;
			this.pctDown.Click += new System.EventHandler(this.PctDownClick);
			this.pctDown.MouseEnter += new System.EventHandler(this.EnterClickable);
			this.pctDown.MouseLeave += new System.EventHandler(this.LeaveClickable);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Blue;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.pctDown);
			this.Controls.Add(this.pctUp);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pctUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctDown)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pctDown;
		private System.Windows.Forms.PictureBox pctUp;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
