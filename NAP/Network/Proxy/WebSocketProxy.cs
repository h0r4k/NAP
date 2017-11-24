using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using NAP.Network.Filter;
using NAP.Network.Packet;
using NAP.Properties;
using System.Net;
using NAP.Utils.WebSocket;
using NAP.Extensions;

namespace NAP.Network.Proxy
{
    class WebSocketProxy : IProxy
    {
        ProxyData proxyData;
        FilterManager filterManager;
        IPacketViewer packetViewer;
        WebSocketServer webSocketServer;
        WebSocketClient webSocketClient;

        public WebSocketProxy(ProxyData proxyData)
        {
            this.proxyData = proxyData;
        }

        public void Start(IPacketViewer packetViewer, FilterManager filterManager)
        {
            this.packetViewer = packetViewer;
            this.filterManager = filterManager;
            
            string certpath = Directory.GetCurrentDirectory() + "\\" + proxyData.certName + ".pfx";
            webSocketServer = new WebSocketServer(proxyData.proxyIP, proxyData.port, RecvFromClient, ConnectServer, certpath, proxyData.certPass);
            webSocketServer.Start();

        }

        public void Close()
        {
            webSocketClient.Close();
            webSocketServer.Close();
        }

        public void SendToClient(byte[] packet)
        {
            webSocketServer.Send(packet);
        }

        public void SendToServer(byte[] packet)
        {
            webSocketClient.Send(packet);
        }

        public void ConnectServer()
        {
            webSocketClient = new WebSocketClient(proxyData.destIP, proxyData.port, RecvFromServer);
            webSocketClient.Connect();
        }

        public void RecvFromClient(byte[] packet)
        {
            if (packet.Length > 0)
            {
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.WebSocket, PacketMethods.SEND, proxyData.destIP);
                filterManager.Filtering(packetData);
                if (packetData.packetState == PacketState.BLOCKED) return;
                SendToServer(packetData.packet);
                packetViewer.GetPacketData(packetData);
            }
        }

        public void RecvFromServer(byte[] packet)
        {
            if (packet.Length > 0)
            {
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.WebSocket, PacketMethods.RECV, proxyData.destIP);
                filterManager.Filtering(packetData);
                if (packetData.packetState == PacketState.BLOCKED) return;
                SendToClient(packetData.packet);
                packetViewer.GetPacketData(packetData);
            }
        }

        public ProxyData GetProxyData()
        {
            return proxyData;
        }
    }
}