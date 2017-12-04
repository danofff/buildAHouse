using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse.Team
{
    class TeamLeader : IWorker
    {
        public workerType type { get; set; }
        public List<string> report
        { get; set; }
        public TeamLeader()
        {
            type = workerType.teamLeader;
            report = new List<string>();
        }
        public void whatDone(string s)
        {
            report.Add(s);
        }
        public void printInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-----------------------");
            Console.WriteLine("This were built:");
            foreach (string item in report)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Project finish on {0:f}%", report.Count == 0 ? 0.00: report.Count*100.0/11.0);
            Console.WriteLine("-----------------------");
        }
    }
}
