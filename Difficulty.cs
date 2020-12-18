using System.Windows.Forms;

namespace CarRacingGame
{
    class Difficulty : Game
    {
        // Inehrit base class constructor parameters
        public Difficulty(PictureBox ai1, PictureBox ai2, PictureBox ai3, PictureBox road1, PictureBox road2) : base(ai1, ai2, ai3, road1, road2)
        {

        }

        // Increase road and AI speed based on score
        public void IncreaseSpeed(double currentScore)
        {
            if (currentScore <= 30)
            {
                RoadSpeed = 5;
                AISpeed = 5;
                aiCar1.Top += AISpeed;
                aiCar2.Top += AISpeed;
                aiCar3.Top += AISpeed;
                road1.Top += RoadSpeed;
                road2.Top += RoadSpeed;
            }
            else if (currentScore <= 45)
            {
                RoadSpeed = 7;
                AISpeed = 7;
                aiCar1.Top += AISpeed;
                aiCar2.Top += AISpeed;
                aiCar3.Top += AISpeed;
                road1.Top += RoadSpeed;
                road2.Top += RoadSpeed;
            }
            else if (currentScore <= 60)
            {
                RoadSpeed = 10;
                AISpeed = 10;
                aiCar1.Top += AISpeed;
                aiCar2.Top += AISpeed;
                aiCar3.Top += AISpeed;
                road1.Top += RoadSpeed;
                road2.Top += RoadSpeed;
            }
            else if (currentScore <= 75)
            {
                RoadSpeed = 12;
                AISpeed = 12;
                aiCar1.Top += AISpeed;
                aiCar2.Top += AISpeed;
                aiCar3.Top += AISpeed;
                road1.Top += RoadSpeed;
                road2.Top += RoadSpeed;
            }
            else if (currentScore <= 90 || currentScore >= 90)
            {
                RoadSpeed = 15;
                AISpeed = 15;
                aiCar1.Top += AISpeed;
                aiCar2.Top += AISpeed;
                aiCar3.Top += AISpeed;
                road1.Top += RoadSpeed;
                road2.Top += RoadSpeed;
            }
        }
    }
}
