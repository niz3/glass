/*
 * Created by SharpDevelop.
 * User: nn930428
 * Date: 2010-11-08
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace glass
{
	partial class MainForm
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
			this.BorderFrame = new System.Windows.Forms.TableLayoutPanel();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.BorderFrame.SuspendLayout();
			this.SuspendLayout();
			// 
			// BorderFrame
			// 
			this.BorderFrame.BackColor = System.Drawing.Color.Black;
			this.BorderFrame.ColumnCount = 3;
			this.BorderFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BorderFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
			this.BorderFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BorderFrame.Controls.Add(this.MainPanel, 1, 1);
			this.BorderFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BorderFrame.Location = new System.Drawing.Point(0, 0);
			this.BorderFrame.Name = "BorderFrame";
			this.BorderFrame.RowCount = 3;
			this.BorderFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BorderFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
			this.BorderFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.BorderFrame.Size = new System.Drawing.Size(878, 745);
			this.BorderFrame.TabIndex = 0;
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.Black;
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(42, 75);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(794, 594);
			this.MainPanel.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(878, 745);
			this.ControlBox = false;
			this.Controls.Add(this.BorderFrame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "glass";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.BorderFrame.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TableLayoutPanel BorderFrame;
		private System.Windows.Forms.Panel MainPanel;
	}
}
