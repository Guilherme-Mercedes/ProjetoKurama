//OK
using System;
using System.Windows.Forms;

namespace ProjetoKurama
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
        private void AdicionarCadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new AdicionarFuncionario().Show();
            this.Close();
        }
        private void AlterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarFuncionario().Show();
            this.Close();
        }

        private void MostrarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaDeFuncionarios().Show();
            this.Close();
        }

        private void RemoverCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoverCadastroFuncionario().Show();
            this.Close();
        }

        private void CadastrarPerifericoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CadastrarPeriferico().Show();
            this.Close();
        }

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AlterarPeriferico().Show();
            this.Close();
        }

        private void MostrarPerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListaPerifericosFuncionario().Show();
            this.Close();
        }

        private void RemoverPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RemoverPeriferico().Show();
            this.Close();
        }
        private void CadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btAlugar_Click(object sender, EventArgs e)
        {
            new RealizarAluguel().Show();
            this.Close();
        }
        private void btVender_Click(object sender, EventArgs e)
        {
            new RealizarVenda().Show();
            this.Close();
        }
        private void btMostrarAluguelVenda_Click(object sender, EventArgs e)
        {
            new TabelaAluguelVendas().Show();
            this.Close();
        }

        private void btRemoverAluguel_Click(object sender, EventArgs e)
        {
            new RemoverAluguel().Show();
            this.Close();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
