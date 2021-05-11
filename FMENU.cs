using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE4QLHANGHOA_ADO
{
    public partial class FMENU : Form
    {
        public FMENU()
        {
            InitializeComponent();
        }

        private void danhSáchMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCONNECT fConnect = new FCONNECT();
            fConnect.MdiParent = this;
            fConnect.Show();
        }

        private void nhậpMặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FNHAPMATHANG fNHAPMATHANG = new FNHAPMATHANG();
            fNHAPMATHANG.Show(); 
        }
    }
}
