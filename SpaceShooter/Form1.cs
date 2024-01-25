using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class SpaceShooter : Form
    {
        WindowsMediaPlayer intro;

        PictureBox[] stars;
        int backgroundspeed;
        Random rnd;
        public SpaceShooter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 4;

            intro = new WindowsMediaPlayer();
            intro.URL = "D:\\SpaceShooterGame\\SpaceShooter\\SpaceShooter\\bin\\Debug\\songs-20231021T033940Z-001\\songs\\intro.mp3";
            intro.settings.setMode("loop", true);
            stars = new PictureBox[10];
            rnd = new Random();

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(5, 5);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(5, 5);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
            intro.controls.play();
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void lblTittle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intro.controls.stop();
            startscreen form2 = new startscreen();
            form2.ShowDialog();
        }
    }
}
