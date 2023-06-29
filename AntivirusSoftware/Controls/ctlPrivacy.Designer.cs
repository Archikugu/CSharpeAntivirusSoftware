namespace AntivirusSoftware.Controls
{
    partial class ctlPrivacy
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
            this.btnVpnConnect = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnVpnDiscconnect = new AntivirusSoftware.Custom_Controls.MyButton();
            this.lblVpnMessage = new System.Windows.Forms.Label();
            this.imageVpnUSA = new System.Windows.Forms.PictureBox();
            this.imageVpnCanada = new System.Windows.Forms.PictureBox();
            this.imageVpnGermany = new System.Windows.Forms.PictureBox();
            this.imageVpnTurkey = new System.Windows.Forms.PictureBox();
            this.imageVpnFrance = new System.Windows.Forms.PictureBox();
            this.imageVpn = new System.Windows.Forms.PictureBox();
            this.lblChoseCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageFlag = new System.Windows.Forms.PictureBox();
            this.panelVpn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnUSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnCanada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnTurkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnFrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFlag)).BeginInit();
            this.panelVpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVpnConnect
            // 
            this.btnVpnConnect.ButtomColor = System.Drawing.Color.GreenYellow;
            this.btnVpnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpnConnect.ForeColor = System.Drawing.Color.White;
            this.btnVpnConnect.Location = new System.Drawing.Point(171, 515);
            this.btnVpnConnect.Name = "btnVpnConnect";
            this.btnVpnConnect.Size = new System.Drawing.Size(225, 53);
            this.btnVpnConnect.TabIndex = 12;
            this.btnVpnConnect.Text = "Connect";
            this.btnVpnConnect.TopColor = System.Drawing.Color.Green;
            this.btnVpnConnect.UseVisualStyleBackColor = true;
            this.btnVpnConnect.Click += new System.EventHandler(this.btnVpnConnect_Click);
            // 
            // btnVpnDiscconnect
            // 
            this.btnVpnDiscconnect.ButtomColor = System.Drawing.Color.DarkRed;
            this.btnVpnDiscconnect.Enabled = false;
            this.btnVpnDiscconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpnDiscconnect.ForeColor = System.Drawing.Color.White;
            this.btnVpnDiscconnect.Location = new System.Drawing.Point(435, 515);
            this.btnVpnDiscconnect.Name = "btnVpnDiscconnect";
            this.btnVpnDiscconnect.Size = new System.Drawing.Size(225, 53);
            this.btnVpnDiscconnect.TabIndex = 11;
            this.btnVpnDiscconnect.Text = "Disconnect";
            this.btnVpnDiscconnect.TopColor = System.Drawing.Color.Red;
            this.btnVpnDiscconnect.UseVisualStyleBackColor = true;
            this.btnVpnDiscconnect.Click += new System.EventHandler(this.btnVpnDiscconnect_Click);
            // 
            // lblVpnMessage
            // 
            this.lblVpnMessage.AutoEllipsis = true;
            this.lblVpnMessage.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVpnMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVpnMessage.Location = new System.Drawing.Point(0, 291);
            this.lblVpnMessage.Name = "lblVpnMessage";
            this.lblVpnMessage.Size = new System.Drawing.Size(821, 32);
            this.lblVpnMessage.TabIndex = 14;
            this.lblVpnMessage.Text = "Vpn Disconnected";
            this.lblVpnMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageVpnUSA
            // 
            this.imageVpnUSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.imageVpnUSA.Image = global::AntivirusSoftware.Properties.Resources.united_states;
            this.imageVpnUSA.Location = new System.Drawing.Point(76, 12);
            this.imageVpnUSA.Name = "imageVpnUSA";
            this.imageVpnUSA.Size = new System.Drawing.Size(83, 73);
            this.imageVpnUSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpnUSA.TabIndex = 19;
            this.imageVpnUSA.TabStop = false;
            this.imageVpnUSA.Click += new System.EventHandler(this.imageVpnUSA_Click);
            // 
            // imageVpnCanada
            // 
            this.imageVpnCanada.Image = global::AntivirusSoftware.Properties.Resources.canada;
            this.imageVpnCanada.Location = new System.Drawing.Point(201, 12);
            this.imageVpnCanada.Name = "imageVpnCanada";
            this.imageVpnCanada.Size = new System.Drawing.Size(83, 73);
            this.imageVpnCanada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpnCanada.TabIndex = 18;
            this.imageVpnCanada.TabStop = false;
            this.imageVpnCanada.Click += new System.EventHandler(this.imageVpnCanada_Click);
            // 
            // imageVpnGermany
            // 
            this.imageVpnGermany.Image = global::AntivirusSoftware.Properties.Resources.germany;
            this.imageVpnGermany.Location = new System.Drawing.Point(439, 12);
            this.imageVpnGermany.Name = "imageVpnGermany";
            this.imageVpnGermany.Size = new System.Drawing.Size(83, 73);
            this.imageVpnGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpnGermany.TabIndex = 17;
            this.imageVpnGermany.TabStop = false;
            this.imageVpnGermany.Click += new System.EventHandler(this.imageVpnGermany_Click);
            // 
            // imageVpnTurkey
            // 
            this.imageVpnTurkey.Image = global::AntivirusSoftware.Properties.Resources.turkey;
            this.imageVpnTurkey.Location = new System.Drawing.Point(319, 12);
            this.imageVpnTurkey.Name = "imageVpnTurkey";
            this.imageVpnTurkey.Size = new System.Drawing.Size(83, 73);
            this.imageVpnTurkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpnTurkey.TabIndex = 16;
            this.imageVpnTurkey.TabStop = false;
            // 
            // imageVpnFrance
            // 
            this.imageVpnFrance.Image = global::AntivirusSoftware.Properties.Resources.france;
            this.imageVpnFrance.Location = new System.Drawing.Point(562, 12);
            this.imageVpnFrance.Name = "imageVpnFrance";
            this.imageVpnFrance.Size = new System.Drawing.Size(83, 73);
            this.imageVpnFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpnFrance.TabIndex = 15;
            this.imageVpnFrance.TabStop = false;
            // 
            // imageVpn
            // 
            this.imageVpn.Image = global::AntivirusSoftware.Properties.Resources.no_wifi__1_;
            this.imageVpn.Location = new System.Drawing.Point(248, 37);
            this.imageVpn.Name = "imageVpn";
            this.imageVpn.Size = new System.Drawing.Size(331, 236);
            this.imageVpn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageVpn.TabIndex = 13;
            this.imageVpn.TabStop = false;
            // 
            // lblChoseCountry
            // 
            this.lblChoseCountry.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoseCountry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblChoseCountry.Location = new System.Drawing.Point(6, 334);
            this.lblChoseCountry.Name = "lblChoseCountry";
            this.lblChoseCountry.Size = new System.Drawing.Size(815, 23);
            this.lblChoseCountry.TabIndex = 20;
            this.lblChoseCountry.Text = "Ülke Şeçiniz";
            this.lblChoseCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(96, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "USA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(206, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Canada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(327, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Turkey";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(438, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Germany";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(572, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "France";
            // 
            // imageFlag
            // 
            this.imageFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.imageFlag.Image = global::AntivirusSoftware.Properties.Resources.united_states;
            this.imageFlag.Location = new System.Drawing.Point(522, 220);
            this.imageFlag.Name = "imageFlag";
            this.imageFlag.Size = new System.Drawing.Size(57, 53);
            this.imageFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageFlag.TabIndex = 26;
            this.imageFlag.TabStop = false;
            // 
            // panelVpn
            // 
            this.panelVpn.Controls.Add(this.imageVpnUSA);
            this.panelVpn.Controls.Add(this.imageVpnFrance);
            this.panelVpn.Controls.Add(this.label6);
            this.panelVpn.Controls.Add(this.imageVpnTurkey);
            this.panelVpn.Controls.Add(this.label5);
            this.panelVpn.Controls.Add(this.imageVpnGermany);
            this.panelVpn.Controls.Add(this.label4);
            this.panelVpn.Controls.Add(this.imageVpnCanada);
            this.panelVpn.Controls.Add(this.label3);
            this.panelVpn.Controls.Add(this.label2);
            this.panelVpn.Location = new System.Drawing.Point(58, 365);
            this.panelVpn.Name = "panelVpn";
            this.panelVpn.Size = new System.Drawing.Size(715, 124);
            this.panelVpn.TabIndex = 27;
            // 
            // ctlPrivacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelVpn);
            this.Controls.Add(this.imageFlag);
            this.Controls.Add(this.lblChoseCountry);
            this.Controls.Add(this.lblVpnMessage);
            this.Controls.Add(this.imageVpn);
            this.Controls.Add(this.btnVpnConnect);
            this.Controls.Add(this.btnVpnDiscconnect);
            this.Name = "ctlPrivacy";
            this.Size = new System.Drawing.Size(835, 603);
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnUSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnCanada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnTurkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpnFrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageVpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageFlag)).EndInit();
            this.panelVpn.ResumeLayout(false);
            this.panelVpn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Custom_Controls.MyButton btnVpnConnect;
        private Custom_Controls.MyButton btnVpnDiscconnect;
        private System.Windows.Forms.PictureBox imageVpn;
        private System.Windows.Forms.Label lblVpnMessage;
        private System.Windows.Forms.PictureBox imageVpnFrance;
        private System.Windows.Forms.PictureBox imageVpnTurkey;
        private System.Windows.Forms.PictureBox imageVpnGermany;
        private System.Windows.Forms.PictureBox imageVpnCanada;
        private System.Windows.Forms.PictureBox imageVpnUSA;
        private System.Windows.Forms.Label lblChoseCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imageFlag;
        private System.Windows.Forms.Panel panelVpn;
    }
}
