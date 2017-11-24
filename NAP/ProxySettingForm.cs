using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Authentication;
using NAP.Network.Proxy;
using NAP.Network.Packet;

namespace NAP
{
    public partial class ProxySettingForm : Form
    {
        IProxy proxy;
        int port;
        IPAddress proxyIP;
        IPAddress destIP;

        public ProxySettingForm()
        {
            InitializeComponent();
            this.proxy = proxy;

            comboBox1.DataSource = Enum.GetValues(typeof(Protocols));
            comboBox2.DataSource = Enum.GetValues(typeof(SslProtocols));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProxyData proxyData = new ProxyData(
                int.Parse(textBox1.Text),
                (Protocols)comboBox1.SelectedItem,
                (SslProtocols)comboBox2.SelectedItem,
                IPAddress.Parse(textBox2.Text),
                IPAddress.Parse(textBox3.Text),
                textBox5.Text,
                textBox4.Text
                );

            switch (proxyData.protocol)
            {
                case Protocols.TCP:
                    {
                        proxy = new TcpProxy(proxyData);
                    }
                    break;
                case Protocols.SSL_TLS:
                    {
                        proxy = new SslTlsProxy(proxyData);
                    }
                    break;
                case Protocols.WebSocket:
                    {
                        proxy = new WebSocketProxy(proxyData);
                    }
                    break;
            }
            Close();
        }

        public IProxy GetProxy()
        {
            return proxy;
        }
    }
}
