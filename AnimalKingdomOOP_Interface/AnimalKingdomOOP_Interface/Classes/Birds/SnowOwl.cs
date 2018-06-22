using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class SnowOwl : Owl, ICanFly
    {
        public override string Diet()
        {
            return "seaweed";
        }

        public override string Habitat()
        {
            return "I live in the water";
        }

        public override int LegCount { get; set; } = 2;
        public override bool IsNocturnal { get; set; } = true;
        public bool Migrates { get; set; } = false;
    }
}
