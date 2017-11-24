using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAP.Network.Packet;
using NAP.Extensions;

namespace NAP.Network.Filter
{
    public class FilterManager
    {
        public List<FilterData> filterDatas;

        public bool filterable = true;

        public FilterManager()
        {
            filterDatas = new List<FilterData>();
        }

        public void Filtering(PacketData packetData)
        {
            lock (this)
            {
                foreach (var filterData in filterDatas)
                {
                    if (!filterable) continue;

                    if (!filterData.enable) continue;

                    if (packetData.destIP.ToString() != filterData.destIPStr && filterData.destIPStr != "") continue;

                    if (packetData.port.ToString() != filterData.portStr && filterData.portStr != "") continue;

                    if (packetData.protocol != filterData.protocol && filterData.protocol != Protocols.NONE) continue;

                    if (packetData.method != filterData.method && filterData.method != PacketMethods.NONE) continue;

                    if (filterData.modify == "BLOCK")
                    {
                        packetData.packet = new byte[0];
                        packetData.ChangeState(PacketState.BLOCKED);

                        continue;
                    }

                    string str = packetData.packet.BytesToHexString();
                    int index = str.IndexOfEx(0, filterData.search);
                    if (index < 0) continue;

                    while (index >= 0)
                    {
                        str = str.ReplaceEx(index, filterData.search, filterData.modify);
                        index = str.IndexOfEx(index, filterData.search);
                    }

                    packetData.packet = str.HexStringToBytes();
                    packetData.ChangeState(PacketState.EDITED);
                }
            }
        }

        public void AddFilterData(FilterData filterData)
        {
            filterDatas.Add(filterData);
        }

        public void RemoveFilterData(FilterData filterData)
        {
            filterDatas.Remove(filterData);
        }

        public void ChangeFilterable()
        {
            filterable = !filterable;
        }
    }
}