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
    public partial class frmMain : Form
    {
        public Risk game = new Risk(2);
                   
        public frmMain()
        {
            InitializeComponent();
            game.init();
        }

        private void DrawUnit(PaintEventArgs e)
        {
            Pen myPen;
        }

        private void LoadPieces()
        {
            foreach (GroupBox g in this.Controls)
            {
                if (game.Board.Territories[g.TabIndex].StandingArmy != null) {
                    PictureBox p = new PictureBox();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e) 
        {
            try 
            {
                foreach (Control g in this.Controls)
                {
                    if (g is GroupBox) 
                    {
                        foreach (CheckBox c in g.Controls)
                        {
                            if (c.Checked)
                            {
                                MessageBox.Show(game.Board.Territories[g.TabIndex].PrintInfo());
                                c.Checked = false;
                            }
                        }
                    }                    
                }
            }
            catch (InvalidCastException i)
            {
                MessageBox.Show("Error, " + i.ToString());
            }
        }
    }
}
