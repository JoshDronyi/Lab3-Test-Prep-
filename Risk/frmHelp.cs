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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            lblHelpText.Text =
                "Welcome to Risk! This form will help you learn the basics of our game.\n"
                + "\nThe Turn: \nAt the beginning of each turn, the player may select two adjacent territories (represented as group boxes) with each territory's checkbox. From there, you selected army will either within your empire, annex ungarrisoned land, or invade enemy territory. The player may also choose to fortify a territory, which recruits a new army in a territory that has none."
                + "\n\nThe Attack: \nWhen a player attacks an occupied territory, the battle sequence is initiated. Dice are rolled for each army, and based on the results of the roll, your attack may result in a triumphant victory, or a crushing defeat."
                + "\n\nThe Progress: \nYou may press the Info button to view statistics about the current game. ";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
