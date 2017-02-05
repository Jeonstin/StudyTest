using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NativeWifi;
using System.Threading;
namespace WifiScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WlanClient wlanClient = new WlanClient();

        Thread thrAP = null;
        private delegate void OnWifiDelegate(ListViewItem lvi, bool f);
        private OnWifiDelegate OnWifi = null; //델리게이트 개체 생성

        private void Form1_Load(object sender, EventArgs e)
        {
            OnWifi = new OnWifiDelegate(OnWifiView);
            thrAP = new Thread(ThreadList);
            thrAP.Start();
        }

        private void OnWifiView(ListViewItem lvi, bool f)
        {
            if (f == true)
                this.lvAP.Items.Add(lvi);
            else
                this.lvAP.Items.Clear();
        }

        private void ThreadList()
        {
            while (true)
            {
                Invoke(OnWifi, null, false);
                Wlan.WlanAvailableNetwork[] wlanBssEntries =
                    wlanClient.Interfaces[0].GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in wlanBssEntries)
                {
                    var lvt = new ListViewItem(new string[] {
                        GetStringForSSID(network.dot11Ssid),
                        network.wlanSignalQuality.ToString(),
                        network.securityEnabled.ToString(),
                        GetMacChanel(1, ConvertToMAC(network.dot11Ssid.SSID)),
                        network.dot11DefaultCipherAlgorithm.ToString(),
                        network.dot11DefaultAuthAlgorithm.ToString(),
                        GetMacChanel(2, ConvertToMAC(network.dot11Ssid.SSID)) });
                    Invoke(OnWifi, lvt, true);
                }
                Thread.Sleep(1000);
            }

        }

        private string GetMacChanel(int i, string Name)
        {
            Wlan.WlanBssEntry[] lstWlanBss = wlanClient.Interfaces[0].GetNetworkBssList();


        }
    
        
    }
}
