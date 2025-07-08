//ALTERAR
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
    public partial class RemoverCadastroFuncionario : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public RemoverCadastroFuncionario()
        {
            InitializeComponent();

        }
        private void RemoverCadastro_Load(object sender, EventArgs e)
        {
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverFuncionario();
        }
        private void btnAdicionarCadastro_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario ad = new AdicionarFuncionario();
            ad.Show();
            this.Close();
        }
        private void btnAlterarCadastro_Click(object sender, EventArgs e)
        {
            AlterarFuncionario af = new AlterarFuncionario();
            af.Show();
            this.Close();
        }

        private void btnListaFuncionarios_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios lf = new ListaDeFuncionarios();
            lf.Show();
            this.Close();
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

        private void RemoverFuncionario()
        {
            string id = tbid.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
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
