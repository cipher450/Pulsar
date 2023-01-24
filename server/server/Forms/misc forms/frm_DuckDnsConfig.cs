using server.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace server.Forms.misc_forms
{
    public partial class frm_DuckDnsConfig : Form
    {
        public frm_DuckDnsConfig()
        {
            InitializeComponent();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(flatTextBox1.Text) || string.IsNullOrEmpty(flatTextBox2.Text))
            {
                return;
            }
            else
            {
                string[] row = { flatTextBox1.Text, flatTextBox2.Text };
                ListViewItem itm = new ListViewItem(row);
                listView1.Items.Add(itm);
                flatTextBox1.Text = "";
            }

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count <= 1)
            {
                foreach (ListViewItem itm in listView1.SelectedItems)
                {
                    listView1.Items.Remove(itm);
                }

            }
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("duckdns_config.json"))
            {
                System.IO.File.Delete("duckdns_config.json");
            }
            DuckDnsUpdater.set.DoUpdateEveryXMinutes = (int)flatNumeric1.Value;
            List<string[]> sites = new List<string[]>();

            foreach (ListViewItem item in listView1.Items)
            {
                string[] arr = { item.Text, item.SubItems[1].Text, "", "" };
                sites.Add(arr);

            }
            DuckDnsUpdater.CreateConfig(sites);
            Close();


        }

        private void frm_DuckDnsConfig_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("duckdns_config.json"))
            {
                DuckDnsUpdater.LoadConfig();
                foreach (var s in DuckDnsUpdater.set.sites)
                {
                    string[] row = { s.Domain, s.Token };
                    ListViewItem itm = new ListViewItem(row);
                    listView1.Items.Add(itm);
                }
            }

        }
    }
}
