using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class Door : IPart
    {
        public bool isDone
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public int quantOfWorkersNeed
        {
            get;

            set;
        }

        public Door()
        {
            quantOfWorkersNeed = 1;
            name = "Door";
            isDone = false;
        }

        public void build()
        {
            //prepare to build
            Turtle.PenUp();
            Turtle.Move(5);
            Turtle.TurnRight();
            Turtle.Move(95);
            Turtle.Turn(180);
            Turtle.PenDown();
            //build
            Turtle.Move(50);
            Turtle.Turn(90);
            Turtle.Move(25);
            Turtle.Turn(90);
            Turtle.Move(50);
            isDone = true;
        }
    }
}
