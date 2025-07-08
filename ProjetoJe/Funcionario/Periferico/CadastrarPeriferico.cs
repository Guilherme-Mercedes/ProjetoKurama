//ok
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
            new MenuFuncionario().Show();
            this.Close();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarPeriferico().Show();
            this.Close();
        }
        private void ListaDePerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaPerifericosFuncionario().Show();
            this.Close();
        }
        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoverPeriferico().Show();
            this.Close();
        }
        private void CadastrarPeriferico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void Label8_Click(object sender, EventArgs e)
        {
        }
        private void CadastroDosPerifericos()
        {
            if (!Utilitarios.TodosPreenchidos(tbTipo.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricacao.Text, tbValorVenda.Text, tbValorAluguel.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            // Verifica se os valores de venda e aluguel são números válidos, algo superficial mas resolve.
            if (!Utilitarios.CampoDecimalValido(tbValorVenda.Text) || !Utilitarios.CampoDecimalValido(tbValorAluguel.Text))
            {
                MessageBox.Show("Preencha os campos de valor com números válidos. exemplo: 200.50");
                return;
            }
            try
            {
                decimal precoVenda = decimal.Parse(tbValorVenda.Text);//Converte o valor de venda para decimal
                decimal precoAluguel = decimal.Parse(tbValorAluguel.Text);//Converte o aluguel de venda para decimal
                bool sucesso = DAO.CadastrarPeriferico(tbTipo.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricacao.Text, precoVenda.ToString("F2"), precoAluguel.ToString("F2"), "Disponivel");

                if (sucesso)
                {
                    MessageBox.Show("Periférico cadastrado com sucesso!");
                    dataGridView1.DataSource = DAO.SelectPeriferico();
                    Utilitarios.LimparTodosTextBox(this); // Limpa todos os TextBoxes do formulário após o cadastro
                    tbTipo.Focus(); // Foca no campo Tipo após o cadastro
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

