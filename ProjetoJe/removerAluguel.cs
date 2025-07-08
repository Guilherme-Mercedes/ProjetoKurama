//ALTERAR
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


    public partial class removerAluguel : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public removerAluguel()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectAlugueis();
        }
        private void removeAluguel()
        {
            if (tbid != null)
            {
                if (DAO.mConn.State == ConnectionState.Open)
                {
                    DAO.sql = "delete from aluguel where id= @id;";
                    MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                    commS.Parameters.AddWithValue("@id", tbid.Text);

                    try
                    {
                        var retorno = commS.ExecuteNonQuery();
                        if (retorno == 1)
                        {
                            MessageBox.Show("Aluguel Removido");
                            dataGridView1.DataSource = DAO.selectAlugueis();
                        }
                        else
                        {
                            MessageBox.Show("Erro, tente novamente...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro" + ex.Message.ToString());
                    }


                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            else
            {
                MessageBox.Show("A id está em branco, por favor preencha o campo");
            }
        }

        private void RemoverAluguel_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            removeAluguel();
        }

        private void MostrarAlugueisEVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarAluguel ra = new RealizarAluguel();
            ra.Show();
            this.Hide();
        }

        private void ReaalizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Hide();
        }

        private void RemoverAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaAluguelVendas av = new TabelaAluguelVendas();
            av.Show();
            this.Hide();
        }

        private void Voltarmenusuario_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Hide();
        }

        private void Sairusuario_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
