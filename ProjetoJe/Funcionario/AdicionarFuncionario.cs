using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class AdicionarFuncionario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public AdicionarFuncionario()
        {
            InitializeComponent();
        }
        private void btEnviar_Click(object sender, EventArgs e)
        {
            AddFuncionario();
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
        private void Label3_Click(object sender, EventArgs e)
        {
        }
        private void AdicionarFuncionario_Load(object sender, EventArgs e)
        {
        }
        private void AtualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizarFuncionario af = new atualizarFuncionario();
            af.Show();
            this.Close();
        }
        private void RemoverCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Close();
        }
        private void ListaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios lf = new ListaDeFuncionarios();
            lf.Show();
            this.Close();
        }
        // funcao para adicionar um novo funcionário
        // futuramente posso separar em outra classe
        private void AddFuncionario()
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
                string.IsNullOrWhiteSpace(tbSenha.Text))
            {
                MessageBox.Show("Não deixe nenhum espaço em branco!");
                return;
            }
            try
            {
                bool sucesso = DAO.InserirFuncionario(tbNome.Text, tbCpf.Text, tbNascimento.Text, tbUsuario.Text, tbSenha.Text);

                if (sucesso)
                {
                    MessageBox.Show("Funcionário cadastrado!");
                    dataGridView1.DataSource = DAO.SelectLogin();
                    Utilitarios.LimparTodosTextBox(this); // Limpa todos os TextBoxes do formulário após o cadastro
                    tbNome.Focus(); // Foca no campo de nome
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar. Tente novamente.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
