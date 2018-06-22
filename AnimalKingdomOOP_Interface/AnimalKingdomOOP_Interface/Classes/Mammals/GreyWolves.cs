using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;

namespace AnimalKingdomOOP_Interface.Classes
{
    public class GreyWolves : Canine, ICanSwim
    {
        public bool BreathesUnderWater { get; set; } = false;

        public override string Sound()
        {
            return "hhhhooooooooowwwwwllll";
        }

        public override string Habitat()
        {
            return "I live in the woods";
        }

        public override string Diet()
        {
            return "I eat what my pack catches.";
        }
    }
}
