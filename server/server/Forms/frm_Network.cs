using server.Classes;
using server.Others;
using System;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_Network : Form
    {
        public int ID;
        public frm_Network()
        {
            InitializeComponent();

        }

        private void flatToggle1_CheckedChanged(object sender)
        {

            TopMost = flatToggle1.Checked;
        }

        private void frm_Network_Load(object sender, EventArgs e)
        {

            Control.CheckForIllegalCrossThreadCalls = false;

        }

        void StartScane()
        {
            Form1.MainServer.Send(ID, Helper.Getbytes("NetworkScanneStart{" + flatTextBox1.Text + "}" + "<" + flatTextBox2.Text + ">"), Common.Current_Key);
            Hostlist.Enabled = false;
            panel1.Visible = true;
            panel2.Enabled = false;
        }
        void StopScane()
        {
            Form1.MainServer.Send(ID, Helper.Getbytes("NetworkScanneStop"), Common.Current_Key);
            Hostlist.Enabled = true;
            panel1.Visible = false;
            panel2.Enabled = true;
        }
        private void scanneToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            if (flatButton2.Text == "Start")
            {
                flatButton2.Text = "Stop";
                StartScane();

            }
            else
            {
                flatButton2.Text = "Start";
                StopScane();

            }

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {


        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
