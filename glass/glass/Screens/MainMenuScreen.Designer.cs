/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 19:14
 */
namespace glass.Screens
{
	partial class MainMenuScreen
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
			this.picPrepositions = new System.Windows.Forms.PictureBox();
			this.picFruits = new System.Windows.Forms.PictureBox();
			this.picColors = new System.Windows.Forms.PictureBox();
			this.picClothes = new System.Windows.Forms.PictureBox();
			this.picBack = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPrepositions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFruits)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picColors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClothes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.picPrepositions, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.picFruits, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.picColors, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.picClothes, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 538);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// picPrepositions
			// 
			this.picPrepositions.BackgroundImage = global::glass.Resources.rum_prepositioner;
			this.picPrepositions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPrepositions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picPrepositions.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picPrepositions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picPrepositions.Location = new System.Drawing.Point(5, 5);
			this.picPrepositions.Name = "picPrepositions";
			this.picPrepositions.Size = new System.Drawing.Size(380, 261);
			this.picPrepositions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPrepositions.TabIndex = 5;
			this.picPrepositions.TabStop = false;
			this.picPrepositions.Click += new System.EventHandler(this.PicPrepositionsClick);
			// 
			// picFruits
			// 
			this.picFruits.BackColor = System.Drawing.Color.Sienna;
			this.picFruits.BackgroundImage = global::glass.Resources.rum_frukter;
			this.picFruits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picFruits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFruits.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picFruits.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picFruits.Location = new System.Drawing.Point(391, 5);
			this.picFruits.Name = "picFruits";
			this.picFruits.Size = new System.Drawing.Size(380, 261);
			this.picFruits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFruits.TabIndex = 6;
			this.picFruits.TabStop = false;
			this.picFruits.Click += new System.EventHandler(this.PicFruitsClick);
			// 
			// picColors
			// 
			this.picColors.BackColor = System.Drawing.Color.Transparent;
			this.picColors.BackgroundImage = global::glass.Resources.meny_farger;
			this.picColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picColors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picColors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picColors.Image = global::glass.Resources.meny_farger;
			this.picColors.Location = new System.Drawing.Point(5, 272);
			this.picColors.Name = "picColors";
			this.picColors.Size = new System.Drawing.Size(380, 261);
			this.picColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picColors.TabIndex = 2;
			this.picColors.TabStop = false;
			this.picColors.Click += new System.EventHandler(this.PicColorsClick);
			// 
			// picClothes
			// 
			this.picClothes.BackColor = System.Drawing.Color.Purple;
			this.picClothes.BackgroundImage = global::glass.Resources.meny_klader;
			this.picClothes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picClothes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picClothes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClothes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picClothes.Location = new System.Drawing.Point(391, 272);
			this.picClothes.Name = "picClothes";
			this.picClothes.Size = new System.Drawing.Size(380, 261);
			this.picClothes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClothes.TabIndex = 1;
			this.picClothes.TabStop = false;
			this.picClothes.Click += new System.EventHandler(this.PicClothesClick);
			// 
			// picBack
			// 
			this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picBack.Image = global::glass.Resources.exit;
			this.picBack.Location = new System.Drawing.Point(768, 0);
			this.picBack.Name = "picBack";
			this.picBack.Size = new System.Drawing.Size(32, 32);
			this.picBack.TabIndex = 4;
			this.picBack.TabStop = false;
			this.picBack.Click += new System.EventHandler(this.PicBackClick);
			// 
			// MainMenuScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.picBack);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainMenuScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainMenu";
			this.TopMost = true;
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picPrepositions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFruits)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picColors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClothes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picColors;
		private System.Windows.Forms.PictureBox picFruits;
		private System.Windows.Forms.PictureBox picClothes;
		private System.Windows.Forms.PictureBox picPrepositions;
		private System.Windows.Forms.PictureBox picBack;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
