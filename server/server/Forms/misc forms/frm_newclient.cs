using server.Classes;
using System;
using System.Media;
using System.Windows.Forms;
namespace server.Forms
{
    public partial class frm_newclient : Form
    {
        public frm_newclient()
        {
            InitializeComponent();
        }

        private void frm_notif_Load(object sender, EventArgs e)
        {
            flatLabel5.Text = Notif_data.username_tag;
            flatLabel6.Text = Notif_data.Country;
            flatLabel4.Text = Notif_data.OS;
            flatLabel7.Text = Notif_data.IP;
            pictureBox1.Image = Countyflags.Images[Notif_data.CountryCode];
            PlaceLowerRight();
            SoundPlayer snd = new SoundPlayer(Properties.Resources.inflicted_601);
            snd.Play();
        }


        private void PlaceLowerRight()
        {
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            Left = rightmost.WorkingArea.Right - Width;
            Top = rightmost.WorkingArea.Bottom - Height;
        }

        private void Autoclose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}