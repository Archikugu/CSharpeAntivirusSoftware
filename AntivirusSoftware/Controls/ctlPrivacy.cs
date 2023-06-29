using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AntivirusSoftware.Properties;

namespace AntivirusSoftware.Controls
{
    public partial class ctlPrivacy : UserControl
    {
        string username;
        string password;
        string host;
        string location;
        public ctlPrivacy()
        {
            InitializeComponent();

        }

        private void imageVpnUSA_Click(object sender, EventArgs e)
        {
            username = "freevpn";
            host = "83.170.115.92";
            password = "account";
            location = "USA";
            imageFlag.Image = imageVpnUSA.Image;
        }

        private void imageVpnCanada_Click(object sender, EventArgs e)
        {
            username = "free";
            host = "65.111.173.161";
            password = "1234";
            location = "Canada";
            imageFlag.Image = imageVpnCanada.Image;

        }

        private void imageVpnGermany_Click(object sender, EventArgs e)
        {
            username = "free";
            host = "108.163.169.44";
            password = "1234";
            location = "Germany";
            imageFlag.Image = imageVpnGermany.Image;
        }

        private void btnVpnConnect_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector"));
            }

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "connection.pbk");
            string fileContent = "[VPN] MEDIA=rastapi" + "Port=VPN2-0 Device=WAN Miniport(IKEv2) DEVICE=vpn PhoneNumber=" + host;
            File.WriteAllText(filePath, fileContent);

            string filePath1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "connection.bat");
            string fileContent1 = "rasdial VPN " + "\"" + username + " " + password + "/phonebook:" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "connection.pbk");
            File.WriteAllText(filePath1, fileContent1);

            System.Diagnostics.Process connect;
            connect = new System.Diagnostics.Process();
            connect.StartInfo.FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "connection.bat");
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            connect.Start();
            connect.WaitForExit();
            if (connect.ExitCode != 0)
            {
                lblVpnMessage.Text = "CONNECTED - YOUR IP ADDRESS IS" + host;
                lblVpnMessage.ForeColor = Color.Green;

                imageVpn.Image = Resources.wifi_connection;
                lblChoseCountry.Text = "You are Connect to " + location;
                btnVpnDiscconnect.Enabled = true;
                btnVpnConnect.Enabled = false;
                panelVpn.Visible = false;
            }
        }

        private void btnVpnDiscconnect_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "disconnect.bat");
            string fileContent = "rasdial /d";

            File.WriteAllText(filePath, fileContent);

            System.Diagnostics.Process connect;
            connect = new System.Diagnostics.Process();
            connect.StartInfo.FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "vpnconnector", "disconnect.bat");
            connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            connect.Start();
            connect.WaitForExit();


            lblVpnMessage.Text = "VPN Disconnected";
            lblVpnMessage.ForeColor = Color.White;

            imageVpn.Image = Resources.no_wifi__1_;
            lblChoseCountry.Text = "Ülke Seçiniz ";
            btnVpnDiscconnect.Enabled = false;
            btnVpnConnect.Enabled = true;
            panelVpn.Visible = true;

        }

    }
}
