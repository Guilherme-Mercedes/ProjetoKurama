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
    public partial class TelaFunc : Form
    {

        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();


        public TelaFunc()
        {
            InitializeComponent();

        }

        private void loginfunc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void senhafunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DAO.mConn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD

                           
                string query = "select * from loginfuncionario where usuario = @usuario and senha = @senha";
                MySqlCommand commS = new MySqlCommand(query, DAO.mConn);
                commS.Parameters.AddWithValue("@usuario", loginfunc.Text);
                commS.Parameters.AddWithValue("@senha", senhafunc.Text);

                
                MySqlDataReader rdr = commS.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    if (rdr["usuario".ToLower()].ToString().Equals(loginfunc.Text.ToLower()) && rdr["senha".ToLower()].ToString().Equals(senhafunc.Text.ToLower()))
                    {
                        MessageBox.Show("Funcionario Logado");
                        FuncMenu fm = new FuncMenu();
                        fm.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou senha Inválida");
                    rdr.Close();
                }
            }
            
        }

        private void TelaFunc_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Form1 sair = new Form1();
            sair.Show();
            this.Hide();
        }
    }
}
