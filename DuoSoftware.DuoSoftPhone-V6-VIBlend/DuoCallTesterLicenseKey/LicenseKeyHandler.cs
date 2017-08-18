﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DuoCallTesterLicenseKey
{
    public class LicenseKeyHandler
    {
        private const string initVector = "tu89geji340t89u2";

        // This constant is used to determine the keysize of the encryption algorithm.
        private const int keysize = 256;
        private static string cipherText = "Gm9n0p+Zmn2FIbZAX0FfaxS/XW3uHL9";
        public static string GetLicenseKey(string passPhrase)
        {
            try
            {
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string OpenSSLDecrypt(string encrypted, string passphrase)
        {
            //get the key bytes (not sure if UTF8 or ASCII should be used here doesn't matter if no extended chars in passphrase)
            var key = Encoding.UTF8.GetBytes(passphrase);

            //pad key out to 32 bytes (256bits) if its too short
            if (key.Length < 32)
            {
                var paddedkey = new byte[32];
                Buffer.BlockCopy(key, 0, paddedkey, 0, key.Length);
                key = paddedkey;
            }

            //setup an empty iv
            var iv = new byte[16];

            //get the encrypted data and decrypt
            byte[] encryptedBytes = Convert.FromBase64String(encrypted);
            return DecryptStringFromBytesAes(encryptedBytes, key, iv);
        }

        static string DecryptStringFromBytesAes(byte[] cipherText, byte[] key, byte[] iv)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("key");
            if (iv == null || iv.Length <= 0)
                throw new ArgumentNullException("iv");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext;

            // Create a RijndaelManaged object
            // with the specified key and IV.
            aesAlg = new RijndaelManaged { Mode = CipherMode.CBC, Padding = PaddingMode.None, KeySize = 256, BlockSize = 8, Key = key, IV = iv };

            // Create a decrytor to perform the stream transform.
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            // Create the streams used for decryption.
            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        // Read the decrypted bytes from the decrypting stream
                        // and place them in a string.
                        plaintext = srDecrypt.ReadToEnd();
                        srDecrypt.Close();
                    }
                }
            }

            return plaintext;
        }

        public static string GetLicenseKey(string passPhrase, string cipherpText)
        {
            try
            {
                string plaintext = string.Empty;
                string keyString = "DuoS1230000000000000000000000000"; //replace with your key
                string ivString = "0000000000000000"; //replace with your iv

                byte[] key = Encoding.ASCII.GetBytes(keyString);
                byte[] iv = Encoding.ASCII.GetBytes(ivString);

                using (var rijndaelManaged =
                        new RijndaelManaged { Key = key, IV = iv, Mode = CipherMode.CBC })
                {
                    rijndaelManaged.BlockSize = 128;
                    rijndaelManaged.KeySize = 256;
                    using (var memoryStream =
                           new MemoryStream(Convert.FromBase64String(cipherpText)))
                    using (var cryptoStream =
                           new CryptoStream(memoryStream,
                               rijndaelManaged.CreateDecryptor(key, iv),
                               CryptoStreamMode.Read))
                    {
                        plaintext = new StreamReader(cryptoStream).ReadToEnd();
                    }
                }
                return plaintext;

                //byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                //byte[] cipherTextBytes = Convert.FromBase64String(cipherpText);
                //PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                //byte[] keyBytes = password.GetBytes(keysize / 8);
                //RijndaelManaged symmetricKey = new RijndaelManaged();
                //symmetricKey.Mode = CipherMode.CBC;
                //symmetricKey.Padding = PaddingMode.None;
                //ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                //MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                //CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                //byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                //int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                //memoryStream.Close();
                //cryptoStream.Close();
                //return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        


        public static string Decrypt<T>(string text, string password, string salt)
           where T : SymmetricAlgorithm, new()
        {
            DeriveBytes rgb = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt));

            SymmetricAlgorithm algorithm = new T();

            algorithm.Key = Encoding.UTF8.GetBytes("07721c66f794f7a26cbdfa1248a54ec78d181ba5f092b6ea8f87ad5448a98d18");
            algorithm.IV = Encoding.UTF8.GetBytes("cd2be49946cd1562190131125ac13164");
            algorithm.Padding = PaddingMode.None;

            byte[] rgbKey = rgb.GetBytes(algorithm.KeySize >> 3);
            byte[] rgbIV = rgb.GetBytes(algorithm.BlockSize >> 3);

            ICryptoTransform transform = algorithm.CreateDecryptor(rgbKey, rgbIV);

            using (MemoryStream buffer = new MemoryStream(Convert.FromBase64String(text)))
            {
                using (CryptoStream stream = new CryptoStream(buffer, transform, CryptoStreamMode.Read))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
    }
}
