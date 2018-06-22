using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Animal
    {


        public virtual string Sound()
        {
            return "my sound here";
        }

        public virtual string Diet()
        {
            return "Things I eat";
        }

        public virtual string Habitat()
        {
            return "I live in nature";
        }

        public abstract int LegCount { get;  set; }

        public abstract bool IsNocturnal { get;  set; }


    }
}
