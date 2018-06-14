using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Sharks : Fish, ICanSwim
    {
        public bool BreathesUnderWater { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
