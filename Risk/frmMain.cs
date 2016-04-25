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
        public Risk game;
        public Color[] EmpireColor = { Color.Red, Color.Blue, Color.Green, Color.Orange, Color.Yellow, Color.Pink };
        // make something where home territory translates to a color
                   
        public frmMain()
        {
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
            InitializeComponent();

            game = new Risk(menu.getNumPlayers());
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
                            pictureBox.BackColor = EmpireColor[game.Board.Territories[g.TabIndex].Owner.HomeTerritory];
                            pictureBox.Location = new Point((g.Width / 2), (g.Height / 2)); ;
                            g.Controls.Add(pictureBox);
                        }
                        if (g.HasChildren)
                        {
                            foreach (Control c in g.Controls)
                            {
                                if (c is PictureBox)
                                {
                                    if (c.BackColor != EmpireColor[game.Board.Territories[g.TabIndex].Owner.HomeTerritory])
                                    {
                                        c.BackColor = EmpireColor[game.Board.Territories[g.TabIndex].Owner.HomeTerritory];
                                    }
                                    if (game.Board.Territories[g.TabIndex].StandingArmy == null)
                                    {
                                        g.Controls.Remove(c);
                                    }                     
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ToggleCheckboxes()
        {
            foreach (Control g in this.Controls)
            {
                if (g is GroupBox)
                {
                    foreach (Control c in g.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox x = (CheckBox)c;
                            x.Checked = false;
                        }
                        if (c is PictureBox)
                        {
                            PictureBox x = (PictureBox)c;
                            if (game.Board.Territories[g.TabIndex].StandingArmy == null)
                            {
                                x.Visible = false;
                            }
                        }
                    }
                }
            }
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
                            if (x.Checked && game.Board.Territories[g.TabIndex].Owner == game.getCurrentPlayer() && game.Board.Territories[g.TabIndex].StandingArmy != null)
                            {
                                Attacker = game.Board.Territories[g.TabIndex].Owner;
                                Base = game.Board.Territories[g.TabIndex];
                                //MessageBox.Show("made it in the first if, " + Attacker.ToString());
                            }
                            else if (x.Checked && (game.Board.Territories[g.TabIndex].Owner != game.getCurrentPlayer() || game.Board.Territories[g.TabIndex].StandingArmy == null))
                            {
                                Target = game.Board.Territories[g.TabIndex];
                                //MessageBox.Show("made it in the beginning of else-if");

                                if (game.Board.Territories[g.TabIndex].Owner != game.getCurrentPlayer())
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
            if (Attacker.Name == null || Base.Owner == null || Target.Name == null || Attacker != game.getCurrentPlayer())
            {
                MessageBox.Show("Invalid Input");
                ToggleCheckboxes();
            }
            else
            {
                if (Target.Owner == Attacker && Target.StandingArmy == null)
                {
                    //MessageBox.Show(Attacker.ToString(), Defender.ToString());
                    game.Board.MoveArmy(Base, Target);
                }
                else if (Target.Owner == null || (Target.Owner != null && Target.StandingArmy == null))
                {
                    //MessageBox.Show(Attacker.ToString(), Defender.ToString());
                    game.Board.AnnexTerritory(Attacker, Base, Target);
                }
                else if (Target.Owner == Defender)
                {
                    //MessageBox.Show(Attacker.Name.ToString(), Defender.Name.ToString());
                    frmBattle battle = new frmBattle();
                    Boolean result = battle.BattleResult();
                    battle.ShowDialog();
                    game.Board.InvadeTerritory(Attacker, Defender, Base, Target, result);
                }
                else
                {

                }
                EndTurn();
            }            
        }

        private void EndTurn()
        {
            game.CheckPlayers();

            if (game.EndGame())
            {
                MessageBox.Show("You Win!");
                Application.Restart();
            }

            game.PlayerTurn();
            LoadPieces();
            ToggleCheckboxes();
            MessageBox.Show("Current Turn: " + game.getCurrentPlayer().Name.ToString());
        }

        private void btnInfo_Click(object sender, EventArgs e) 
        {
            frmStatistics myStat = new frmStatistics(game.Board.Territories);
            myStat.ShowDialog();
        }

        private void btnFortify_Click(object sender, EventArgs e)
        {
            foreach (Control g in this.Controls)
            {
                if (g is GroupBox)
                {
                    foreach (Control c in g.Controls)
                    {
                        if (c is CheckBox)
                        {
                            CheckBox x = (CheckBox)c;
                            if (x.Checked && game.Board.Territories[g.TabIndex].StandingArmy == null)
                            {
                                Army newArmy = new Army();
                                game.getCurrentPlayer().ArmyList.Add(newArmy);
                                game.Board.Territories[g.TabIndex].StandingArmy = newArmy;
                                //x.Checked = false;
                                EndTurn();
                            }
                        }
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }
    }
}
