using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    class Player
    {
                List<Territory> playerTerritories  = new List <Territories>;
        Random random = new Random(1);



        //Necessary empty Player constructor
        public Player() 
        {

        }
         enum unitType
        {
            infantry = 1,
            calvary = 5,
            artillary = 10
        }

        public bool Owns(Territory t)
        {
            bool gotIt = false;
            foreach(Territory tory in playerTerritories)
            {
                if (tory.Name = t.Name)
                    gotIt = true;
            }

            return gotIt;
        }

        public Die[] Attack()
        {
           Die[] rollResults = new Die[2];

            //Create Die objects
            Die firstDie = new Die();
            Die secondDie = new Die();

            //roll two Die since the player is attacking
            firstDie.Face = random.Next(1,7);
            secondDie.Face = random.Next(1,7);

            //put the results of the Die in results array
            rollResults[0] = firstDie;
            rollResults[1] = secondDie;

            return rollResults;

        }

        public Die[] Defend()
        {
            Die[] rollResults = new Die[3];

            // Create Die Objects
            Die firstDie = new Die();
            Die secondDie = new Die();
            Die thirdDie = new Die();

            //roll three Die since the plaer is defending
            firstDie.Face = random.Next(1,7);
            secondDie.Face = random.Next(1,7);
            thirdDie.Face = random.Next(1,7);

            //store the results in a results array
            rollResults[0] = firstDie;
            rollResults[1] = secondDie;
            rollResults[2] = thirdDie;

            return rollResults;
        }

        public void Fortify(Territory t, int fortifications)
        {
            if(fortifications == Convert.ToInt32(unitType.infantry))
            {
                t.Army.addInfantry();
            }
            else if(fortifications == Convert.ToInt32(unitType.calvary))
            {
                t.Army.addCalvary();
            }
            else
            {
                t.Army.addArtillary();
            }
        }


    }
}
