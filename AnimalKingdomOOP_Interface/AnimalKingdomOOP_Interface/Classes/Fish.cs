using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Fish : Animal
    {
        public virtual bool Sushiable { get; set; } = true;
    }
}
