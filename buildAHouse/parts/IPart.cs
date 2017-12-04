using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildAHouse
{
    interface IPart
    {
        string name { get; set; }
        int quantOfWorkersNeed { get; set; }
        bool isDone { get; set; }
        void build();

    }
}
