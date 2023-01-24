using CefSharp;
using server.Classes;
using server.Others;
using System;
using System.IO;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_Information : Form
    {
        public frm_Information()
        {
            InitializeComponent();
        }
        public static string info_path = Common.current_path + @"\inforamtion.html";
        public static int id;
        public void loadall(string data)
        {
            if (File.Exists(info_path) == false)
            {
                StreamWriter strm = new StreamWriter(info_path);
                string source = Properties.Resources.html_info;
                //data = data.Replace("<cpulogo>", Properties.Resources.html_info_cpulogo);
                //data = data.Replace("<geologo>", Properties.Resources.html_info_geologo);
                //data = data.Replace("<oslogo>", Properties.Resources.html_info_oslogo);
                strm.Write(source);
                strm.Write(data);
                strm.Close();
            }
            chromiumWebBrowser1.Load(info_path);

            Shared_data.info_ready = false;
        }


        private void frm_Information_Load(object sender, EventArgs e)
        {
            if (File.Exists(info_path))
            {

                chromiumWebBrowser1.LoadHtml(File.ReadAllText(info_path));

                timer1.Stop();
            }
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Shared_data.info_ready == true)
            {
                loadall(Shared_data.information_data);
                timer1.Stop();
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            File.Delete(info_path);
            Form1.MainServer.Send(id, Helper.Getbytes("Getinfo"), Common.Current_Key);
            timer1.Start();
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            this.TopMost = flatToggle1.Checked;
        }
    }
}
