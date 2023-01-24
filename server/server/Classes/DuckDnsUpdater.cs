using Newtonsoft.Json;
using server.Forms.misc_forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace server.Classes
{
    class DuckDnsUpdater
    {

        public static int configVersion = 1;
        public static Settings set = new Settings(); //Used all over the place, so it made sense to only have 1.

        public static void DoUpdate()
        {
            if (File.Exists("duckdns_config.json") == false)
            {

                frm_DuckDnsConfig frm = new frm_DuckDnsConfig();
                frm.ShowDialog();

            }
            else
            {
                set = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("duckdns_config.json"));
                if (set.configfileVersion < configVersion)
                {

                    File.WriteAllText("duckdns_config.json", JsonConvert.SerializeObject(set, Formatting.Indented));
                }


            }

            TimedUpdate(set.DoUpdateEveryXMinutes * 1000 * 60); //Update the DNS names every 5 minutes. Minutes*1000=Minutes in Milliseconds. Runs Immediatly.





        }

        public static async void TimedUpdate(int millisecondsDelay)
        {
            while (true)
            {

                ForceUpdate();
                await Task.Delay(millisecondsDelay);
            }
        }



        public static void LoadConfig()
        {
            if (File.Exists("duckdns_config.json"))
            {
                set = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("duckdns_config.json"));
            }

        }

        static async void ForceUpdate()
        {
            Console.WriteLine("Reloading Config...");
            set = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("duckdns_config.json"));
            Console.WriteLine("Reload Complete!");

            try
            {


                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                ListViewItem itm;
                foreach (var p in set.sites)
                {

                    var httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("DuckDNS_Updater_github_com_pfckrutonium_DuckDNS_Updater", "1.0")); //*Grin*
                    string query = "https://duckdns.org/update?domains=" + p.Domain + "&token=" + p.Token;
                    if (p.force_ip_number == "" == false) //Allows overriding the ip's.
                    {
                        query += "&ip=" + p.force_ip_number;
                    }
                    if (p.force_ipv6_number == "" == false)
                    {
                        query += "&ipv6=" + p.force_ipv6_number;
                    }

                    var result = await httpClient.GetStringAsync(query);
                    if (result == "KO")
                    {

                        string[] row = { p.Domain, p.Token, "Not Working" };
                        itm = new ListViewItem(row);
                        itm.ImageKey = "tray_error.ico";


                        frm1.listView1.Items.Add(itm);
                        Logger.Log("Failed to update IP of " + p.Domain, "error");
                        Console.WriteLine("Failed to update IP of " + p.Domain);
                    }
                    else if (result == "OK")
                    {
                        string[] row = { p.Domain, p.Token, "Up to date" };
                        itm = new ListViewItem(row);
                        itm.ImageKey = "tray_works.ico";

                        frm1.listView1.Items.Add(itm);
                        Console.WriteLine("Updated " + p.Domain); //It didn't error, and it didn't return KO, so we are going to assume it worked. Probably not the smartest way.
                    }
                    else
                    {
                        string[] row = { p.Domain, p.Token, "Somthing Happened when updating" };
                        itm = new ListViewItem(row);
                        itm.ImageKey = "tray_error.ico";

                        frm1.listView1.Items.Add(itm);
                        Console.WriteLine("Somthing Happened when updating " + p.Domain + ". Please contact PFCKrutonium on GitHub.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("Update Complete.");
        }

        public static void CreateConfig(List<string[]> sites)
        {
            Settings set = new Settings();
            set.sites = new List<ValueSet>();
            //string Domain , string Token , string firce_ip_number , string force_ipv6_num 
            //set.sites.Add(new KeyValuePair<string, string>("domain", "token"));
            //set.sites.Add(new KeyValuePair<string, string>("domain2", "token2")); //Examples. There can be an unlimited number of domains and tokens here.

            var temp = new ValueSet();
            foreach (string[] str in sites)
            {
                temp.Domain = str[0];
                temp.Token = str[1];
                temp.force_ip_number = str[2];
                temp.force_ipv6_number = str[3];
                set.sites.Add(temp);
            }


            File.WriteAllText("duckdns_config.json", JsonConvert.SerializeObject(set, Formatting.Indented));

        }

        public class Settings
        {
            public int DoUpdateEveryXMinutes = 5; //Defauts to every 5 minutes.
            public int configfileVersion = configVersion; //Useful for future updates.
            public List<ValueSet> sites; //Domain, Token
        }
        public struct ValueSet
        {
            public string Domain;
            public string Token;
            public string force_ip_number;
            public string force_ipv6_number;
        }


    }
}
