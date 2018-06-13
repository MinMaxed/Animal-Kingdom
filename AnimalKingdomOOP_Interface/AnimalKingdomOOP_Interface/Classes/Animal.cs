using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Animal
    {
        public string Sound { get; set; }

        public int LimbCount { get; set; }

        public string Diet { get; set; }
    }
}
