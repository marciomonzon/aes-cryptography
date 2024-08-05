using System.Security.Cryptography;

namespace AesExample.Security
{
    public static class Cryptography
    {
        public static byte[] AesEncrypt(byte[] data, byte[] key, byte[] initializationVector)
        {
            using var aes = Aes.Create();
            aes.Key = key;
            var encryptedData = aes.EncryptCbc(data, initializationVector);

            return encryptedData;
        }

        public static byte[] AesDecrypt(byte[] data, byte[] key, byte[] initializationVector)
        {
            using var aes = Aes.Create();
            aes.Key = key;
            var decryptedData = aes.DecryptCbc(data, initializationVector);

            return decryptedData;
        }
    }
}
