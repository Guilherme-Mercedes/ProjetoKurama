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
    public partial class listadeperifericoDisponivel : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public listadeperifericoDisponivel()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectPeriferico();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TelaUsua tu = new TelaUsua();
            tu.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            aluguelUsuario au = new aluguelUsuario();
            au.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vendaUsuario vu = new vendaUsuario();
            vu.Show();
            this.Hide();
        }

        private void listadeperifericoDisponivel_Load(object sender, EventArgs e)
        {

        }
    }
}
