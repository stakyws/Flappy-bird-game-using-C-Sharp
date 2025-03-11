using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird_لعبه
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravity = 20;
        int speed = 21;
        int speed1 = 10;
        int speed2 = 11;
        int speed3 = 12;
        int speed4 = 13;
        int speed5 = 14;
        Random r = new Random();
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            /* عند بدئ اللعبه يبدأ الطائر بالنزول لأسفل */
            pictureBox1.Top += gravity;

            /* عند بدئ اللعبه اجعل العمدان للعبه تتحرك لجهة اليسار*/
            pictureBox3.Left -= speed;
            pictureBox4.Left -= speed;

            /*   عند وصول احد العمدان بجهة اليسار إلى النقطه صفر اجعله يعود من جديد وبطريقه عشوائيه من المسافه المحدده */
            if (pictureBox3.Left < 3)
            {
                pictureBox3.Left = 700; score++;
                pictureBox3.Height = 150;
            }
          

            if (pictureBox4.Left < 3)
            {
                pictureBox4.Left = 700;
                pictureBox4.Height = r.Next(125,160 );
                
            }
            
            if (score >= 7)
            {
                if (pictureBox3.Left < 3)
                {
                    pictureBox3.Left = 700; score++;
                    pictureBox3.Height = 62; /* r.Next(232,265); 62; */
                }
                else
                    pictureBox3.Left -= speed1;

                if (pictureBox4.Left < 3)
                {
                    pictureBox4.Left = 700;
                    pictureBox4.Height = r.Next(150, 180);

                }
                else
                    pictureBox4.Left -= speed1;
            }

            if (score >= 14)
            {
                if (pictureBox3.Left < 3)
                {
                    pictureBox3.Left = 700; score++;
                    pictureBox3.Height = 62;
                }
                else
                    pictureBox3.Left -= speed2;

                if (pictureBox4.Left < 3)
                {
                    pictureBox4.Left = 700;
                    pictureBox4.Height = r.Next(180, 200);

                }
                else
                    pictureBox4.Left -= speed2; 
            }

            if (score >= 21)
            {
                if (pictureBox3.Left < 3)
                {
                    pictureBox3.Left = 700; score++;
                    pictureBox3.Height = 62;
                }
                else
                    pictureBox3.Left -= speed3;

                if (pictureBox4.Left < 3)
                {
                    pictureBox4.Left = 700;
                    pictureBox4.Height = r.Next(190, 200);

                }
                else
                    pictureBox4.Left -= speed3;
            }

            if (score >= 28)
            {
                if (pictureBox3.Left < 3)
                {
                    pictureBox3.Left = 700; score++;
                    pictureBox3.Height = 62;
                }
                else
                    pictureBox3.Left -= speed4;

                if (pictureBox4.Left < 3)
                {
                    pictureBox4.Left = 700;
                    pictureBox4.Height = r.Next(190, 210);

                }
                else
                    pictureBox4.Left -= speed4;
            }

            if (score >= 35)
            {
                if (pictureBox3.Left < 3)
                {
                    pictureBox3.Left = 700; score++;
                    pictureBox3.Height = 62;
                }
                else
                    pictureBox3.Left -= speed5;

                if (pictureBox4.Left < 3)
                {
                    pictureBox4.Left = 700;
                    pictureBox4.Height = r.Next(210, 220);

                }
                else
                    pictureBox4.Left -= speed5;
            }


            label1.Text = "قيمه نقاطق هي" + score;

            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            { 
                timer1.Stop();
                label1.Text = "انتهت اللعبه قيمة نقاطك هي: " + score;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /* تبدأ اللعبه واظغط على زر المسطره فيبدأ الطائر يطير  Enter إضغط على */
            if (timer1.Enabled == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    timer1.Start();
                    label1.Visible = true;
                    pictureBox3.Left = 500;
                    pictureBox4.Left = 500;
                    pictureBox3.Height = 120;
                    pictureBox4.Height = 120;
                    pictureBox1.Top = 50;
                    score = 0; /* يعود عداد النقاط إلى صفر Enter عند الخساره والظغط على */
                    label1.Text = "" + score;

                }
            }
            /* جعل الطائر ينزل للاسفل */
            if (e.KeyCode == Keys.Space) { gravity = -15; }

            /* 2 =y لل Location عندمايصعد الطائر وتكون قيمه ال 
               15 فأجعله ينزل وتكون قيمة الوكيشن يساوي */
            if (pictureBox1.Top < 2) { pictureBox1.Top = 15; }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            /*  15 بسافه Top عندما يبدأ الطائر بالنزول اجعله, إظغط على زر المسطره ليرتفع ال */
            if (e.KeyCode == Keys.Space) { gravity = 15; }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Blue;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.Black;
        }
    }
}
