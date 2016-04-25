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
    public partial class frmBattle : Form
    {
        Boolean result; // true is attacker wins, false is defender wins

        public frmBattle()
        {
            InitializeComponent();

            Player emptyPlayer = new Player();

            int[] attackRoll = emptyPlayer.Attack();
            int[] defendRoll = emptyPlayer.Defend();

            if (attackRoll[0] > defendRoll[0])
            {
                result = true;
            }
            else
            {
                result = false;
            }

            lblAttackRoll.Text = "Die 1: " + attackRoll[0].ToString() + "\n" +
                                 "Die 2: " + attackRoll[1].ToString() + "\n" +
                                 "Die 3: " + attackRoll[2].ToString();
            lblDefenseRoll.Text = "Die 1: " + defendRoll[0].ToString() + "\n" +
                                  "Die 2: " + defendRoll[1].ToString();
        }

        public Boolean BattleResult()
        {
            return result;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmMain.game.Board.InvadeTerritory(Attacker, Defender, Base, Target, battle.BattleResult());
            this.Close();
        }
    }
}
