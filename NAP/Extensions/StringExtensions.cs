using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAP.Extensions
{
    public static class StringExtensions
    {
        public static Encoding Encode = Encoding.UTF8;

        public static string AsciiToHexString(this string input) => BytesToHexString(Encode.GetBytes(input));

        public static byte[] AsciiToBytes(this string input) => Encode.GetBytes(input);

        public static string BytesToAscii(this byte[] input) => Encode.GetString(input);

        public static string BytesToHexString(this byte[] input) => BitConverter.ToString(input).Replace("-", "");

        public static string HexStringToAscii(this string input) => Encode.GetString(HexStringToBytes(input));

        public static byte[] HexStringToBytes(this string input)
        {
            var length = input.Length;

            var index = new byte[length / 2];

            for (var i = 0; i < length; i = i + 2)
            {
                index[i / 2] = Convert.ToByte(input.Substring(i, 2), 16);
            }

            return index;
        }
    }
}
