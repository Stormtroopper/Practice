using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class APPBODY : Form
    {
        public const int WM_NCLBUTTONDOWN = 0XA1;
        public const int HT_CAPTION = 0X2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();









        public APPBODY()
        {
            InitializeComponent();
        }

        private void APPBODY_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            LoginTimer.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                LoginTimer.Stop();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //sliding code starts here

        bool isSlidingPExpanded;
        const int MAXSLIDEWIDTH = 275;
        const int MINSLIDEWIDTH = 80;
        private void Toggle1_Click(object sender, EventArgs e)
        {
            if (isSlidingPExpanded)
            {
                //retract pannel
            }
            slidingpanelTimer.Start();
        }

        private void slidingpanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPExpanded)
            {
                //retract pannel
                Slidingp.Width -= 30;
                if (Slidingp.Width <= MINSLIDEWIDTH)
                {
                    //stop retract  
                    isSlidingPExpanded = false;
                    slidingpanelTimer.Stop();

                    this.Refresh();
                }


            }
            else
            {
                // expand panel
                Slidingp.Width += 30;
                if (Slidingp.Width >= MAXSLIDEWIDTH)
                {
                    //stop exoanding
                    isSlidingPExpanded = true;
                    slidingpanelTimer.Stop();

                    this.Refresh();
                }
            }


        }
    }
}
