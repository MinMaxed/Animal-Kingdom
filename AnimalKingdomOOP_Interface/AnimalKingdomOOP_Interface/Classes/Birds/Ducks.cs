using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Ducks : Birds, ICanFly, ICanSwim
    {
        public bool Migrates { get; set; } = true;
        public bool BreathesUnderWater { get; set; } = false;
    }
}
