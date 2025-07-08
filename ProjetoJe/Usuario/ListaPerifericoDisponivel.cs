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
    public partial class ListaPerifericoDisponivel : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public ListaPerifericoDisponivel()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.SelectPeriferico();
        }
        private void listadeperifericoDisponivel_Load(object sender, EventArgs e)
        {
        }
        //nova tela de aluguel de perifericos
        private void alugarPeriferico_Click(object sender, EventArgs e)
        {
            AlugarPerifericoUsuario au = new AlugarPerifericoUsuario();
            au.Show();
            this.Close();
        }
        private void comprarPeriferico_Click(object sender, EventArgs e)
        {
            vendaUsuario vu = new vendaUsuario();
            vu.Show();
            this.Close();
        }
        private void voltarMenu_Click(object sender, EventArgs e)
        {
            TelaUsua tu = new TelaUsua();
            tu.Show();
            this.Close();
        }
        private void sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
