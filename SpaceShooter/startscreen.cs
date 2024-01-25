﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class startscreen : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] enemiesMunition;
        int enemiesMunitionSpeed;

        PictureBox[] stars;
        int backgroundspeed;
        int playerSpeed;

        PictureBox[] munitions;
        int MunitionSpeed;

        PictureBox[] enemies;
        int enemieSpeed;

        Random rnd;

        int score;
        int level;
        int dificulty;
        bool pause;
        bool gameIsOver;
        public startscreen()
        {
            InitializeComponent();
        }

        private void startscreen_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            dificulty = 9;

            backgroundspeed = 4;
            playerSpeed = 4;
            enemieSpeed = 4;
            MunitionSpeed = 20;
            enemiesMunitionSpeed = 4;

            munitions = new PictureBox[3];

            //Load images
            Image munition = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\munition.png");

            Image enemi1 = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\E1.png");
            Image enemi2 = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\E2.png");
            Image enemi3 = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\E3.png");
            Image boss1 = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\Boss1.png");
            Image boss2 = Image.FromFile(@"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\asserts-20231021T033915Z-001\asserts\Boss2.png");

            enemies = new PictureBox[10];

            //initialiase EnemisPictureBoxes
            for(int i = 0;i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(30, 30);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1)*38, -50);
            }


            enemies[0].Image = boss1;
            enemies[1].Image = enemi2;
            enemies[2].Image = enemi3;
            enemies[3].Image = enemi3;
            enemies[4].Image = enemi1;
            enemies[5].Image = enemi3;
            enemies[6].Image = enemi2;
            enemies[7].Image = enemi3;
            enemies[8].Image = enemi2;
            enemies[9].Image = boss2;


            for(int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode =PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }

            //create WMP
            gameMedia =new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            //Load all songs
            gameMedia.URL = "D:\\SpaceShooterGame\\SpaceShooter\\SpaceShooter\\bin\\Debug\\songs-20231021T033940Z-001\\songs\\GameSong.mp3";
            shootgMedia.URL = "D:\\SpaceShooterGame\\SpaceShooter\\SpaceShooter\\bin\\Debug\\songs-20231021T033940Z-001\\songs\\shoot.mp3";
            explosion.URL = @"D:\SpaceShooterGame\SpaceShooter\SpaceShooter\bin\Debug\songs-20231021T033940Z-001\songs\boom.mp3";

            //Setup songs settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;

            stars = new PictureBox[15];
            rnd = new Random();

            for(int i = 0;i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 500),rnd.Next(-10, 400));
                if(i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            // enemies Munition
            enemiesMunition = new PictureBox[10];

            for(int i = 0;i < enemiesMunition.Length; i++)
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(2, 20);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Red;
                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }

            gameMedia.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                if(stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
                if(Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Right < 440)
            {
                Player.Left += playerSpeed;
            }

        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Top < 330)
            {
                Player.Top += playerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if(Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void startscreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    LeftMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpMoveTimer.Start();
                }
            }
            
        }

        private void startscreen_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if(e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        label1.Visible = false;
                        gameMedia.controls.play();  
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(150, 150);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        gameMedia.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void MoveMunitionTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();

            for(int i = 0;i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;

                    collision();
                }
                else
                {
                    munitions[i].Visible=false;
                    munitions[i].Location = new Point(Player.Location.X + 12, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemieSpeed);
        }
        private void MoveEnemies(PictureBox[] array,int speed)
        {
            for(int i = 0;i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 38, -200);
                }
            }
        }

        private void collision()
        {
            for(int i = 0;i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    score += 1;
                    scorelbl.Text = (score < 10) ? "0" + score.ToString(): score.ToString();

                    if(score % 30 == 0)
                    {
                        level += 1;
                        levellbl.Text =(level < 10) ? "0" + level.ToString() : level.ToString();

                        if(enemieSpeed <= 10 && enemiesMunitionSpeed <= 10 && dificulty >= 0)
                        {
                            dificulty--;
                            enemieSpeed++;
                            enemiesMunitionSpeed++;
                        }

                        if(level == 10)
                        {
                            GameOver("NICE DONE");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 60;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            Replaybtn.Visible = true;
            Exitbtn.Visible = true;

            gameMedia.controls.stop();
            StopTimers();
        }

        private void StopTimers()
        {
            MoveBgTimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMunitionTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }

        private void StartTimers()
        {
            MoveBgTimer.Start();
            MoveEnemiesTimer.Start();
            MoveMunitionTimer.Start();
            EnemiesMunitionTimer.Start();
        }

        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i < enemiesMunition.Length - dificulty; i++)
            {
                if (enemiesMunition[i].Top  < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemiesMunitionSpeed;

                    collisionWithEnemiesMunition();
                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void collisionWithEnemiesMunition()
        {
            for(int i = 0;i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Replaybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            startscreen_Load(e, e);

        }

        private void labels_Click(object sender, EventArgs e)
        {

        }
    }
}
