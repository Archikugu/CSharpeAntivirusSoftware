using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Kapatma Butonu için interop servisi çağırıyoruz
using System.Runtime.InteropServices;
using AntivirusSoftware.Forms;
using AntivirusSoftware.Classes;
using AntivirusSoftware.Custom_Controls;

namespace AntivirusSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmPopup popup = new frmPopup();
            popup.ShowDialog();
        }



        private void OnMouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                MyFunctions.ReleaseCapture();
                MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HTCAPTION, 0);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ctlDashboard1.BringToFront();
            ctlDashboard1.Visible = true;
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }



        }

        private void btnProtected_Click(object sender, EventArgs e)
        {
            ctlScanCenter1.BringToFront();
            ctlScanCenter1.Visible = true;
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            ctlPrivacy1.BringToFront();
            ctlPrivacy1.Visible = true;
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
        }

        private void BtnSystemPerformance_Click(object sender, EventArgs e)
        {
            ctlSystemPerformance1.BringToFront();
            ctlSystemPerformance1.Visible = true;
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ctlMyAccount2.BringToFront();
            ctlMyAccount2.Visible = true;
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
        }

        private void btnPreference_Click(object sender, EventArgs e)
        {
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            {
                var withBlock = btnDashboard;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnProtected;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPrivacy;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnSystemPerformance;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnAccount;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnPreference;
                withBlock.ButtomColor = MyColors.deactive_color1;
                withBlock.TopColor = MyColors.deactive_color2;
            }
            {
                var withBlock = btnHelp;
                withBlock.ButtomColor = MyColors.active_color1;
                withBlock.TopColor = MyColors.active_color2;
            }
        }
    }
}

