using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;

namespace AnimalKingdomOOP_Interface.Classes
{
    public class GreyWolves : Canine
    {
        public override string Sound { get => base.Sound; set => base.Sound = value; }
        public override int LegCount { get => base.LegCount; set => base.LegCount = value; }
        public override bool HasHair { get => base.HasHair; set => base.HasHair = value; }
    }
}
