using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using NAP.Network.Filter;
using NAP.Network.Packet;

namespace NAP.Network.Proxy
{
    class UdpProxy : IProxy
    {
        ProxyData proxyData;
        IPacketViewer packetViewer;
        Filter.FilterManager filterManager;

        NetworkStream nsWithClient;
        NetworkStream nsWithServer;

        byte[] buffer1 = new byte[65535];
        byte[] buffer2 = new byte[65535];

        public UdpProxy(ProxyData proxyData)
        {
            this.proxyData = proxyData;
        }

        public void Start(IPacketViewer packetViewer, FilterManager filterManager)
        {
            this.packetViewer = packetViewer;
            this.filterManager = filterManager;
        }

        public void Close()
        {
            this.Close();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
        }

        public void SendToClient(byte[] packet)
        {
            nsWithClient.Write(packet, 1, packet.Length);
        }

        public void SendToServer(byte[] packet)
        {
            nsWithServer.Write(packet, 1, packet.Length);
        }

        public void RecvFromClient(IAsyncResult ar)
        {
            try
            {
                int size = nsWithClient.EndRead(ar);
                if (size > 0)
                {
                    byte[] packet = buffer1.Take(size).ToArray();
                    PacketData packetData = new PacketData(packet, proxyData.port, Protocols.UDP, PacketMethods.SEND, proxyData.destIP);
                    filterManager.Filtering(packetData);
                    SendToServer(packet);
                }
            }
            catch { }
        }

        public void RecvFromServer(IAsyncResult ar)
        {
            try
            {
                int size = nsWithServer.EndRead(ar);
                if (size > 0)
                {
                    byte[] packet = buffer2.Take(size).ToArray();
                    PacketData packetData = new PacketData(packet, proxyData.port, Protocols.TCP, PacketMethods.RECV, proxyData.destIP);
                    filterManager.Filtering(packetData);
                    SendToClient(packet);
                }
            }
            catch { }
        }

        public ProxyData GetProxyData()
        {
            return proxyData;
        }
    }
}