using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Animal
    {
        public virtual string Sound { get; set; }

        public virtual int LegCount { get; set; }

        public string Diet { get; set; }

        public bool isNocturnal { get; set; }
    }
}
