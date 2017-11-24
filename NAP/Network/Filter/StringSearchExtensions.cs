using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAP.Network.Filter
{
    public static class StringSearchExtensions
    {
        public static int IndexOfEx(this string str1, int opcode, string str2)
        {
            int index = -1;

            if (!str2.Contains("-"))
            {
                index = str1.Substring(opcode).IndexOf(str2);
                return (index < 0) ? index : index + opcode;

            }

            for (int k = opcode; k < str1.Length - str2.Length; k++)
            {
                index = k;

                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] != '-')
                    {
                        if (str2[i] != str1[k + i])
                        {
                            index = -1;
                            break;
                        }
                    }
                }

                if (index >= 0)
                {
                    break;
                }
            }

            return index;
        }

        public static string ReplaceEx(this string str, int index, string search, string modify)
        {
            string _str = str.Substring(index, modify.Length);

            return str.Substring(0, index) + Asd(_str, modify) + str.Substring(index + search.Length);
        }

        private static string Asd(string _str, string modify)
        {
            string result = modify;

            for (int i = 0; i < modify.Length; i++)
            {
                if (modify[i] == '-')
                {
                    result = result.Substring(0, i) + _str[i] + result.Substring(i + 1);
                }
            }

            return result.ToString();
        }
    }
}
