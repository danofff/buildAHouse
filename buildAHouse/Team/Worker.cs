using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse.Team
{
    class Worker : IWorker
    {
        public List<string> report
        { get; set; }
        public workerType type
        { get; set; }
        public Worker()
        {
            type = workerType.worker;
            report = new List<string>();
        }
        public void whatDone(string s)
        {
            report.Add(s);
        }
    }
}
