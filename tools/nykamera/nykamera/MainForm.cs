/*
 Ta en bild med en webkamera
 Axel Isaksson (http://h4xxel.ath.cx/)
 Använder DirectShow.NET (http://directshownet.sf.net/)
 Public Domain, gör vad du vill med källkoden
 DLL-filen DirectShowLib-2005.dll är släppt under licensen LGPL, se directshowlib-license.txt
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
	public partial class MainForm : Form {
		private System.ComponentModel.Container components = null;
		private Capture cam;
		IntPtr m_ip = IntPtr.Zero;
		
		public MainForm() {
			InitializeComponent();
			
			//Initiera webkameran och rita ut bilden på pictureBox1
			//Webkamera nummer 0
			//Upplösning: 640x480, 24bitar färger
			cam=new Capture(0,640,480,24,pictureBox1);
		}
		
		//Funktion för att städa upp efter oss
		//Viktig!!
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
		
		//Städa upp när vi stänger fönstret
		//Om denna funktion inte finns krashar programmet när man stänger av!
		void MainFormFormClosed(object sender, FormClosedEventArgs e){
			cam.Dispose();

            if (m_ip != IntPtr.Zero){
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }
		}
		
		//Ta en bild när vi klickar
		void Button1Click(object sender, EventArgs e){
			//Här tar vi en bild och gör en bitmap av den
			//bitmapen finns i variabeln b
			m_ip=cam.Click();
			Bitmap b = new Bitmap(cam.Width, cam.Height, cam.Stride, PixelFormat.Format24bppRgb, m_ip);
			//Bilden måste roteras för att inte vara upp-och-ner
			b.RotateFlip(RotateFlipType.RotateNoneFlipY);
			
			//Vi öppnar ett nytt fönster och visar bilden där
			VisaBild frmVisaBild=new VisaBild();
			PictureBox picPictureBox1=(PictureBox)frmVisaBild.Controls.Find("pictureBox1",true)[0];
			picPictureBox1.Image=b;
			frmVisaBild.Show();
		}
	}
}
