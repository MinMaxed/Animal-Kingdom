using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;

namespace AnimalKingdomOOP_Interface.Classes
{
    public class Canine : Mammals
    {
        public override bool HasHair { get; set; } = true;
        public override int LegCount { get; set; } = 4;
        public override bool IsNocturnal { get; set; } = false;
        private override bool SweatGlands { get; set; } = false;
    }
}
