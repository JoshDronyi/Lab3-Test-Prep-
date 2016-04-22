using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class RiskBoard
    {
        public List<Territory> Territories { get; set; }
        public bool?[,] NeighborMatrix { get; set; }

        public RiskBoard()
        {
            init();
        }
        
        public void init()
        {
            Territories = new List<Territory>();

            try
            {
                Territories.Add(new Territory("North America"));
                Territories.Add(new Territory("South America"));
                Territories.Add(new Territory("Europe"));
                Territories.Add(new Territory("Asia"));
                Territories.Add(new Territory("Africa"));
                Territories.Add(new Territory("Australia"));
            } 
            catch (NullReferenceException)
            {
                
            }            

            NeighborMatrix = new bool?[,]
            {
                { null,  true,  true,  false, false, false },
                { true,  null,  false, false, true,  false },
                { true,  false, null,  true,  true,  false },
                { false, false, true,  null,  true,  true  },
                { false, true,  true,  true,  null,  false },
                { false, false, false, true,  false, null  }
            };
        }

        public void InitPlayers(List<Player> p)
        {
            for (int i = 0; i < p.Count; i++)
            {
                Territories[p[i].HomeTerritory].Owner = p[i];
                p[i].ArmyList.Add(new Army());
                Territories[p[i].HomeTerritory].StandingArmy = p[i].ArmyList[0];
            }
        }

        public bool? Connected(Territory a, Territory b)
        {
            // basically here we'll get each index value (ex. france is 3, germany is 4)
            // NeighborMatrix[3, 4] is true, therefore Connected(Territories<3>, Territories<4>) will return true
            //return NeighborMatrix[Territories.IndexOf(a), Territories.IndexOf(b)];
            return true;
        }

        public void AnnexTerritory(Player player, Territory playerBase, Territory target)
        {
            target.Owner = player;
            target.StandingArmy = playerBase.StandingArmy;
            playerBase.StandingArmy = null;
        }
    }
}
