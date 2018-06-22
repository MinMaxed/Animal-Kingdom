using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;

namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Owl : Birds
    {
        public override sealed string Sound()
        {
            return "hoot hoot";
        }
    }
}
