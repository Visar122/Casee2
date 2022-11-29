using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casee2
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelefonNr { get; set; }

        public Person(string firstName, string lastName, int telefonNr)
        {
            FirstName = firstName;
            LastName = lastName;
            TelefonNr= telefonNr;

        }
        public abstract void Getname(Entry e1, string name);


    }
}
