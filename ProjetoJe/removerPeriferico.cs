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
    public partial class removerPeriferico : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public removerPeriferico()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectPeriferico();
        }

        private void removerPerifericos()
        {
            if (tbid != null)
            {
                if (DAO.mConn.State == ConnectionState.Open)
                {
                    DAO.sql = "delete from perifericos where id_peri= @id;";
                    MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                    commS.Parameters.AddWithValue("@id", tbid.Text);

                    try
                    {
                        var retorno = commS.ExecuteNonQuery();
                        if (retorno == 1)
                        {
                            MessageBox.Show("Periferico Removido");
                            dataGridView1.DataSource = DAO.selectPeriferico();
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


        private void Button1_Click(object sender, EventArgs e)
        {
            removerPerifericos();
        }

        private void Tbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarPeriferico cp = new CadastrarPeriferico();
            cp.Show();
            this.Hide();
        }

        private void AlterarPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPeriferico ap = new AlterarPeriferico();
            ap.Show();
            this.Hide();
        }

        private void ListaDePerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPerifericos mp = new mostrarPerifericos();
            mp.Show();
            this.Hide();
        }

        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFuncionario fm = new MenuFuncionario();
            fm.Show();
            this.Hide();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoverPeriferico_Load(object sender, EventArgs e)
        {

        }
    }
}
