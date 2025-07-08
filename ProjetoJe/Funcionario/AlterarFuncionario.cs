//ALTERAR
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class AlterarFuncionario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public AlterarFuncionario()
        {
            InitializeComponent();
        }
        private void AtualizarFuncionario_Load(object sender, EventArgs e)
        {
        }
        private void Tbid_TextChanged(object sender, EventArgs e)
        {
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario();
        }
        private void adicionarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario af = new AdicionarFuncionario();
            af.Show();
            this.Close();
        }
        private void listaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios lf = new ListaDeFuncionarios();
            lf.Show();
            this.Close();
        }
        private void removerCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverCadastro rc = new RemoverCadastro();
            rc.Show();
            this.Close();
        }
        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void AtualizarFuncionario()
        {
            if (tbSenha.Text != tbSenha2.Text)
            {
                MessageBox.Show("As senhas digitadas são diferentes");
                tbSenha2.Clear(); // Limpa o campo de confirmação de senha apenas
                tbSenha2.Focus(); // Foca no campo de confirmacao de senha para o usuário corrigir
                return;
            }
            if (string.IsNullOrWhiteSpace(tbNome.Text) || string.IsNullOrWhiteSpace(tbCpf.Text) ||
                string.IsNullOrWhiteSpace(tbNascimento.Text) || string.IsNullOrWhiteSpace(tbUsuario.Text) ||
                string.IsNullOrWhiteSpace(tbSenha.Text) || string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Não deixe nenhum espaço em branco!");
                return;
            }
            try
            {
                bool sucesso = DAO.AlterarFuncionario(tbId.Text, tbNome.Text, tbCpf.Text, tbNascimento.Text, tbUsuario.Text, tbSenha.Text);

                if (sucesso)
                {
                    MessageBox.Show($"Cadastro do Funcionário: {tbNome.Text} alterado com sucesso!");
                    dataGridView1.DataSource = DAO.SelectLogin();
                    Utilitarios.LimparTodosTextBox(this); // Limpa todos os TextBoxes do formulário após o cadastro
                    tbNome.Focus(); // Foca no campo de nome
                }
                else
                {
                    MessageBox.Show("Erro ao alterar. Tente novamente.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}
