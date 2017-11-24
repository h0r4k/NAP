using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NAP.Network.Packet;
using NAP.Network.Filter;

namespace NAP.Network.Proxy
{
    public interface IProxy
    {
        void Start(IPacketViewer packetViewer, FilterManager filterManager);
        void Close();
        void SendToClient(byte[] packet);
        void SendToServer(byte[] packet);
        ProxyData GetProxyData();
    }
}