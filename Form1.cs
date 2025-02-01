using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen Pen = new Pen(Color.White);
            Pen.Width = 10;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 550, 130, 550, 520);
            e.Graphics.DrawLine(Pen, 700, 130, 700, 520);

            e.Graphics.DrawLine(Pen, 400, 250, 850, 250);
            e.Graphics.DrawLine(Pen, 400, 400, 850, 400);


        }

        void PlayTurn(Button btn)
        {
            if(btn.Tag.ToString() != "X" && btn.Tag.ToString() != "O")
            {
                if (lblTurn.Text == "Player 1")
                {
                    btn.Tag = "X";
                    btn.Image = Resources.X;
                    lblTurn.Text = "Player 2";

                }
                else
                {
                    btn.Tag = "O";
                    btn.Image = Resources.O;
                    lblTurn.Text = "Player 1";
                }
            }

            else
            {
                MessageBox.Show("Wrong!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool GameFinished()
        {
            return
                 (
                  btn1.Tag.ToString() != "" && btn2.Tag.ToString() != "" && btn3.Tag.ToString() != "" &&
                  btn4.Tag.ToString() != "" && btn5.Tag.ToString() != "" && btn6.Tag.ToString() != "" &&
                  btn7.Tag.ToString() != "" && btn8.Tag.ToString() != "" && btn9.Tag.ToString() != ""
                 );
        }

        void GreenButtons(Button btn1, Button btn2, Button btn3)
        {
            btn1.BackColor = Color.Lime;
            btn2.BackColor = Color.Lime;
            btn3.BackColor = Color.Lime;
        }

        void win()
        {
            if
              ( 
                (btn1.Tag.ToString() != "" && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag) ||
                (btn4.Tag.ToString() != "" && btn4.Tag == btn5.Tag && btn5.Tag == btn6.Tag) ||
                (btn7.Tag.ToString() != "" && btn7.Tag == btn8.Tag && btn8.Tag == btn9.Tag) ||
                (btn1.Tag.ToString() != "" && btn1.Tag == btn4.Tag && btn4.Tag == btn7.Tag) ||
                (btn2.Tag.ToString() != "" && btn2.Tag == btn5.Tag && btn5.Tag == btn8.Tag) ||
                (btn3.Tag.ToString() != "" && btn3.Tag == btn6.Tag && btn6.Tag == btn9.Tag) ||
                (btn1.Tag.ToString() != "" && btn1.Tag == btn5.Tag && btn5.Tag == btn9.Tag) ||
                (btn3.Tag.ToString() != "" && btn3.Tag == btn5.Tag && btn5.Tag == btn7.Tag)
              )

            {

                if (btn1.Tag.ToString() != "" && btn1.Tag == btn2.Tag && btn2.Tag == btn3.Tag)
                {
                    GreenButtons(btn1, btn2, btn3);
                }
                else if (btn4.Tag.ToString() != "" && btn4.Tag == btn5.Tag && btn5.Tag == btn6.Tag)
                {
                    GreenButtons(btn4, btn5, btn6);
                }
                else if (btn7.Tag.ToString() != "" && btn7.Tag == btn8.Tag && btn8.Tag == btn9.Tag)
                {
                    GreenButtons(btn7, btn8, btn9);
                }
                else if (btn1.Tag.ToString() != "" && btn1.Tag == btn4.Tag && btn4.Tag == btn7.Tag)
                {
                    GreenButtons(btn1, btn4, btn7);
                }
                else if (btn2.Tag.ToString() != "" && btn2.Tag == btn5.Tag && btn5.Tag == btn8.Tag)
                {
                    GreenButtons(btn2, btn5, btn8);
                }
                else if (btn3.Tag.ToString() != "" && btn3.Tag == btn6.Tag && btn6.Tag == btn9.Tag)
                {
                    GreenButtons(btn3, btn6, btn9);
                }
                else if (btn1.Tag.ToString() != "" && btn1.Tag == btn5.Tag && btn5.Tag == btn9.Tag)
                {
                    GreenButtons(btn1, btn5, btn9);
                }
                else if (btn3.Tag.ToString() != "" && btn3.Tag == btn5.Tag && btn5.Tag == btn7.Tag)
                {
                    GreenButtons(btn3, btn5, btn7);
                }


                if (lblTurn.Text == "Player 2")
                {
                    lblWinner.Text = "Player 1";

                }
                
                else
                {
                    lblWinner.Text = "Player 2";
                    
                }

                lblTurn.Text = "Game Over";
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if(GameFinished())
                {
                    lblWinner.Text = "Draw";
                    lblTurn.Text = "Game Over";

                }
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            PlayTurn((Button)sender);
            win();

        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.BackColor = Color.Black;
            btn.Tag = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
            ResetButton(btn1);
            ResetButton(btn2);
            ResetButton(btn3);
            ResetButton(btn4);
            ResetButton(btn5);
            ResetButton(btn6);
            ResetButton(btn7);
            ResetButton(btn8);
            ResetButton(btn9);

        }
    }
}
