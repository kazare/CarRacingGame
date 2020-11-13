using System.Windows.Forms;

namespace CarRacingGame
{
    //Handles all road functionality
    class Road : Game
    {
        // Inehrit base class constructor parameters
        public Road(PictureBox road1, PictureBox road2) : base(road1, road2)
        {

        }

        public void Run()
        {
            //Move roads at certain speed
            road1.Top += RoadSpeed;
            road2.Top += RoadSpeed;

            //Once the top of the road reaches the boundary reset the road to new position
            if (road1.Top > Boundary)
            {
                road1.Top = BackToTop;
            }
            if (road2.Top > Boundary)
            {
                road2.Top = BackToTop;
            }
        }
    }
}
