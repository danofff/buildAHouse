using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildProcess process = new BuildProcess();
            process.startBuild();
        }
    }
}
