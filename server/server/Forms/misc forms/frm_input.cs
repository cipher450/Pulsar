using server.Others;
using System;
using System.Windows.Forms;

namespace server.Forms
{
    public partial class frm_input : Form
    {
        public frm_input()
        {
            InitializeComponent();
        }

        private void frm_input_Load(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (flatTextBox1.Text != string.Empty)
            {
                Shared_data.tmp_frminput_data = flatTextBox1.Text;
                this.Close();
            }
            else { MessageBox.Show("No text error"); }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
