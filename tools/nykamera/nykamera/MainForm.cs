/*
 * Created by SharpDevelop.
 * User: Axel
 * Date: 2010-11-05
 * Time: 14:03
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

namespace nykamera {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {
		private System.ComponentModel.Container components = null;
		private Capture cam;
		IntPtr m_ip = IntPtr.Zero;
		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			cam=new Capture(0,640,480,24,pictureBox1);
		}
		
		protected override void Dispose( bool disposing ) {
            if( disposing ) {
                if (components != null)  {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );

            if (m_ip != IntPtr.Zero) {
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }
        }
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			cam.Dispose();

            if (m_ip != IntPtr.Zero){
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }
		}
		
		void Button1Click(object sender, EventArgs e){
			m_ip=cam.Click();
			Bitmap b = new Bitmap(cam.Width, cam.Height, cam.Stride, PixelFormat.Format24bppRgb, m_ip);
			b.RotateFlip(RotateFlipType.RotateNoneFlipY);
			b.Save(Environment.GetEnvironmentVariable("temp")+"\\snap.png");
			Process paint=new Process();
			paint.StartInfo.FileName="mspaint.exe";
			paint.StartInfo.Arguments=Environment.GetEnvironmentVariable("temp")+"\\snap.png";
			paint.Start();
			Application.Exit();
		}
	}
}
