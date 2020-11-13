using System;

namespace CarRacingGame
{
    class Score : Game
    {
        public double IncreaseScore()
        {
            // Round points up to prevent a decimal score
            Points = Math.Round(RawPoints);
            return Points;
        }

        public double IncreaseBestScore()
        {
            // if points are higher than the best score replace best score
            if (IncreaseScore() > BestScore)
            {
                BestScore = IncreaseScore();
            }

            return BestScore;
        }
    }
}
