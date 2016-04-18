using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class RiskBoard
    {
        public List<Territory> Territories;
        public Boolean[,] NeighborMatrix;

        public RiskBoard()
        {

        }

        public Boolean Connected(Territory a, Territory b)
        {
            // basically here we'll get each index value (ex. france is 3, germany is 4)
            // NeighborMatrix[3, 4] is true, therefore Connected(Territories<3>, Territories<4>) will return true
            return true;
        }
        
    }
}
