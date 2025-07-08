//ok
using System;
using System.Windows.Forms;

namespace ProjetoJe
{
    public partial class RemoverAluguel : Form
    {
        private DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public RemoverAluguel()
        {
            InitializeComponent();
        }
        private void RemoverAluguel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DAO.SelectAlugueis();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoveAluguel();
        }
        private void btnRealizarVenda_Click(object sender, EventArgs e)
        {
            new RealizarVenda().Show();
            this.Close();
        }
        private void btnMostrarAluguelVenda_Click(object sender, EventArgs e)
        {
            new TabelaAluguelVendas().Show();
            this.Close();
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            new MenuFuncionario().Show();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnRealizarAlugueis_Click(object sender, EventArgs e)
        {
            new RealizarAluguel().Show();
            this.Close();
        }
        private void RemoveAluguel()
        {
            string id = tbId.Text.Trim();

            if (!Utilitarios.CampoPreenchido(id))
            {
                MessageBox.Show("O campo ID está em branco. Por favor, preencha.");
                return;
            }
            try
            {
                bool sucesso = DAO.RemoverAluguelPorId(id);
                if (sucesso)
                {
                    MessageBox.Show("Aluguel removido com sucesso.");
                    dataGridView1.DataSource = DAO.SelectAlugueis();
                }
                else
                {
                    MessageBox.Show("Nenhum aluguel foi removido. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover aluguel: " + ex.Message);
            }
        }

        private void tbIdRemoverAluguel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se o caractere não for número nem tecla de controle (como backspace), bloqueia
            Utilitarios.BloquearCaractere(e);
        }
    }
}
