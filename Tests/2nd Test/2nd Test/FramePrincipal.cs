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

        private void listBoxNOME_DoubleClick(object sender, EventArgs e)
        {
            iselecionado = listBoxNOME.SelectedIndex;
            txtBoxNOME.Text = listBoxNOME.Items[iselecionado].ToString();
            buttonCADASTRAR.Text = "Alterar";
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if(iselecionado > -1)
            {
                listBoxNOME.Items[iselecionado] = txtBoxNOME.Text;
                Ordenar();
                txtBoxNOME.Text = string.Empty;
                iselecionado = -1;
                buttonCADASTRAR.Text = "Cadastrar";
                return;
            }
            listBoxNOME.Items.Add(txtBoxNOME.Text);
            Ordenar();
            txtBoxNOME.Text = string.Empty;
        }

        private void Ordenar()
        {
            ListBox.ObjectCollection lista = listBoxNOME.Items;
            List<string> listastring = new List<string>();
            foreach (var item in lista)
            {
                listastring.Add(item.ToString());
            }
            listastring = (from s in listastring select s).OrderBy(x => x).ToList();
            listBoxNOME.Items.Clear();
            foreach(var item in listastring)
            {
                listBoxNOME.Items.Add(item);
            }
        }
    }
}
