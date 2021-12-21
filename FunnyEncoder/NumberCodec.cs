using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyEncoder
{
    public sealed class NumberCodec : SimpleExclusiveOrCrypto, Codec
    {
        private static readonly IDictionary<string, string> NUMBER = new Dictionary<string, string>()
        {
            { "000", "070" },
            { "001", "160" },
            { "010", "250" },
            { "011", "340" },
            { "100", "430" },
            { "101", "520" },
            { "110", "610" },
            { "111", "700" }
        };

        public NumberCodec()
        {
            name = "Number";
            description = "A Simple Number Codec";
        }

        public override byte[] encode(byte[] data)
        {
            string bitString = Util.getBitString(data);
            int remaining = bitString.Length % 3;
            int pad = remaining == 0 ? 0 : 3 - remaining;
            bitString += new string('0', pad);

            StringBuilder sb = new StringBuilder();
            sb.Append(new string('8', pad));
            for (int i = 0; i + 2 < bitString.Length; i += 3)
            {
                string current = string.Format("{0}{1}{2}", bitString[i], bitString[i + 1], bitString[i + 2]);
                string output = NUMBER[current];
                sb.Append(output);
            }
            return Encoding.UTF8.GetBytes(sb.ToString());
        }

        public override byte[] decode(byte[] data)
        {
            string input = Encoding.UTF8.GetString(data);
            int pad = 0;
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] != '8')
                {
                    break;
                }
                ++pad;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = pad; i + 2 < input.Length; i += 3)
            {
                string current = string.Format("{0}{1}{2}", input[i], input[i + 1], input[i + 2]);
                string output = NUMBER.First(pair => pair.Value == current).Key;
                sb.Append(output);
            }
            sb.Length -= pad;
            return Util.bitStringToByteArray(sb.ToString());
        }
    }
}