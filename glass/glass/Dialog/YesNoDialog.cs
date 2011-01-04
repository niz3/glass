/*
 * User: Axel
 * Date: 2010-11-23
 * Time: 20:46
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using glass.framework;

namespace glass.Dialog {
	public partial class YesNoDialog : Form {
		public bool Answer=false;
		public YesNoDialog() {
			InitializeComponent();
			Framework.sndPlay.SoundLocation=@"Sounds\avsluta.wav";
			Framework.sndPlay.Play();
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
