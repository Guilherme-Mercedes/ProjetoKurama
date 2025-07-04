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
    public partial class cadastrarPeriferico : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();


        public cadastrarPeriferico()
        {
            InitializeComponent();
        }

        private void cadastrarPerifericos()
        {

            if (DAO.mConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão Ok");

                DAO.sql = "insert into perifericos(nome, modelo, marca, garantia_venda, ano_fabricação, preço_venda, preço_aluguel, status) values (@nome, @modelo, @marca, @garantia, @ano, @venda, @aluguel, @status)";
                MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                commS.Parameters.AddWithValue("@nome", tbtipo.Text);
                commS.Parameters.AddWithValue("@modelo", tbmodelo.Text);
                commS.Parameters.AddWithValue("@marca", tbmarca.Text);
                commS.Parameters.AddWithValue("@garantia", tbgarantia.Text);
                commS.Parameters.AddWithValue("@ano", tbfabricação.Text);
                commS.Parameters.AddWithValue("@venda", tbvvenda.Text);
                commS.Parameters.AddWithValue("@aluguel", tbvaluguel.Text);
                commS.Parameters.AddWithValue("@status", "Disponivel");

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
                            MessageBox.Show("Periferico Cadastrado");


                            dataGridView1.DataSource = DAO.selectPeriferico();
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
            else
            {
                MessageBox.Show("erro");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Btenviar_Click(object sender, EventArgs e)
        {
            cadastrarPerifericos();
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

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterarPeriferico ap = new alterarPeriferico();
            ap.Show();
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

        private void CadastrarPeriferico_Load(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}

