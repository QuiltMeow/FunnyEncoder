namespace FunnyEncoder
{
    public abstract class SimpleIntroduction : Codec
    {
        public virtual string name
        {
            get;
            protected set;
        }

        public virtual string description
        {
            get;
            protected set;
        }

        public abstract byte[] encode(byte[] data);

        public abstract byte[] decode(byte[] data);

        public abstract byte[] encrypt(byte[] data, byte[] key);

        public abstract byte[] decrypt(byte[] data, byte[] key);
    }
}