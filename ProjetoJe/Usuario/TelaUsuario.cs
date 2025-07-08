using System;
using System.ComponentModel;
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
            MainForm sair = new MainForm();
            sair.Show();
            this.Close();
        }

        private void btnMostrarPerifericos_Click(object sender, EventArgs e)
        {
            ListaPerifericoDisponivel lpd = new ListaPerifericoDisponivel();
            lpd.Show();
            this.Close();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            AlugarPerifericoUsuario au = new AlugarPerifericoUsuario();
            au.Show();
            this.Close();
        }

        private void btComprarPeriferico_Click(object sender, EventArgs e)
        {
            VendaPerifericoUsuario vu = new VendaPerifericoUsuario();
            vu.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
