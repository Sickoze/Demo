using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace _2nd_Test
{
    public partial class FrameCADASTRAR : Form
    {
        private int index = -1;
        public FrameCADASTRAR()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string Connection = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
            MySqlConnection Conexão = new MySqlConnection(Connection);

            try
            {
                Conexão.Open();
                MySqlCommand comando = new MySqlCommand();
                comando = Conexão.CreateCommand();
                comando.CommandText = "INSERT INTO Base(`Proprietário`,`Bar`) VALUES (@varProprietário,@varBar);";
                comando.Parameters.AddWithValue("varProprietário", textBoxPROPRIETÁRIO.Text.Trim());
                comando.Parameters.AddWithValue("varBar", listBoxOPÇÕES.Items[index].ToString() + textBoxBAR.Text.Trim());
                int valorRetorno = comando.ExecuteNonQuery();
                if (valorRetorno < 1)
                {
                    MessageBox.Show("Erro ao Inserir.");
                }
                else
                    MessageBox.Show("Inserido com sucesso!");
            }
            catch (MySqlException sqle)
            {
                MessageBox.Show("Erro de Acesso ao MySQL: " + sqle.Message, "Erro");
            }
            finally
            {
                Conexão.Close();
            }
        }

        private void listBoxOPÇÕES_Click(object sender, EventArgs e)
        {
            index = listBoxOPÇÕES.SelectedIndex;
        }
    }
}
