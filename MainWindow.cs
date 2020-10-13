using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class MainWindow : Form
    {
        double rawPoints = 0;
        double points;
        double bestScore;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Game clock. The timer willl be used to help move the game and calculate points
        //For every tick of the timer give the user a point
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Increase points by 0.06 instead of every millisecond. Prevents score from being too high
            //Round points up to prevent a decimal score
            rawPoints += 0.06f;
            points = Math.Round(rawPoints);

            //How fast to move the road
            int roadSpeed = 5;
            road1.Top += roadSpeed;
            road2.Top += roadSpeed;

            //Once the top of the road reaches the boundary reset the road to new position
            int boundary = 350;
            int reset = -350;
            
            if (road1.Top > boundary)
            {
                road1.Top = reset;
            }
            if(road2.Top > boundary)
            {
                road2.Top = reset;
            }

            //Display score
            scoreText.Text = points.ToString();

           //iF points are higher than the best score replace best score
           if(points > bestScore)
            {
                bestScore = points;
            }

            bestScoreText.Text = bestScore.ToString();
        }

        //Allow the player to move the car left and right with the keyboard
        //
        /*
         * Error handling will include cases where the player moves the car offscreen
         * This will be based on the window/panel size. If the player moves beyond the boundaries
         * Error handling will catch and handle it
         */


        //This must be added to designer for method to work
        //this.KeyPreview = true;
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                playerCar.Left -= 15;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                playerCar.Left += 15;
            }
        }

        //On click start the game timer
        private void startBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        //On click stop the game timer
        //Will implement a way to reset the game
        private void stopBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }
    }
}
