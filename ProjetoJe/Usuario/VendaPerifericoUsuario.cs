using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class VendaPerifericoUsuario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public VendaPerifericoUsuario()
        {
            InitializeComponent();
        }
        private void VendaUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            ComprarPeriferico();
        }
        private void tbIdPeriferico_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorVenda();
        }
        private void btnMostrarPeriferico_Click(object sender, EventArgs e)
        {
            new ListaPerifericoDisponivel().Show();
            this.Close();
        }
        private void btnAlugar_Click(object sender, EventArgs e)
        {
            new AlugarPerifericoUsuario().Show();
            this.Close();
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            new TelaUsuario().Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AtualizarValorVenda()
        {
            if (!Utilitarios.CampoPreenchido(tbIdPeriferico.Text))
            {
                txtVenda.Text = "";
                return;
            }
            try
            {
                string query = "SELECT preco_venda, status FROM perifericos WHERE id_periferico = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, DAO.mConn))
                {
                    cmd.Parameters.AddWithValue("@id", tbIdPeriferico.Text);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string status = reader["status"].ToString();
                            if (status == "Indisponivel")
                            {
                                txtVenda.Text = "Periférico indisponível.";
                                return;
                            }

                            decimal preco = Convert.ToDecimal(reader["preco_venda"]);
                            txtVenda.Text = $"Valor de venda: R$ {preco:F2}";
                        }
                        else
                        {
                            txtVenda.Text = "Periférico não encontrado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtVenda.Text = "Erro ao buscar valor: " + ex.Message;
            }
        }
        private void ComprarPeriferico()
        {
            if (!Utilitarios.TodosPreenchidos(tbNome.Text, tbCpf.Text, tbTelefone.Text, tbDataNascimento.Text, tbIdPeriferico.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            try
            {
                string query = "SELECT preco_venda, status FROM perifericos WHERE id_periferico = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, DAO.mConn))
                {
                    cmd.Parameters.AddWithValue("@id", tbIdPeriferico.Text);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Periférico não encontrado.");
                            return;
                        }

                        string status = reader["status"].ToString();
                        if (status == "Indisponivel")
                        {
                            MessageBox.Show("Este periférico está indisponível.");
                            return;
                        }

                        decimal precoVenda = Convert.ToDecimal(reader["preco_venda"]);
                        reader.Close();

                        string dataVenda = DateTime.Now.ToString();

                        bool sucesso = DAO.VenderPeriferico(tbNome.Text, tbCpf.Text, tbTelefone.Text, tbDataNascimento.Text, precoVenda.ToString("F2"), dataVenda, tbIdPeriferico.Text);

                        if (sucesso)
                        {
                            DAO.AtualizarStatusPeriferico(tbIdPeriferico.Text, "Indisponivel");
                            MessageBox.Show("Compra realizada com sucesso!");

                            dataGridView1.DataSource = DAO.SelectPeriferico();

                            Utilitarios.LimparTodosTextBox(this);
                            tbNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao fazer a compra.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer a compra: " + ex.Message);
            }
        }

        private void tbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }

        private void tbTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }

        private void tbIdPeriferico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }
    }
}