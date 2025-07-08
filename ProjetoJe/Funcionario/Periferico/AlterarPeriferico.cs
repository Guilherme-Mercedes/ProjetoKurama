//ok
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class AlterarPeriferico : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public AlterarPeriferico()
        {
            InitializeComponent();
        }
        private void tbId_TextChanged(object sender, EventArgs e)
        {
        }
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }
        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastrarPeriferico().Show();
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
        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuFuncionario().Show();
            this.Close();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void AlterarPeriferico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            AlterPerifericos();
        }
        private void AlterPerifericos()
        {
            //O famoso "PREENCHA TODAS AS INFORMAÇÕES" - Guilherme Souza Mercedes 2019 
            //Comentario acima de alguem que em 2019 quebrou a cabeça para fazer esse código funcionar
            //e conseguiu, mas tem maneiras melhores de fazer isso
            //Consegui adicionar o método Utilitarios.TodosPreenchidos para verificar se todos os campos estão preenchidos
            if (!Utilitarios.TodosPreenchidos(tbId.Text, tbTipoPeriferico.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricacao.Text, tbValorVenda.Text, tbValorAluguel.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            if (!Utilitarios.CampoDecimalValido(tbValorVenda.Text) || !Utilitarios.CampoDecimalValido(tbValorAluguel.Text))
            {
                MessageBox.Show("Preencha os campos de valor com números válidos. exemplo: 200.50");
                return;
            }
            try
            {
                decimal precoVenda = decimal.Parse(tbValorVenda.Text);//Converte o valor de venda para decimal
                decimal precoAluguel = decimal.Parse(tbValorAluguel.Text);//Converte o aluguel de venda para decimal
                bool sucesso = DAO.AlterarPeriferico(tbId.Text, tbTipoPeriferico.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricacao.Text, precoVenda.ToString("F2"),precoAluguel.ToString("F2"));

                if (sucesso)
                {
                    MessageBox.Show("Periférico alterado com sucesso!");
                    dataGridView1.DataSource = DAO.SelectPeriferico(); // Atualiza o DataGridView com os dados mais recentes
                    Utilitarios.LimparTodosTextBox(this); // Limpa todos os TextBoxes do formulário após o cadastro
                    tbId.Focus(); // Foca no campo ID após a alteração
                }
                else
                {
                    MessageBox.Show("Erro ao alterar o periférico. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

    }
}