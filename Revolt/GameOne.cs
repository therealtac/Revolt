using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revolt
{
    public partial class GameOne : Form
    {

        private readonly RevoltEntities _db;
        private Revoltist _revoltist;

        //game variables
        private bool jumping;
        private int jumpSpeed;
        private int force;
        private int score;
        private int obstacleSpeed;
        private Random rnd = new Random();

        public GameOne(Revoltist revoltist)
        {
            InitializeComponent();
            reset();
            _db = new RevoltEntities();
            _revoltist = revoltist;
        }

        //reset the game to defaults
        private void reset()
        {
            force = 12;
            picMia.Top = 0;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreText.Text = "Score: " + score;
            picMia.Image = Properties.Resources.Mia;

            foreach (Control x in this.Controls)
                if (x is PictureBox && (x.Tag == "obstacle" || x.Tag == "chicken"))
                    x.Left = 40 + (x.Left + rnd.Next(600, 1000) + x.Width * 3);

            timer.Start();
        }

        //when space is pressed, jump
        private void GameOne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !jumping)
                jumping = true;
        }

        //when r is let go, reset the game and if space (implied), stop jumping
        private void GameOne_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
                reset();
            if (jumping)
                jumping = false;
        }

        //rotates image when player loses
        private static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
        }

        //event happens every 20 ms
        private void timer_Tick(object sender, EventArgs e)
        {
            picMia.Top += jumpSpeed;
            scoreText.Text = "Score: " + score;

            if (jumping && force < 0)
                jumping = false;
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
                jumpSpeed = 12;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {

                    x.Left -= obstacleSpeed;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                    }

                    //when player dies, stop the game/event
                    if (picMia.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer.Stop();
                        picMia.Image = RotateImage(Properties.Resources.Mia, 180);
                        scoreText.Text += "  Press R to restart";

                        RevoltistGameScore revoltistGameScore = _db.RevoltistGameScores.FirstOrDefault(q => q.gameId == 0 && q.id == _revoltist.id);
                        
                        //if not the first time playing, and score is better than previous attempts, save it
                        //if first time, save a new entity
                        if(revoltistGameScore != null)
                        {
                            int oldScore = revoltistGameScore.score;
                            if(oldScore < score)
                                revoltistGameScore.score = score;
                        }
                        else
                        {
                            RevoltistGameScore newRevoltistGameScore = new RevoltistGameScore();
                            newRevoltistGameScore.id = _revoltist.id;
                            newRevoltistGameScore.gameId = 0;
                            newRevoltistGameScore.score = score;
                            _db.RevoltistGameScores.Add(newRevoltistGameScore);
                        }
                        _db.SaveChanges();
                    }
                }

                //moves the chicken and if intersected with Mia, add a point
                if (x is PictureBox && x.Tag == "chicken")
                {
                    x.Left -= obstacleSpeed / 2;
                    if (x.Left + x.Width < -120)
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                    if (picMia.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        score++;
                    }
                }
            }

            if (picMia.Top >= 360 && !jumping)
            {
                force = 12;
                picMia.Top = floor.Top - picMia.Height + 5;
                jumpSpeed = 0;
            }
            if (score >= 10)
                obstacleSpeed = 15;
        }
    }
}
