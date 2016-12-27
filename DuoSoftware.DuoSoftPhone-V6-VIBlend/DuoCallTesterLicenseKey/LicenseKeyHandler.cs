using System;
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
        private static string cipherText = "pZkQANFF5pX9sYUO6SUTPnvmlZ108CUAShbyArW9lTlmPDiR7JgkT1ZqijXTswQCryYQHsEJ/3upLXIaURFS17eXlNuEK9x/vibpCqLR15zmqp6ilpCNR/IjRbG2AxeFimunVP/HGEZJOvtGxcbp9YaRz8pY/sp9+AJA1sTB7i6HYTZoRV5Olf7I9STNblrGXao//hIqEYfDOzi7gAaWWREKbsvH7RF/AGm9n0p+Zmn2FIbZAX0FfaxS/XW3uHL9";
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
    }
}
