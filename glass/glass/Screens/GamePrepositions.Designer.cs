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
			this.SuspendLayout();
			// 
			// drawArea1
			// 
			this.drawArea1.BackColor = System.Drawing.Color.Blue;
			this.drawArea1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.drawArea1.Location = new System.Drawing.Point(27, 12);
			this.drawArea1.Name = "drawArea1";
			this.drawArea1.Size = new System.Drawing.Size(404, 303);
			this.drawArea1.TabIndex = 0;
			// 
			// GamePrepositions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::glass.Resources.new_user;
			this.ClientSize = new System.Drawing.Size(443, 348);
			this.Controls.Add(this.drawArea1);
			this.Name = "GamePrepositions";
			this.Text = "GamePrepositions";
			this.ResumeLayout(false);
		}
		private glass.framework.DrawArea drawArea1;
	}
}
