using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class RealizarVenda : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public RealizarVenda()
        {
            InitializeComponent();
        }
        private void Tbidperiferico_TextChanged(object sender, EventArgs e)
        {
            AtualizarValorVenda();
        }
        private void RealizarVenda_Load(object sender, EventArgs e)
        {

        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            RealizaVenda();
        }

        private void btnRealizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarAluguel ra = new RealizarAluguel();
            ra.Show();
            this.Close();
        }

        private void btnRemoverAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Close();
        }

        private void btnMostrarAlugueisEVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaAluguelVendas av = new TabelaAluguelVendas();
            av.Show();
            this.Close();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void AtualizarValorVenda()
        {
            if (string.IsNullOrWhiteSpace(tbIdPeriferico.Text))
            {
                txtVenda.Text = "";
                return;
            }
            try
            {
                string query = "SELECT preço_venda, status FROM perifericos WHERE id_peri = @id";
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

                            double preco = Convert.ToDouble(reader["preço_venda"]);
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
        private void RealizaVenda()
        {
            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
                string.IsNullOrWhiteSpace(tbCpf.Text) ||
                string.IsNullOrWhiteSpace(tbTelefone.Text) ||
                string.IsNullOrWhiteSpace(tbDataNascimento.Text) ||
                string.IsNullOrWhiteSpace(tbIdPeriferico.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }

            try
            {
                string query = "SELECT preço_venda, status FROM perifericos WHERE id_peri = @id";
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

                        double precoVenda = Convert.ToDouble(reader["preço_venda"]);
                        reader.Close();

                        string dataVenda = DateTime.Now.ToString();

                        bool sucesso = DAO.VenderPeriferico(tbNome.Text, tbCpf.Text, tbTelefone.Text, tbDataNascimento.Text, precoVenda.ToString("F2"), dataVenda, tbIdPeriferico.Text);

                        if (sucesso)
                        {
                            DAO.AtualizarStatusPeriferico(tbIdPeriferico.Text, "Indisponivel");
                            MessageBox.Show("Venda realizada com sucesso!");

                            dataGridView1.DataSource = DAO.SelectPeriferico();
                            dataGridView2.DataSource = DAO.SelectVendas();

                            Utilitarios.LimparTodosTextBox(this);
                            tbNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao registrar a venda.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a venda: " + ex.Message);
            }
        }
    }
}
