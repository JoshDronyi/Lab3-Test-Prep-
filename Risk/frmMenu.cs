using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk
{
    public partial class frmMenu : Form
    {
        int numPlayers;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            numPlayers = (int) nudPlayerCount.Value;
            this.Close();
        }

        public int getNumPlayers()
        {
            return numPlayers;
        }
    }
}
