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
		}
		
		void PicBackClick(object sender, EventArgs e) {
			this.Close();
		}
		
		void PicPrepositionsClick(object sender, EventArgs e) {
			SetDifficulty();
			GamePrepositions frmGamePrepositions=new GamePrepositions();
			frmGamePrepositions.Show(this);
		}
		
		void PicFruitsClick(object sender, EventArgs e){
			SetDifficulty();
			GameFruits frmGameFruits=new GameFruits();
			frmGameFruits.Show(this);
		}
		
		void PicColorsClick(object sender, EventArgs e){
			SetDifficulty();
			GameFarger frmGameFarger=new GameFarger();
			frmGameFarger.Show();
		}
		void SetDifficulty() {
			Dialog.DifficultyDialog frmDifficultyDialog=new glass.Dialog.DifficultyDialog();
			frmDifficultyDialog.ShowDialog();
			config.Config.LoggedInUser.difficulty=frmDifficultyDialog.Difficulty;
		}
	}
}
