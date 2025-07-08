using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class VendaPerifericoUsuario : Form
    {
        public DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public VendaPerifericoUsuario()
        {
            InitializeComponent();
        }

        private void VendaUsuario_Load(object sender, EventArgs e)
        {
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
            ListaPerifericoDisponivel lpd = new ListaPerifericoDisponivel();
            lpd.Show();
            this.Close();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            AlugarPerifericoUsuario au = new AlugarPerifericoUsuario();
            au.Show();
            this.Close();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            TelaUsua tu = new TelaUsua();
            tu.Show();
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
        private void ComprarPeriferico()
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
    }
}