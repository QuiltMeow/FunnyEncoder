namespace FunnyEncoder
{
    public abstract class SimpleExclusiveOrCrypto : SimpleIntroduction, Codec
    {
        public override byte[] encrypt(byte[] data, byte[] key)
        {
            byte[] encryptData = Util.exclusiveOr(data, key);
            return encode(encryptData);
        }

        public override byte[] decrypt(byte[] data, byte[] key)
        {
            byte[] decodeData = decode(data);
            return Util.exclusiveOr(decodeData, key);
        }
    }
}