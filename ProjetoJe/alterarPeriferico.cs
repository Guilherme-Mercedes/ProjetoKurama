using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAOMysql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class alterarPeriferico : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public alterarPeriferico()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }

        private void alterarPerifericos()
        {
            if (DAO.mConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão Ok");

                string query = "UPDATE perifericos SET nome= @nome, modelo= @modelo, marca= @marca, garantia_venda= @garantia, ano_fabricação= @ano, preço_venda= @venda, preço_aluguel= @aluguel WHERE id_peri = @id";
                MySqlCommand commS = new MySqlCommand(query, DAO.mConn);
                commS.Parameters.AddWithValue("@id", tbid.Text);
                commS.Parameters.AddWithValue("@nome", tbtipo.Text);
                commS.Parameters.AddWithValue("@modelo", tbmodelo.Text);
                commS.Parameters.AddWithValue("@marca", tbmarca.Text);
                commS.Parameters.AddWithValue("@garantia", tbgarantia.Text);
                commS.Parameters.AddWithValue("@ano", tbfabricação.Text);
                commS.Parameters.AddWithValue("@venda", tbvvenda.Text);
                commS.Parameters.AddWithValue("@aluguel", tbvaluguel.Text);

                //o famoso "PREENCHA TODAS AS INFORMAÇÕES"
                if ((tbtipo.Text == "") || (tbmodelo.Text == "") || (tbmarca.Text == "") || (tbgarantia.Text == "") || (tbfabricação.Text == "") || (tbvvenda.Text == "") || (tbvaluguel.Text == ""))
                {
                    MessageBox.Show("Não deixe nenhum espaço em branco!");
                }
                else
                {


                    try
                    {
                        var retorno = commS.ExecuteNonQuery();
                        if (retorno == 1)
                        {
                            MessageBox.Show("Cadastrado do Periferico Atualizado");
                            dataGridView1.DataSource = DAO.SelectPeriferico();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro oa inserir, tente novamente...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex.Message.ToString());
                    }



                }
            }
        }

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Hide();
        }

        private void ListaDePerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPerifericos mp = new mostrarPerifericos();
            mp.Show();
            this.Hide();
        }

        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Hide();
        }

        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btenviar_Click(object sender, EventArgs e)
        {
            alterarPerifericos();


        }

        private void AlterarPeriferico_Load(object sender, EventArgs e)
        {

        }
    }
}