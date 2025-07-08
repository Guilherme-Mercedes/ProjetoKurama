using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class TabelaAluguelVendas : Form
    {

        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public TabelaAluguelVendas()
        {
            InitializeComponent();
            dataGridView2.DataSource = DAO.SelectAlugueis();// Carrega os dados de Alugueis no DataGridView2
            dataGridView1.DataSource = DAO.SelectVendas();// Carrega os dados de Vendas no DataGridView1
        }
        //Novas funções para os botões de realizar aluguel e venda
        private void realizarAluguel_Click(object sender, EventArgs e)
        {
            RealizarAluguel ra = new RealizarAluguel();
            ra.Show();
            this.Close();
        }
        private void realizarVenda_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Close();
        }

        private void removerAluguel_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
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
    }
}
