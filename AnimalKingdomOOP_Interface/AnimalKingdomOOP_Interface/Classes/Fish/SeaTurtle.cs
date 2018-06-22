using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public class SeaTurtle : Turtle
    {

        public override string Sound()
        {
            return "________";
        }

        public override string Diet()
        {
            return "seaweed";
        }

        public override string Habitat()
        {
            return "I live in the water";
        }

        public override int LegCount { get; set; } = 4;
        public override bool IsNocturnal { get; set; } = false;
    }
}
