using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKK_20241219
{
    public partial class frmfo : Form
    {
        public frmfo()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vásárlástToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvasarlas ujvasarlas = new frmvasarlas();
            ujvasarlas.ShowDialog();
        }
    }
}
