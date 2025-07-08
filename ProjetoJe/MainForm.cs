using System;
using System.Windows.Forms;

namespace ProjetoJe
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
            TelaInicialFuncionario tf = new TelaInicialFuncionario();
            tf.Show();
            this.Close();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            TelaUsuario tu = new TelaUsuario();
            tu.Show();
            this.Close();
        }
    }
}
