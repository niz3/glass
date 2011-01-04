/*
 * User: Axel
 * Date: 2010-11-17
 * Time: 19:14
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using glass.framework;
using glass.config;

namespace glass.Screens {
	public partial class MainMenuScreen : Form {
		Bitmap[] star={
			global::glass.Resources.star000,
			global::glass.Resources.star100,
			global::glass.Resources.star010,
			global::glass.Resources.star110,
			global::glass.Resources.star001,
			global::glass.Resources.star101,
			global::glass.Resources.star111,
		};
		public MainMenuScreen() {
			InitializeComponent();
			Framework.sndPlay.SoundLocation=@"Sounds\starta.wav";
			Framework.sndPlay.Play();
			
			UpdateScore();
		}
		
		void PicBackClick(object sender, EventArgs e) {
			this.Close();
		}
		
		void PicPrepositionsClick(object sender, EventArgs e) {
			SetDifficulty();
			GamePrepositions frmGamePrepositions=new GamePrepositions();
			frmGamePrepositions.ShowDialog(this);
			UpdateScore();
		}
		
		void PicClothesClick(object sender, EventArgs e){
			SetDifficulty();
			GameClothes frmGameClothes=new GameClothes();
			frmGameClothes.ShowDialog(this);
			UpdateScore();
		}
		void PicFruitsClick(object sender, EventArgs e){
			SetDifficulty();
			GameFruits frmGameFruits=new GameFruits();
			frmGameFruits.ShowDialog(this);
			UpdateScore();
		}
		
		void PicColorsClick(object sender, EventArgs e){
			SetDifficulty();
			GameFarger frmGameFarger=new GameFarger();
			frmGameFarger.ShowDialog(this);
			UpdateScore();
		}
		void SetDifficulty() {
			Dialog.DifficultyDialog frmDifficultyDialog=new glass.Dialog.DifficultyDialog();
			frmDifficultyDialog.ShowDialog();
			config.Config.LoggedInUser.difficulty=frmDifficultyDialog.Difficulty;
		}
		
		void UpdateScore() {
			picPrepositions.Image=star[((Config.LoggedInUser.score>>0)&7)];
			picFruits.Image=star[((Config.LoggedInUser.score>>6)&7)];
			picColors.Image=star[((Config.LoggedInUser.score>>9)&7)];
			picClothes.Image=star[((Config.LoggedInUser.score>>3)&7)];
		}
	}
}
