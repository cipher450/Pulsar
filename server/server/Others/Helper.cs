using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace server.Others
{
    public static class Helper
    {
        #region Declarations
        public static Thread notif = new Thread(opennotif);
        public static Thread clipboardz = new Thread(openclipboard);
        private const string CHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly Random _rnd = new Random(Environment.TickCount);
        #endregion
        #region Functions
        public static void SetListViewColumnSizes(ListView lvw, int width)
        {
            foreach (ColumnHeader col in lvw.Columns)
                col.Width = width;
        }

        #region Registry 

        public static string ReadRegKey(string KeyName, string SubkeyName)
        {
            string val = "";
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(SubkeyName);

            val = key.GetValue(KeyName).ToString();
            key.Close();
            return val;
        }
        public static void CreateRegKey(string KeyName, string Value, string SubkeyName)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(SubkeyName);
            key.SetValue(KeyName, Value);
            key.Close();

        }
        public static bool KeyExists(string KeyName, string SubkeyName)
        {

            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(SubkeyName);



            if (key.GetValue(KeyName) == null)
            {
                key.Close();
                return false;

            }
            else
            {
                key.Close();
                return true;
            }

        }
        #endregion

        #region Format 
        public static string ThreeNonZeroDigits(double value)
        {
            if (value >= 100)
            {
                // No digits after the decimal.
                return value.ToString("0,0");
            }
            else if (value >= 10)
            {
                // One digit after the decimal.
                return value.ToString("0.0");
            }
            else
            {
                // Two digits after the decimal.
                return value.ToString("0.00");
            }
        }
        public static string ToFileSize(this double value)
        {
            string[] suffixes = { "bytes", "KB", "MB", "GB",
        "TB", "PB", "EB", "ZB", "YB"};
            for (int i = 0; i < suffixes.Length; i++)
            {
                if (value <= (Math.Pow(1024, i + 1)))
                {
                    return ThreeNonZeroDigits(value /
                        Math.Pow(1024, i)) +
                        " " + suffixes[i];
                }
            }

            return ThreeNonZeroDigits(value /
                Math.Pow(1024, suffixes.Length - 1)) +
                " " + suffixes[suffixes.Length - 1];
        }
        #endregion



        #region Strings
        public static string CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }
        public static string DecompressString(string compressedText)
        {

            byte[] gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
        public static string GetRandomString(int length, string extension = "")
        {
            StringBuilder randomName = new StringBuilder(length);
            for (int i = 0; i < length; i++)
                randomName.Append(CHARS[_rnd.Next(CHARS.Length)]);

            return string.Concat(randomName.ToString(), extension);
        }
        public static string Downloadstring(string url)
        {
            string data = "";
            WebClient client = new WebClient();
            try
            {
                data = client.DownloadString(url);
            }
            catch (WebException ex)
            {
                data = ex.Message;
            }
            return data;

        }
        public static byte[] Getbytes(string str)
        {
            return Encoding.Default.GetBytes(str);
        }
        public static string Getstrings(byte[] byt)
        {



            return Encoding.Default.GetString(byt);
        }


        #endregion




        #endregion


        #region formopning
        public static void opennotif()
        {
            Forms.frm_newclient frm = new Forms.frm_newclient();
            frm.ShowDialog();

        }
        public static void openclipboard()
        {
            frm_clipboard frm = new frm_clipboard();
            frm.ShowDialog();
        }
        public static void openinfo()
        {
            Forms.frm_Information frm = new Forms.frm_Information();
            frm.ShowDialog();
        }
        #endregion
    }



}
