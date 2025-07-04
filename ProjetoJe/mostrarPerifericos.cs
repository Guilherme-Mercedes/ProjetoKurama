//ALTERAR
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
    public partial class mostrarPerifericos : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public mostrarPerifericos()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectPeriferico();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarPerifericos_Load(object sender, EventArgs e)
        {

        }
    }
}
