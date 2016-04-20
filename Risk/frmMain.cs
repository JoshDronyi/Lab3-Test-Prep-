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
        Risk game = new Risk(2);
                   
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void gpxNAmerica_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuPlayerMoves_Opening(object sender, CancelEventArgs e)
        {

        }

        private void attackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if 
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // selected groupbox -> selected territory -> print info method
            MessageBox.Show(e.GetType().ToString());
            MessageBox.Show(sender.GetType().ToString());
        }
    }
}
