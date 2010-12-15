/*
 * User: Axel
 * Date: 2010-11-23
 * Time: 20:46
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace glass.Dialog {
	public partial class YesNoDialog : Form {
		public bool Answer=false;
		public YesNoDialog() {
			InitializeComponent();
		}
		
		void BtnYesClick(object sender, EventArgs e) {
			Answer=true;
			this.Close();
		}
		
		void BtnNoClick(object sender, EventArgs e){
			Answer=false;
			this.Close();
		}
	}
}
