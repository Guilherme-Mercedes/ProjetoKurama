using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAOMysql;
using System.Threading.Tasks;
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

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoveAluguel();
        }

        private void btnRealizarVenda_Click(object sender, EventArgs e)
        {
            RealizarVenda rv = new RealizarVenda();
            rv.Show();
            this.Close();
        }

        private void btnMostrarAluguelVenda_Click(object sender, EventArgs e)
        {
            TabelaAluguelVendas av = new TabelaAluguelVendas();
            av.Show();
            this.Close();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRealizarAlugueis_Click(object sender, EventArgs e)
        {
            RealizarAluguel ra = new RealizarAluguel();
            ra.Show();
            this.Close();
        }

        private void RemoveAluguel()
        {
            string id = tbId.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
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
    }
}
