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
