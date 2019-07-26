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
        private int iselecionado;
        public FramePrincipal()
        {
            iselecionado = -1;
            InitializeComponent();
        }

        private void buttonPRÓXIMO_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonVOLTAR_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNOME_Validating(object sender, CancelEventArgs e)
        {
            if(txtBoxNOME.Text.Length < 3)
            {
                MessageBox.Show("Nome Inválido");
            }
        }
    }
}
