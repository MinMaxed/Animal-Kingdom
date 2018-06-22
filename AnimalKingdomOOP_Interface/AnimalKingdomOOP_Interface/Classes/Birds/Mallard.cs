using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class Mallard : Ducks
    {
        public override int LegCount { get; set; } = 2;
        public override bool IsNocturnal { get; set; } = false;

        public override string Sound()
        {
            return "quack";
        }

        public override string Diet()
        {
            return "I eat bugs and bread and stuff";
        }

        public override string Habitat()
        {
            return "I live in lakes";
        }

    }
}
