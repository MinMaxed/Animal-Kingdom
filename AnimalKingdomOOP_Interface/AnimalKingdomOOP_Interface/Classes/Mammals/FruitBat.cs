using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class FruitBat : Bat
    {
        public override bool HasHair { get; set; } = true;
        public override int LegCount { get; set; } = 2;
        public override bool IsNocturnal { get; set; } = true;

        public override string Sound()
        {
            return "eek eek eek";
        }

        public override string Habitat()
        {
            return "I live in caves";
        }
        public override string Diet()
        {
            return "I eat fruits and bugs";
        }
    }
}
