using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class SnowOwl : Owl, ICanFly
    {
        public bool Migrates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
