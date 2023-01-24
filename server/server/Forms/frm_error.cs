using System;
using System.Windows.Forms;

namespace server.Forms
{
    public partial class frm_error : Form
    {
        public frm_error()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_error_Load(object sender, EventArgs e)
        {
            flatTextBox1.Text = server.Others.Shared_data.errormessage;
        }
    }
}
