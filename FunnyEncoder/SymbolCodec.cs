using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyEncoder
{
    public sealed class SymbolCodec : SimpleExclusiveOrCrypto, Codec
    {
        private static readonly IDictionary<char, char> SYMBOL = new Dictionary<char, char>()
        {
            { '1', '!' },
            { '2', '@' },
            { '3', '#' },
            { '4', '$' },
            { '5', '%' },
            { '6', '^' },
            { '7', '&' },
            { '8', '*' },
            { '9', '(' },
            { '0', ')' },
            { 'A', '`' },
            { 'B', '-' },
            { 'C', '=' },
            { 'D', '[' },
            { 'E', ']' },
            { 'F', '/' }
        };

        public SymbolCodec()
        {
            name = "Symbol";
            description = "A Simple Symbol Codec";
        }

        public override byte[] encode(byte[] data)
        {
            string byteString = Util.getHexString(data, string.Empty);
            StringBuilder sb = new StringBuilder();
            foreach (char value in byteString)
            {
                sb.Append(SYMBOL[value]);
            }
            return Encoding.UTF8.GetBytes(sb.ToString());
        }

        public override byte[] decode(byte[] data)
        {
            string input = Encoding.UTF8.GetString(data);
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in input)
            {
                sb.Append(SYMBOL.First(pair => pair.Value == symbol).Key);
            }
            return Util.hexStringToByteArray(sb.ToString());
        }
    }
}