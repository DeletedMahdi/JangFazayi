using System.ComponentModel;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace jang_fazayi
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();



        }



        private void Form1_Load(object sender, EventArgs e)
        {

            bullets = new PictureBox[1000];


            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer8.Stop();
            timer9.Stop();






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private PictureBox[] bullets;
        int radenemy = 1;
        int speed = 5;
        bool out1 = false;
        Random rnd = new Random();
        int fainal = 0;
        int resalt = 0;
        private int sum = 0;
        int heartenemy1 = 0;



        private void timer1_Tick(object sender, EventArgs e)
        {
            DayandNight();
            Random rnd = new Random();
            enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + speed);
            if (enemy.Location.Y > 490)
            {
                score1.Text = (int.Parse(score1.Text) + 1).ToString();
                sum += 1;
                enemy.Location = new Point(rnd.Next(1, 800), 0);


            }
            if (enemy.Location.Y < 0)
            {
                Random rnd1 = new Random();
            }
            if (enemy.Bounds.IntersectsWith(player.Bounds))
            {
                if (rohe == false && halatroh == false)
                {

                    heartcount1--;
                    heartcount();
                    enemy.Location = new Point(rnd.Next(1, 800), 0);




                }
                if (heartcount1 == 0)
                {




                    gameover();



                }

            }
        }

        bool gameover3 = false;
        private void gameover()
        {
            button2.Visible = true;
            button2.Enabled = true;
            label1.Text = "Game Over";
            gameover1 = true;
            gameover3 = true;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer8.Stop();
            timer9.Stop();


            System.Media.SoundPlayer player1;


            player1 = new System.Media.SoundPlayer(@"sound\aspose_Game-Over-Voice-Scary-Sound.wav");
            player1.Play();

            if (label1.Text != "Game Over")
            {

                player1.Stop();

            }




        }

        int restart = 0;

        string password = "1234";
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (player.Right < 824)
                {
                    player.Left += 20;

                    if (gameover3 == true && label1.Text == "Game Over")
                    {


                        player.Left -= 20;


                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 2)
                {
                    player.Left -= 20;

                    if (gameover3 == true && label1.Text == "Game Over")
                    {


                        player.Left += 20;


                    }
                }
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (label1.Text == "Game Over")
                {
                    gameover1 = true;

                    restartGame();
                    restart++;
                }



            }


            else if (e.KeyCode == Keys.Oem3)
            {
                ramz.Visible = true;

                ramz.KeyDown += (sender, e) =>
                {
                    if (e.KeyCode == Keys.F1)
                    {


                        if (ramz.Text == password)
                        {
                            rohe = true;
                            MessageBox.Show("Cheat Activated");
                            ramz.Visible = false;
                            ramz.Enabled = false;


                        }

                        else if (ramz.Text != password)
                        {

                            MessageBox.Show("incorrect password");
                            ramz.Visible = false;
                            ramz.Enabled = false;


                        }



                    }


                };
            }




            if (e.KeyCode == Keys.Space)
            {

                System.Media.SoundPlayer player2;


                player2 = new System.Media.SoundPlayer(@"sound\aspose_Pistol+Sound+Effects+One+Shot.wav");
                player2.Play();

                if (label1.Text == "Game Over")
                {

                    player2.Stop();

                }



                if (label1.Text == "" && label4.Text != "   " && red1.Text == "   " && label1.Text != "Game Over")
                {


                    for (int i = 0; i < bullets.Length; i++)
                    {
                        if (bullets[i] == null)
                        {
                            bullets[i] = new PictureBox();
                            //   bullets[i].BackColor = Color.Black;

                            bullets[i].Width = 7;
                            bullets[i].Height = 17;
                            bullets[i].BackColor = Color.Red;
                            bullets[i].Left = player.Left + (player.Width / 2);
                            bullets[i].Top = player.Top - 43;
                            this.Controls.Add(bullets[i]);




                            timer5.Start();

                            break;




                            if (enemy.Bounds.IntersectsWith(bullets[i].Bounds))
                            {

                                label2.Text = (int.Parse(label2.Text) + 2).ToString();
                                sum += 2;



                            }





                        }



                    }

                }

                if (label1.Text != "Game Over" && label4.Text == "   ")
                {

                    for (int i = 0; i < bullets.Length; i++)
                    {
                        if (bullets[i] == null)
                        {
                            bullets[i] = new PictureBox();
                            bullets[i].Width = 7;
                            bullets[i].Height = 17;
                            bullets[i].BackColor = Color.Green;
                            bullets[i].Left = player.Left + (player.Width / 2);
                            bullets[i].Top = player.Top - 43;
                            this.Controls.Add(bullets[i]);
                            timer5.Start();

                            break;

                        }
                    }
                }
                ////////////////////////////////////////////////////

                if (red1.Text == " " && label4.Text != "   " && label1.Text != "Game Over")
                {
                    for (int i = 0; i < bullets.Length; i++)
                    {
                        if (bullets[i] == null)
                        {
                            bullets[i] = new PictureBox();
                            bullets[i].Width = 7;
                            bullets[i].Height = 17;
                            bullets[i].BackColor = Color.Blue;
                            bullets[i].Left = player.Left + (player.Width / 2);
                            bullets[i].Top = player.Top - 43;
                            this.Controls.Add(bullets[i]);
                            timer5.Start();

                            break;

                        }
                    }


                }



                if (e.KeyCode == Keys.F2)
                {


                    halatroh = true;

                }

            }
        }

        bool halatroh = false;


        bool gameover1 = false;
        private void restartGame()
        {

            if (gameover1 == true && label1.Text == "Game Over")
            {


                this.BackColor = Color.Cyan;
                shoting1.Visible = false;


                moon.Visible = false;
                star1.Visible = false;
                star2.Visible = false;
                star.Visible = false;
                label1.ForeColor = Color.Black;
                sun.Visible = true;

                score1.Text = "0";
                speed = 20;
                heartcount1 = 3;
                heart1.Visible = true;
                heart2.Visible = true;
                heart3.Visible = true;
                rohe = false;
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer6.Start();
                timer8.Start();
                timer9.Start();

                soratp.Text = "5";
                score.Text = "3";
                label1.Text = "";
                score1.Text = "0";
                label4.Text = "0";
                label3.Text = "20";

                fainal = 0;
                sum = 0;
                enemy.Location = new Point(rnd.Next(1, 800), speed);
                randomheart.Location = new Point(rnd.Next(1, 800), speed);

            }











        }

        private void Allfivenumbers()
        {
            DayandNight();
            if (score1.Text != "0" && Convert.ToInt32(score1.Text) % 5 == 0)
            {

                speed += 1;


                System.Media.SoundPlayer player4;

                player4 = new System.Media.SoundPlayer(@"sound\output (1).wav");
                player4.Play();


                if (label1.Text == "Game Over")
                {

                    player4.Stop();

                }

            }



        }


        bool rohe = false;

        private void player_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void timer3_Tick(object sender, EventArgs e)
        {
            DayandNight();


            score.Text = (int.Parse(score.Text) - 1).ToString();
            if (score.Text == "0")
            {

                score1.Text = (int.Parse(score1.Text) + 1).ToString();
                sum += 1;
                score.Text = "3";


            }
        }



        int heartcount1 = 3;
        private void heartcount()
        {

            if (heartcount1 == 2)
            {

                heart3.Visible = false;

            }
            if (heartcount1 == 1)
            {


                heart2.Visible = false;

            }
            if (heartcount1 == 0)
            {


                heart1.Visible = false;

            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            DayandNight();
            Random rndheart = new Random();
            randomheart.Location = new Point(randomheart.Location.X, randomheart.Location.Y + 100);
            if (randomheart.Location.Y > 810)
            {
                randomheart.Location = new Point(rndheart.Next(1, 800), 0);

            }
            if (randomheart.Location.Y < 0)
            {
                Random rnd1 = new Random();
            }
            if (randomheart.Bounds.IntersectsWith(player.Bounds))
            {
                heartcount1++;

                randomheart.Location = new Point(rndheart.Next(1, 800), 0);

                if (heartcount1 == 3)
                {
                    heart3.Visible = true;
                }
                if (heartcount1 == 2)
                {
                    heart2.Visible = true;
                }
                if (heartcount1 == 1)
                {
                    heart1.Visible = true;
                }
                if (heartcount1 > 3)
                {
                    heartcount1--;
                }
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            DayandNight();
            Allfivenumbers();

            soratp.Text = (int.Parse(soratp.Text) - 1).ToString();
            if (soratp.Text == "0")
            {


                speed += 1;

                System.Media.SoundPlayer player3;

                player3 = new System.Media.SoundPlayer(@"sound\output (1).wav");
                player3.Play();

                soratp.Text = "5";

                if (label1.Text == "Game Over")
                {

                    player3.Stop();

                }

            }
        }
        private void ghost1()
        {

        }


        int day = 0;

        private void timer5_Tick(object sender, EventArgs e)
        {
            DayandNight();


            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] != null)
                {
                    bullets[i].Top -= 20;
                    if (bullets[i].Top < 0)
                    {

                        this.Controls.Remove(bullets[i]);

                        bullets[i] = null;

                    }


                    else if (enemy.Bounds.IntersectsWith(bullets[i].Bounds))
                    {

                        if (label4.Text != "   ")
                        {


                            this.Controls.Remove(bullets[i]);
                            heartenemy1++;

                            // MessageBox.Show(heartenemy1 + ""); 


                            if (heartenemy1 == 9)
                            {

                                heartenemy1 = 0;



                                blownup.Location = enemy.Location;

                                blownup.Visible = true;

                                timer6.Start();

                                if (timer6.Interval == 1000)
                                {


                                    blownup.Visible = false;

                                    this.Controls.Remove(blownup);
                                }



                                bullets[i] = null;

                                enemy.Location = new Point(rnd.Next(1, 800), speed);


                                score1.Text = (int.Parse(score1.Text) + 2).ToString();
                                sum += 2;
                                this.Controls.Remove(bullets[i]);

                                bullets[i] = null;


                            }

                        }
                        else
                        {


                            if (enemy.Bounds.IntersectsWith(bullets[i].Bounds))
                            {
                                this.Controls.Remove(bullets[i]);


                                blownup.Location = enemy.Location;

                                blownup.Visible = true;

                                timer6.Start();

                                if (timer6.Interval == 1000)
                                {


                                    blownup.Visible = false;

                                    this.Controls.Remove(blownup);
                                }

                                bullets[i] = null;

                                enemy.Location = new Point(rnd.Next(1, 800), speed);


                                score1.Text = (int.Parse(score1.Text) + 2).ToString();
                                sum += 2;
                                this.Controls.Remove(bullets[i]);

                                bullets[i] = null;


                            }

                        }

                    }

                }

            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            DayandNight();
            blownup.Visible = false;
            timer6.Stop();

        }


        private void DayandNight()
        {
            if (score1.Text != "0" && Convert.ToInt32(score1.Text) % 20 == 0)
            {


                if (this.BackColor == Color.Cyan)
                {

                    this.BackColor = Color.Black;

                    label1.ForeColor = Color.White;


                    sun.Visible = false;
                    Cloud.Visible = false;

                    moon.Visible = true;
                    star.Visible = true;
                    star1.Visible = true;
                    star2.Visible = true;
                    moongif.Visible = true;
                }



                if (Convert.ToInt32(score1.Text) % 40 == 0)
                {

                    if (this.BackColor == Color.Black)
                    {



                        this.BackColor = Color.Cyan;


                        label1.ForeColor = Color.Black;

                        sun.Visible = true;
                        Cloud.Visible = true;

                        moon.Visible = false;
                        star.Visible = false;
                        star1.Visible = false;
                        star2.Visible = false;
                        moongif.Visible = false;


                    }
                }
                if (Convert.ToInt32(score1.Text) % 60 == 0)
                {

                    if (this.BackColor == Color.Cyan)
                    {


                        this.BackColor = Color.Black;

                        label1.ForeColor = Color.White;

                        soratp.ForeColor = Color.White;


                        sun.Visible = false;
                        Cloud.Visible = false;

                        moon.Visible = true;
                        star.Visible = true;
                        star1.Visible = true;
                        star2.Visible = true;
                        moongif.Visible = true;


                    }
                }


                if (Convert.ToInt32(score1.Text) % 80 == 0)
                {

                    if (this.BackColor == Color.Black)
                    {


                        this.BackColor = Color.Cyan;



                        label1.ForeColor = Color.Black;

                        sun.Visible = true;
                        Cloud.Visible = true;

                        moon.Visible = false;
                        star.Visible = false;
                        star1.Visible = false;
                        star2.Visible = false;
                        moongif.Visible = false;


                    }
                }

                if (Convert.ToInt32(score1.Text) % 100 == 0)
                {

                    if (this.BackColor == Color.Cyan)
                    {




                        this.BackColor = Color.Black;

                        label1.ForeColor = Color.White;


                        sun.Visible = false;
                        Cloud.Visible = false;

                        moon.Visible = true;
                        star.Visible = true;
                        star1.Visible = true;
                        star2.Visible = true;

                        moongif.Visible = true;


                    }

                    if (Convert.ToInt32(score1.Text) % 120 == 0)
                    {

                        if (this.BackColor == Color.Black)
                        {


                            this.BackColor = Color.Cyan;



                            label1.ForeColor = Color.Black;

                            sun.Visible = true;
                            Cloud.Visible = true;

                            moon.Visible = false;
                            star.Visible = false;
                            star1.Visible = false;
                            star2.Visible = false;

                            moongif.Visible = false;

                        }
                    }
                    if (Convert.ToInt32(score1.Text) % 140 == 0)
                    {

                        if (this.BackColor == Color.Cyan)
                        {


                            this.BackColor = Color.Black;

                            label1.ForeColor = Color.White;


                            sun.Visible = false;
                            Cloud.Visible = false;

                            moon.Visible = true;
                            star.Visible = true;
                            star1.Visible = true;
                            star2.Visible = true;

                            moongif.Visible = true;


                        }
                    }
                    if (Convert.ToInt32(score1.Text) % 160 == 0)
                    {

                        if (this.BackColor == Color.Black)
                        {


                            this.BackColor = Color.Cyan;



                            label1.ForeColor = Color.Black;

                            sun.Visible = true;
                            Cloud.Visible = true;

                            moon.Visible = false;
                            star.Visible = false;
                            star1.Visible = false;
                            star2.Visible = false;

                            moongif.Visible = false;

                        }
                    }
                    if (Convert.ToInt32(score1.Text) % 180 == 0)
                    {

                        if (this.BackColor == Color.Cyan)
                        {



                            this.BackColor = Color.Black;

                            label1.ForeColor = Color.White;


                            sun.Visible = false;
                            Cloud.Visible = false;

                            moon.Visible = true;
                            star.Visible = true;
                            star1.Visible = true;
                            star2.Visible = true;

                            moongif.Visible = true;
                        }
                    }
                    if (Convert.ToInt32(score1.Text) % 200 == 0)
                    {

                        if (this.BackColor == Color.Black)
                        {


                            this.BackColor = Color.Cyan;



                            label1.ForeColor = Color.Black;

                            sun.Visible = true;
                            Cloud.Visible = true;

                            moon.Visible = false;
                            star.Visible = false;
                            star1.Visible = false;
                            star2.Visible = false;

                            moongif.Visible = false;

                        }
                    }


                }


            }


        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            DayandNight();
            if (this.BackColor == Color.Black)
            {

                moon.Visible = true;
                star.Visible = true;
                star1.Visible = true;
                star2.Visible = true;


                Random rndr = new Random();

                moon.Location = new Point(moon.Location.X, moon.Location.Y + 30);
                star.Location = new Point(star.Location.X, star.Location.Y + 30);
                star1.Location = new Point(star1.Location.X, star1.Location.Y + 30);
                star2.Location = new Point(star2.Location.X, star2.Location.Y + 30);


                if (moon.Location.Y > 420)
                {

                    moon.Location = new Point(rndr.Next(1, 800), 0);

                    if (star.Location.Y > 473)
                    {




                        star.Location = new Point(rndr.Next(5, 800), 0);
                    }

                    if (star1.Location.Y > 473)
                    {



                        star1.Location = new Point(rndr.Next(1, 800), 0);
                    }


                    if (star2.Location.Y > 473)
                    {


                        star2.Location = new Point(rndr.Next(0, 800), 0);

                    }

                }


            }
        }

        bool ghave = false;

        private void strongenemy()
        {

        }


        bool shoting12 = false;



        private void timer9_Tick(object sender, EventArgs e)
        {
            DayandNight();
            Random rnde = new Random();

            label3.Text = (int.Parse(label3.Text) - 1).ToString();

            if (Convert.ToInt32(label3.Text) < 0)

            {


                shoting1.Location = new Point(shoting1.Location.X, shoting1.Location.Y + 30);

                if (shoting1.Location.Y > 600)
                {

                    shoting1.Location = new Point(rnde.Next(1, 800), 0);
                    shoting1.Visible = true;





                }
                if (shoting1.Bounds.IntersectsWith(player.Bounds))
                {

                    label4.Text = "   ";
                    shoting1.Visible = false;



                }

            }

        }







        int click = 0;
        int click1 = 0;
        int click2 = 0;
        int click3 = 0;

        private void RemoveEnemy()
        {
            this.Controls.Remove(enemy);
            enemy = null;
        }


        private void player23_Click(object sender, EventArgs e)
        {

            player.Image = player23.Image;

            click++;


            player25.Visible = false;
            player25.Enabled = false;
            player23.Visible = false;
            player23.Enabled = false;


            label5.Text = " ";
        }







        private void player25_Click(object sender, EventArgs e)
        {

            player.Image = player25.Image;
            click1++;

            player25.Visible = false;
            player.Enabled = false;
            player25.Visible = false;
            player25.Enabled = false;
            player23.Visible = false;
            player23.Enabled = false;

            label5.Text = " ";


        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            red1.Text = "   ";
            radioButton1.Visible = false;
            radioButton1.Enabled = false;
            radioButton2.Visible = false;
            radioButton2.Enabled = false;
            click3++;





        }


        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            red1.Text = " ";

            radioButton1.Visible = false;
            radioButton1.Enabled = false;
            radioButton2.Visible = false;
            radioButton2.Enabled = false;
            click3++;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Game Over")
            {




                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {


                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                    timer4.Start();
                    timer5.Start();
                    timer6.Start();
                    timer8.Start();
                    timer9.Start();

                    button1.Visible = false;
                    button1.Enabled = false;



                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Game Over")
            {

                button2.Visible = false;
                button2.Enabled = false;
                restartGame();


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }




}
