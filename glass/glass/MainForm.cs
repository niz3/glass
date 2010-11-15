/*
 * Created by SharpDevelop.
 * User: nn930428
 * Date: 2010-11-08
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using glass.config;

namespace glass {
	public partial class MainForm : Form {
		private System.ComponentModel.Container components = null;
		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
		void MainFormLoad(object sender, EventArgs e){
			Form frmLogin = new LoginForm();
			frmLogin.ShowDialog(this);
			Application.Exit();
		}
	}
}
