﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw7
{
    abstract class Bilet
    {
        protected double cena;
        abstract public void ObliczCene(RodzajBiletu rodzaj);
    }
}
