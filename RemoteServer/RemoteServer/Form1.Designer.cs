namespace RemoteServer
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSClose = new System.Windows.Forms.Button();
            this.btnSOpen = new System.Windows.Forms.Button();
            this.txtSPort = new System.Windows.Forms.TextBox();
            this.ckSContinue = new System.Windows.Forms.CheckBox();
            this.jRemoteServer1 = new JRemoteServer.JRemoteServer();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Location = new System.Drawing.Point(0, 49);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(575, 91);
            this.txtLog.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port";
            // 
            // btnSClose
            // 
            this.btnSClose.Location = new System.Drawing.Point(409, 13);
            this.btnSClose.Name = "btnSClose";
            this.btnSClose.Size = new System.Drawing.Size(83, 23);
            this.btnSClose.TabIndex = 16;
            this.btnSClose.Text = "중지";
            this.btnSClose.UseVisualStyleBackColor = true;
            this.btnSClose.Click += new System.EventHandler(this.btnSClose_Click);
            // 
            // btnSOpen
            // 
            this.btnSOpen.Location = new System.Drawing.Point(316, 13);
            this.btnSOpen.Name = "btnSOpen";
            this.btnSOpen.Size = new System.Drawing.Size(83, 23);
            this.btnSOpen.TabIndex = 15;
            this.btnSOpen.Text = "시작";
            this.btnSOpen.UseVisualStyleBackColor = true;
            this.btnSOpen.Click += new System.EventHandler(this.btnSOpen_Click);
            // 
            // txtSPort
            // 
            this.txtSPort.Location = new System.Drawing.Point(194, 15);
            this.txtSPort.Name = "txtSPort";
            this.txtSPort.Size = new System.Drawing.Size(100, 21);
            this.txtSPort.TabIndex = 14;
            this.txtSPort.Text = "9999";
            // 
            // ckSContinue
            // 
            this.ckSContinue.AutoSize = true;
            this.ckSContinue.Checked = true;
            this.ckSContinue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSContinue.Location = new System.Drawing.Point(12, 15);
            this.ckSContinue.Name = "ckSContinue";
            this.ckSContinue.Size = new System.Drawing.Size(76, 16);
            this.ckSContinue.TabIndex = 13;
            this.ckSContinue.Text = "서버 유지";
            this.ckSContinue.UseVisualStyleBackColor = true;
            this.ckSContinue.CheckedChanged += new System.EventHandler(this.ckSContinue_CheckedChanged);
            // 
            // jRemoteServer1
            // 
            this.jRemoteServer1.Location = new System.Drawing.Point(111, 11);
            this.jRemoteServer1.Name = "jRemoteServer1";
            this.jRemoteServer1.Size = new System.Drawing.Size(23, 25);
            this.jRemoteServer1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 140);
            this.Controls.Add(this.jRemoteServer1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSClose);
            this.Controls.Add(this.btnSOpen);
            this.Controls.Add(this.txtSPort);
            this.Controls.Add(this.ckSContinue);
            this.Name = "Form1";
            this.Text = "RemoteServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSClose;
        private System.Windows.Forms.Button btnSOpen;
        private System.Windows.Forms.TextBox txtSPort;
        private System.Windows.Forms.CheckBox ckSContinue;
        private JRemoteServer.JRemoteServer jRemoteServer1;
    }
}

