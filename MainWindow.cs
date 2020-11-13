using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class MainWindow : Form
    {
       // Initialize in global scope to retain points        
        Score score = new Score();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        //Game clock. The timer will be used to help move the game and calculate points
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Create new objects for game logic
            CarAI carAI = new CarAI(playerCar, aiCar1, aiCar2, aiCar3);
            GameReset game = new GameReset(playerCar, aiCar1, aiCar2, aiCar3, road1, road2, gameTimer);
            Road road = new Road(road1, road2);

            // If cars collide end game
            if (carAI.Collide())
            {
                gameTimer.Stop();
                startBtn.Enabled = true;
                pauseBtn.Enabled = false;

                MessageBox.Show("Game over!" + Environment.NewLine + $"High Score: {score.BestScore}", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset game to default varialbes
                game.Reset();
                score.RawPoints = game.RawPoints;
                score.Points = game.Points;
            }

            //Increase points by 0.06 instead of every millisecond. Prevents score from being too high
            score.RawPoints += 0.06f;

            score.IncreaseScore();
            score.IncreaseBestScore();

            // Display score as text
            scoreText.Text = score.IncreaseScore().ToString();
            bestScoreText.Text = score.IncreaseBestScore().ToString();

            //Move road
            road.Run();

            //Move car carAI
            carAI.Run();
        }

        //This must be added to designer for method to work
        //this.KeyPreview = true;
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            // How fast the playerCar moves left and right
            int movement = 40;

            //if players presses A or Left arrow key
            switch (e.KeyCode)
            {
                //if players presses A or Left arrow key, move car left
                case Keys.Left:
                case Keys.A:
                    playerCar.Left -= movement;
                    break;

                //if players presses D or Right arrow key, move car right
                case Keys.Right:
                case Keys.D:
                    playerCar.Left += movement;
                    break;
            }

            // Player car boundary
            int maxLeft = 0;
            int maxRight = (390 - playerCar.Width);

            //If player location passes boundary reset to position 
            if (playerCar.Left <= maxLeft)
            {
                playerCar.Left = maxLeft;

            }
            else if (playerCar.Left >= maxRight)
            {
                playerCar.Left = maxRight;
            }
        }        

        //On click start the game timer
        private void startBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            startBtn.Enabled = false;
            pauseBtn.Enabled = true;
        }

        //On click stop the game timer
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            startBtn.Enabled = true;
            pauseBtn.Enabled = false;
        }
    }
}
