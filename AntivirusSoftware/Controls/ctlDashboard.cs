using AntivirusSoftware.Classes;
using AntivirusSoftware.Forms;
using AntivirusSoftware.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AntivirusSoftware.Controls
{

    public partial class ctlDashboard : UserControl
    {
        bool isActive;
        public ctlDashboard()
        {
            InitializeComponent();
        }

        private void imageQuicklyScan_Click(object sender, EventArgs e)
        {
            frmScan frmScan = new frmScan();
            frmScan.ShowDialog();
        }

        private void imageSystemScan_Click(object sender, EventArgs e)
        {
            frmScan frmScan = new frmScan();
            frmScan.ShowDialog();
        }

        private void imageVpn_Click(object sender, EventArgs e)
        {
            //btnPrivacy.PerformClick();
        }

      

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (isActive == false)
            {
                isActive = true;
                btnActive.Text = "Devredışı bırak";
                btnActive.ButtomColor = Color.Red;
                btnActive.TopColor = Color.DarkRed;
               
                MyFunctions.Disable_Firewall();
               
            }
            else
            {
                isActive = false;
                btnActive.Text = "Etkinleştir";
                btnActive.ButtomColor = Color.DodgerBlue;
                btnActive.TopColor = Color.Blue;
                MyFunctions.Enable_Firewall();
                
            }
        }

        private void ctlDashboard_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firewall = true)
            {
                isActive = true;
                btnActive.ButtomColor = Color.Red;
                btnActive.TopColor = Color.DarkRed;
                btnActive.Text = "Devredışı bırak";
            }
            else if (Properties.Settings.Default.firewall = false)
            {
                isActive = false;
                btnActive.ButtomColor = Color.DodgerBlue;
                btnActive.TopColor = Color.Blue;
                btnActive.Text = "Etkinleştir";
            }
        }

        private void labelNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Archikugu");
        }
    }
}
