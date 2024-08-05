# AES Cryptography Implementation in .NET 8 C#
<p>
  In a world that is almost fully computerized with many confidential data in various applications, 
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

<br>

## Library
* System.Security.Cryptography.

<br>

## Technical Information
* The KEY and IV (initializationVector) should be the same in the decrypt process.
* Unit Tests present;
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

