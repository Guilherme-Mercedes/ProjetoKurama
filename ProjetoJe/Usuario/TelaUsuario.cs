using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class TelaUsuario : Form
    {
        public TelaUsuario()
        {
            InitializeComponent();
        }
        private void TelaUsua_Load(object sender, EventArgs e)
        {
        }
        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }
        private void btnMostrarPerifericos_Click(object sender, EventArgs e)
        {
            new ListaPerifericoDisponivel().Show();
            this.Close();
        }
        private void btnAlugar_Click(object sender, EventArgs e)
        {
            new AlugarPerifericoUsuario().Show();
            this.Close();
        }
        private void btComprarPeriferico_Click(object sender, EventArgs e)
        {
            new VendaPerifericoUsuario().Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
