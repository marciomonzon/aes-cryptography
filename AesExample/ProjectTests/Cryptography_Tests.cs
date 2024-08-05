using AesExample.Security;
using System.Security.Cryptography;
using System.Text;

namespace ProjectTests
{
    public class Cryptography_Tests
    {
        [Theory]
        [InlineData("SecretMessage")]
        [InlineData("Secret Message")]
        [InlineData("Secret_Message")]
        [InlineData("Secret_Message@")]
        [InlineData("Secret!@#Message@")]
        [InlineData("test@test.com")]
        public void Should_Encrypt_Decrypt_And_Be_Valid(string secretMessage)
        {
            // Arrange
            var initializationVector = RandomNumberGenerator.GetBytes(16);
            var key = RandomNumberGenerator.GetBytes(32);

            // Act
            var encryptedData = Cryptography.AesEncrypt(Encoding.UTF8.GetBytes(secretMessage),
                                                        key,
                                                        initializationVector);

            var decryptedData = Cryptography.AesDecrypt(encryptedData,
                                                        key,
                                                        initializationVector);

            // Assert
            Assert.Equal(secretMessage, Encoding.UTF8.GetString(decryptedData));
        }
    }
}
