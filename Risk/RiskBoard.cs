using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class RiskBoard
    {
        private List<Territory> Territories { get; set; }
        private bool?[,] NeighborMatrix { get; set; }

        public RiskBoard()
        {
            init();
        }

        public void init()
        {
            try
            {
                Territories.Add(new Territory("North America"));
                Territories.Add(new Territory("South America"));
                Territories.Add(new Territory("Europe"));
                Territories.Add(new Territory("Asia"));
                Territories.Add(new Territory("Africa"));
            } catch (NullReferenceException)
            {
                
            }            

            NeighborMatrix = new bool?[,]
            {
                { null,  true,  true,  false, false },
                { true,  null,  false, false, true  },
                { true,  false, null,  true,  true  },
                { false, false, true,  null,  true  },
                { false, true,  true,  true,  null  }
            };
        }

        public bool? Connected(Territory a, Territory b)
        {
            // basically here we'll get each index value (ex. france is 3, germany is 4)
            // NeighborMatrix[3, 4] is true, therefore Connected(Territories<3>, Territories<4>) will return true
            return NeighborMatrix[Territories.IndexOf(a), Territories.IndexOf(b)];
        }
        
    }
}
