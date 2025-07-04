using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAOMysql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class AdicionarFuncionario : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public AdicionarFuncionario()
        {
            InitializeComponent();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Btenviar_Click(object sender, EventArgs e)
        {
            AddFuncionario();
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
            this.Hide();
        }
        private void RemoverCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Hide();
        }
        private void ListaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadeFuncionarios lf = new listadeFuncionarios();
            lf.Show();
            this.Hide();
        }
        // funcao para adicionar um novo funcionário
        // futuramente posso separar em outra classe
        private void AddFuncionario()
        {
            if (tbsenha.Text != tbsenha2.Text)
            {
                MessageBox.Show("As senhas digitadas são diferentes");
                tbsenha2.Clear();
                tbsenha.Clear();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbnome.Text) || string.IsNullOrWhiteSpace(tbcpf.Text) ||
                string.IsNullOrWhiteSpace(tbnascimento.Text) || string.IsNullOrWhiteSpace(tbusuario.Text) ||
                string.IsNullOrWhiteSpace(tbsenha.Text))
            {
                MessageBox.Show("Não deixe nenhum espaço em branco!");
                return;
            }
            try
            {
                bool sucesso = DAO.InserirFuncionario(tbnome.Text, tbcpf.Text, tbnascimento.Text, tbusuario.Text, tbsenha.Text);

                if (sucesso)
                {
                    MessageBox.Show("Funcionário cadastrado!");
                    dataGridView1.DataSource = DAO.SelectLogin();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar. Tente novamente.");
                }
                // Limpa os campos
                tbsenha2.Clear();
                tbusuario.Clear();
                tbsenha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

    }
}
