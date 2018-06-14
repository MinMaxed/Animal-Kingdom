using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Primates : Mammals
    {
        public override bool HasHair { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
