using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class GreatWhiteShark : Sharks, ICanSwim
    {

        public override string Sound()
        {
            return "CRUNCH";
        }

        public override string Diet()
        {
            return "I eat everything";
        }

        public override string Habitat()
        {
            return "I live in the water";
        }

        public override int LegCount { get; set; } = 0;
        public override bool IsNocturnal { get; set; } = false;

        public override bool Sushiable { get; set; } = true;
    }
}
