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
    public partial class TabelaAluguelVendas : Form
    {

        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public TabelaAluguelVendas()
        {
            InitializeComponent();
            dataGridView2.DataSource = DAO.SelectAlugueis();// Carrega os dados de Alugueis no DataGridView2
            dataGridView1.DataSource = DAO.SelectVendas();// Carrega os dados de Vendas no DataGridView1
        }
        private void Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnAluguel_Click(object sender, EventArgs e)
        {
            realizarAluguel ra = new realizarAluguel();
            ra.Show();
            this.Close();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Close();
        }

        private void btnRemoverAluguel_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Close();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Close();
        }
    }
}
