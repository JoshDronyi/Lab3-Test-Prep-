using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    class Unit
    {
        int strength;
        int type;

        public Unit()
        {
            strength = 0;
            type = 0;
        }

        
        public int UnitStrength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int UnitType 
        {
            get { return type; }
            set { type = value; }
        }
    }
}
