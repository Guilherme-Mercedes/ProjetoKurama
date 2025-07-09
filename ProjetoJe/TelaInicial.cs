//ok
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class TelaInicial : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public TelaInicial()
        {
            InitializeComponent();
        }
        private void TelaFunc_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin(object sender, EventArgs e)
        {
            Logar();
        }
        private void Logar()
        {
            string usuario = txbUsuario.Text.Trim();
            string senha = txbSenha.Text.Trim();

            if (!Utilitarios.CampoPreenchido(usuario) || !Utilitarios.CampoPreenchido(senha))
            {
                MessageBox.Show("Informe o usuário e a senha.");
                return;
            }
            try
            {
                if (DAO.FazerLogin(usuario, senha))
                {
                    MessageBox.Show("Funcionário logado com sucesso!");
                    new MenuFuncionario().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar fazer login: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
