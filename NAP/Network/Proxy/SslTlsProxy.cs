using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Authentication;
using NAP.Properties;
using NAP.Network.Filter;
using NAP.Network.Packet;

namespace NAP.Network.Proxy
{
    public class SslTlsProxy : IProxy
    {
        ProxyData proxyData;
        FilterManager filterManager;
        IPacketViewer packetViewer;
        SslStream sslStreamWithClient;
        SslStream sslStreamWithServer;
        TcpListener tcpListener;
        byte[] buffer1 = new byte[65535];
        byte[] buffer2 = new byte[65535];

        private static Boolean RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public SslTlsProxy(ProxyData proxyData)
        {
            this.proxyData = proxyData;
        }

        public void Start(IPacketViewer packetViewer, FilterManager filterManager)
        {
            this.packetViewer = packetViewer;
            this.filterManager = filterManager;

            tcpListener = new TcpListener(proxyData.proxyIP, proxyData.port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(AcceptCallback, tcpListener);
        }

        public void Close()
        {
            tcpListener?.Stop();
            CloseConnections();
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                TcpClient ClientTcpClient = tcpListener.EndAcceptTcpClient(ar);
                tcpListener.Stop();
                NetworkStream ClientNS = ClientTcpClient.GetStream();
                sslStreamWithClient = new SslStream(ClientNS);

                string certpath = Directory.GetCurrentDirectory() + "\\" + proxyData.certName + ".pfx";
                X509Certificate2 certificate = new X509Certificate2(certpath, proxyData.certPass);
                sslStreamWithClient.AuthenticateAsServer(certificate, false, proxyData.sslProtocol, false);

                TcpClient ServerTcpClient = new TcpClient();
                ServerTcpClient.Connect(proxyData.destIP, proxyData.port);
                NetworkStream ServerNS = ServerTcpClient.GetStream();
                sslStreamWithServer = new SslStream(ServerNS, false, RemoteCertificateValidationCallback);
                sslStreamWithServer.AuthenticateAsClient("");

                sslStreamWithClient.BeginRead(buffer1, 0, buffer1.Length, RecvFromClient, sslStreamWithClient);
                sslStreamWithServer.BeginRead(buffer2, 0, buffer2.Length, RecvFromServer, sslStreamWithServer);
            }
            catch { }
        }

        private void CloseConnections()
        {
            sslStreamWithClient?.Close();
            sslStreamWithServer?.Close();
        }

        public void SendToClient(byte[] packet)
        {
            sslStreamWithClient.Write(packet);
        }

        public void SendToServer(byte[] packet)
        {
            sslStreamWithServer.Write(packet);
        }

        public void RecvFromClient(IAsyncResult ar)
        {
            try
            {
                int size = sslStreamWithClient.EndRead(ar);
                if (size == 0)
                {
                    CloseConnections();
                    return;
                }

                byte[] packet = buffer1.Take(size).ToArray();
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.SSL_TLS, PacketMethods.SEND, proxyData.destIP);
                filterManager.Filtering(packetData);
                SendToServer(packetData.packet);
                packetViewer.GetPacketData(packetData);
                sslStreamWithClient?.BeginRead(buffer1, 0, buffer1.Length, RecvFromClient, sslStreamWithClient);
            }
            catch
            {
            }
        }

        public void RecvFromServer(IAsyncResult ar)
        {
            try
            {
                int size = sslStreamWithServer.EndRead(ar);
                if (size == 0)
                {
                    CloseConnections();
                    return;
                }

                byte[] packet = buffer2.Take(size).ToArray();
                PacketData packetData = new PacketData(packet, proxyData.port, Protocols.SSL_TLS, PacketMethods.RECV, proxyData.destIP);
                filterManager.Filtering(packetData);
                SendToClient(packetData.packet);
                packetViewer.GetPacketData(packetData);
                sslStreamWithServer?.BeginRead(buffer2, 0, buffer2.Length, RecvFromServer, sslStreamWithServer);
            }
            catch
            {
            }
        }

        public ProxyData GetProxyData()
        {
            return proxyData;
        }
    }
}