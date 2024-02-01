using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string des, int score)
        {
            Description = des;
            Board.TotalScore = Board.TotalScore + score;
        }
        public override void Display() {
            Console.WriteLine("Diamond " + Description + " is displayed");
        }

    }
}
