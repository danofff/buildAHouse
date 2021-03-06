﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using buildAHouse.Team;

namespace buildAHouse
{
    class BuildProcess
    {
        public House myHouse { get; set; }
        public team myTeam { get; set; }

        public BuildProcess()
        {
            myHouse = new House();
            myTeam = new team();
        }
            public void
            startBuild()
        {
            Turtle.Y = 400;
            Turtle.Speed = 8;
            //build basement
            myHouse.basement.build();
            if (myHouse.basement.isDone)
                myTeam.getReport(myHouse.basement.name);
            myTeam.leader.printInfo();
            //build walls
            myHouse.walls[0].build();
            if (myHouse.walls[0].isDone)
                myTeam.getReport(myHouse.walls[0].name);
            myTeam.leader.printInfo();
            myHouse.walls[1].build();
            if (myHouse.walls[1].isDone)
                myTeam.getReport(myHouse.walls[1].name);
            myTeam.leader.printInfo();
            myHouse.walls[2].build();
            if (myHouse.walls[2].isDone)
                myTeam.getReport(myHouse.walls[2].name);
            myTeam.leader.printInfo();
            myHouse.walls[3].build();
            if (myHouse.walls[3].isDone)
                myTeam.getReport(myHouse.walls[3].name);
            myTeam.leader.printInfo();
            //build roof
            myHouse.roof.build();
            if (myHouse.roof.isDone)
                myTeam.getReport(myHouse.roof.name);
            myTeam.leader.printInfo();
            //build windows
            myHouse.windows[0].build();
            if (myHouse.windows[0].isDone)
                myTeam.getReport(myHouse.windows[0].name);
            myTeam.leader.printInfo();
            myHouse.windows[1].build();
            if (myHouse.windows[1].isDone)
                myTeam.getReport(myHouse.windows[1].name);
            myTeam.leader.printInfo();
            myHouse.windows[2].build();
            if (myHouse.windows[2].isDone)
                myTeam.getReport(myHouse.windows[2].name);
            myTeam.leader.printInfo();
            myHouse.windows[3].build();
            if (myHouse.windows[3].isDone)
                myTeam.getReport(myHouse.windows[3].name);
            myTeam.leader.printInfo();
            //build door
            myHouse.door.build();
            if (myHouse.door.isDone)
                myTeam.getReport(myHouse.door.name);
            myTeam.leader.printInfo();
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("HOUSE WERE BUILT");
            Console.ResetColor();
        } 
    }
}
