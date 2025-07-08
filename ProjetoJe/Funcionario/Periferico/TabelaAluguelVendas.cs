//ok
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class TabelaAluguelVendas : Form
    {

        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public TabelaAluguelVendas()
        {
            InitializeComponent();
            dataGridView2.DataSource = DAO.SelectAlugueis();// Carrega os dados de Alugueis no DataGridView2
            dataGridView1.DataSource = DAO.SelectVendas();// Carrega os dados de Vendas no DataGridView1
        }
        //Novas funções para os botões de realizar aluguel e venda
        private void realizarAluguel_Click(object sender, EventArgs e)
        {
            new RealizarAluguel().Show();
            this.Close();
        }
        private void realizarVenda_Click(object sender, EventArgs e)
        {
            new RealizarVenda().Show();
            this.Close();
        }

        private void removerAluguel_Click(object sender, EventArgs e)
        {
            new RemoverAluguel().Show();
            this.Close();
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuFuncionario().Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TabelaAluguelVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
