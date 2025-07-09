//Essa classe o usuario conseguia ver informaões de alugueis realizados, informacoes que nao poderia ter acesso
//ok
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class AlugarPerifericoUsuario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public AlugarPerifericoUsuario()
        {
            InitializeComponent();
        }
        private void AluguelUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void tbDiaAluguel_TextChanged(object sender, EventArgs e)
        {
            AtualizarResumoAluguel();
        }
        private void tbIdPeriferico_TextChanged(object sender, EventArgs e)
        {
            AtualizarResumoAluguel();
        }
        private void ReaalizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void btComprarPeriferico_Click(object sender, EventArgs e)
        {
            new VendaPerifericoUsuario().Show();
            this.Close();
        }
        private void btnMostrarPeriferico_Click(object sender, EventArgs e)
        {
            new ListaPerifericoDisponivel().Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            new TelaUsuario().Show();
            this.Close();
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            AlugarUsuario();
        }
        //Funcoes
        private (decimal valorTotal, string dataDevolucao) CalcularValorAluguel(int dias, decimal precoDiario)
        {
            decimal total = dias * precoDiario;
            string data = DateTime.Now.AddDays(dias).ToString("dd/MM/yyyy");
            return (total, data);
        }

        //Evento para atualizar o resumo do aluguel quando o usuário digita o número de dias ou o ID do periférico
        private void AtualizarResumoAluguel()
        {
            if (!Utilitarios.TodosPreenchidos(tbDiaAluguel.Text, tbIdPeriferico.Text))
            {
                labelResposta.Text = "";
                return;
            }
            if (!Utilitarios.CampoInteiroValido(tbDiaAluguel.Text) || int.Parse(tbDiaAluguel.Text) <= 0)
            {
                labelResposta.Text = "Informe um número válido de dias.";
                return;
            }
            try
            {
                int dias = int.Parse(tbDiaAluguel.Text);
                string query = "SELECT preco_aluguel FROM perifericos WHERE id_perifericos = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, DAO.mConn))
                {
                    cmd.Parameters.AddWithValue("@id", tbIdPeriferico.Text);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal precoDiario = Convert.ToDecimal(reader["preco_aluguel"]);
                            var (valorTotal, dataDevolucao) = CalcularValorAluguel(dias, precoDiario);

                            labelResposta.Text = $"Valor total: R$ {valorTotal:F2} | Devolução: {dataDevolucao}";
                        }
                        else
                        {
                            labelResposta.Text = "Periférico não encontrado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                labelResposta.Text = "Erro: " + ex.Message;
            }
        }
        private void AlugarUsuario()
        {
            // Validação dos campos
            if (!Utilitarios.TodosPreenchidos(tbNome.Text, tbCpf.Text, tbTelefone.Text, tbDataNascimento.Text, tbDiaAluguel.Text, tbIdPeriferico.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            try
            {
                //Buscar o preço do aluguel do periférico
                string query = "SELECT preco_aluguel, status FROM perifericos WHERE id_periferico = @id";
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
                        decimal precoDiario = Convert.ToDecimal(reader["preco_aluguel"]);
                        reader.Close();

                        //Calcular valor total e data de devolução
                        int dias = int.Parse(tbDiaAluguel.Text);
                        var (valorTotal, dataDevolucao) = CalcularValorAluguel(dias, precoDiario);
                        string horarioAgora = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                        //Realizar o aluguel
                        bool sucesso = DAO.AlugarPeriferico(tbNome.Text, tbCpf.Text, tbTelefone.Text, tbDataNascimento.Text, tbDiaAluguel.Text,
                                                            valorTotal.ToString("F2"), dataDevolucao, horarioAgora, tbIdPeriferico.Text);

                        //Atualizar status e exibir resultado
                        if (sucesso)
                        {
                            DAO.AtualizarStatusPeriferico(tbIdPeriferico.Text, "Indisponivel");
                            MessageBox.Show("Aluguel realizado com sucesso!");

                            dataGridView1.DataSource = DAO.SelectPeriferico();

                            Utilitarios.LimparTodosTextBox(this);
                            tbNome.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao realizar o aluguel.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alugar o periférico. Tente novamente: " + ex.Message);
            }
        }
        private void tbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }
        private void tbIdPeriferico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }
    }
}
