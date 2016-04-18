﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Territory
    {
        public string Name { get; set; }
        public Enum Continent { get; set; }
        public Player Owner { get; set; }
        public Army StandingArmy { get; set; }
    }
}
