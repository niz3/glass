/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 19:14
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using glass.framework;

namespace glass.Screens {
	public partial class MainMenuScreen : Form {
		public MainMenuScreen() {
			InitializeComponent();
			picBack.MouseEnter+= new EventHandler(Framework.EnterClickable);
			picBack.MouseLeave+= new EventHandler(Framework.LeaveClickable);
			
			picPrepositions.MouseEnter+=new EventHandler(Framework.EnterClickable);
			picPrepositions.MouseLeave+=new EventHandler(Framework.LeaveClickable);
		}
		
		void PicBackClick(object sender, EventArgs e) {
			this.Close();
		}
		
		void PicPrepositionsClick(object sender, EventArgs e) {
			GamePrepositions frmGamePrepositions=new GamePrepositions();
			frmGamePrepositions.Show(this);
		}
	}
}
