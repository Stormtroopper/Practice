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

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOG_IN_Click(object sender, EventArgs e)
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

        bool isSLIDINGExpanded;
        const int MAXSLIDEWIDTH = 275;
        const int MINSLIDEWIDTH = 80;
        private void TTOGGLEClick(object sender, EventArgs e)
        {
            if (isSLIDINGExpanded)
            {
                retractSLIDINGGUI();
            }
            slidingpanelTimer.Start();
        }

        private void slidingpanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSLIDINGExpanded)
            {
                //retract pannel
                Slidingp.Width -= 30;
                if (Slidingp.Width <= MINSLIDEWIDTH)
                {
                    //stop retract  
                    isSLIDINGExpanded = false;
                    slidingpanelTimer.Stop();
                    
                    this.Refresh();
                }


            }
            else
            {
                // expand panel
                panel2.Width += 30;
                if (panel2.Width >= MAXSLIDEWIDTH)
                {
                    //stop exoanding
                    isSLIDINGExpanded = true;
                    slidingpanelTimer.Stop();
                    expandSLIDINGGUI();
                    this.Refresh();
                }
            }
        }
            public void expandSLIDINGGUI()
            {
                //gui adjustments for expanding
                BRANCHT.Text = "BRANCH";
                ACCOUNTST.Text = "ACCONUTS";
                LOANST.Text = "LOANS";
                TRANSACTIONT.Text = "TRANSACTION";
                SETTINGST .Text = "SETTINGS";
                ABOUTT.Text = "ABOUT";

                BRANCHT.Image = null;
                ACCOUNTST.Image = null;
                LOANST.Image = null;
                TRANSACTIONT.Image = null;
                SETTINGST.Image = null;
                ABOUTT.Image = null;
            }

        public void retractSLIDINGGUI()
        {

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

