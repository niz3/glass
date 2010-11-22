/*
 * Created by SharpDevelop.
 * User: Axel
 * Date: 2010-11-08
 * Time: 19:28
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
using glass.framework;

namespace glass.Dialog {
	public partial class WebcamDialog : Form{
		public Bitmap b=null;
		private System.ComponentModel.Container components = null;
		private Capture cam;
		IntPtr m_ip = IntPtr.Zero;
		public WebcamDialog(){
			InitializeComponent();
		}
		public Bitmap get_b() {
			return b;
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
		void WebcamDialogFormClosed(object sender, FormClosedEventArgs e){
			//cleanup
			try {cam.Dispose();} catch{}

            if (m_ip != IntPtr.Zero){
                Marshal.FreeCoTaskMem(m_ip);
                m_ip = IntPtr.Zero;
            }
		}
		void WebcamDialogShown(object sender, EventArgs e) {
			cam=new Capture(WebCam.id,WebCam.width,WebCam.height,WebCam.bpp,pctCam);
			pctCam.Image=null;
			pctCam.SizeMode= PictureBoxSizeMode.StretchImage;
			btnSnap.Enabled=true;
		}
		void BtnSnapClick(object sender, EventArgs e){
			m_ip=cam.Click();
			b = new Bitmap(cam.Width, cam.Height, cam.Stride, PixelFormat.Format24bppRgb,m_ip);
			b.RotateFlip(RotateFlipType.RotateNoneFlipY);
			this.Close();
		}
	}
}
