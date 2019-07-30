using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_Test
{
    public partial class FramePrincipal : Form
    {
        public FramePrincipal()
        {
            InitializeComponent();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
