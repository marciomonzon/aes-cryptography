# AES Cryptography Implementation in .NET 8 C#
<p>
  In a world with many applications running confidential data, 
  it is very important to think about application security, such as encrypting the data.
  One very popular and secure algorithm is AES (Advanced Encryption Standard), 
  which is the successor of DES. This algorithm uses a 128, 192, or 256-bit key.
</p>

<p>
  This example was implemented for studying purpose and should not be used in
  a production environment like it is. You should do your own modifications as necessary.
</p>

<br>

## Stack
* .NET 8;
* C#;
* Console Application.

<br>

## Library
* System.Security.Cryptography.

<br>

## Technical Information
* The KEY and IV (initializationVector) should be the same in the decrypt process.
* Unit Tests present and are passing;
* The example is using CBC mode: Cipher Block Chaining mode;
* CBC Mode uses PaddingMode.PKCS7;
* Encrypt Method:
  
```ruby
public static byte[] Encrypt(byte[] data, byte[] key, byte[] initializationVector)
{
    using var aes = Aes.Create();
    aes.Key = key;
    var encryptedData = aes.EncryptCbc(data, initializationVector);

    return encryptedData;
}
```

* Decrypt Method:
```ruby
 public static byte[] AesDecrypt(byte[] data, byte[] key, byte[] initializationVector)
 {
     using var aes = Aes.Create();
     aes.Key = key;
     var decryptedData = aes.DecryptCbc(data, initializationVector);

     return decryptedData;
 }
```

<br>


## Documentation
* https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography?view=net-8.0
* https://learn.microsoft.com/pt-br/dotnet/api/system.security.cryptography.aes?view=net-8.0
* Example implemented based on: https://devwithjosh.com/cryptography-in-c-asymmetric-and-symmetric-encryption

