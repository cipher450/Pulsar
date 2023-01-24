using server.Classes;
using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace server.Others
{
    public static class Crypto
    {
        private const int IVLENGTH = 16;

        #region Bytes Encryption
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
        public static byte[] byte_Encrypt(byte[] input, string _key)
        {

            byte[] __key = Encoding.Default.GetBytes(_key);
            if (input == null || input.Length == 0) throw new ArgumentException("Input can not be empty.");

            byte[] data = input, encdata = new byte[0];

            try
            {
                using (var ms = new MemoryStream())
                {
                    using (var aesProvider = new AesCryptoServiceProvider() { Key = __key })
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return encdata;
        }


        public static byte[] byte_Decrypt_Compressed(byte[] input)
        {

            /*string Decompresed = Helper.DecompressString(Helper.Getstrings(input));
            input = Helper.Getbytes(Decompresed);*/
            if (string.IsNullOrEmpty(Common.Current_Key))
            {
                MessageBox.Show("Key can not be emptye !", "Pulsar - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            byte[] __key = Encoding.Default.GetBytes(Common.Current_Key);
            byte[] data = new byte[0];

            try
            {


                using (var ms = new MemoryStream(input))
                {
                    using (var aesProvider = new AesCryptoServiceProvider() { Key = __key })
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        #endregion

        #region RSA

        public static void GenKeys(int BitStrenght)
        {
            string KeyDirectory_Path = Application.StartupPath + @"\RSA Keys";
            if (!Directory.Exists(KeyDirectory_Path))
            {
                Directory.CreateDirectory(KeyDirectory_Path);
            }

            RSACryptoServiceProvider RSAProvider = new RSACryptoServiceProvider(BitStrenght);
            string PrivateKey = "<BitStrength>" + BitStrenght.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(true);
            string PublicKey = "<BitStrength>" + BitStrenght.ToString() + "</BitStrength>" + RSAProvider.ToXmlString(false);
            File.WriteAllText(KeyDirectory_Path + @"\PrivateKey.kez", PrivateKey);
            File.WriteAllText(KeyDirectory_Path + @"\PublicKey.pke", PublicKey);

        }
        public static string DecryptString(string inputString, string PrivatKey_Path)
        {
            string PrivatKey = "";

            StreamReader streamReader = new StreamReader(PrivatKey_Path, true);
            PrivatKey = streamReader.ReadToEnd();
            streamReader.Close();

            string bitStrengthString = PrivatKey.Substring(0, PrivatKey.IndexOf("</BitStrength>") + 14);
            PrivatKey = PrivatKey.Replace(bitStrengthString, "");
            int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));


            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(bitStrength);
            rsaCryptoServiceProvider.FromXmlString(PrivatKey);
            int base64BlockSize = ((bitStrength / 8) % 3 != 0) ? (((bitStrength / 8) / 3) * 4) + 4 : ((bitStrength / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));

                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }
        #endregion


    }
}
