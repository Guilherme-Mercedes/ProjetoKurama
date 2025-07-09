using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class ListaPerifericoDisponivel : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public ListaPerifericoDisponivel()
        {
            InitializeComponent();
        }
        private void listadeperifericoDisponivel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        //nova tela de aluguel de perifericos
        private void alugarPeriferico_Click(object sender, EventArgs e)
        {
            new AlugarPerifericoUsuario().Show();
            this.Close();
        }
        private void comprarPeriferico_Click(object sender, EventArgs e)
        {
            new VendaPerifericoUsuario().Show();
            this.Close();
        }
        private void voltarMenu_Click(object sender, EventArgs e)
        {
            new TelaUsuario().Show();
            this.Close();
        }
        private void sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
