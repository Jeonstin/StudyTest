namespace RemoteViewer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdDomain = new System.Windows.Forms.RadioButton();
            this.rdIPAddr = new System.Windows.Forms.RadioButton();
            this.txtCPort = new System.Windows.Forms.TextBox();
            this.txtCAddr = new System.Windows.Forms.TextBox();
            this.btnCClose = new System.Windows.Forms.Button();
            this.btnCOpen = new System.Windows.Forms.Button();
            this.jRemoteViewer1 = new JRemoteClient.JRemoteViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "서버주소";
            // 
            // rdDomain
            // 
            this.rdDomain.AutoSize = true;
            this.rdDomain.Location = new System.Drawing.Point(120, 13);
            this.rdDomain.Name = "rdDomain";
            this.rdDomain.Size = new System.Drawing.Size(66, 16);
            this.rdDomain.TabIndex = 12;
            this.rdDomain.Text = "Domain";
            this.rdDomain.UseVisualStyleBackColor = true;
            // 
            // rdIPAddr
            // 
            this.rdIPAddr.AutoSize = true;
            this.rdIPAddr.Checked = true;
            this.rdIPAddr.Location = new System.Drawing.Point(80, 13);
            this.rdIPAddr.Name = "rdIPAddr";
            this.rdIPAddr.Size = new System.Drawing.Size(34, 16);
            this.rdIPAddr.TabIndex = 11;
            this.rdIPAddr.TabStop = true;
            this.rdIPAddr.Text = "IP";
            this.rdIPAddr.UseVisualStyleBackColor = true;
            // 
            // txtCPort
            // 
            this.txtCPort.Location = new System.Drawing.Point(514, 12);
            this.txtCPort.Name = "txtCPort";
            this.txtCPort.Size = new System.Drawing.Size(55, 21);
            this.txtCPort.TabIndex = 9;
            this.txtCPort.Text = "9999";
            // 
            // txtCAddr
            // 
            this.txtCAddr.Location = new System.Drawing.Point(288, 12);
            this.txtCAddr.Name = "txtCAddr";
            this.txtCAddr.Size = new System.Drawing.Size(129, 21);
            this.txtCAddr.TabIndex = 10;
            this.txtCAddr.Text = "192.168.0.5";
            // 
            // btnCClose
            // 
            this.btnCClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCClose.Location = new System.Drawing.Point(776, 10);
            this.btnCClose.Name = "btnCClose";
            this.btnCClose.Size = new System.Drawing.Size(75, 23);
            this.btnCClose.TabIndex = 7;
            this.btnCClose.Text = "해제";
            this.btnCClose.UseVisualStyleBackColor = true;
            this.btnCClose.Click += new System.EventHandler(this.btnCClose_Click);
            // 
            // btnCOpen
            // 
            this.btnCOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOpen.Location = new System.Drawing.Point(695, 10);
            this.btnCOpen.Name = "btnCOpen";
            this.btnCOpen.Size = new System.Drawing.Size(75, 23);
            this.btnCOpen.TabIndex = 8;
            this.btnCOpen.Text = "접속";
            this.btnCOpen.UseVisualStyleBackColor = true;
            this.btnCOpen.Click += new System.EventHandler(this.btnCOpen_Click);
            // 
            // jRemoteViewer1
            // 
            this.jRemoteViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jRemoteViewer1.Location = new System.Drawing.Point(12, 39);
            this.jRemoteViewer1.Name = "jRemoteViewer1";
            this.jRemoteViewer1.Size = new System.Drawing.Size(1078, 500);
            this.jRemoteViewer1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 542);
            this.Controls.Add(this.jRemoteViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdDomain);
            this.Controls.Add(this.rdIPAddr);
            this.Controls.Add(this.txtCPort);
            this.Controls.Add(this.txtCAddr);
            this.Controls.Add(this.btnCClose);
            this.Controls.Add(this.btnCOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdDomain;
        private System.Windows.Forms.RadioButton rdIPAddr;
        private System.Windows.Forms.TextBox txtCPort;
        private System.Windows.Forms.TextBox txtCAddr;
        private System.Windows.Forms.Button btnCClose;
        private System.Windows.Forms.Button btnCOpen;
        private JRemoteClient.JRemoteViewer jRemoteViewer1;
    }
}

