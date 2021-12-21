using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyEncoder
{
    public sealed class FunnyCodec : SimpleExclusiveOrCrypto, Codec
    {
        private static readonly IDictionary<string, char> CODE = new Dictionary<string, char> {
            {"00", 'A'},
            {"01", 'C'},
            {"10", 'G'},
            {"11", 'T'}
        };

        public FunnyCodec()
        {
            name = "Funny";
            description = "A Simple Funny Codec";
        }

        public override byte[] encode(byte[] data)
        {
            string bitString = Util.getBitString(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i + 1 < bitString.Length; i += 2)
            {
                string current = string.Format("{0}{1}", bitString[i], bitString[i + 1]);
                char output = CODE[current];
                sb.Append(output);
            }
            return Encoding.UTF8.GetBytes(sb.ToString());
        }

        public override byte[] decode(byte[] data)
        {
            string input = Encoding.UTF8.GetString(data);
            StringBuilder sb = new StringBuilder();
            foreach (char current in input)
            {
                sb.Append(CODE.First(pair => pair.Value == current).Key);
            }
            return Util.bitStringToByteArray(sb.ToString());
        }
    }
}