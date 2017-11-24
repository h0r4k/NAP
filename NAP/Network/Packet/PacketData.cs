using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NAP.Network.Packet
{
    public class PacketData
    {
        public byte[] packet;
        public int port;
        public Protocols protocol;
        public PacketMethods method;
        public PacketState packetState;
        public IPAddress destIP;

        public PacketData(byte[] packet, int port, Protocols protocol, PacketMethods method, IPAddress destIP)
        {
            this.packet = packet;
            this.port = port;
            this.protocol = protocol;
            this.method = method;
            this.destIP = destIP;
            packetState = PacketState.PLANE;
        }

        public void ChangeState(PacketState packetState)
        {
            this.packetState = packetState;
        }
    }
}