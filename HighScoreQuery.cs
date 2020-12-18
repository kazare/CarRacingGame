using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;

namespace CarRacingGame
{
    class HighScoreQuery
    {
        static DataClasses1DataContext dbContext = new DataClasses1DataContext();
        Table<HighScore> highscores = dbContext.GetTable<HighScore>();

        public IQueryable ShowTableData()
        {
            var data = (from row in highscores
                        orderby row.BestScore descending
                        select new { row.UserName, row.BestScore, row.Date }).Take(10);
            return data;
        }

        public bool IsTopTen(double userScore)
        {
            var data = (from row in highscores
                        orderby row.BestScore descending
                        select new { row.UserName, row.BestScore, row.Date }).Take(10);

            List<double> scores = new List<double>();
            foreach (var x in data)
            {
                scores.Add(x.BestScore);
            }

            //If database contains less than 10 items
            if (scores.Count < 10)
            {
                return true;
            }
            //If userScore is greater than the minimum score
            else if (userScore > scores.Min())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddScore(string username, double score)
        {
            DateTime date = DateTime.Now;
            HighScore obj = new HighScore();
            obj.UserName = username;
            obj.BestScore = Math.Round(score);
            obj.Date = date;

            try
            {
                dbContext.GetTable<HighScore>().InsertOnSubmit(obj);
                dbContext.SubmitChanges();
                Console.WriteLine("Submitted: " + username + " " + score + " " + date);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
