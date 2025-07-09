//ok
using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class ListaPerifericosFuncionario : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public ListaPerifericosFuncionario()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void mostrarPerifericos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            new MenuFuncionario().Show();
            this.Close();
        }
        private void btnRemoverPeriferico_Click(object sender, EventArgs e)
        {
            new RemoverPeriferico().Show();
            this.Close();
        }
        private void btnAlterarPeriferico_Click(object sender, EventArgs e)
        {
            new AlterarPeriferico().Show();
            this.Close();
        }
        private void btnCadastrarPeriferico_Click(object sender, EventArgs e)
        {
            new CadastrarPeriferico().Show();
            this.Close();
        }
    }
}
