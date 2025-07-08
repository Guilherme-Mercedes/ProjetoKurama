using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoJe
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

        }
        private void btnListaPeriferico_Click(object sender, EventArgs e)
        {
            ListaPerifericosFuncionario mp = new ListaPerifericosFuncionario();
            mp.Show();
            this.Hide();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverPerifericos();
        }
        private void btnCadastrarPeriferico_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Hide();
        }
        private void btnAlterarPeriferico_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Hide();
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
        private void RemoverPerifericos()
        {
            string id = tbIdPeriferico.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
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

    }
}
