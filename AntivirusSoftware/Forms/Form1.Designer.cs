namespace AntivirusSoftware
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnProtected = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnPrivacy = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnSystemPerformance = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnHelp = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnPreference = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnAccount = new AntivirusSoftware.Custom_Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.imgHelp = new System.Windows.Forms.PictureBox();
            this.imgPreference = new System.Windows.Forms.PictureBox();
            this.imgAccount = new System.Windows.Forms.PictureBox();
            this.imgNotification = new System.Windows.Forms.PictureBox();
            this.imgPrivacy = new System.Windows.Forms.PictureBox();
            this.imgProtected = new System.Windows.Forms.PictureBox();
            this.pictureBoxKKULogo = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new AntivirusSoftware.Custom_Controls.MyButton();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ctlDashboard1 = new AntivirusSoftware.Controls.ctlDashboard();
            this.ctlMyAccount2 = new AntivirusSoftware.Controls.ctlMyAccount();
            this.ctlMyAccount1 = new AntivirusSoftware.Controls.ctlMyAccount();
            this.ctlSystemPerformance1 = new AntivirusSoftware.Controls.ctlSystemPerformance();
            this.ctlPrivacy1 = new AntivirusSoftware.Controls.ctlPrivacy();
            this.ctlScanCenter1 = new AntivirusSoftware.Controls.ctlScanCenter();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrivacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProtected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKKULogo)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.SidePanel.Controls.Add(this.btnProtected);
            this.SidePanel.Controls.Add(this.btnPrivacy);
            this.SidePanel.Controls.Add(this.btnSystemPerformance);
            this.SidePanel.Controls.Add(this.btnHelp);
            this.SidePanel.Controls.Add(this.btnPreference);
            this.SidePanel.Controls.Add(this.btnAccount);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Controls.Add(this.pictureBoxKKULogo);
            this.SidePanel.Controls.Add(this.btnDashboard);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(241, 647);
            this.SidePanel.TabIndex = 0;
            // 
            // btnProtected
            // 
            this.btnProtected.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnProtected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProtected.ForeColor = System.Drawing.Color.White;
            this.btnProtected.Location = new System.Drawing.Point(45, 216);
            this.btnProtected.Name = "btnProtected";
            this.btnProtected.Size = new System.Drawing.Size(193, 43);
            this.btnProtected.TabIndex = 16;
            this.btnProtected.Text = "Koruma";
            this.btnProtected.TopColor = System.Drawing.Color.Gray;
            this.btnProtected.UseVisualStyleBackColor = true;
            this.btnProtected.Click += new System.EventHandler(this.btnProtected_Click);
            // 
            // btnPrivacy
            // 
            this.btnPrivacy.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnPrivacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivacy.ForeColor = System.Drawing.Color.White;
            this.btnPrivacy.Location = new System.Drawing.Point(45, 275);
            this.btnPrivacy.Name = "btnPrivacy";
            this.btnPrivacy.Size = new System.Drawing.Size(193, 43);
            this.btnPrivacy.TabIndex = 15;
            this.btnPrivacy.Text = "Gizlilik";
            this.btnPrivacy.TopColor = System.Drawing.Color.Gray;
            this.btnPrivacy.UseVisualStyleBackColor = true;
            this.btnPrivacy.Click += new System.EventHandler(this.btnPrivacy_Click);
            // 
            // btnSystemPerformance
            // 
            this.btnSystemPerformance.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnSystemPerformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemPerformance.ForeColor = System.Drawing.Color.White;
            this.btnSystemPerformance.Location = new System.Drawing.Point(45, 334);
            this.btnSystemPerformance.Name = "btnSystemPerformance";
            this.btnSystemPerformance.Size = new System.Drawing.Size(193, 43);
            this.btnSystemPerformance.TabIndex = 14;
            this.btnSystemPerformance.Text = "Sistem Performansı";
            this.btnSystemPerformance.TopColor = System.Drawing.Color.Gray;
            this.btnSystemPerformance.UseVisualStyleBackColor = true;
            this.btnSystemPerformance.Click += new System.EventHandler(this.BtnSystemPerformance_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(48, 601);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(193, 43);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Yardım";
            this.btnHelp.TopColor = System.Drawing.Color.Gray;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnPreference
            // 
            this.btnPreference.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnPreference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreference.ForeColor = System.Drawing.Color.White;
            this.btnPreference.Location = new System.Drawing.Point(48, 546);
            this.btnPreference.Name = "btnPreference";
            this.btnPreference.Size = new System.Drawing.Size(193, 43);
            this.btnPreference.TabIndex = 12;
            this.btnPreference.Text = "Ayarlar";
            this.btnPreference.TopColor = System.Drawing.Color.Gray;
            this.btnPreference.UseVisualStyleBackColor = true;
            this.btnPreference.Click += new System.EventHandler(this.btnPreference_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.ButtomColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(48, 488);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(193, 43);
            this.btnAccount.TabIndex = 11;
            this.btnAccount.Text = "Hesabım";
            this.btnAccount.TopColor = System.Drawing.Color.Gray;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.imgDashboard);
            this.panel1.Controls.Add(this.imgHelp);
            this.panel1.Controls.Add(this.imgPreference);
            this.panel1.Controls.Add(this.imgAccount);
            this.panel1.Controls.Add(this.imgNotification);
            this.panel1.Controls.Add(this.imgPrivacy);
            this.panel1.Controls.Add(this.imgProtected);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 647);
            this.panel1.TabIndex = 10;
            // 
            // imgDashboard
            // 
            this.imgDashboard.Image = global::AntivirusSoftware.Properties.Resources.in_time__1_;
            this.imgDashboard.Location = new System.Drawing.Point(2, 155);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(40, 43);
            this.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            // 
            // imgHelp
            // 
            this.imgHelp.Image = global::AntivirusSoftware.Properties.Resources.question;
            this.imgHelp.Location = new System.Drawing.Point(3, 601);
            this.imgHelp.Name = "imgHelp";
            this.imgHelp.Size = new System.Drawing.Size(40, 43);
            this.imgHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHelp.TabIndex = 0;
            this.imgHelp.TabStop = false;
            // 
            // imgPreference
            // 
            this.imgPreference.Image = global::AntivirusSoftware.Properties.Resources.gear;
            this.imgPreference.Location = new System.Drawing.Point(2, 546);
            this.imgPreference.Name = "imgPreference";
            this.imgPreference.Size = new System.Drawing.Size(40, 43);
            this.imgPreference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreference.TabIndex = 0;
            this.imgPreference.TabStop = false;
            // 
            // imgAccount
            // 
            this.imgAccount.Image = global::AntivirusSoftware.Properties.Resources.user__1_;
            this.imgAccount.Location = new System.Drawing.Point(2, 488);
            this.imgAccount.Name = "imgAccount";
            this.imgAccount.Size = new System.Drawing.Size(40, 43);
            this.imgAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAccount.TabIndex = 0;
            this.imgAccount.TabStop = false;
            // 
            // imgNotification
            // 
            this.imgNotification.Image = global::AntivirusSoftware.Properties.Resources.statistic;
            this.imgNotification.Location = new System.Drawing.Point(1, 334);
            this.imgNotification.Name = "imgNotification";
            this.imgNotification.Size = new System.Drawing.Size(40, 43);
            this.imgNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNotification.TabIndex = 0;
            this.imgNotification.TabStop = false;
            // 
            // imgPrivacy
            // 
            this.imgPrivacy.Image = global::AntivirusSoftware.Properties.Resources.privacy__1_;
            this.imgPrivacy.Location = new System.Drawing.Point(0, 275);
            this.imgPrivacy.Name = "imgPrivacy";
            this.imgPrivacy.Size = new System.Drawing.Size(43, 43);
            this.imgPrivacy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPrivacy.TabIndex = 0;
            this.imgPrivacy.TabStop = false;
            // 
            // imgProtected
            // 
            this.imgProtected.Image = global::AntivirusSoftware.Properties.Resources.shield;
            this.imgProtected.Location = new System.Drawing.Point(-1, 216);
            this.imgProtected.Name = "imgProtected";
            this.imgProtected.Size = new System.Drawing.Size(43, 43);
            this.imgProtected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProtected.TabIndex = 0;
            this.imgProtected.TabStop = false;
            // 
            // pictureBoxKKULogo
            // 
            this.pictureBoxKKULogo.Image = global::AntivirusSoftware.Properties.Resources._30yil_logo;
            this.pictureBoxKKULogo.Location = new System.Drawing.Point(48, 11);
            this.pictureBoxKKULogo.Name = "pictureBoxKKULogo";
            this.pictureBoxKKULogo.Size = new System.Drawing.Size(187, 127);
            this.pictureBoxKKULogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKKULogo.TabIndex = 2;
            this.pictureBoxKKULogo.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtomColor = System.Drawing.Color.Red;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(45, 155);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(193, 43);
            this.btnDashboard.TabIndex = 9;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TopColor = System.Drawing.Color.Orange;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.btnMinimize);
            this.HeaderPanel.Controls.Add(this.btnClose);
            this.HeaderPanel.Controls.Add(this.lblTitle);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(241, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(834, 47);
            this.HeaderPanel.TabIndex = 3;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::AntivirusSoftware.Properties.Resources.minus_button;
            this.btnMinimize.Location = new System.Drawing.Point(739, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 43);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::AntivirusSoftware.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(785, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 41);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PC Protector - Sistem PROG ODEV";
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.ctlDashboard1);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Controls.Add(this.SidePanel);
            this.MainPanel.Controls.Add(this.ctlScanCenter1);
            this.MainPanel.Controls.Add(this.ctlPrivacy1);
            this.MainPanel.Controls.Add(this.ctlSystemPerformance1);
            this.MainPanel.Controls.Add(this.ctlMyAccount1);
            this.MainPanel.Controls.Add(this.ctlMyAccount2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1077, 649);
            this.MainPanel.TabIndex = 2;
            // 
            // ctlDashboard1
            // 
            this.ctlDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlDashboard1.Location = new System.Drawing.Point(241, 45);
            this.ctlDashboard1.Name = "ctlDashboard1";
            this.ctlDashboard1.Size = new System.Drawing.Size(835, 603);
            this.ctlDashboard1.TabIndex = 4;
            // 
            // ctlMyAccount2
            // 
            this.ctlMyAccount2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlMyAccount2.Location = new System.Drawing.Point(244, 45);
            this.ctlMyAccount2.Name = "ctlMyAccount2";
            this.ctlMyAccount2.Size = new System.Drawing.Size(835, 603);
            this.ctlMyAccount2.TabIndex = 9;
            // 
            // ctlMyAccount1
            // 
            this.ctlMyAccount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlMyAccount1.Location = new System.Drawing.Point(224, 38);
            this.ctlMyAccount1.Name = "ctlMyAccount1";
            this.ctlMyAccount1.Size = new System.Drawing.Size(852, 610);
            this.ctlMyAccount1.TabIndex = 8;
            // 
            // ctlSystemPerformance1
            // 
            this.ctlSystemPerformance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlSystemPerformance1.Location = new System.Drawing.Point(241, 45);
            this.ctlSystemPerformance1.Name = "ctlSystemPerformance1";
            this.ctlSystemPerformance1.Size = new System.Drawing.Size(852, 610);
            this.ctlSystemPerformance1.TabIndex = 7;
            // 
            // ctlPrivacy1
            // 
            this.ctlPrivacy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlPrivacy1.Location = new System.Drawing.Point(241, 45);
            this.ctlPrivacy1.Name = "ctlPrivacy1";
            this.ctlPrivacy1.Size = new System.Drawing.Size(852, 610);
            this.ctlPrivacy1.TabIndex = 6;
            // 
            // ctlScanCenter1
            // 
            this.ctlScanCenter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ctlScanCenter1.Location = new System.Drawing.Point(241, 53);
            this.ctlScanCenter1.Name = "ctlScanCenter1";
            this.ctlScanCenter1.Size = new System.Drawing.Size(852, 610);
            this.ctlScanCenter1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1077, 649);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Protector";
            this.SidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrivacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProtected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKKULogo)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.PictureBox imgHelp;
        private System.Windows.Forms.PictureBox imgNotification;
        private System.Windows.Forms.PictureBox imgPreference;
        private System.Windows.Forms.PictureBox imgPrivacy;
        private System.Windows.Forms.PictureBox imgAccount;
        private System.Windows.Forms.PictureBox imgProtected;
        private System.Windows.Forms.PictureBox pictureBoxKKULogo;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private Custom_Controls.MyButton btnDashboard;
        private System.Windows.Forms.Panel MainPanel;
        private Custom_Controls.MyButton btnProtected;
        private Custom_Controls.MyButton btnPrivacy;
        private Custom_Controls.MyButton btnSystemPerformance;
        private Custom_Controls.MyButton btnHelp;
        private Custom_Controls.MyButton btnPreference;
        private Custom_Controls.MyButton btnAccount;
        private Controls.ctlDashboard ctlDashboard1;
        private Controls.ctlMyAccount ctlMyAccount1;
        private Controls.ctlMyAccount ctlMyAccount2;
        private Controls.ctlScanCenter ctlScanCenter1;
        private Controls.ctlPrivacy ctlPrivacy1;
        private Controls.ctlSystemPerformance ctlSystemPerformance1;
    }
}

