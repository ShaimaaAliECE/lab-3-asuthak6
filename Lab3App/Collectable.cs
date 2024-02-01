using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : CollectionBoard, Displayable
    {
        public String Description { get; set; }
        public CollectionBoard Board = new CollectionBoard();

        public virtual void AddMe(List<Collectable> list)
        {
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
        public virtual void Display(){}
    }
}
