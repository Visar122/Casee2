using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casee2
{
    public class Entry
    {
        public Worker WorkerInfo { get; set; }
        public Kunde Kundeinfo { get; set; }

        public Entry(Kunde kundeinfo, Worker workerinfo)
        {
            Kundeinfo=kundeinfo;
            WorkerInfo=workerinfo;
        }

        public List<Entry> Entries { get; set; }
        public Entry()
        {
            Entries = new List<Entry>();
        }

    }
}
