using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NAP.Network.Filter;
using NAP.Network.Packet;
using NAP.Network.Proxy;
using NAP.Extensions;
using Be.Windows.Forms;

namespace NAP
{
    public partial class ProxyControlForm : Form, IPacketViewer
    {
        IProxy proxy;
        FilterManager filterManager;
        bool capturePacket = false;

        int sendListCount = 0;

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
            comboBox1.DataSource = Enum.GetValues(typeof(PacketMethods));
        }

        public void GetPacketData(PacketData packetData)
        {
            if (capturePacket)
            {
                Invoke((Action)(() =>
                {
                    dgridMain.Rows.Add(
                    packetData.method.ToString(),
                    packetData.packetState.ToString(),
                    packetData.packet.Length,
                    packetData.packet.Take(1000).ToArray().BytesToAscii(),
                    packetData.packet
                    );
                }));
            }
        }

        private void SendPacket(PacketMethods method, byte[] data)
        {
            switch (method)
            {
                case PacketMethods.RECV:
                    {
                        proxy.SendToClient(data);
                    }
                    break;
                case PacketMethods.SEND:
                    {
                        proxy.SendToServer(data);
                    }
                    break;
                case PacketMethods.NONE:
                    {
                    }
                    break;
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
            proxy.Close();
        }

        private void SendPacketButton_Click(object sender, EventArgs e)
        {
            SendPacket((PacketMethods)comboBox1.SelectedValue, PacketText.Text.HexStringToBytes());
        }

        private void copyHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            try
            {
                for (int i = 0; i < dgridMain.SelectedRows.Count; i++)
                {
                    data = ((byte[])dgridMain.SelectedRows[0].Cells["RawData"].Value).BytesToHexString();
                }
                if (data != string.Empty) Clipboard.SetText(data);
            }
            catch { }
        }

        private void clearViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgridMain.Rows.Clear();
        }

        private void dgridMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            byte[] data = new byte[0];
            try
            {
                for (int i = 0; i < dgridMain.SelectedRows.Count; i++)
                {
                    data = (byte[])dgridMain.SelectedRows[0].Cells["RawData"].Value;
                }
                if (data.Length > 0)
                {
                    HexPacketForm hexPacketForm = new HexPacketForm(data);
                    hexPacketForm.Show();
                }
            }
            catch { }
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            if (PacketText.Text != "")
            {
                dgridSendList.Rows.Add(comboBox1.SelectedItem.ToString(), PacketText.Text.Length / 2, PacketText.Text);
            }
        }

        private void addListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            string packetMethodString = null;
            for (int i = 0; i < dgridMain.SelectedRows.Count; i++)
            {
                data = ((byte[])dgridMain.SelectedRows[0].Cells["RawData"].Value).BytesToHexString();
                packetMethodString = (string)dgridMain.SelectedRows[0].Cells["Method"].Value;
            }

            dgridSendList.Rows.Add(packetMethodString, data.Length / 2, data);
        }

        private void SendPacketCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SendPacketCheckBox.Checked == true)
            {
                Thread th = new Thread(() =>
                {
                    while (SendPacketCheckBox.Checked)
                    {
                        Invoke((Action)(() =>
                        {
                            SendPacket((PacketMethods)comboBox1.SelectedValue, PacketText.Text.HexStringToBytes());
                        }));
                        Thread.Sleep(int.Parse(SendIntervalText.Text));
                    }
                });
                th.Start();
            }
        }

        private void ListSendCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ListSendCheck.Checked == true)
            {
                Thread th = new Thread(() =>
                {
                    while (ListSendCheck.Checked)
                    {
                        PacketMethods method = (PacketMethods)Enum.Parse(typeof(PacketMethods), dgridSendList.Rows[sendListCount].Cells[0].Value.ToString(), true);
                        byte[] packet = ((string)dgridSendList.Rows[sendListCount].Cells[2].Value).HexStringToBytes();

                        Invoke((Action)(() =>
                        {
                            SendPacket(method, packet);
                        }));

                        sendListCount++;

                        if (sendListCount == dgridSendList.Rows.Count)
                        {
                            sendListCount = 0;
                        }
                        Thread.Sleep(int.Parse(ListSendIntervalText.Text));
                    }

                });
                th.Start();
            }
            else
            {
                sendListCount = 0;
            }
        }

        private void copyHexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string data = "";
            try
            {
                for (int i = 0; i < dgridSendList.SelectedRows.Count; i++)
                {
                    data = dgridSendList.SelectedRows[0].Cells[2].Value.ToString();
                }
                if (data != string.Empty) Clipboard.SetText(data);
            }
            catch { }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgridSendList.Rows.Remove(dgridSendList.SelectedRows[0]);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            dgridSendList.Rows.Clear();
        }
    }
}
