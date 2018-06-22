using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Bat : Mammals, ICanFly
    {
        private new bool HasHair = true;
        public bool Migrates { get; set; } = false;
    }
}
