using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Army
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
                //Methods to subtract units
        public void SubtractInfantry() 
        {
            //Finds out if there are any loose infantrymen or we would have to break them.
            List<Unit> infantryList = new List<Unit>();

            for(int i =0; i <armyUnits.Count; i++)
            {
                Unit unit =  (Unit) armyUnits[i];
                if(unit.UnitType == Convert.ToInt32(unitType.infantry))
                {
                    infantryList.Add(unit);
                    armyUnits.Remove(unit);
                    return;
                }
           }
            //Since there are no single infantry we need to break either a calvary or artillary
            for (int i = 0; i < armyUnits.Count; i++)
           {
                Unit unit = (Unit)armyUnits[i];
                List<Unit> newInfantry = new List<Unit>();
                
                if(unit.UnitType == Convert.ToInt32(unitType.calvary))
                {
                    if (armyUnits.Count > 0)
                    {
                        newInfantry = BreakCalvary();
                        SubtractInfantry();
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                    
                }
                else if (unit.UnitType == Convert.ToInt32(unitType.artillary))
                {
                    if (armyUnits.Count > 0)
                    {
                        newInfantry = BreakArtillary();
                        SubtractInfantry();
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
           }
            
        }

        //Breaks Calvary unit into 5 infantry units
        public List<Unit> BreakCalvary() 
        {
            List<Unit> newInfantry = new List<Unit>();
            for (int i = 0; i < armyUnits.Count; i++ )
            {
                Unit unit = (Unit)armyUnits[i];
                if(unit.UnitType == Convert.ToInt32(unitType.calvary))
                {
                    int count = 0;

                    while (count < 5) 
                    {
                        Unit newUnit = new Unit();
                        newUnit.UnitType = Convert.ToInt32(unitType.infantry);
                        newInfantry.Add(newUnit);
                    }
                }

            }
            return newInfantry;
        }
        
        //Breaks Artillary unit into 10 infantry units
        public List<Unit> BreakArtillary() 
        {
            List<Unit> newInfantry = new List<Unit>();
            for (int i = 0; i < armyUnits.Count; i++)
            {
                Unit unit = (Unit)armyUnits[i];
                if (unit.UnitType == Convert.ToInt32(unitType.artillary))
                {
                    int count = 0;

                    while (count < 10)
                    {
                        Unit newUnit = new Unit();
                        newUnit.UnitType = Convert.ToInt32(unitType.infantry);
                        newInfantry.Add(newUnit);
                    }
                }
            }
            return newInfantry;
        }
    

        public int GetStrength()
        {
            return armyUnits.Count;
        }

    }
}
