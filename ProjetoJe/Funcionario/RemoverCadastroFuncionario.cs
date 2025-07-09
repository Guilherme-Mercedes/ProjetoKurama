//ok
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class RemoverCadastroFuncionario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public RemoverCadastroFuncionario()
        {
            InitializeComponent();
        }
        private void RemoverCadastro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectLogin();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
        }
        private void tbIdRemoverCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se o caractere não for número nem tecla de controle (como backspace), bloqueia
            Utilitarios.BloquearCaractere(e);
        }
        private void btnAdicionarCadastro_Click(object sender, EventArgs e)
        {
            new AdicionarFuncionario().Show();
            this.Close();
        }
        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            new AlterarFuncionario().Show();
            this.Close();
        }

        private void btnListaFuncionarios_Click(object sender, EventArgs e)
        {
            new ListaDeFuncionarios().Show();
            this.Close();
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
        private void RemoverFuncionario()
        {
            string id = tbid.Text.Trim();

            if (!Utilitarios.CampoPreenchido(id))
            {
                MessageBox.Show("O campo ID está em branco. Por favor, preencha.");
                return;
            }
            try
            {
                bool sucesso = DAO.RemoverFuncionarioPorId(id);
                if (sucesso)
                {
                    MessageBox.Show("Funcionário removido com sucesso.");
                    dataGridView1.DataSource = DAO.SelectLogin();
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário foi removido. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover funcionário: " + ex.Message);
            }
        }
    }
}
