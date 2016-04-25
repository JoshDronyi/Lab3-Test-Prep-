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
    public partial class frmStatistics : Form
    {
        List<Territory> myT;

        public frmStatistics(List<Territory> t)
        {
            InitializeComponent();
            this.myT = t;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myT.Count; i++)
            {
                lblInfo.Text += myT[i].Name.ToString() + "\n" + myT[i].Owner.Name.ToString() + "\n \n";
            }
        }
    }
}
