using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class TelaInicialFuncionario : Form
    {

        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();


        public TelaInicialFuncionario()
        {
            InitializeComponent();

        }

        private void TelaFunc_Load(object sender, EventArgs e)
        {
            
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            MainForm sair = new MainForm();
            sair.Show();
            this.Close();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            Logar();
        }

        private void Logar()
        {
            string usuario = txbUsuario.Text.Trim();
            string senha = txbSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Informe o usuário e a senha.");
                return;
            }

            try
            {
                if (DAO.FazerLogin(usuario, senha))
                {
                    MessageBox.Show("Funcionário logado com sucesso!");
                    MenuFuncionario menu = new MenuFuncionario();
                    menu.Show();
                    this.Close();
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
    }
}
