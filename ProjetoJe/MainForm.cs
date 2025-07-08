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
            TelaFunc tf = new TelaFunc();
            tf.Show();
            this.Close();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            TelaUsua tu = new TelaUsua();
            tu.Show();
            this.Close();
        }
    }
}
