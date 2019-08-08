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
    public partial class FramePRINCIPAL : Form
    {
        public FramePRINCIPAL()
        {
            InitializeComponent();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameCADASTRAR Abrir = new FrameCADASTRAR();
            Abrir.ShowDialog();
        }

        private void containerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrameCONSULTAR Abrir = new FrameCONSULTAR();
            Abrir.ShowDialog();
        }
    }
}
