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
    public partial class removerCadastro : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();
        public removerCadastro()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectLogin();
        }

        private void removerFuncionrio()
        {
            if (tbid != null)
            {
                if (DAO.mConn.State == ConnectionState.Open)
                {
                    DAO.sql = "delete from loginfuncionario where id_func= @id;";
                    MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                    commS.Parameters.AddWithValue("@id", tbid.Text);

                    try
                    {
                        var retorno = commS.ExecuteNonQuery();
                        if (retorno == 1)
                        {
                            MessageBox.Show("Funcionario Removido");
                            dataGridView1.DataSource = DAO.selectLogin();
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
            removerFuncionrio();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoverCadastro_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario ad = new AdicionarFuncionario();
            ad.Show();
            this.Hide();
        }

        private void RemoverCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizarFuncionario af = new atualizarFuncionario();
            af.Show();
            this.Hide();
        }

        private void ListaDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listadeFuncionarios lf = new listadeFuncionarios();
            lf.Show();
            this.Hide();
        }

        private void VoltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
