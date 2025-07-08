
using System;
using System.Windows.Forms;

namespace ProjetoJe
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

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }

        private void btnRemoverPeriferico_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Close();
        }

        private void btnAlterarPeriferico_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Close();
        }

        private void btnCadastrarPeriferico_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Close();
        }
    }
}
