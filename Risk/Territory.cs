﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Drawing.Graphics;

namespace Risk
{
    public class Territory
    {
        public string Name { get; set; }
        //public Enum Continent { get; set; }
        public Player Owner { get; set; }
        public Army StandingArmy { get; set; }

        public Territory(string n /*, Player o, Army s*/)
        {
            this.Name = n;
            //this.Continent = c;
            //this.Owner = o;
            //this.StandingArmy = s;
        }
    }
}
