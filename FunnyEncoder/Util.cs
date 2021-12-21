using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FunnyEncoder
{
    public static class Util
    {
        public static string getBitString(byte[] data)
        {
            return string.Join(string.Empty, data.Select(value => Convert.ToString(value, 2).PadLeft(8, '0')));
        }

        public static byte[] bitStringToByteArray(string bitString)
        {
            bitString = Regex.Replace(bitString, "\\s+", string.Empty);
            return Enumerable.Range(0, bitString.Length / 8).Select(position => Convert.ToByte(bitString.Substring(position * 8, 8), 2)).ToArray();
        }

        public static byte[] exclusiveOr(byte[] data, byte[] key)
        {
            byte[] ret = data.ToArray();
            for (int i = 0, j = 0; i < ret.Length; ++i, ++j)
            {
                if (j >= key.Length)
                {
                    j = 0;
                }
                ret[i] ^= key[j];
            }
            return ret;
        }

        public static string getHexString(byte[] data, string replace = " ")
        {
            return BitConverter.ToString(data).Replace("-", replace);
        }

        public static byte[] hexStringToByteArray(string data)
        {
            data = Regex.Replace(data, "\\s+", string.Empty);
            return Enumerable.Range(0, data.Length).Where(value => value % 2 == 0).Select(index => Convert.ToByte(data.Substring(index, 2), 16)).ToArray();
        }

        public static IEnumerable<string> splitLengthPart(this string data, int length)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (length <= 0)
            {
                throw new ArgumentException("切割長度必須是正數", nameof(length));
            }
            for (int i = 0; i < data.Length; i += length)
            {
                yield return data.Substring(i, Math.Min(length, data.Length - i));
            }
        }
    }
}