namespace jang_fazayi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            enemy = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            label1 = new Label();
            score = new Label();
            timer3 = new System.Windows.Forms.Timer(components);
            score1 = new Label();
            label2 = new Label();
            heart1 = new PictureBox();
            heart2 = new PictureBox();
            heart3 = new PictureBox();
            randomheart = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            soratp = new Label();
            timer4 = new System.Windows.Forms.Timer(components);
            ramz = new TextBox();
            sun = new PictureBox();
            Cloud = new PictureBox();
            timer5 = new System.Windows.Forms.Timer(components);
            blownup = new PictureBox();
            timer6 = new System.Windows.Forms.Timer(components);
            star = new PictureBox();
            moon = new PictureBox();
            timer8 = new System.Windows.Forms.Timer(components);
            star1 = new PictureBox();
            star2 = new PictureBox();
            timer9 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            shoting1 = new PictureBox();
            label4 = new Label();
            moongif = new PictureBox();
            player23 = new PictureBox();
            player25 = new PictureBox();
            red1 = new Label();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)enemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)randomheart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cloud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blownup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shoting1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moongif).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player25).BeginInit();
            SuspendLayout();
            // 
            // enemy
            // 
            enemy.Image = (Image)resources.GetObject("enemy.Image");
            enemy.Location = new Point(309, 4);
            enemy.Margin = new Padding(2, 1, 2, 1);
            enemy.Name = "enemy";
            enemy.Size = new Size(111, 66);
            enemy.SizeMode = PictureBoxSizeMode.Zoom;
            enemy.TabIndex = 0;
            enemy.TabStop = false;
            enemy.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // player
            // 
            player.Image = Properties.Resources._05d4b71e_dac3_4a50_8461_c847137ba3d3;
            player.Location = new Point(330, 361);
            player.Margin = new Padding(2, 1, 2, 1);
            player.Name = "player";
            player.Size = new Size(111, 66);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 1;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 184);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 2;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.SlateGray;
            score.Location = new Point(1, 60);
            score.Margin = new Padding(2, 0, 2, 0);
            score.Name = "score";
            score.Size = new Size(26, 30);
            score.TabIndex = 3;
            score.Text = "3";
            score.Click += label2_Click;
            // 
            // timer3
            // 
            timer3.Enabled = true;
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // score1
            // 
            score1.AutoSize = true;
            score1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score1.ForeColor = Color.SlateGray;
            score1.Location = new Point(24, 37);
            score1.Margin = new Padding(2, 0, 2, 0);
            score1.Name = "score1";
            score1.Size = new Size(26, 30);
            score1.TabIndex = 3;
            score1.Text = "0";
            score1.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(1, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(26, 30);
            label2.TabIndex = 3;
            label2.Text = "$";
            label2.Click += label2_Click;
            // 
            // heart1
            // 
            heart1.Image = (Image)resources.GetObject("heart1.Image");
            heart1.Location = new Point(5, 4);
            heart1.Margin = new Padding(2, 1, 2, 1);
            heart1.Name = "heart1";
            heart1.Size = new Size(43, 31);
            heart1.SizeMode = PictureBoxSizeMode.StretchImage;
            heart1.TabIndex = 4;
            heart1.TabStop = false;
            // 
            // heart2
            // 
            heart2.Image = (Image)resources.GetObject("heart2.Image");
            heart2.Location = new Point(50, 4);
            heart2.Margin = new Padding(2, 1, 2, 1);
            heart2.Name = "heart2";
            heart2.Size = new Size(43, 31);
            heart2.SizeMode = PictureBoxSizeMode.StretchImage;
            heart2.TabIndex = 4;
            heart2.TabStop = false;
            // 
            // heart3
            // 
            heart3.Image = (Image)resources.GetObject("heart3.Image");
            heart3.Location = new Point(95, 4);
            heart3.Margin = new Padding(2, 1, 2, 1);
            heart3.Name = "heart3";
            heart3.Size = new Size(43, 31);
            heart3.SizeMode = PictureBoxSizeMode.StretchImage;
            heart3.TabIndex = 4;
            heart3.TabStop = false;
            // 
            // randomheart
            // 
            randomheart.Image = (Image)resources.GetObject("randomheart.Image");
            randomheart.Location = new Point(487, 4);
            randomheart.Margin = new Padding(2, 1, 2, 1);
            randomheart.Name = "randomheart";
            randomheart.Size = new Size(43, 31);
            randomheart.SizeMode = PictureBoxSizeMode.StretchImage;
            randomheart.TabIndex = 4;
            randomheart.TabStop = false;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 700;
            timer2.Tick += timer2_Tick;
            // 
            // soratp
            // 
            soratp.AutoSize = true;
            soratp.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            soratp.ForeColor = Color.SlateGray;
            soratp.Location = new Point(1, 87);
            soratp.Margin = new Padding(2, 0, 2, 0);
            soratp.Name = "soratp";
            soratp.Size = new Size(26, 30);
            soratp.TabIndex = 3;
            soratp.Text = "5";
            soratp.Click += label2_Click;
            // 
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick;
            // 
            // ramz
            // 
            ramz.Location = new Point(1, 120);
            ramz.Name = "ramz";
            ramz.Size = new Size(100, 23);
            ramz.TabIndex = 5;
            ramz.Visible = false;
            // 
            // sun
            // 
            sun.Image = Properties.Resources.icegif_111;
            sun.Location = new Point(637, 2);
            sun.Name = "sun";
            sun.Size = new Size(100, 101);
            sun.SizeMode = PictureBoxSizeMode.StretchImage;
            sun.TabIndex = 8;
            sun.TabStop = false;
            // 
            // Cloud
            // 
            Cloud.Image = Properties.Resources.icegif_1038;
            Cloud.Location = new Point(163, 4);
            Cloud.Name = "Cloud";
            Cloud.Size = new Size(125, 100);
            Cloud.SizeMode = PictureBoxSizeMode.StretchImage;
            Cloud.TabIndex = 9;
            Cloud.TabStop = false;
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // blownup
            // 
            blownup.ErrorImage = (Image)resources.GetObject("blownup.ErrorImage");
            blownup.Image = Properties.Resources._54439246198__1_;
            blownup.Location = new Point(1, 154);
            blownup.Margin = new Padding(3, 2, 3, 2);
            blownup.Name = "blownup";
            blownup.Size = new Size(77, 62);
            blownup.SizeMode = PictureBoxSizeMode.StretchImage;
            blownup.TabIndex = 10;
            blownup.TabStop = false;
            blownup.Visible = false;
            // 
            // timer6
            // 
            timer6.Enabled = true;
            timer6.Tick += timer6_Tick;
            // 
            // star
            // 
            star.Image = Properties.Resources._1427064_7cc5a;
            star.Location = new Point(174, 130);
            star.Margin = new Padding(3, 2, 3, 2);
            star.Name = "star";
            star.Size = new Size(48, 33);
            star.SizeMode = PictureBoxSizeMode.StretchImage;
            star.TabIndex = 11;
            star.TabStop = false;
            star.Visible = false;
            // 
            // moon
            // 
            moon.Image = Properties.Resources.photo108084273942;
            moon.Location = new Point(450, 110);
            moon.Margin = new Padding(3, 2, 3, 2);
            moon.Name = "moon";
            moon.Size = new Size(80, 53);
            moon.SizeMode = PictureBoxSizeMode.StretchImage;
            moon.TabIndex = 12;
            moon.TabStop = false;
            moon.Visible = false;
            // 
            // timer8
            // 
            timer8.Enabled = true;
            timer8.Tick += timer8_Tick;
            // 
            // star1
            // 
            star1.Image = Properties.Resources.photo10808148554;
            star1.Location = new Point(436, 41);
            star1.Margin = new Padding(3, 2, 3, 2);
            star1.Name = "star1";
            star1.Size = new Size(32, 23);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 13;
            star1.TabStop = false;
            star1.Visible = false;
            // 
            // star2
            // 
            star2.Image = Properties.Resources.photo10808148554;
            star2.Location = new Point(626, 120);
            star2.Margin = new Padding(3, 2, 3, 2);
            star2.Name = "star2";
            star2.Size = new Size(32, 23);
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.TabIndex = 14;
            star2.TabStop = false;
            star2.Visible = false;
            // 
            // timer9
            // 
            timer9.Enabled = true;
            timer9.Interval = 1000;
            timer9.Tick += timer9_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 218);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 15;
            label3.Text = "20";
            label3.Visible = false;
            // 
            // shoting1
            // 
            shoting1.Image = Properties.Resources.Screenshot_2024_04_18_173300;
            shoting1.Location = new Point(57, 37);
            shoting1.Margin = new Padding(3, 2, 3, 2);
            shoting1.Name = "shoting1";
            shoting1.Size = new Size(10, 20);
            shoting1.SizeMode = PictureBoxSizeMode.StretchImage;
            shoting1.TabIndex = 16;
            shoting1.TabStop = false;
            shoting1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 232);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 17;
            label4.Text = "0";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // moongif
            // 
            moongif.Image = Properties.Resources._649ffa02503d5;
            moongif.Location = new Point(637, 2);
            moongif.Margin = new Padding(3, 2, 3, 2);
            moongif.Name = "moongif";
            moongif.Size = new Size(100, 101);
            moongif.SizeMode = PictureBoxSizeMode.StretchImage;
            moongif.TabIndex = 18;
            moongif.TabStop = false;
            // 
            // player23
            // 
            player23.Image = Properties.Resources.Screenshot_2024_03_28_162928__1_;
            player23.Location = new Point(220, 208);
            player23.Margin = new Padding(3, 2, 3, 2);
            player23.Name = "player23";
            player23.Size = new Size(111, 66);
            player23.SizeMode = PictureBoxSizeMode.Zoom;
            player23.TabIndex = 21;
            player23.TabStop = false;
            player23.Click += player23_Click;
            // 
            // player25
            // 
            player25.Image = Properties.Resources._05d4b71e_dac3_4a50_8461_c847137ba3d3;
            player25.Location = new Point(369, 208);
            player25.Margin = new Padding(2, 1, 2, 1);
            player25.Name = "player25";
            player25.Size = new Size(111, 66);
            player25.SizeMode = PictureBoxSizeMode.Zoom;
            player25.TabIndex = 22;
            player25.TabStop = false;
            player25.Click += player25_Click;
            // 
            // red1
            // 
            red1.AutoSize = true;
            red1.Location = new Point(5, 260);
            red1.Name = "red1";
            red1.Size = new Size(13, 15);
            red1.TabIndex = 23;
            red1.Text = "0";
            red1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 296);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 24;
            label5.Text = "0";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 325);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 25;
            label6.Text = "0";
            label6.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(430, 295);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 26;
            radioButton1.Text = "قرمز";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(244, 295);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(42, 19);
            radioButton2.TabIndex = 27;
            radioButton2.Text = "ابی";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(318, 296);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(72, 32);
            button1.TabIndex = 28;
            button1.Text = "شروع";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(78, 312);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(111, 52);
            button2.TabIndex = 29;
            button2.Text = "مجدد";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(738, 434);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(red1);
            Controls.Add(player25);
            Controls.Add(player23);
            Controls.Add(label4);
            Controls.Add(shoting1);
            Controls.Add(label3);
            Controls.Add(star2);
            Controls.Add(star1);
            Controls.Add(star);
            Controls.Add(blownup);
            Controls.Add(player);
            Controls.Add(enemy);
            Controls.Add(label1);
            Controls.Add(soratp);
            Controls.Add(score);
            Controls.Add(label2);
            Controls.Add(score1);
            Controls.Add(heart2);
            Controls.Add(heart3);
            Controls.Add(heart1);
            Controls.Add(randomheart);
            Controls.Add(ramz);
            Controls.Add(moon);
            Controls.Add(sun);
            Controls.Add(Cloud);
            Controls.Add(moongif);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "`";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)enemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)randomheart).EndInit();
            ((System.ComponentModel.ISupportInitialize)sun).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cloud).EndInit();
            ((System.ComponentModel.ISupportInitialize)blownup).EndInit();
            ((System.ComponentModel.ISupportInitialize)star).EndInit();
            ((System.ComponentModel.ISupportInitialize)moon).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)shoting1).EndInit();
            ((System.ComponentModel.ISupportInitialize)moongif).EndInit();
            ((System.ComponentModel.ISupportInitialize)player23).EndInit();
            ((System.ComponentModel.ISupportInitialize)player25).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemy;
        internal System.Windows.Forms.Timer timer1;
        private PictureBox player;
        private Label label1;
        private Label score;
        private System.Windows.Forms.Timer timer3;
        private Label score1;
        private Label label2;
        private PictureBox heart1;
        private PictureBox heart2;
        private PictureBox heart3;
        private PictureBox randomheart;
        internal System.Windows.Forms.Timer timer2;
        private Label soratp;
        private System.Windows.Forms.Timer timer4;
        private TextBox ramz;
        private PictureBox sun;
        private PictureBox Cloud;
        private System.Windows.Forms.Timer timer5;
        private PictureBox blownup;
        internal System.Windows.Forms.Timer timer6;
        private PictureBox star;
        private PictureBox moon;
        private PictureBox star1;
        private PictureBox star2;
        internal System.Windows.Forms.Timer timer8;
        private Label label3;
        internal System.Windows.Forms.Timer timer9;
        private PictureBox shoting1;
        private Label label4;
        private PictureBox moongif;
        private PictureBox player23;
        private PictureBox player25;
        private Label red1;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
    }
}
