using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse.Team
{
    class team
    {
        public TeamLeader leader { get; set; }
        public Worker[] workers { get; set; }

        public team()
        {
            leader = new TeamLeader();
            workers = new Worker[4];
            for (int i = 0;  i < 4; i++)
            {
                workers[i]=new Worker();
            }
        }
        public void getReport(string s)
        {
            leader.whatDone(s);
            for (int i = 0; i < 4; i++)
            {
                workers[i].whatDone(s);
            }
        }

    }
}
