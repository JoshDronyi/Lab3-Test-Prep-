using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Drawing.Graphics;

namespace Risk
{
    public class Territory
    {
        private string Name { get; set; }
        //public Enum Continent { get; set; }
        public Player Owner { get; set; }
        public Army StandingArmy { get; set; }

        public Territory(string n)
        {
            this.Name = n;
        }

        public string PrintInfo()
        {
            return ("Name: " + Name + "\n" +
                   "Owner: " + Owner.Name);
        }
    }
}
