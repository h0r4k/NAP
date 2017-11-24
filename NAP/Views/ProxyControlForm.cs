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
    public partial class ProxyControlForm : Form, IPacketViewer
    {
        IProxy proxy;
        FilterManager filterManager;
        bool capturePacket = false;
        delegate void dele();

        public ProxyControlForm(IProxy proxy, FilterManager filterManager)
        {
            InitializeComponent();
            this.proxy = proxy;
            this.filterManager = filterManager;
        }

        private void ProxyControlForm_Load(object sender, EventArgs e)
        {
            proxy.Start(this, filterManager);
            ProxyData proxyData = proxy.GetProxyData();
            this.Text = $"{proxyData.protocol} Proxy [ IP : {proxyData.destIP}, Port : {proxyData.port} ]";
        }

        public void GetPacketData(PacketData packetData)
        {
            if (capturePacket)
            {
                Invoke(new dele(() => {
                    dgridMain.Rows.Add(
                    packetData.method.ToString(),
                    packetData.packetState.ToString(),
                    packetData.packet.Length,
                    packetData.packet.Take(packetData.packet.Length > 1000 ? 1000 : packetData.packet.Length).ToArray().BytesToHexString(),
                    packetData.packet
                    );
                }));
            }
        }

        private void CapturePacketButton_Click(object sender, EventArgs e)
        {
            capturePacket = !capturePacket;
            if (capturePacket) CapturePacketButton.BackColor = SystemColors.ActiveBorder;
            else CapturePacketButton.BackColor = SystemColors.ControlLight;
        }

        private void ProxyControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //proxy.Close();
        }

        private void SendPacketButton_Click(object sender, EventArgs e)
        {

        }
    }
}
