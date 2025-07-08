using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }
        private void FuncMenu_Load(object sender, EventArgs e)
        { 
        }
        private void btvoltarmenu_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Close();
        }

        private void AdicionarCadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AdicionarFuncionario af = new AdicionarFuncionario();
            af.Show();
            this.Close();
        }
        private void AlterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFuncionario af = new AlterarFuncionario();
            af.Show();
            this.Close();
        }

        private void MostrarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeFuncionarios ifu = new ListaDeFuncionarios();
            ifu.Show();
            this.Close();
        }

        private void RemoverCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Close();
        }

        private void CadastrarPerifericoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Close();
        }

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Close();
        }

        private void MostrarPerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPerifericos mp = new mostrarPerifericos();
            mp.Show();
            this.Close();
        }

        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerPeriferico rp = new removerPeriferico();
            rp.Show();
            this.Close();
        }
        private void CadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btAlugar_Click(object sender, EventArgs e)
        {
            realizarAluguel ra = new realizarAluguel();
            ra.Show();
            this.Close();
        }
        private void btVender_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Close();
        }
        private void btMostrarAluguelVenda_Click(object sender, EventArgs e)
        {
            TabelaAluguelVendas av = new TabelaAluguelVendas();
            av.Show();
            this.Close();
        }

        private void btRemoverAluguel_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Close();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
