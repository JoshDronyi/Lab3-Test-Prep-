using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    class Army
    {
        List<Unit> armyUnits = new List<Unit>();
        public Army() 
        {

        }
        enum unitType
        {
            infantry = 1,
            calvary = 5,
            artillary = 10
        }
        //methods to add infantry, Calvary or Artillary to the armyUnits list
        public void AddInfantry()
        {
            Unit infantry = new Unit();
            infantry.UnitStrength = Convert.ToInt32(unitType.infantry);
            infantry.UnitType = Convert.ToInt32(unitType.infantry);

            armyUnits.Add(infantry);
        }
        public void AddCalvary()
        {
            Unit calvary = new Unit();
            calvary.UnitStrength = Convert.ToInt32(unitType.calvary);
            calvary.UnitType = Convert.ToInt32(unitType.calvary);

            armyUnits.Add(calvary);
        }
        public void AddArtillary()
        {
            Unit artillary = new Unit();
            artillary.UnitStrength = Convert.ToInt32(unitType.artillary);
            artillary.UnitType = Convert.ToInt32(unitType.artillary);

            armyUnits.Add(artillary);
        }

        public int GetStrength()
        {
            return armyUnits.Count;
        }

    }
}
