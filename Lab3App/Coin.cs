using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        private int Value { get; set; }
        
        public Coin(string des, int score, int value)
        {
            Score = score;
            Value = value;
            Description = des;
        }

        public void UpdateTotalValue() { }
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
        public void AddMe(List<Collectable> list){

        }
    }
}
