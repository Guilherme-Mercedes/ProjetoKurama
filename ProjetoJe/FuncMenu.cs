//ALTERAR
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class FuncMenu : Form
    {
        

        public FuncMenu()
        {
            InitializeComponent();
        }

        private void FuncMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btvoltarmenu_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void AdicionarCadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AdicionarFuncionario af = new AdicionarFuncionario();
            af.Show();
            this.Hide();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AlterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizarFuncionario af = new atualizarFuncionario();
            af.Show();
            this.Hide();
        }

        private void MostrarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios ifu = new ListaDeFuncionarios();
            ifu.Show();
            this.Hide();
        }

        private void RemoverCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Hide();
        }

        private void CadastrarPerifericoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Hide();
        }

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Hide();
        }

        private void MostrarPerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPerifericos mp = new mostrarPerifericos();
            mp.Show();
            this.Hide();
        }

        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Hide();
        }

        private void Btalugar_Click(object sender, EventArgs e)
        {
            realizarAluguel ra = new realizarAluguel();
            ra.Show();
            this.Hide();
        }

        private void Btvender_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Hide();
        }

        private void Btmostrar_Click(object sender, EventArgs e)
        {
            alugueiVendas av = new alugueiVendas();
            av.Show();
            this.Hide();
        }

        private void btremover_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Hide();
        }

        private void CadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
