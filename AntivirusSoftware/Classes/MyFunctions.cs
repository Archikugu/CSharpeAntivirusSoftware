using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusSoftware.Classes
{
    public class MyFunctions
    {
        //Sayfa Küçültme 
        //public const int WM_NCLBUTTONDOWN = 0xA1;
        //public const int HT_CAPTION = 0x2;


        //MouseDown hareket ettirmek için
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0X2;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public static void Enable_Firewall()
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe";
            firewall.StartInfo.WorkingDirectory = @"C:\windows\system32\";
            firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode = enable";
            firewall.Start();
            MessageBox.Show("Firewall Enabled Succesfully", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Disable_Firewall()
        {
            Process firewall = new Process();
            firewall.StartInfo.FileName = "cmd.exe";
            firewall.StartInfo.WorkingDirectory = @"C:\windows\system32\";
            firewall.StartInfo.Arguments = "/c netsh firewall set opmode mode = disable";
            firewall.Start();
            MessageBox.Show("Firewall Disabled Succesfully", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
