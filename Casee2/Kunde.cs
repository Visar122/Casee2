using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casee2
{
    public class Kunde : Person
    {
        public string Nummerplader { get; set; }
        public string BilensMærke { get; set; }

        public string BilensModel { get; set; }

        public DateTime RegistreringsÅrgang { get; set; }



        public Kunde(string firstName, string lastName, int telefonNr, string nummerplader, string bilensMærke, string bilensModel, DateTime registreringsÅrgang) : base(firstName, lastName, telefonNr)
        {

            Nummerplader=nummerplader;
            BilensMærke=bilensMærke;
            BilensModel=bilensModel;
            RegistreringsÅrgang=registreringsÅrgang;

        }
        public override void Getname(Entry e1, string name)
        {


            foreach (Entry e in e1.Entries)
            {
                string fullname = e.Kundeinfo.FirstName  +" "+ e.Kundeinfo.LastName;

                if (fullname==name)

                    Console.WriteLine($"\n  {e.WorkerInfo.FirstName} arbejder med {e.WorkerInfo.KøretøjType} ");
            }
        }

    }
}
