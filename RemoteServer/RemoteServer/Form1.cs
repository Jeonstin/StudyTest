using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteServer
{
    public partial class Form1 : Form
    {
        private delegate void UIDelegate(Control aControl, String aStr);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlSetting(!jRemoteServer1.IsStarted);
        }

        private void btnSOpen_Click(object sender, EventArgs e)
        {
            this.jRemoteServer1.ServicePort = this.txtSPort.Text;
            this.jRemoteServer1.IsContinue = this.ckSContinue.Checked;
            if(!jRemoteServer1.IsStarted)
            {
                this.jRemoteServer1.Start();
            }
            ControlSetting(jRemoteServer1.IsStarted);


        }
        

        private void btnSClose_Click(object sender, EventArgs e)
        {
            if(jRemoteServer1.IsStarted)
            {
                this.jRemoteServer1.Stop();
            }
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(jRemoteServer1.IsStarted)
            {
                this.jRemoteServer1.Stop();
            }
        }


        private void ckSContinue_CheckedChanged(object sender, EventArgs e)
        {
            this.jRemoteServer1.IsContinue = this.ckSContinue.Checked;
        }

        private void jRemoteServer1_JRemoteServerOpen(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString("yyyyMMddHHmmss") + ": 서버 오픈" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 서버 오픈 ");
            }
        }

        private void jRemoteServer1_JRemoteServerDisConnected(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString("yyyymmddHHss") + ": 클라이언트 접속해제" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString("yyyyMMddHHmmss") + ": 클라이언트 접속해제");
            }
        }

        private void jRemoteServer1_JRemoteServerConnected(object aSender, JRemoteServer.SocketEventArgs aSocketEventArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속 [" + aSocketEventArgs.fClientInfo + "]" });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 클라이언트 접속 [" + aSocketEventArgs.fClientInfo + "]");
            }
        }

        private void jRemoteServer1_JRemoteServerClosed(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UIDelegate(TextSet), new Object[] { this.txtLog, DateTime.Now.ToString() + " : 서버 중지 " });
            }
            else
            {
                TextSet(this.txtLog, DateTime.Now.ToString() + " : 서버 중지 ");
            }
        }

        private void TextSet(Control aControl, String aString)
        {
            (aControl as TextBox).AppendText(aString + "\r\n");
        }


        //컨트롤 셋팅 (서버상태에 따라 활성/비활성)
        private void ControlSetting(Boolean aServerStatus)
        {
            this.ckSContinue.Enabled = aServerStatus;
            this.txtSPort.Enabled = aServerStatus;
            this.btnSOpen.Enabled = aServerStatus;
            this.btnSClose.Enabled = !aServerStatus;
        }
    }
    }
