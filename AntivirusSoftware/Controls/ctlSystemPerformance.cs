using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Win32;

namespace AntivirusSoftware.Controls
{
    public partial class ctlSystemPerformance : UserControl
    {
        public ctlSystemPerformance()
        {
            InitializeComponent();
        }

        private void ctlSystemPerformance_Load(object sender, EventArgs e)
        {
            string name = (string)Microsoft.Win32.Registry.GetValue(@"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", null);
            lblComputerName.Text = name;

            string keyPath = @"HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0";
            string valueName = "~MHz";
            string speed = "";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (key != null)
                {
                    speed = key.GetValue(valueName, null) as string;
                }
            }

            speed += "MHz";

            lblComputerSpeed.Text = speed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progressBar1.Value = (int)fcpu;
            progressBar2.Value = (int)fram;
            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);

            PcPerformanceCharts.Series["CPU"].Points.AddY(fcpu);
            PcPerformanceCharts.Series["RAM"].Points.AddY(fram);
        }

        
    }
}
