using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using NAP.Network.Packet;

namespace NAP.Network.Filter
{
    public class FilterData
    {
        public string name;
        public bool enable;
        public string portStr;
        public Protocols protocol;
        public PacketMethods method;
        public string destIPStr;
        public string search;
        public string modify;

        public FilterData()
        {
        }

        public void Set(bool enable, string name, string portStr, Protocols protocol, PacketMethods method, string destIPStr, string search, string modify)
        {
            this.enable = enable;
            this.name = name;
            this.portStr = portStr;
            this.protocol = protocol;
            this.method = method;
            this.destIPStr = destIPStr;
            this.search = search;
            this.modify = modify;
        }
    }
}