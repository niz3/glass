/*
 * Created by SharpDevelop.
 * User: nn930428
 * Date: 2010-11-08
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace glass {
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	
	internal sealed class Program {
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
