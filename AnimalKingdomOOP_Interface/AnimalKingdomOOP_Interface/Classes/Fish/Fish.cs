using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Fish : Animal, ICanSwim
    {
        public virtual bool Sushiable { get; set; } = true;
        public bool BreathesUnderWater { get; set; } = true;
    }
}
