/*
 * User: Axel
 * Date: 2010-12-13
 * Time: 15:00
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace glass.Dialog
{
	/// <summary>
	/// Description of WebcamSetup.
	/// </summary>
	public partial class WebcamSetup : Form
	{
		public WebcamSetup()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOKClick(object sender, EventArgs e){
			this.Close();
		}
	}
}
