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
    public partial class ListaDeFuncionarios : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public ListaDeFuncionarios()
        {
            InitializeComponent();
        }

        private void ListadeFuncionarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectLogin();
        }
        //botoes de ações
        //por sinal esses botões poderiam ser feitos com o menu strip, na epoca provavelmente eu achei conceito usar botoes enormes 
        //a nomeclatura é algo que priorizei, vi que a comunidade usa em botoes o camelCase
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario ad = new AdicionarFuncionario();
            ad.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarFuncionario af = new AlterarFuncionario();
            af.Show();
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverCadastro rc = new RemoverCadastro();
            rc.Show();
            this.Close();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
