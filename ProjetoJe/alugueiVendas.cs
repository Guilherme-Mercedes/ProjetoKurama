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
    public partial class alugueiVendas : Form
    {

        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public alugueiVendas()
        {
            InitializeComponent();
            dataGridView2.DataSource = DAO.selectAlugueis();
            dataGridView1.DataSource = DAO.selectVendas();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            realizarAluguel ra = new realizarAluguel();
            ra.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Hide();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AlugueiVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
