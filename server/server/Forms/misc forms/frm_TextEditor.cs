using server.Classes;
using server.Others;
using System;
using System.Windows.Forms;

namespace server.Forms
{
    public partial class frm_TextEditor : Form
    {
        public frm_TextEditor()
        {
            InitializeComponent();
        }
        public int ConnectionID;
        public string data;
        private void flatButton2_Click(object sender, EventArgs e)
        {

            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMEditeezhereyougoboi~" + fastColoredTextBox1.Text), Common.Current_Key);

            this.Close();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Menu

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ConnectionID, Helper.Getbytes("FMEditeezhereyougoboi~" + fastColoredTextBox1.Text), Common.Current_Key);

            this.Close();
        }



        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fastColoredTextBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ofd = new SaveFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(ofd.FileName, fastColoredTextBox1.Text);

                }
            }
        }
        #endregion
    }
}
