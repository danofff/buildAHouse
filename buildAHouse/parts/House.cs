using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace buildAHouse
{
    class House
    {
        public Basement basement { get; set; }
        public Wall[] walls { get; set; }
        public Roof roof { get; set; }
        public Window[] windows { get; set; }
        public Door door { get; set; }


        public House()
        {
            basement = new Basement();
            roof = new Roof();
            door = new Door();
            walls = new Wall[4];
            for (int i = 0; i < 4; i++)
            {
                walls[i] = new Wall();
            }
            windows = new Window[4];
            for (int i = 0; i < 4; i++)
            {
                windows[i] = new Window();
            }
        }
    }
}
