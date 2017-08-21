using System;

namespace smcrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            SM4Utils sm4 = new SM4Utils();
            sm4.secretKey = "JeF8U9wHFOMfs2Y8";
            sm4.hexString = false;

            Console.WriteLine("ECB模式");
            Console.WriteLine("密文: " + sm4.Encrypt_ECB("11223344556677881122334455667788".HexToByteArray(), "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF".HexToByteArray()).ByteArrayToHex());
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
