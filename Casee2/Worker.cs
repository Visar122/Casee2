using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casee2
{
    public class Worker : Person
    {
        public Opgave MekanikerObjekt { get; set; }
        public KøretøjType KøretøjType { get; set; }
        public Worker(string firstName, string lastName, int telefonNr, Opgave mekanikerObjekt, KøretøjType køretøjType) : base(firstName, lastName, telefonNr)
        {
            MekanikerObjekt= mekanikerObjekt;
            KøretøjType=køretøjType;
        }
        public List<Worker> Workers { get; set; }



        public override void Getname(Entry e1, string name)
        {

            foreach (Entry e in e1.Entries)
            {
                string fullname = e.WorkerInfo +" "+ e.WorkerInfo.LastName;

                if (fullname==name)

                    Console.WriteLine($"\n  {e.WorkerInfo.FirstName} arbejder med {e.WorkerInfo.KøretøjType} ");
            }
        }
    }
}
