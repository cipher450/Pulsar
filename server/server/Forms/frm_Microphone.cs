using server.Classes;
using server.Others;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_Microphon : Form
    {
        public frm_Microphon()
        {
            InitializeComponent();
        }
        #region Declartions
        public int ConnectioID;
        private string ToSend = null;
        private SoundPlayer SP = new SoundPlayer();
        #endregion

        #region Methods 

        public void PlayAudio(byte[] Audio)
        {
            using (MemoryStream MS = new MemoryStream(Audio))
            {
                SP = new SoundPlayer(MS);
                SP.Play();
                MS.Dispose();
            }
        }

        #endregion
        private void flatToggle1_CheckedChanged(object sender)
        {
            TopMost = flatToggle1.Checked;
        }

        private void flatButton2_Click(object sender, System.EventArgs e)
        {

            ToSend = "MicrophoneStart~";
            Form1.MainServer.Send(ConnectioID, Helper.Getbytes(ToSend), Common.Current_Key);
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            ToSend = "MicrophoneStop~";
            Form1.MainServer.Send(ConnectioID, Helper.Getbytes(ToSend), Common.Current_Key);
            GC.SuppressFinalize(this);
            SP.Dispose();
            SP.Stop();

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            ToSend = "MicrophoneStop~";
            Form1.MainServer.Send(ConnectioID, Helper.Getbytes(ToSend), Common.Current_Key);
            GC.SuppressFinalize(this);
            Close();
            SP.Stop();
        }

        private void frm_Microphon_Load(object sender, EventArgs e)
        {

        }
    }
}
