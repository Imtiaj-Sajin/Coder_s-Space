using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coder_s_space
{
    public partial class FormCourses : Form
    {
        public FormCourses()
        {
            InitializeComponent();
           // this.video();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel58_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://www.example.com/myvideo.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void video()
        {
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.settings.volume = 50;
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.URL = "E:\\Ecpp\\JARVIS 4.0 Logo Reveal_4.mp4";
        }
    }
}
