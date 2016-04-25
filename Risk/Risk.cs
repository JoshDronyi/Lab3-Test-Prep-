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
        int currentPlayer = 0;
        int myPlayerCount;

        public Risk(int numPlayers)
        {
            Board = new RiskBoard();
            Players = new List<Player>();
            this.myPlayerCount = numPlayers;
        }

        public void init()
        {
            /*
            Players.Add(new Player("Sam's Empire", 0));
            Players.Add(new Player("Josh's Empire", 3));
            */
            for (int i = 0; i < myPlayerCount; i++)
            {
                Players.Add(new Player(("Player " + (i+1).ToString()), i, true));
            }

            Board.init();
            Board.InitPlayers(Players);
        }

        public Boolean EndGame()
        {
            return Players.Count == 1;
        }

        public void CheckPlayers()
        {            
            for (int x = 0; x < Players.Count; x++)
            {
                int landCount = 0;
                for (int y = 0; y < Board.Territories.Count; y++)
                {
                    if (Board.Territories[y].Owner == Players[x])
                    {
                        landCount++;
                    }
                }

                if (landCount == 0)
                {
                    Players[x].Alive = false;
                }
            }
        }

        public Player getCurrentPlayer()
        {
            return Players[currentPlayer];
        }

        public void PlayerTurn()
        {
            if (currentPlayer == Players.Count - 1)
            {
                currentPlayer = 0;
            }
            else
            {
                currentPlayer++;
            } 
        }
    }
}
