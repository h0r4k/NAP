using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NAP.Network.Packet;
using System.Security.Authentication;

namespace NAP.Network.Proxy
{
    public class ProxyData
    {
        public byte[] packet;
        public int port;
        public Protocols protocol;
        public SslProtocols sslProtocol;
        public IPAddress proxyIP;
        public IPAddress destIP;
        public string certName;
        public string certPass;

        public ProxyData(int port, Protocols protocol, SslProtocols sslProtocol, IPAddress proxyIP, IPAddress destIP, string certName = "", string certPass = "")
        {
            this.port = port;
            this.protocol = protocol;
            this.sslProtocol = sslProtocol;
            this.proxyIP = proxyIP;
            this.destIP = destIP;
            this.certName = certName;
            this.certPass = certPass;
        }
    }
}
