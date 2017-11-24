using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAP.Network.Packet
{
    public interface IPacketViewer
    {
        void GetPacketData(PacketData packetData);
    }
}