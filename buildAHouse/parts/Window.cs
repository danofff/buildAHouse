using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class Window : IPart
    {
        private static int numberHolder=1;
        private int windNumb;
        public bool isDone
        { get; set; }

        public string name
        { get; set; }
        public int quantOfWorkersNeed
        { get; set; }

        public Window()
        {
            windNumb = numberHolder;
            name = "Window" + windNumb;
            quantOfWorkersNeed = 1;
            isDone = false;
            numberHolder++;
        }
        public void build()
        {
            Turtle.Move(25);
            Turtle.Turn(90);
            Turtle.Move(25);
            Turtle.Turn(90);
            Turtle.Move(25);
            Turtle.Turn(90);
            Turtle.Move(25);
            Turtle.PenUp();
            if (windNumb == 2)
            {
                Turtle.Move(70);
                Turtle.PenDown();
            }
            else
            {
                Turtle.Move(20);
                Turtle.PenDown();
            }
            isDone = true;           
        }
    }
}
