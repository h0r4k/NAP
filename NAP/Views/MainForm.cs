using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAP.Network.Filter;
using NAP.Network.Packet;
using NAP.Network.Proxy;
using NAP.Extensions;

namespace NAP.Views
{
    public partial class MainForm : Form
    {
        FilterManager filterManager;
        FilterControlForm filterControlForm;

        public MainForm()
        {
            InitializeComponent();
            filterManager = new FilterManager();
            filterControlForm = new FilterControlForm(filterManager);
        }

        private void newFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterControlForm.ShowDialog();
        }

        public void GetPacketData(PacketData packetData)
        {
            Console.WriteLine("{0}:{1}", packetData.method, packetData.packet.BytesToHexString());
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IProxy proxy = null;
            ProxySettingForm proxySettingForm = new ProxySettingForm();
            proxySettingForm.ShowDialog();
            proxy = proxySettingForm.GetProxy();

            if (proxy != null)
            {
                ProxyControlForm proxyControlForm = new ProxyControlForm(proxy, filterManager);
                proxyControlForm.TopLevel = false;
                mainPanel.Controls.Add(proxyControlForm);
                proxyControlForm.Show();
                proxyControlForm.BringToFront();
            }
        }

        private void filteringToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            filterManager.ChangeFilterable();
        }
    }
}
