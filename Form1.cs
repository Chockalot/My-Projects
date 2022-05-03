using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong
{

    public partial class Form1 : Form
    {

        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        int player1Score = 0;
        int player2Score = 0;

        bool player1DetectedUp;
        bool player2DetectedUp;
        bool player1DetectedDown;
        bool player2DetectedDown;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                player2DetectedUp = false;
                timer2.Stop();
            }
            else if (e.KeyCode == Keys.Down)
            {
                player2DetectedDown = false;
                timer2.Stop();
            }
            if (e.KeyCode == Keys.W)
            {
                player1DetectedUp = false;
                timer1.Stop();
            }
            else if (e.KeyCode == Keys.S)
            {
                player1DetectedDown = false;
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if(e.KeyCode == Keys.Up)
            {
                player2DetectedUp = true;
                timer2.Start();
            }
            else if(e.KeyCode == Keys.Down)
            {
                player2DetectedDown = true;
                timer2.Start();
            }
            if (e.KeyCode == Keys.W)
            {
                player1DetectedUp = true;
                timer1.Start();
            }
            else if (e.KeyCode == Keys.S)
            {
                player1DetectedDown = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          

            //Move player1 up
            if(player1DetectedUp && spielerLinks.Location.Y > 4)
            {
                spielerLinks.Top -= 13; //paddle move speed
            }
            //Move player1 down
            if (player1DetectedDown && spielerLinks.Location.Y < ClientSize.Height - spielerLinks.Height)
            {
                spielerLinks.Top += 13;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Move player2 up
            if (player2DetectedUp && spielerRechts.Location.Y > 4)
            {
                spielerRechts.Top -= 13;
            }
            //Move player2 down
            if (player2DetectedDown && spielerRechts.Location.Y < ClientSize.Height - spielerRechts.Height)
            {
                spielerRechts.Top += 13;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

            ball.Top -= ballYCoordinate;
            ball.Left -= ballXCoordinate;

            // Check if the ball has exited the left side of the screen
            if (ball.Left < 0)
            {
                ball.Left = ClientSize.Width / 2;
                ball.Top = ClientSize.Height / 2;
                ballXCoordinate = 5;
                ballYCoordinate = 5;
                player2Score++;
                spielerRechtsScore.Text = player2Score.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = ClientSize.Width / 2;
                ball.Top = ClientSize.Height / 2;
                ballXCoordinate = 5;
                ballYCoordinate = 5;
                player1Score++;
                spielerLinksScore.Text = player1Score.ToString();
            }
            // Ensure the ball is within the boundaries of the screen
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height) 
            { 
                ballYCoordinate = -ballYCoordinate; 
            }
            // Check if the ball hits the player or CPU paddle
            if (ball.Bounds.IntersectsWith(spielerLinks.Bounds))
            {
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;

                //increase speed horizontally
                ballXCoordinate -= 2;

                //increase speed vertically
                if(ballYCoordinate > 0)
                {
                    ballYCoordinate += 1;
                }
                else if(ballYCoordinate < 0)
                {
                    ballYCoordinate -= 1;
                }
            }

            else if(ball.Bounds.IntersectsWith(spielerRechts.Bounds))
            {
                ballXCoordinate = -ballXCoordinate;

                //increase speed horizontally
                ballXCoordinate += 2;

                //increase speed vertically
                if (ballYCoordinate > 0)
                {
                    ballYCoordinate += 1;
                }
                else if (ballYCoordinate < 0)
                {
                    ballYCoordinate -= 1;
                }
            }
        }
    }
}
