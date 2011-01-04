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
	public partial class DifficultyDialog : Form {
		public glass.config.Difficulty Difficulty=glass.config.Difficulty.normal;
		public DifficultyDialog() {
			InitializeComponent();
			Framework.sndPlay.SoundLocation=@"Sounds\bra.wav";
			Framework.sndPlay.Play();
		}
		
		void BtnOkClick(object sender, EventArgs e) {
			this.Close();
		}
		
		void TrkDifficultyScroll(object sender, EventArgs e) {
			Difficulty=(glass.config.Difficulty)trkDifficulty.Value;
		}
	}
}
