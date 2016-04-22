using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Territory
    {
        private string Name { get; set; }
        //public Enum Continent { get; set; }
        public Player Owner { get; set; }
        public Army StandingArmy { get; set; }

        public Territory()
        {
        }

        public Territory(string n)
        {
            this.Name = n;
        }

        public string PrintInfo()
        {
            if (Owner == null)
            {
                return ("Name:  " + Name + "\n" +
                        "Owner: Unclaimed");
            }
            else
            {
                return ("Name:  " + Name + "\n" +
                        "Owner: " + Owner.Name + "\n" + 
                        "Army:  " + StandingArmy);
            }            
        }
    }
}
