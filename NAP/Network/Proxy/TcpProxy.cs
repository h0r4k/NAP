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
    class TcpProxy : IProxy
    {
        ProxyData proxyData;
        IPacketViewer packetViewer;
        FilterManager filterManager;

        TcpClient tcpClient1;
        TcpClient tcpClient2;
        TcpListener tcpListener;

        NetworkStream networkStreamWithClient;
        NetworkStream networkStreamWithServer;
        byte[] buffer1 = new byte[65535];
        byte[] buffer2 = new byte[65535];

        public TcpProxy(ProxyData proxyData)
        {
            this.proxyData = proxyData;
        }

        public void Start(IPacketViewer packetViewer, Filter.FilterManager filterManager)
        {
            this.packetViewer = packetViewer;
            this.filterManager = filterManager;

            tcpListener = new TcpListener(proxyData.proxyIP, proxyData.port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(AcceptCallback, tcpListener);
        }

        public void Close()
        {
            tcpListener.Stop();
            CloseConnections();
        }

        public void CloseConnections()
        {
            tcpClient1?.Close();
            tcpClient2?.Close();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                tcpClient1 = tcpListener?.EndAcceptTcpClient(ar);
                tcpListener.Stop();
                networkStreamWithClient = tcpClient1.GetStream();

                tcpClient2 = new TcpClient();
                tcpClient2.Connect(proxyData.destIP, proxyData.port);
                networkStreamWithServer = tcpClient2.GetStream();

                networkStreamWithClient.BeginRead(buffer1, 0, buffer1.Length, RecvFromClient, networkStreamWithClient);
                networkStreamWithServer.BeginRead(buffer2, 0, buffer2.Length, RecvFromServer, networkStreamWithServer);
            }
            catch { }
        }

        public void SendToClient(byte[] packet)
        {
            networkStreamWithClient.Write(packet, 0, packet.Length);
        }

        public void SendToServer(byte[] packet)
        {
            networkStreamWithServer.Write(packet, 0, packet.Length);
        }

        public void RecvFromClient(IAsyncResult ar)
        {
            try
            {
                int size = networkStreamWithClient.EndRead(ar);
                byte[] packet = buffer1.Take(size).ToArray();
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.TCP, PacketMethods.SEND, proxyData.destIP);
                filterManager.Filtering(packetData);
                SendToServer(packetData.packet);

                if (size == 0)
                {
                    CloseConnections();
                    return;
                }

                packetViewer.GetPacketData(packetData);
                networkStreamWithClient?.BeginRead(buffer1, 0, buffer1.Length, RecvFromClient, networkStreamWithClient);
            }
            catch
            {
                Console.WriteLine("Client Disconnected Error.");
            }
        }

        public void RecvFromServer(IAsyncResult ar)
        {
            try
            {
                int size = networkStreamWithServer.EndRead(ar);
                byte[] packet = buffer2.Take(size).ToArray();
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.TCP, PacketMethods.RECV, proxyData.destIP);
                filterManager.Filtering(packetData);
                SendToClient(packetData.packet);

                if (size == 0)
                {
                    CloseConnections();
                    return;
                }

                packetViewer.GetPacketData(packetData);
                networkStreamWithServer?.BeginRead(buffer2, 0, buffer2.Length, RecvFromServer, networkStreamWithServer);
            }
            catch
            {
                Console.WriteLine("Server Disconnected Error.");
            }
        }

        public ProxyData GetProxyData()
        {
            return proxyData;
        }
    }
}