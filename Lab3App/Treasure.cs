using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score {get; set;}
        public void UpdateTotalScore(int score)
        {
            Board.TotalScore = Board.TotalScore + score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);

        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            if(Score > 0)
            {
                UpdateTotalScore(Score);
            }
            else
            {
                UpdateTotalScore(100);
            }
        }
    }
}
