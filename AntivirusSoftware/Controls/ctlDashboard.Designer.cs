namespace AntivirusSoftware.Controls
{
    partial class ctlDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNext = new System.Windows.Forms.LinkLabel();
            this.btnActive = new AntivirusSoftware.Custom_Controls.MyButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imageQuicklyScan = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageSystemScan = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.imageVpn = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageQuicklyScan)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSystemScan)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(15, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 146);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bilgisayarınızda kötü amaçlı yazılımın algılanması ve silinmesi için etkinleştiri" +
    "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Güvenlik Duvarını Etkinleştirin / Devre Dışı Bırakın";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AntivirusSoftware.Properties.Resources.security_system;
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.labelNext);
            this.panel2.Controls.Add(this.btnActive);
            this.panel2.Location = new System.Drawing.Point(573, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 146);
            this.panel2.TabIndex = 3;
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNext.Location = new System.Drawing.Point(54, 103);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(122, 20);
            this.labelNext.TabIndex = 1;
            this.labelNext.TabStop = true;
            this.labelNext.Text = "Bir sonraki öneri";
            this.labelNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelNext_LinkClicked);
            // 
            // btnActive
            // 
            this.btnActive.ButtomColor = System.Drawing.Color.DodgerBlue;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Location = new System.Drawing.Point(23, 31);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(182, 53);
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Etkinleştir";
            this.btnActive.TopColor = System.Drawing.Color.Blue;
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.imageQuicklyScan);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(15, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 127);
            this.panel5.TabIndex = 6;
            // 
            // imageQuicklyScan
            // 
            this.imageQuicklyScan.Image = global::AntivirusSoftware.Properties.Resources.fingerprint;
            this.imageQuicklyScan.Location = new System.Drawing.Point(66, 19);
            this.imageQuicklyScan.Name = "imageQuicklyScan";
            this.imageQuicklyScan.Size = new System.Drawing.Size(83, 59);
            this.imageQuicklyScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageQuicklyScan.TabIndex = 10;
            this.imageQuicklyScan.TabStop = false;
            this.imageQuicklyScan.Click += new System.EventHandler(this.imageQuicklyScan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hızlı Tarama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Güvendesiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cihazınızı ve Verilerinizi Tarıyoruz";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.imageSystemScan);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(300, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 127);
            this.panel3.TabIndex = 9;
            // 
            // imageSystemScan
            // 
            this.imageSystemScan.Image = global::AntivirusSoftware.Properties.Resources.target;
            this.imageSystemScan.Location = new System.Drawing.Point(78, 19);
            this.imageSystemScan.Name = "imageSystemScan";
            this.imageSystemScan.Size = new System.Drawing.Size(83, 59);
            this.imageSystemScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageSystemScan.TabIndex = 11;
            this.imageSystemScan.TabStop = false;
            this.imageSystemScan.Click += new System.EventHandler(this.imageSystemScan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sistem Tarama";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.imageVpn);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(15, 442);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 127);
            this.panel6.TabIndex = 9;
            // 
            // imageVpn
            // 
            this.imageVpn.Image = global::AntivirusSoftware.Properties.Resources.vpn__1_;
            this.imageVpn.Location = new System.Drawing.Point(66, 19);
            this.imageVpn.Name = "imageVpn";
            this.imageVpn.Size = new System.Drawing.Size(83, 59);
            this.imageVpn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpn.TabIndex = 13;
            this.imageVpn.TabStop = false;
            this.imageVpn.Click += new System.EventHandler(this.imageVpn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(83, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "VPN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(52, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Özel Tarama";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AntivirusSoftware.Properties.Resources.add;
            this.pictureBox6.Location = new System.Drawing.Point(78, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(83, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.pictureBox6);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(300, 442);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 127);
            this.panel7.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Güvenlik Açığı Tarama";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AntivirusSoftware.Properties.Resources.cyber_crime;
            this.pictureBox4.Location = new System.Drawing.Point(70, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(573, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 127);
            this.panel4.TabIndex = 10;
            // 
            // ctlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ctlDashboard";
            this.Size = new System.Drawing.Size(852, 610);
            this.Load += new System.EventHandler(this.ctlDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageQuicklyScan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSystemScan)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Custom_Controls.MyButton btnActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel labelNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox imageQuicklyScan;
        private System.Windows.Forms.PictureBox imageSystemScan;
        private System.Windows.Forms.PictureBox imageVpn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
    }
}
