using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irairabou
{
    public partial class Form2 : Form
    {
        int playTime;   //ゲームのプレイ時間を表す
        Boolean playGame; //ゲームをプレイ中かどうかを表すフラグ
        int wheelAngle;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            playGame = false;
            playTime = 0;

            playTimeLabel.Text = "Time:" + playTime;

            wheelAngle = 0;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //カーソルをスタート位置に移動
            Point startingPoint = field.Location;
            startingPoint.Offset(55, 65);
            Cursor.Position = PointToScreen(startingPoint);

            playGame = true;
            playTime = 0;
            playTimeLabel.Text = "Time:" + playTime;
            timer1.Start();
            wheelTimer.Start();
            block1Timer.Start();
            block2Timer.Start();
            block3Timer.Start();
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playTime++;
            playTimeLabel.Text = "Time:" + playTime;
        }

        private void Goal_MouseEnter(object sender, EventArgs e)
        {
            if (playGame == true)
            {
                playGame = false;
                timer1.Stop();
                wheelTimer.Stop();
                block1Timer.Stop();
                block2Timer.Stop();
                block3Timer.Stop();
                MessageBox.Show("Stage Clear!\n" + "Time:" + playTime);
            }
        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }

        private void lineShape57_MouseEnter(object sender, EventArgs e)
        {
            if (playGame == true)
            {
                playGame = false;
                timer1.Stop();
                wheelTimer.Stop();
                block1Timer.Stop();
                block2Timer.Stop();
                block3Timer.Stop();
                MessageBox.Show("Miss!\n" + "Please, retry.");
            }
        }
        private void wheelRightMove()
        {
            int size = 45;
            int centerX = wheelRight1.X2;
            int centerY = wheelRight1.Y2;
            wheelRight1.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI*4) + Math.PI / 2)) + centerX;
            wheelRight1.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI*4) + Math.PI / 2)) + centerY;
            wheelRight2.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI*4))) + centerX;
            wheelRight2.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI*4))) + centerY;
            wheelRight3.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI*4) - Math.PI / 2)) + centerX;
            wheelRight3.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI*4) - Math.PI / 2)) + centerY;
            wheelRight4.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI*4) - Math.PI)) + centerX;
            wheelRight4.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI*4) - Math.PI)) + centerY;
        }

        private void wheelCenterMove()
        {
            int size = 45;
            int centerX = wheelCenter1.X2;
            int centerY = wheelCenter1.Y2;
            wheelCenter1.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI * 5) + Math.PI / 2)) + centerX;
            wheelCenter1.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI * 5) + Math.PI / 2)) + centerY;
            wheelCenter2.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI * 5))) + centerX;
            wheelCenter2.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI * 5))) + centerY;
            wheelCenter3.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI * 5) - Math.PI / 2)) + centerX;
            wheelCenter3.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI * 5) - Math.PI / 2)) + centerY;
            wheelCenter4.X1 = (int)(size * Math.Cos(wheelAngle / (Math.PI * 5) - Math.PI)) + centerX;
            wheelCenter4.Y1 = (int)(size * Math.Sin(wheelAngle / (Math.PI * 5) - Math.PI)) + centerY;
        }

        private void wheelLeftMove()
        {
            int size = 45;
            int centerX = wheelLeft1.X2;
            int centerY = wheelLeft1.Y2;
            wheelLeft1.X1 = (int)(size * Math.Cos(-wheelAngle / (Math.PI * 3) + Math.PI / 2 + 1)) + centerX;
            wheelLeft1.Y1 = (int)(size * Math.Sin(-wheelAngle / (Math.PI * 3) + Math.PI / 2 + 1)) + centerY;
            wheelLeft2.X1 = (int)(size * Math.Cos(-wheelAngle / (Math.PI * 3) + 1)) + centerX;
            wheelLeft2.Y1 = (int)(size * Math.Sin(-wheelAngle / (Math.PI * 3) + 1)) + centerY;
            wheelLeft3.X1 = (int)(size * Math.Cos(-wheelAngle / (Math.PI * 3) - Math.PI / 2 + 1)) + centerX;
            wheelLeft3.Y1 = (int)(size * Math.Sin(-wheelAngle / (Math.PI * 3) - Math.PI / 2 + 1)) + centerY;
            wheelLeft4.X1 = (int)(size * Math.Cos(-wheelAngle / (Math.PI * 3) - Math.PI + 1)) + centerX;
            wheelLeft4.Y1 = (int)(size * Math.Sin(-wheelAngle / (Math.PI * 3) - Math.PI + 1)) + centerY;
        }

        int blankSize1 = 30;
        private void block1Move()
        {
            if (blockUpper1.Height == 90 && blockLower1.Height == 0)
            {
                blockUpper1.Height = 0;
                blockLower1.Top = 10;
                blockLower1.Height = 90;
            }
            else if (blockUpper1.Height == 0)
            {
                if (blankSize1 == 30)
                {
                    blockUpper1.Height++;
                    blockLower1.Top++;
                    blockLower1.Height--;
                }
                else
                {
                    blockLower1.Top++;
                    blockLower1.Height--;
                    blankSize1++;
                }
            }
            else if (blockLower1.Height == 0)
            {
                blockUpper1.Height++;
                blankSize1--;
            }
            else
            {
                blockUpper1.Height++;
                blockLower1.Top++;
                blockLower1.Height--;
            }
        }

        int blankSize2 = 30;
        private void block2Move()
        {
            if (blockLower2.Height == 90 && blockUpper2.Height == 0)
            {
                blockLower2.Height = 0;
                blockLower2.Top = 100;
                blockUpper2.Height = 90;
            }
            else if (blockLower2.Height == 0)
            {
                if (blankSize2 == 30)
                {
                    blockLower2.Top--;
                    blockLower2.Height++;
                    blockUpper2.Height--;
                }
                else
                {
                    blockUpper2.Height--;
                    blankSize2++;
                }
            }
            else if (blockUpper2.Height == 0)
            {
                blockLower2.Top--;
                blockLower2.Height++;
                blankSize2--;
            }
            else
            {
                blockUpper2.Height--;
                blockLower2.Top--;
                blockLower2.Height++;
            }
        }

        int blankSize3 = 30;
        private void block3Move()
        {
            if (blockUpper3.Height == 90 && blockLower3.Height == 0)
            {
                blockUpper3.Height = 0;
                blockLower3.Top = 10;
                blockLower3.Height = 90;
            }
            else if (blockUpper3.Height == 0)
            {
                if (blankSize3 == 30)
                {
                    blockUpper3.Height++;
                    blockLower3.Top++;
                    blockLower3.Height--;
                }
                else
                {
                    blockLower3.Top++;
                    blockLower3.Height--;
                    blankSize3++;
                }
            }
            else if (blockLower3.Height == 0)
            {
                blockUpper3.Height++;
                blankSize3--;
            }
            else
            {
                blockUpper3.Height++;
                blockLower3.Top++;
                blockLower3.Height--;
            }
        }

        private void wheelTimer_Tick(object sender, EventArgs e)
        {
            wheelAngle++;
            wheelRightMove();
            wheelCenterMove();
            wheelLeftMove();
        }

        private void wheelRight4_MouseMove(object sender, MouseEventArgs e)
        {
            lineShape57_MouseEnter(sender, e);
        }

        private void wheelLeft4_Click(object sender, EventArgs e)
        {

        }

        private void wheelLeft1_Click(object sender, EventArgs e)
        {

        }

        private void wheelLeft2_Click(object sender, EventArgs e)
        {

        }

        private void wheelLeft3_Click(object sender, EventArgs e)
        {

        }

        private void wheelCenter4_Click(object sender, EventArgs e)
        {

        }

        private void wheelCenter1_Click(object sender, EventArgs e)
        {

        }

        private void wheelCenter3_Click(object sender, EventArgs e)
        {

        }

        private void block1Timer_Tick(object sender, EventArgs e)
        {
            block1Move();
            block2Move();
            block3Move();
        }

        private void block2Timer_Tick(object sender, EventArgs e)
        {
            block2Move();
            block3Move();
        }

        private void block3Timer_Tick(object sender, EventArgs e)
        {
            block3Move();
            block3Move();
        }

    }
}
