using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class CadastrarPeriferico : Utilitarios
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
        private void Btenviar_Click(object sender, EventArgs e)
        {
            CadastroDosPerifericos();
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
        private void CadastroDosPerifericos()
        {
            if (string.IsNullOrWhiteSpace(tbtipo.Text) ||
                string.IsNullOrWhiteSpace(tbmodelo.Text) ||
                string.IsNullOrWhiteSpace(tbmarca.Text) ||
                string.IsNullOrWhiteSpace(tbgarantia.Text) ||
                string.IsNullOrWhiteSpace(tbfabricação.Text) ||
                string.IsNullOrWhiteSpace(tbvvenda.Text) ||
                string.IsNullOrWhiteSpace(tbvaluguel.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar.");
                return;
            }
            // Verifica se os valores de venda e aluguel são números válidos, algo superficial mas resolve.
            // Eu nao quero o valor de volta entao uso o out _ para ignorar o retorno do TryParse.
            if (!decimal.TryParse(tbvvenda.Text, out _) || !decimal.TryParse(tbvaluguel.Text, out _))
            {
                MessageBox.Show("Preencha os campos de valor com números válidos.");
                return;
            }

            try
            {
                bool sucesso = DAO.InserirPeriferico(tbtipo.Text, tbmodelo.Text, tbmarca.Text, tbgarantia.Text, tbfabricação.Text, tbvvenda.Text, tbvaluguel.Text);

                if (sucesso)
                {
                    MessageBox.Show("Periférico cadastrado com sucesso!");
                    dataGridView1.DataSource = DAO.SelectPeriferico();

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

