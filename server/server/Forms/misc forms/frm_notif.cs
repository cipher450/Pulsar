using System;
using System.Windows.Forms;

namespace server.Forms
{
    public partial class frm_notif : Form
    {
        public frm_notif()
        {
            InitializeComponent();
        }

        private void frm_notif_Load(object sender, EventArgs e)
        {
            flatTextBox1.Text = server.Others.Shared_data.notifmessage;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Autoclose_Tick(object sender, EventArgs e)
        {
            Close();

        }
    }
}
