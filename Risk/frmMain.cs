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
            LoadPieces();
        }

        private void LoadPieces()
        {
            try
            {
                foreach (Control g in this.Controls)
                {
                    if (g is GroupBox)
                    {
                        if (game.Board.Territories[g.TabIndex].StandingArmy != null)
                        {
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Size = new Size(25, 25);
                            pictureBox.BorderStyle = BorderStyle.FixedSingle;
                            pictureBox.BackColor = Color.Red;
                            pictureBox.Location = new Point((g.Width / 2), (g.Height / 2)); ;
                            g.Controls.Add(pictureBox);
                        } 
                    }
                }
            }
            catch (InvalidCastException i)
            {
                MessageBox.Show("Error, " + i.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Player Attacker = new Player();
            Player Defender = new Player();

            Territory Base = new Territory();
            Territory Target = new Territory();

            foreach (Control g in this.Controls)
            {
                if (g is GroupBox)
                {
                    foreach (Control c in g.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox x = (CheckBox) c;
                            if (x.Checked && game.Board.Territories[g.TabIndex].Owner == game.getCurrentPlayer())
                            {
                                Attacker = game.getCurrentPlayer();
                                Base = game.Board.Territories[g.TabIndex];
                                //MessageBox.Show("made it in the first if, " + Attacker.ToString());
                            }
                            else if (x.Checked && game.Board.Territories[g.TabIndex].Owner != game.getCurrentPlayer())
                            {
                                Target = game.Board.Territories[g.TabIndex];
                                //MessageBox.Show("made it in the beginning of else-if");

                                if (game.Board.Territories[g.TabIndex].Owner != null)
                                {
                                    Defender = game.Board.Territories[g.TabIndex].Owner;
                                    //MessageBox.Show("made it in the first if of the else if");
                                }                                
                            }
                            else
                            {
                                
                            }
                        } 
                    }
                }
            }

            game.Board.AnnexTerritory(Attacker, Base, Target);
            LoadPieces();
        }

        private void btnInfo_Click(object sender, EventArgs e) 
        {
            try 
            {
                foreach (Control g in this.Controls)
                {
                    if (g is GroupBox) 
                    {
                        foreach (Control c in g.Controls)
                        {
                            if (c is CheckBox)
                            {
                                CheckBox x = (CheckBox) c;
                                if (x.Checked)
                                {
                                    MessageBox.Show(game.Board.Territories[g.TabIndex].PrintInfo());
                                    x.Checked = false;
                                }                                
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
