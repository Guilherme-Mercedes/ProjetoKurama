//OK
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class ListaDeFuncionarios : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public ListaDeFuncionarios()
        {
            InitializeComponent();
        }
        private void ListadeFuncionarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectLogin();
        }
        //botoes de ações
        //por sinal esses botões poderiam ser feitos com o menu strip, na epoca provavelmente eu achei conceito usar botoes enormes 
        //a nomeclatura é algo que priorizei, vi que a comunidade usa em botoes o camelCase
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new AdicionarFuncionario().Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new AlterarFuncionario().Show();
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            new RemoverCadastroFuncionario().Show();
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

    }
}
