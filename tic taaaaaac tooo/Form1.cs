using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_taaaaaac_tooo.Properties;

namespace tic_taaaaaac_tooo
{
    public partial class Form1 : Form
    {
        enPlayer PlayerTurn = enPlayer.player1;
        stGameStatus GameStatus;

        enum enPlayer
        {
            player1,
            player2
        }
        enum winner
        {
            player1, player2, draw, gameinprogress
        }
        struct stGameStatus
        {
            public winner Winner;
            public bool GameOver;
            public short PlayCount;

        }
        void endgame()
        {
            lbltrun.Text = "Game Over ";
            switch(GameStatus.Winner)
            { case winner.player1:
                    lblwinner.Text = "player1";
                    break;
                case winner.player2:
                    lblwinner.Text = "player2";
                    break;
                default:
                    lblwinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool checkvalues(Button btn1,Button btn2,Button btn3)
        {
            if (btn1.Tag != "?" && btn1.Tag.ToString() == btn2.Tag.ToString()
                && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.Aquamarine;
                btn2.BackColor = Color.Aquamarine;
                btn3.BackColor = Color.Aquamarine;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = winner.player1;
                    GameStatus.GameOver = true;
                    endgame();
                    return true;

                }
                else
                {
                    GameStatus.Winner = winner.player2;
                    GameStatus.GameOver = true;
                    endgame();

                    return true;

                }
            }

            GameStatus.GameOver = false;
            return false;


        }
        public void CheckWinner()
        {


            //checked rows
            //check Row1
            if (checkvalues(button1, button2, button6))
                return;

            //check Row2
            if (checkvalues(button4, button7, button5))
                return;

            //check Row3
            if (checkvalues(button3, button8, button9))
                return;

            //checked cols
            //check col1
            if (checkvalues(button1, button4, button3))
                return;

            //check col2
            if (checkvalues(button2, button7, button8))
                return;

            //check col3
            if (checkvalues(button6, button5, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (checkvalues(button1, button7, button9))
                return;

            //check Diagonal2
            if (checkvalues(button6, button7, button3))
                return;

            //8 
        }
        public void changeImage(Button btn)
    {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn) 
                {
                case enPlayer.player1:
                        btn.Image = Resources.thought_bubble_emoji_app_icon__27_;
                        PlayerTurn = enPlayer.player2;
                        lbltrun.Text = "player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;
                    case enPlayer.player2:
                        btn.Image = Resources.thought_bubble_emoji_app_icon__29_;
                        PlayerTurn = enPlayer.player1;
                        lbltrun.Text = "player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;

                }


            }
            else

            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = winner.draw;
                endgame();
            }



        }
        public Form1()
        {
            InitializeComponent();
        }
      


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            changeImage(button6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeImage(button1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen whitepen = new Pen(white);
            whitepen.Width = 15;
            whitepen.Color = Color.DarkOrange;
            whitepen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitepen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(whitepen, 650, 177, 1335, 177);
            e.Graphics.DrawLine(whitepen, 650, 340, 1335, 340);
            e.Graphics.DrawLine(whitepen, 903, 45, 900, 500);

            e.Graphics.DrawLine(whitepen, 1100, 45, 1100, 500);







        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeImage(button2);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            changeImage(button5);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            changeImage(button7);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeImage(button4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeImage(button3);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            changeImage(button8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            changeImage(button9);

        }
        private void restartbtn(Button btn)
        {
            btn.Image = Resources.thought_bubble_emoji_app_icon__30_;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }
        private void restartgame()
        {
            restartbtn(button1);
            restartbtn(button2);
            restartbtn(button3);
            restartbtn(button4);
            restartbtn(button5);
            restartbtn(button6);
            restartbtn(button7);
            restartbtn(button8);
            restartbtn(button9);

            PlayerTurn = enPlayer.player1;
            lbltrun.Text = "player 1";
            GameStatus.Winner = winner.gameinprogress;
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            lblwinner.Text = "In Progress";


        }
        private void lbltrun_Click(object sender, EventArgs e)
        {
            restartgame();
        }
    }

    }
