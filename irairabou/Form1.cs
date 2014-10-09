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
    public partial class Form1 : Form
    {
        int playTime;   //ゲームのプレイ時間を表す
        Boolean playGame; //ゲームをプレイ中かどうかを表すフラグ

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playGame = false;
            playTime = 0;

            playTimeLabel.Text = "Time:" + playTime;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //カーソルをスタート位置に移動
            Point startingPoint = field.Location;
            startingPoint.Offset(55, 65);
            Cursor.Position = PointToScreen(startingPoint);

            playGame = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playTime++;
            playTimeLabel.Text = "Time:" + playTime;
        }

        private void lineShape1_MouseEnter(object sender, EventArgs e)
        {
            if (playGame == true)
            {
                playGame = false;
                timer1.Stop();
                MessageBox.Show("Game Over");
     
            }
        }

        private void lineShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void lineShape2_Click(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void lineShape5_Click(object sender, EventArgs e)
        {

        }

        private void lineShape7_Click(object sender, EventArgs e)
        {

        }

        private void lineShape6_Click(object sender, EventArgs e)
        {

        }

        private void lineShape8_Click(object sender, EventArgs e)
        {

        }

        private void lineShape9_Click(object sender, EventArgs e)
        {

        }

        private void lineShape15_Click(object sender, EventArgs e)
        {

        }

        private void lineShape16_Click(object sender, EventArgs e)
        {

        }

        private void lineShape19_Click(object sender, EventArgs e)
        {

        }

        private void lineShape20_Click(object sender, EventArgs e)
        {

        }

        private void lineShape17_Click(object sender, EventArgs e)
        {

        }

        private void lineShape18_Click(object sender, EventArgs e)
        {

        }

        private void lineShape23_Click(object sender, EventArgs e)
        {

        }

        private void lineShape24_Click(object sender, EventArgs e)
        {

        }

        private void lineShape22_Click(object sender, EventArgs e)
        {

        }

        private void lineShape21_Click(object sender, EventArgs e)
        {

        }

        private void lineShape12_Click(object sender, EventArgs e)
        {

        }

        private void Goal_MouseEnter(object sender, EventArgs e)
        {
            if (playGame == true)
            {
                playGame = false;
                timer1.Stop();
                MessageBox.Show("Stage Clear!\n" + "Time:" + playTime );

            }
        }
    }
}
