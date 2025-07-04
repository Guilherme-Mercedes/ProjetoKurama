using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAOMysql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class atualizarFuncionario : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public atualizarFuncionario()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectLogin();
        }

        private void alterarFuncionario()
        {
            if (tbsenha.Text.Equals(tbsenha2.Text))
            {
                if (DAO.mConn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexão Ok");

                    DAO.sql = "UPDATE loginfuncionario SET nome = @nome, cpf = @cpf, data_nascimento = @nascimento, usuario = @usuario, senha = @senha WHERE id_func = @id ";
                    MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                    commS.Parameters.AddWithValue("@id", tbid.Text);
                    commS.Parameters.AddWithValue("@nome", tbnome.Text);
                    commS.Parameters.AddWithValue("@cpf", tbcpf.Text);
                    commS.Parameters.AddWithValue("@nascimento", tbnascimento.Text);
                    commS.Parameters.AddWithValue("@usuario", tbusuario.Text);
                    commS.Parameters.AddWithValue("@senha", tbsenha.Text);

                    //o famoso "PREENCHA TODAS AS INFORMAÇÕES"
                    if ((tbnome.Text == "") || (tbcpf.Text == null) || (tbnascimento.Text == "") || (tbusuario.Text == "") || (tbsenha.Text == ""))
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
                                MessageBox.Show("Cadastrado Atualizado");
                                dataGridView1.DataSource = DAO.selectLogin();
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

                        tbsenha2.Text = "";
                        tbusuario.Text = "";
                        tbsenha.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("erro");
                }

            }
            else
            {
                MessageBox.Show("As senhas digitas são diferentes");
                tbsenha2.Text = "";
                tbsenha.Text = "";
            }
        }

        private void RemoverCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Hide();
        }

        private void AdicionarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario af = new AdicionarFuncionario();
            af.Show();
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

        private void Btenviar_Click(object sender, EventArgs e)
        {
            alterarFuncionario();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void ListaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios lf = new ListaDeFuncionarios();
            lf.Show();
            this.Hide();
        }
    }
}
