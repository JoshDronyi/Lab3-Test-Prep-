using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Risk
    {
        private RiskBoard Board { get; set; }
        private List<Player> Players { get; set; }

        public Risk(int numPlayers)
        {
            Board = new RiskBoard();
            Players = new List<Player>(numPlayers);
        }

        public Player getCurrentPlayer()
        {
            return Players[0];
        }

        public void PlayerTurn()
        {

        }
    }
}
