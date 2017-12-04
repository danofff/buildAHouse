using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class Roof : IPart
    {
        public bool isDone
        { get; set;}

        public string name
        { get; set;}

        public int quantOfWorkersNeed
        { get; set; }

        public Roof()
        {
            quantOfWorkersNeed = 3;
            name = "Roof";
            isDone = false;
        }
        public void build()
        {
            //prepare
            Turtle.PenUp();
            Turtle.Move(170);
            Turtle.TurnLeft();
            Turtle.PenDown();
            //build
            Turtle.Move(14);
            Turtle.Turn(135);
            Turtle.Move(140);
            Turtle.Turn(90);
            Turtle.Move(140);
            Turtle.Turn(135);
            Turtle.Move(184);
            //prepere for building windows
            Turtle.TurnLeft();
            Turtle.PenUp();
            Turtle.Move(75);
            Turtle.TurnLeft();
            Turtle.Move(120);
            Turtle.PenDown();
            isDone = true;
        }
    }
}
