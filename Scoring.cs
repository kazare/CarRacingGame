using System;

namespace CarRacingGame
{
    class Scoring
    {
        //Take users points and provide a message based on the amount of points they earned
        public void Score(int points)
        {
            Console.WriteLine($"You scored {points}");

            if (points < 10)
            {
                Console.WriteLine("Better luck next time!"); ;
            }
            else if (points > 10 && points < 50)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Amazing!!");
            }


        }
    }
}
