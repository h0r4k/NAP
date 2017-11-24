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
    public class WebSocketClient
    {
        SslStream sslStream;
        PacketTuner packetTuner;
        byte[] buffer1 = new byte[65535];

        IPAddress ip;
        int port;
        Action<byte[]> receiver;
        bool firstSend = true;
        bool firstRecv = true;

        private static Boolean RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public WebSocketClient(IPAddress ip, int port, Action<byte[]> receiver)
        {
            this.ip = ip;
            this.port = port;
            this.receiver = receiver;
        }

        public void Connect()
        {
            packetTuner = new PacketTuner(receiver);
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(ip, port);
            NetworkStream networkStream = tcpClient.GetStream();
            sslStream = new SslStream(networkStream, false, RemoteCertificateValidationCallback);
            sslStream.AuthenticateAsClient("");
            sslStream.BeginRead(buffer1, 0, buffer1.Length, AsyncReceive, sslStream);
        }

        public void Send(byte[] data)
        {
            if(!firstSend)
            {
                data = WebSocketMethods.SetFramework(data, true, "09A39F78".HexStringToBytes());
            }
            firstSend = false;

            sslStream.Write(data);
        }

        public void Close()
        {
            sslStream.Close();
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

                if(!firstRecv)
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
                
                sslStream.BeginRead(buffer1, 0, buffer1.Length, AsyncReceive, sslStream);
            }
            catch { }
        }
    }
}