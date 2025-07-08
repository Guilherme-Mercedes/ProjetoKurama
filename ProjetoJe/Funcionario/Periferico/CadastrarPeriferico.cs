using System;
using System.Windows.Forms;


namespace ProjetoJe
{
    public partial class CadastrarPeriferico : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public CadastrarPeriferico()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Label7_Click(object sender, EventArgs e)
        {
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            CadastroDosPerifericos();
        }
        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Close();
        }
        private void ListaDePerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPerifericos mp = new mostrarPerifericos();
            mp.Show();
            this.Close();
        }
        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Close();
        }
        private void CadastrarPeriferico_Load(object sender, EventArgs e)
        {
        }
        private void Label8_Click(object sender, EventArgs e)
        {
        }
        private void CadastroDosPerifericos()
        {
            if (string.IsNullOrWhiteSpace(tbtipo.Text) ||
                string.IsNullOrWhiteSpace(tbModelo.Text) ||
                string.IsNullOrWhiteSpace(tbMarca.Text) ||
                string.IsNullOrWhiteSpace(tbGarantia.Text) ||
                string.IsNullOrWhiteSpace(tbFabricação.Text) ||
                string.IsNullOrWhiteSpace(tbValorVenda.Text) ||
                string.IsNullOrWhiteSpace(tbValorAluguel.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            // Verifica se os valores de venda e aluguel são números válidos, algo superficial mas resolve.
            // Eu nao quero o valor de volta entao uso o out _ para ignorar o retorno do TryParse.
            if (!decimal.TryParse(tbValorVenda.Text, out _) || !decimal.TryParse(tbValorAluguel.Text, out _))
            {
                MessageBox.Show("Preencha os campos de valor com números válidos.");
                return;
            }

            try
            {
                bool sucesso = DAO.CadastrarPeriferico(tbtipo.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricação.Text, tbValorVenda.Text, tbValorAluguel.Text, "Disponivel");

                if (sucesso)
                {
                    MessageBox.Show("Periférico cadastrado com sucesso!");
                    dataGridView1.DataSource = DAO.SelectPeriferico();
                    Utilitarios.LimparTodosTextBox(this); // Limpa todos os TextBoxes do formulário após o cadastro
                    tbtipo.Focus(); // Foca no campo Tipo após o cadastro

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o periférico. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

