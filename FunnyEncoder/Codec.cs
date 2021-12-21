namespace FunnyEncoder
{
    // 歡迎擴充 實作就好 怎麼建構的不重要
    public interface Codec
    {
        string name // 編解碼器名稱
        {
            get;
        }

        string description // 編解碼器描述
        {
            get;
        }

        byte[] encode(byte[] data); // 編碼方法

        byte[] decode(byte[] data); // 解碼方法

        byte[] encrypt(byte[] data, byte[] key); // 加密方法

        byte[] decrypt(byte[] data, byte[] key); // 解密方法
    }
}