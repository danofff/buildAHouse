using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class Wall : IPart
    {
        private static int wallNumber = 1;
        public string name
        { get; set;}
        public int quantOfWorkersNeed
        { get; set; }

        public bool isDone { get; set; }
        public Wall()
        {
            quantOfWorkersNeed = 2;
            name = "Wall" +wallNumber;
            wallNumber++;
            isDone = false;
        }
        public void build()
        {
            Turtle.Move(170);
            Turtle.TurnRight();
            isDone = true;
        }
    }
}
