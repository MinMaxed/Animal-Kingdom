using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Ducks : Birds, ICanFly, ICanSwim
    {
        public abstract bool Migrates { get; set; }
        bool ICanSwim.BreathesUnderWater { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        bool BreathesUnderWater = false;
    }
}
