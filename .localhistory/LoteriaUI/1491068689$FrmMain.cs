using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteriaUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

      
        private void euromillonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEuromillones(this) { WindowState = FormWindowState.Maximized };
            frm.Show();
        }

        private void euromillonesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
