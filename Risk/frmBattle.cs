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
            lblAttackRoll.Text = "Die 1: \nDie 2: \nDie 3: ";
            lblDefenseRoll.Text = "Die 1: \nDie 2: ";
        }

        public Boolean BattleResult()
        {
            return result;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Player emptyPlayer = new Player();

            Die[] attackRoll = emptyPlayer.Attack();
            Die[] defendRoll = emptyPlayer.Defend();

            if (attackRoll[0].Face > defendRoll[0].Face)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            lblAttackRoll.Text = "Die 1: " + attackRoll[0].Face.ToString() + "\n" +
                                 "Die 2: " + attackRoll[1].Face.ToString() + "\n" +
                                 "Die 3: " + attackRoll[2].Face.ToString();
            lblDefenseRoll.Text = "Die 1: " + defendRoll[0].Face.ToString() + "\n" +
                                  "Die 2: " + defendRoll[1].Face.ToString();
        }
    }
}
