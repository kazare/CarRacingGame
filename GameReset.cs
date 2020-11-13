using System;
using System.Windows.Forms;

namespace CarRacingGame
{
    //Class to handle reset logic
    class GameReset : Game
    {
        // Inehrit base class constructor parameters
        public GameReset(PictureBox playerCar, PictureBox aiCar1, PictureBox aiCar2, PictureBox aiCar3, PictureBox road1, PictureBox road2, Timer gameTimer) : base(playerCar, aiCar1, aiCar2, aiCar3, road1, road2, gameTimer)
        {
            
        }

        public void Reset()
        {
            // Reset variables
            RawPoints = 0;
            Points = 0;
            RoadSpeed = 5;
            AISpeed = 5;

            gameTimer.Stop();

            //default item positions
            road1.Top = 0;
            road1.Left = 0;

            road2.Top = -351;
            road1.Left = 0;

            aiCar1.Top = -81;
            aiCar1.Left = 24;

            aiCar2.Top = -457;
            aiCar2.Left = 175;

            aiCar3.Top = -177;
            aiCar3.Left = 256;

            playerCar.Top = 265;
            playerCar.Left = 175;
        }
    }
}
