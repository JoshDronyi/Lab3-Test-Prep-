using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Die
    {
        int dieFace;
        public Die()
        {

        }

        public int Face 
        {
            get { return dieFace; }
            set { dieFace = value; }
        }
    }
}
