using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class AlterarPeriferico : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public AlterarPeriferico()
        {
            InitializeComponent();
        }
        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
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
        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
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
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            AlterPerifericos();
        }
        private void AlterPerifericos()
        {
            //o famoso "PREENCHA TODAS AS INFORMAÇÕES" - Guilherme Souza Mercedes 2019 
            //comentario acima de alguem que em 2019 quebrou a cabeça para fazer esse código funcionar
            //e conseguiu, mas tem maneiras melhores de fazer isso
            if (string.IsNullOrWhiteSpace(tbId.Text) ||
                string.IsNullOrWhiteSpace(tbTipoPeriferico.Text) ||
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
            if (!decimal.TryParse(tbValorVenda.Text, out _) || !decimal.TryParse(tbValorAluguel.Text, out _))
            {
                MessageBox.Show("Preencha os campos de valor com números válidos.");
                return;
            }
            try
            {
                bool sucesso = DAO.AlterarPeriferico(tbId.Text, tbTipoPeriferico.Text, tbModelo.Text, tbMarca.Text, tbGarantia.Text, tbFabricação.Text, tbValorVenda.Text, tbValorAluguel.Text);

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