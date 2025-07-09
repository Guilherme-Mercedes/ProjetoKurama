//ok
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class RemoverPeriferico : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public RemoverPeriferico()
        {
            InitializeComponent();
        }
        private void RemoverPeriferico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void btnListaPeriferico_Click(object sender, EventArgs e)
        {
            new ListaPerifericosFuncionario().Show();
            this.Hide();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverPerifericos();
        }
        private void btnCadastrarPeriferico_Click(object sender, EventArgs e)
        {
            new CadastrarPeriferico().Show();
            this.Hide();
        }
        private void btnAlterarPeriferico_Click(object sender, EventArgs e)
        {
            new AlterarPeriferico().Show();
            this.Hide();
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            new MenuFuncionario().Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void RemoverPerifericos()
        {
            string id = tbIdPeriferico.Text.Trim();

            if (!Utilitarios.CampoPreenchido(id))
            {
                MessageBox.Show("O campo ID está em branco. Por favor, preencha.");
                return;
            }
            try
            {
                bool sucesso = DAO.RemoverPerifericoPorId(id);
                if (sucesso)
                {
                    MessageBox.Show("Periférico removido com sucesso.");
                    dataGridView1.DataSource = DAO.SelectPeriferico();
                }
                else
                {
                    MessageBox.Show("Nenhum periférico foi removido. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover periférico: " + ex.Message);
            }
        }
        private void tbIdPeriferico_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilitarios.BloquearCaractere(e);
        }
    }
}
