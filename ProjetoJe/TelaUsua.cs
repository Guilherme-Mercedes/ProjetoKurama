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
    public partial class TelaUsua : Form
    {
        public TelaUsua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlugarPerifericoUsuario au = new AlugarPerifericoUsuario();
            au.Show();
            this.Hide();
        }

        private void TelaUsua_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void sairusuario_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btcomprarperif_Click(object sender, EventArgs e)
        {
            vendaUsuario vu = new vendaUsuario();
            vu.Show();
            this.Hide();

        }

        private void voltarmenusuario_Click(object sender, EventArgs e)
        {
            MainForm sair = new MainForm();
            sair.Show();
            this.Hide();
        }

        private void Btmostperif_Click(object sender, EventArgs e)
        {
            ListaPerifericoDisponivel lpd = new ListaPerifericoDisponivel();
            lpd.Show();
            this.Hide();
        }
    }
}
