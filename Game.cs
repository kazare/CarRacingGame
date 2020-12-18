using System.Windows.Forms;

namespace CarRacingGame
{
    class Game
    {
        // Game variables
        public PictureBox playerCar, aiCar1, aiCar2, aiCar3, road1, road2;
        public Timer gameTimer;
        
        // Set default values
        protected int Boundary { get; set; } = 350;
        protected int BackToTop { get; set; } = -350;
        protected int RoadSpeed { get; set; } = 5;
        protected int AISpeed { get; set; } = 5;
        public double RawPoints { get; set; }
        public double Points { get; set; }
        public double BestScore { get; set; }

        // Prevent class from being instatiated but allow child classes to inherit constructor parameters
        // Differt overload methods for child classes to use
        protected Game() // Allow child classes to contain no constrcutor
        {

        }

        protected Game(PictureBox player, PictureBox ai1, PictureBox ai2, PictureBox ai3, PictureBox road1, PictureBox road2, Timer gameTimer)
        {
            this.playerCar = player;
            this.aiCar1 = ai1;
            this.aiCar2 = ai2;
            this.aiCar3 = ai3;
            this.road1 = road1;
            this.road2 = road2;
            this.gameTimer = gameTimer;
        }

        protected Game(PictureBox ai1, PictureBox ai2, PictureBox ai3, PictureBox road1, PictureBox road2)
        {
            this.aiCar1 = ai1;
            this.aiCar2 = ai2;
            this.aiCar3 = ai3;
            this.road1 = road1;
            this.road2 = road2;
        }

        protected Game(PictureBox player, PictureBox ai1, PictureBox ai2, PictureBox ai3)
        {
            this.playerCar = player;
            this.aiCar1 = ai1;
            this.aiCar2 = ai2;
            this.aiCar3 = ai3;
        }

        protected Game(PictureBox road1, PictureBox road2)
        {
            this.road1 = road1;
            this.road2 = road2;
        }
    }
}
