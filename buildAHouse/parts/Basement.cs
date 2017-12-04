using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class Basement : IPart
    {
        public string name { get; set; }
        public int quantOfWorkersNeed
        {
            get;
            set;
        }

        public bool isDone { get; set; }

        public Basement()
        {
            quantOfWorkersNeed = 4;
            name = "Basement";
            isDone = false;
        }

        public void build()
        {
            Turtle.Move(20);
            Turtle.Turn(90);
            Turtle.Move(198);
            Turtle.Turn(90);
            Turtle.Move(20);
            Turtle.Turn(90);
            Turtle.Move(198);
            Turtle.Turn(90);
            Turtle.PenUp();
            Turtle.Move(20);
            Turtle.Turn(90);
            Turtle.Move(14);
            Turtle.TurnLeft();
            Turtle.PenDown();
            isDone = true;
        }
    }
}
