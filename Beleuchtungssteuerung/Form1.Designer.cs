namespace Beleuchtungssteuerung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.grpLEDControl = new System.Windows.Forms.GroupBox();
            this.btnLedWhite = new System.Windows.Forms.Button();
            this.btnLedBlue = new System.Windows.Forms.Button();
            this.btnLedPink = new System.Windows.Forms.Button();
            this.btnLedGreen = new System.Windows.Forms.Button();
            this.btnLedTurkis = new System.Windows.Forms.Button();
            this.btnLedYellow = new System.Windows.Forms.Button();
            this.btnLedRed = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.grpLEDControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 54);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 28);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(273, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "192.168.14.124";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(12, 9);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host:";
            // 
            // grpLEDControl
            // 
            this.grpLEDControl.Controls.Add(this.btnLedWhite);
            this.grpLEDControl.Controls.Add(this.btnLedBlue);
            this.grpLEDControl.Controls.Add(this.btnLedPink);
            this.grpLEDControl.Controls.Add(this.btnLedGreen);
            this.grpLEDControl.Controls.Add(this.btnLedTurkis);
            this.grpLEDControl.Controls.Add(this.btnLedYellow);
            this.grpLEDControl.Controls.Add(this.btnLedRed);
            this.grpLEDControl.Controls.Add(this.btnLedOff);
            this.grpLEDControl.Enabled = false;
            this.grpLEDControl.Location = new System.Drawing.Point(12, 84);
            this.grpLEDControl.Name = "grpLEDControl";
            this.grpLEDControl.Size = new System.Drawing.Size(343, 258);
            this.grpLEDControl.TabIndex = 3;
            this.grpLEDControl.TabStop = false;
            this.grpLEDControl.Text = "LED-Steuerung:";
            // 
            // btnLedWhite
            // 
            this.btnLedWhite.BackColor = System.Drawing.Color.White;
            this.btnLedWhite.Location = new System.Drawing.Point(217, 171);
            this.btnLedWhite.Name = "btnLedWhite";
            this.btnLedWhite.Size = new System.Drawing.Size(68, 60);
            this.btnLedWhite.TabIndex = 8;
            this.btnLedWhite.UseVisualStyleBackColor = false;
            this.btnLedWhite.Click += new System.EventHandler(this.btnLedWhite_Click);
            // 
            // btnLedBlue
            // 
            this.btnLedBlue.BackColor = System.Drawing.Color.Blue;
            this.btnLedBlue.Location = new System.Drawing.Point(217, 39);
            this.btnLedBlue.Name = "btnLedBlue";
            this.btnLedBlue.Size = new System.Drawing.Size(68, 60);
            this.btnLedBlue.TabIndex = 7;
            this.btnLedBlue.UseVisualStyleBackColor = false;
            this.btnLedBlue.Click += new System.EventHandler(this.btnLedBlue_Click);
            // 
            // btnLedPink
            // 
            this.btnLedPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLedPink.Location = new System.Drawing.Point(143, 171);
            this.btnLedPink.Name = "btnLedPink";
            this.btnLedPink.Size = new System.Drawing.Size(68, 60);
            this.btnLedPink.TabIndex = 5;
            this.btnLedPink.UseVisualStyleBackColor = false;
            this.btnLedPink.Click += new System.EventHandler(this.btnLedPink_Click);
            // 
            // btnLedGreen
            // 
            this.btnLedGreen.BackColor = System.Drawing.Color.Lime;
            this.btnLedGreen.Location = new System.Drawing.Point(143, 39);
            this.btnLedGreen.Name = "btnLedGreen";
            this.btnLedGreen.Size = new System.Drawing.Size(68, 60);
            this.btnLedGreen.TabIndex = 4;
            this.btnLedGreen.UseVisualStyleBackColor = false;
            this.btnLedGreen.Click += new System.EventHandler(this.btnLedGreen_Click);
            // 
            // btnLedTurkis
            // 
            this.btnLedTurkis.BackColor = System.Drawing.Color.Aqua;
            this.btnLedTurkis.Location = new System.Drawing.Point(175, 105);
            this.btnLedTurkis.Name = "btnLedTurkis";
            this.btnLedTurkis.Size = new System.Drawing.Size(68, 60);
            this.btnLedTurkis.TabIndex = 3;
            this.btnLedTurkis.UseVisualStyleBackColor = false;
            this.btnLedTurkis.Click += new System.EventHandler(this.btnLedTurkis_Click);
            // 
            // btnLedYellow
            // 
            this.btnLedYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnLedYellow.Location = new System.Drawing.Point(101, 105);
            this.btnLedYellow.Name = "btnLedYellow";
            this.btnLedYellow.Size = new System.Drawing.Size(68, 60);
            this.btnLedYellow.TabIndex = 2;
            this.btnLedYellow.UseVisualStyleBackColor = false;
            this.btnLedYellow.Click += new System.EventHandler(this.btnLedYellow_Click);
            // 
            // btnLedRed
            // 
            this.btnLedRed.BackColor = System.Drawing.Color.Red;
            this.btnLedRed.Location = new System.Drawing.Point(69, 39);
            this.btnLedRed.Name = "btnLedRed";
            this.btnLedRed.Size = new System.Drawing.Size(68, 60);
            this.btnLedRed.TabIndex = 1;
            this.btnLedRed.UseVisualStyleBackColor = false;
            this.btnLedRed.Click += new System.EventHandler(this.btnLedRed_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.BackColor = System.Drawing.Color.Black;
            this.btnLedOff.Location = new System.Drawing.Point(69, 171);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(68, 60);
            this.btnLedOff.TabIndex = 0;
            this.btnLedOff.UseVisualStyleBackColor = false;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(288, 9);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(291, 28);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(64, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "60666";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(93, 55);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Trennen";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 354);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.grpLEDControl);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TOR-LED-control, v0.1, D. Marx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLEDControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.GroupBox grpLEDControl;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnLedWhite;
        private System.Windows.Forms.Button btnLedBlue;
        private System.Windows.Forms.Button btnLedPink;
        private System.Windows.Forms.Button btnLedGreen;
        private System.Windows.Forms.Button btnLedTurkis;
        private System.Windows.Forms.Button btnLedYellow;
        private System.Windows.Forms.Button btnLedRed;
        private System.Windows.Forms.Button btnLedOff;
    }
}

