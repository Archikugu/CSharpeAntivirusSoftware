namespace AntivirusSoftware.Forms
{
    partial class frmPopup
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
            this.panelPopup = new System.Windows.Forms.Panel();
            this.btnPopupNo = new AntivirusSoftware.Custom_Controls.MyButton();
            this.btnPopupYes = new AntivirusSoftware.Custom_Controls.MyButton();
            this.lblPopupMessage = new System.Windows.Forms.Label();
            this.pictureBoxKKULogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKKULogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPopup
            // 
            this.panelPopup.Controls.Add(this.btnPopupNo);
            this.panelPopup.Controls.Add(this.btnPopupYes);
            this.panelPopup.Controls.Add(this.lblPopupMessage);
            this.panelPopup.Controls.Add(this.pictureBoxKKULogo);
            this.panelPopup.Controls.Add(this.lblTitle);
            this.panelPopup.Controls.Add(this.btnClose);
            this.panelPopup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPopup.Location = new System.Drawing.Point(0, 0);
            this.panelPopup.Name = "panelPopup";
            this.panelPopup.Size = new System.Drawing.Size(443, 253);
            this.panelPopup.TabIndex = 0;
            this.panelPopup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPopup_MouseDown);
            // 
            // btnPopupNo
            // 
            this.btnPopupNo.ButtomColor = System.Drawing.Color.Red;
            this.btnPopupNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopupNo.ForeColor = System.Drawing.Color.White;
            this.btnPopupNo.Location = new System.Drawing.Point(31, 136);
            this.btnPopupNo.Name = "btnPopupNo";
            this.btnPopupNo.Size = new System.Drawing.Size(162, 53);
            this.btnPopupNo.TabIndex = 10;
            this.btnPopupNo.Text = "Hayır";
            this.btnPopupNo.TopColor = System.Drawing.Color.DarkRed;
            this.btnPopupNo.UseVisualStyleBackColor = true;
            this.btnPopupNo.Click += new System.EventHandler(this.btnPopupNo_Click);
            // 
            // btnPopupYes
            // 
            this.btnPopupYes.ButtomColor = System.Drawing.Color.Green;
            this.btnPopupYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopupYes.ForeColor = System.Drawing.Color.White;
            this.btnPopupYes.Location = new System.Drawing.Point(245, 136);
            this.btnPopupYes.Name = "btnPopupYes";
            this.btnPopupYes.Size = new System.Drawing.Size(162, 53);
            this.btnPopupYes.TabIndex = 9;
            this.btnPopupYes.Text = "Evet";
            this.btnPopupYes.TopColor = System.Drawing.Color.YellowGreen;
            this.btnPopupYes.UseVisualStyleBackColor = true;
            this.btnPopupYes.Click += new System.EventHandler(this.btnPopupYes_Click);
            // 
            // lblPopupMessage
            // 
            this.lblPopupMessage.AutoSize = true;
            this.lblPopupMessage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopupMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPopupMessage.Location = new System.Drawing.Point(108, 51);
            this.lblPopupMessage.Name = "lblPopupMessage";
            this.lblPopupMessage.Size = new System.Drawing.Size(299, 23);
            this.lblPopupMessage.TabIndex = 8;
            this.lblPopupMessage.Text = "Çıkmak istediğinize emin misiniz?";
            // 
            // pictureBoxKKULogo
            // 
            this.pictureBoxKKULogo.Image = global::AntivirusSoftware.Properties.Resources._30yil_logo;
            this.pictureBoxKKULogo.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxKKULogo.Name = "pictureBoxKKULogo";
            this.pictureBoxKKULogo.Size = new System.Drawing.Size(99, 74);
            this.pictureBoxKKULogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKKULogo.TabIndex = 5;
            this.pictureBoxKKULogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(108, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PC Protector ";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::AntivirusSoftware.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(406, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(23)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(443, 253);
            this.Controls.Add(this.panelPopup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPopup";
            this.panelPopup.ResumeLayout(false);
            this.panelPopup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKKULogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPopup;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBoxKKULogo;
        private System.Windows.Forms.Label lblPopupMessage;
        private Custom_Controls.MyButton btnPopupNo;
        private Custom_Controls.MyButton btnPopupYes;
    }
}