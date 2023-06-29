using AntivirusSoftware.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusSoftware.Controls
{
    public partial class ctlScanCenter : UserControl
    {
        public ctlScanCenter()
        {
            InitializeComponent();
        }

        private void btnSmartRun_Click(object sender, EventArgs e)
        {
            frmScan scanCenter = new frmScan();
            scanCenter.ShowDialog();

        }
    }
}
