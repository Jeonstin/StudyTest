using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCOpen_Click(object sender, EventArgs e)
        {
            jRemoteViewer1.IsDomain = rdDomain.Checked;
            jRemoteViewer1.SetConnectionString = this.txtCAddr.Text;
            jRemoteViewer1.SetPort = this.txtCPort.Text;
            if (!jRemoteViewer1.IsConnected)
            {
                jRemoteViewer1.Connect();
            }
        }

        private void btnCClose_Click(object sender, EventArgs e)
        {
            if(jRemoteViewer1.IsConnected)
            {
                jRemoteViewer1.DisConnect();
            }
        }

        private void jRemoteViewer1_JRemoteClientClosed(object sender, EventArgs e)
        {
            MessageBox.Show("중지 이벤트");
        }

        //서버 접속 이벤트
        private void jRemoteViewer1_JRemoteClientOpen(object sender, EventArgs e)
        {
            MessageBox.Show("접속 이벤트");
        }
    }
}
