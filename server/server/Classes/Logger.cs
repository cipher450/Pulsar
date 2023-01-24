using System;
using System.Windows.Forms;
namespace server.Classes
{
    public static class Logger
    {
        // public static Action<string> Log = Console.WriteLine;
        //  public static Action<string> LogWarning = Console.WriteLine;
        //public static Action<string> LogError = Console.Error.WriteLine;
        public static void Log(string log_str, string Type)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            switch (Form1.isLoging)
            {
                case true:
                    if (Type == "log")
                    {
                        frm1.Logs.AppendText(log_str + Environment.NewLine);
                    }
                    else if (Type == "warning")
                    {
                        frm1.Logs.AppendText("[Warning]  " + log_str + Environment.NewLine);
                    }
                    else if (Type == "error")
                    {
                        frm1.Logs.AppendText("[Error]  " + log_str + Environment.NewLine);
                    }

                    break;

            }

        }


    }
}