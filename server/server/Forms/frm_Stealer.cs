using server.Classes;
using System;
using System.IO;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_Stealer : Form
    {
        public frm_Stealer()
        {
            InitializeComponent();
        }
        string Datefolder = Common.current_path + @"\Stealer\";
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Browsers_TextBox.SelectedText);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Browsers_treeview.Nodes.Clear();
            Messangers_treeView.Nodes.Clear();
            Gaming_treeView.Nodes.Clear();
            vpn_treeView.Nodes.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(Datefolder + @"\Browsers");
            Browsers_treeview.AfterSelect += Browsers_AfterSelect;
            BuildTree(directoryInfo, Browsers_treeview.Nodes);

            DirectoryInfo directoryInfo2 = new DirectoryInfo(Datefolder + @"\Messenger");
            Messangers_treeView.AfterSelect += Messangers_AfterSelect;
            BuildTree(directoryInfo2, Messangers_treeView.Nodes);

            DirectoryInfo directoryInfo3 = new DirectoryInfo(Datefolder + @"\Gaming");
            Gaming_treeView.AfterSelect += Gaming_AfterSelect;
            BuildTree(directoryInfo3, Gaming_treeView.Nodes);

            DirectoryInfo directoryInfo4 = new DirectoryInfo(Datefolder + @"\VPN");
            vpn_treeView.AfterSelect += VPN_AfterSelect;
            BuildTree(directoryInfo4, vpn_treeView.Nodes);
        }

        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            try
            {
                TreeNode curNode = addInMe.Add(directoryInfo.Name);

                foreach (FileInfo file in directoryInfo.GetFiles())
                {
                    curNode.Nodes.Add(file.FullName, file.Name);
                }
                foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
                {
                    BuildTree(subdir, curNode.Nodes);
                }
            }
            catch
            {

            }

        }

        private void Browsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Browsers_TextBox.Clear();
                StreamReader reader = new StreamReader(e.Node.Name);
                Browsers_TextBox.Text = reader.ReadToEnd();
                reader.Close();
            }

            catch
            {

            }


        }
        private void Messangers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Messangers_TextBox.Clear();
                StreamReader reader = new StreamReader(e.Node.Name);
                Messangers_TextBox.Text = reader.ReadToEnd();
                reader.Close();
            }

            catch
            {

            }


        }
        private void Gaming_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Gaming_TextBox.Clear();
                StreamReader reader = new StreamReader(e.Node.Name);
                Gaming_TextBox.Text = reader.ReadToEnd();
                reader.Close();
            }

            catch
            {

            }


        }
        private void VPN_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Vpns_TextBox.Clear();
                StreamReader reader = new StreamReader(e.Node.Name);
                Vpns_TextBox.Text = reader.ReadToEnd();
                reader.Close();

            }
            catch
            {

            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            this.TopMost = flatToggle1.Checked;
        }
    }
}
