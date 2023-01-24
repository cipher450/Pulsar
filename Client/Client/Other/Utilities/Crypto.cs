using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace boulzar.Other
{
    public static class AES
    {
        private const int IVLENGTH = 16;
        private static byte[] _defaultKey;
        public static string PublicKey;

        public static void SetDefaultKey()
        {
            //   Information.Setup();

            _defaultKey = Encoding.UTF8.GetBytes(HWID.Hwid_gen());

        }

        #region Bytes Encryption

        public static byte[] Encrypt(byte[] input)
        {

            if (_defaultKey == null || _defaultKey.Length == 0)
            {
                SetDefaultKey();
            }

            if (input == null || input.Length == 0) return null;

            byte[] data = input, encdata = new byte[0];

            try
            {
                using (var ms = new MemoryStream())
                {
                    using (var aesProvider = new AesCryptoServiceProvider() { Key = _defaultKey })
                    {
                        aesProvider.GenerateIV();

                        using (var cs = new CryptoStream(ms, aesProvider.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            ms.Write(aesProvider.IV, 0, aesProvider.IV.Length); // write first 16 bytes IV, followed by encrypted message
                            cs.Write(data, 0, data.Length);
                        }
                    }


                    encdata = ms.ToArray();
                }
            }
            catch
            {
            }

            return encdata;
        }
        public static byte[] Decrypt(byte[] input)
        {
            byte[] data = new byte[0];
            if (_defaultKey == null || _defaultKey.Length == 0)
            {
                SetDefaultKey();
            }

            try
            {



                using (var ms = new MemoryStream(input))
                {
                    using (var aesProvider = new AesCryptoServiceProvider() { Key = _defaultKey })
                    {
                        byte[] iv = new byte[IVLENGTH];
                        ms.Read(iv, 0, IVLENGTH); // read first 16 bytes for IV, followed by encrypted message
                        aesProvider.IV = iv;

                        using (var cs = new CryptoStream(ms, aesProvider.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            byte[] temp = new byte[ms.Length - IVLENGTH + 1];
                            data = new byte[cs.Read(temp, 0, temp.Length)];
                            Buffer.BlockCopy(temp, 0, data, 0, data.Length);
                        }
                    }
                }
            }
            catch
            {

            }


            return data;
        }

        #endregion

        #region String Encryption
        public static string strEncrypt(string input)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
        }

        public static string StrDecrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }

        #endregion

        #region RSA
        public static string EncryptString(string inputString, string PublicKey)
        {

            string bitStrengthString = PublicKey.Substring(0, PublicKey.IndexOf("</BitStrength>") + 14);
            PublicKey = PublicKey.Replace(bitStrengthString, "");
            int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));


            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(bitStrength);
            rsaCryptoServiceProvider.FromXmlString(PublicKey);
            int keySize = bitStrength / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);

            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);

                Array.Reverse(encryptedBytes);

                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }


        #endregion

    }

    public static class md
    {
        public static string CreateMD5(string input)
        {

            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
