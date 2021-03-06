﻿using System;
using System.Collections.Generic;
using System.Text;
using AnimalKingdomOOP_Interface.Interfaces;


namespace AnimalKingdomOOP_Interface.Classes
{
    public abstract class Mammals : Animal
    {

        public virtual bool SweatGlands { get; set; } = true;

        public abstract bool HasHair { get; set; }

    }
}
