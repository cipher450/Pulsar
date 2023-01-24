using boulzar;
using System;
using System.Runtime.InteropServices;

namespace F
{
    class E9
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public static void CheackUp()
        {



            //Cheack to see if the PS script is still in the temp folder ( this should be looped)
        }
        public static void Bd()
        {
            CheackUp();
            Program.Main();

        }



    }
}