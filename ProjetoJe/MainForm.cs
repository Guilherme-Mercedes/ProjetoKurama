using System;
using System.Windows.Forms;

namespace ProjetoKurama
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            new TelaInicialFuncionario().Show();
            this.Hide();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new TelaUsuario().Show();
            this.Hide();
        }
    }
}
