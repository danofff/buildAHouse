using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse.Team
{
    public enum workerType { teamLeader, worker };
    interface IWorker
    {
        workerType type { get; set; }
        List <string> report { get; set; }
        void whatDone(string s);           
    }
}
