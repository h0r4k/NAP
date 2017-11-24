using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NAP.Extensions;

namespace NAP.Utils.WebSocket
{
    public static class WebSocketMethods
    {
        public static int opcode = -1;
        public enum Bits : byte
        {
            b1 = 0x01,
            b2 = 0x02,
            b3 = 0x04,
            b4 = 0x08,
            b5 = 0x10,
            b6 = 0x20,
            b7 = 0x40,
            b8 = 0x80
        }

        public static uint CheckHeadSize(byte[] data)
        {
            uint headsize = 0;
            if (data[1] - (byte)Bits.b8 == 126 || data[1] == 126)
            {
                headsize = 3;
                return headsize;
            }
            if (data[1] - (byte)Bits.b8 == 127 || data[1] == 127)
            {
                headsize = 9;
                return headsize;
            }

            headsize = 1;
            return headsize;
        }

        public static uint[] CheckPacketSize(byte[] data, bool maskedbool)
        {
            uint packetsize = 0;
            uint headsize = 0;
            if (data[1] - (byte)Bits.b8 == 126 || data[1] == 126)
            {
                packetsize = BitConverter.ToUInt16(data.Skip(2).Take(2).Reverse().ToArray(), 0);
                headsize = 3;
                return new uint[] { packetsize, headsize };
            }
            if (data[1] - (byte)Bits.b8 == 127 || data[1] == 127)
            {
                packetsize = BitConverter.ToUInt32(data.Skip(6).Take(4).Reverse().ToArray(), 0);
                headsize = 9;
                return new uint[] { packetsize, headsize };
            }

            if (maskedbool == true)
            {
                packetsize = (uint)(data[1] - (byte)Bits.b8);
            }
            if (maskedbool == false)
            {
                packetsize = (uint)(data[1]);
            }
            headsize = 1;
            return new uint[] { packetsize, headsize };

        }
        public static byte[] SetFramework(byte[] data, bool mask, byte[] maskingkey)
        {
            byte[] seteddata = null;
            byte[] len = null;
            if (data.Length < 126)
            {
                byte blen = (byte)data.Length;
                len = new byte[] { blen };
            }
            if (126 <= data.Length && data.Length <= 65535)
            {
                short slen = (short)data.Length;
                len = (new byte[] { 126 }).Concat(BitConverter.GetBytes(slen).Reverse()).ToArray();
            }
            if (65535 < data.Length)
            {
                long slen = (long)data.Length;
                len = (new byte[] { 127 }).Concat(BitConverter.GetBytes(slen).Reverse()).ToArray();
            }
            if (mask == true)
            {
                len[0] = (byte)((int)len[0] + 0x80);
                data = SetMasking(data, maskingkey);
                len = len.Concat(maskingkey).ToArray();
            }
            seteddata = (new byte[] { (byte)(opcode + 128) }).Concat(len.Concat(data)).ToArray();
            return seteddata;
        }

        public static byte[] RidMasking(byte[] data, byte[] key)
        {
            byte[] unmasked;
            unmasked = new byte[data.Length];
            for (int i = 0; i < unmasked.Length; i++)
            {
                unmasked[i] = (byte)(key[i % 4] ^ data[i]);
            }
            return unmasked;
        }

        public static byte[] SetMasking(byte[] unmasked, byte[] maskingkey)
        {
            byte[] masked = new byte[unmasked.Length];
            for (int i = 0; i < masked.Length; i++)
            {
                masked[i] = (byte)(maskingkey[i % 4] ^ unmasked[i]);
            }
            return masked;
        }
    }
}
