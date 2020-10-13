namespace CarRacingGame
{
    //Handles all road functionality
    class Road
    {
        private int speed;

        public int Speed { get; set; }

        //If user reaches a certain number of points increase the road speed. The road will go faster and faster.
        public void RoadSpeed(int points)
        {
            if (points < 10)
            {
                Speed = 20;
            }
            else if (points > 10 && points < 50)
            {
                Speed = 60;
            }
            else
            {
                Speed = 100;
            }
        }

    }
}
