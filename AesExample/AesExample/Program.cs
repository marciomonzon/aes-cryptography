using AesExample.Security;
using System.Security.Cryptography;
using System.Text;

namespace AesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = "Your Secret Message";

            // IV
            var initializationVector = RandomNumberGenerator.GetBytes(16);

            // KEY
            var key = RandomNumberGenerator.GetBytes(32);

            var encryptedData = Cryptography.AesEncrypt(Encoding.UTF8.GetBytes(message), key, initializationVector);
            Console.WriteLine(Convert.ToBase64String(encryptedData));

            var decryptedData = Cryptography.AesDecrypt(encryptedData, key, initializationVector);
            Console.WriteLine(Encoding.UTF8.GetString(decryptedData));
        }
    }
}
