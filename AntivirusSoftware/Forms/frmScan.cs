using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using AntivirusSoftware.Classes;

namespace AntivirusSoftware.Forms
{
    public partial class frmScan : Form
    {
        public frmScan()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgFolderScan_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                btnCancel.Enabled = true;
            }
            else
            {
                return;
            }

            try
            {
                foreach (string strFile in System.IO.Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", System.IO.SearchOption.AllDirectories))
                {
                    listBox1.Items.Add(strFile);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = listBox1.Items.Count;
            lblTotal.Text = listBox1.Items.Count.ToString();
            listBox1.Enabled = false;

            if (progressBar1.Value != progressBar1.Maximum)
            {
                try
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    lblLastScan.Text = listBox1.SelectedItem.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    TextBox scanbox = new TextBox();
                    string[] lines = File.ReadAllLines("main.txt");
                    string read = string.Join(Environment.NewLine, lines);
                    progressBar1.Increment(1);
                    lblVirus.Text = listBox2.Items.Count.ToString();
                    lblTotal.Text = progressBar1.Value.ToString();
                    scanbox.Text = read.ToString();

                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        using (FileStream fs = new FileStream(listBox1.SelectedItem.ToString(), FileMode.Open, FileAccess.Read, FileShare.Read, 8192))
                        {
                            byte[] hash = md5.ComputeHash(fs);
                            StringBuilder buff = new StringBuilder();

                            foreach (byte hashByte in hash)
                            {
                                buff.Append(hashByte.ToString("X2"));
                            }

                            if (scanbox.Text.Contains(buff.ToString()))
                            {
                                listBox2.Items.Add(listBox1.SelectedItem);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                listBox1.Enabled = true;
                timer1.Stop();

                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("Tarama Tamamlandı.\n" + listBox2.Items.Count.ToString() + " Virüsler tespit edildi. Lütfen listeyi gözden geçirin ve bir işlem seçin.", MessageBoxButtons.OK.ToString());
                    btnCancel.Enabled = false;
                    btnScanCenterClose.Enabled = true;
                    btnQuestion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Tarama Tamamlandı.\n" + "Virüs bulunamadı", MessageBoxButtons.OK.ToString());
                    progressBar1.Value = 0;
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("taramayı iptal etmek istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                timer1.Stop();
                if (listBox2.Items.Count > 0)
                {
                    MessageBox.Show("Tarama Tamamlandı.\n" + "Virüs bulunamadı", MessageBoxButtons.OK.ToString());
                    timer1.Stop();
                    progressBar1.Value = 0;
                    btnCancel.Enabled = false;
                    btnScanCenterClose.Enabled = true;
                    btnQuestion.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Tarama Tamamlandı.\n" + "Virüs bulunamadı", MessageBoxButtons.OK.ToString());
                    timer1.Stop();
                    progressBar1.Value = 0;
                    btnCancel.Enabled = false;
                }
            }

        }

        private void imageQuicklyScan_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"C:\";

            try
            {
                foreach (string strDir in System.IO.Directory.GetDirectories(folderBrowserDialog1.SelectedPath, "*.*", System.IO.SearchOption.TopDirectoryOnly))
                {
                    foreach (string strFile in System.IO.Directory.GetFiles(strDir, "*.*", System.IO.SearchOption.AllDirectories))
                    {
                        listBox1.Items.Add(strFile);
                    }
                }
                btnCancel.Enabled = false;
                btnScanCenterClose.Enabled = true;
                btnQuestion.Enabled = true;
                timer1.Start();
                progressBar1.Visible = false;

            }
            catch (Exception ex)
            {
                // Handle the exception
            }

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MyFunctions.ReleaseCapture();
                MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HTCAPTION, 0);
            }
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnScanCenterClose_Click(object sender, EventArgs e)
        {
            listBox2.Enabled = false;
            listBox2.SelectedIndex = -1;
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Emin misiniz ?", MessageBoxButtons.OK.ToString());
            }
            else
            {
                return;
            }
            while (listBox2.Items.Count != -1 && listBox2.SelectedIndex != -1)
            {
                listBox2.SelectedIndex += 1;
                File.Delete(listBox2.SelectedItem.ToString());
                if (listBox2.Items.Count == listBox2.SelectedIndex + 1)
                {
                    listBox2.Items.Clear();
                    listBox2.Enabled = true;
                    MessageBox.Show("Tüm virüsler başarıyla kaldırıldı. Bilgisayarınız güvende", MessageBoxButtons.OK.ToString());
                    progressBar1.Value = 0;
                    btnCancel.Enabled = false;
                    btnScanCenterClose.Enabled = false;
                    btnQuestion.Enabled = false;
                    return;
                }
            }


        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm öğeleri yok saymak istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                listBox2.Items.Clear();
                listBox2.Enabled = true;
                progressBar1.Value = 0;
                btnCancel.Enabled = false;
                btnScanCenterClose.Enabled = false;
                btnQuestion.Enabled = false;
            }
        }
    }
}
