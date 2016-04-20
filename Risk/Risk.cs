using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Risk
    {
        public RiskBoard Board { get; set; }
        public List<Player> Players { get; set; }

        public Risk(int numPlayers)
        {
            Board = new RiskBoard();
            Players = new List<Player>(numPlayers);
        }

        public void init()
        {
            Players.Add(new Player("Sam's Empire", 0));
            Players.Add(new Player("Josh's Empire", 4));

            Board.InitPlayers(Players);
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
