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
                
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void DrawObject()
        {
            System.Drawing.Graphics g = this.CreateGraphics();
            // basically this method will check the current object type, then draw it's appropriate shape and model
            // for now, units will be circles, and territories will be squares
        }
    }
}
