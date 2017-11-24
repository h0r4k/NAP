using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Authentication;
using NAP.Properties;
using NAP.Extensions;
using NAP.Network.Filter;
using NAP.Network.Packet;

namespace NAP.Utils.WebSocket
{
    class WebSocketServer
    {

        SslStream sslStream;
        TcpListener tcpListener;
        PacketTuner packetTuner;
        byte[] buffer1 = new byte[65535];

        IPAddress ip;
        int port;
        Action<byte[]> receiver;
        Action opening;

        bool firstSend = true;
        bool firstRecv = true;
        string certPath;
        string certPass;

        public WebSocketServer(IPAddress ip, int port, Action<byte[]> receiver, Action opening, string certPath, string certPass)
        {
            this.ip = ip;
            this.port = port;
            this.receiver = receiver;
            this.opening = opening;
            this.certPath = certPath;
            this.certPass = certPass;
        }

        private static Boolean RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void Start()
        {
            packetTuner = new PacketTuner(receiver);
            tcpListener = new TcpListener(ip, port);
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(AcceptCallback, tcpListener);
        }

        public void Send(byte[] data)
        {
            if (!firstSend)
            {
                data = WebSocketMethods.SetFramework(data, false, null);
            }
            firstSend = false;

            sslStream.Write(data);
        }

        public void AcceptCallback(IAsyncResult ar)
        {
            try
            {
                tcpListener = (TcpListener)ar.AsyncState;
                TcpClient ClientTcpClient = tcpListener.EndAcceptTcpClient(ar);
                tcpListener.Stop();
                NetworkStream nteworkStream = ClientTcpClient.GetStream();
                sslStream = new SslStream(nteworkStream);
                X509Certificate2 certificate = new X509Certificate2(certPath, certPass);
                sslStream.AuthenticateAsServer(certificate, false, SslProtocols.Tls, false);
                opening();
                sslStream.BeginRead(buffer1, 0, buffer1.Length, AsyncReceive, sslStream);
            }
            catch { }
        }

        public void Close()
        {
            tcpListener.Stop();
            sslStream?.Close();
        }

        public void AsyncReceive(IAsyncResult ar)
        {
            try
            {
                int size = sslStream.EndRead(ar);
                if (size == 0)
                {
                    return;
                }

                byte[] packet = buffer1.Take(size).ToArray();

                if (!firstRecv)
                {
                    lock (packetTuner)
                    {
                        packetTuner.RidFrame(packet);
                    }
                }
                else
                {
                    receiver(packet);
                }

                firstRecv = false;

                sslStream?.BeginRead(buffer1, 0, buffer1.Length, AsyncReceive, sslStream);
            }
            catch { }
        }
    }
}
