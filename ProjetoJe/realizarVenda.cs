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
    public partial class realizarVenda : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        private string dm, dd;
       



        public realizarVenda()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectPeriferico();
            dataGridView2.DataSource = DAO.selectVendas();
        }

        private void pegarValor()
        {

            if (tbidperiferico.Text == "")
            {
                txtvenda.Text = "";
            }
            else
            {

                //pega o valor de venda do banco de dados
                DAO.sql = "select preço_venda from perifericos where id_peri = @id";
                MySqlCommand ler = new MySqlCommand(DAO.sql, DAO.mConn);
                ler.Parameters.AddWithValue("@id", tbidperiferico.Text);
                MySqlDataReader rdrrr = ler.ExecuteReader();
                rdrrr.Read();


                if (rdrrr.HasRows)
                {
                    dd = rdrrr.GetValue(0).ToString();
                    txtvenda.Text = "VALOR DO PERIFERICO: R$" + dd;
                    rdrrr.Close();


                }
                else
                {
                    rdrrr.Close();
                    tbidperiferico.Text = "";
                }

            }

        }

        private void realizaVenda()
        {

            if (DAO.mConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão Ok");








                dm = DateTime.Now.ToString();

                //Vai armazenar as informações no banco 
                DAO.sql = "insert into venda (Nome, cpf, telefone, data_nascimento, preço_venda, dia_venda, id_periferico ) values (@nome, @cpf, @telefone, @datan, @preço, @horario_e_dia, @id)";
                MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                commS.Parameters.AddWithValue("@nome", tbnome.Text);
                commS.Parameters.AddWithValue("@cpf", tbcpf.Text);
                commS.Parameters.AddWithValue("@telefone", tbtelefone.Text);
                commS.Parameters.AddWithValue("@datan", tbnascimento.Text);
                commS.Parameters.AddWithValue("@preço", dd);
                commS.Parameters.AddWithValue("@horario_e_dia", dm);
                commS.Parameters.AddWithValue("@id", tbidperiferico.Text);




                //o famoso "PREENCHA TODAS AS INFORMAÇÕES"
                if ((tbnome.Text == "") || (tbcpf.Text == "") || (tbtelefone.Text == "") || (tbnascimento.Text == "") || (tbidperiferico.Text == "") || (dm == ""))
                {
                    MessageBox.Show("Não deixe nenhum espaço em branco!");


                }
                else
                {


                    //UM ANO PRA ARRUMAR ISSO, MAS NO FINAAL VALEU A PENA (COMANDO PRA IMPEDIR QUE PEGUE UM PERIFERICO QUE JÁ FOI ALUGADO)
                    DAO.sql = "select status from perifericos where id_peri = @idd";
                    MySqlCommand commmS = new MySqlCommand(DAO.sql, DAO.mConn);
                    commmS.Parameters.AddWithValue("@idd", tbidperiferico.Text);
                    MySqlDataReader rdr = commmS.ExecuteReader();
                    rdr.Read();
                    string aa = rdr.GetValue(0).ToString();
                    rdr.Close();



                    if (aa == "Indisponivel")
                    {
                        MessageBox.Show("Periferico Indisponivel ");
                        rdr.Close();
                    }
                    else
                    {


                        //Atualiza o status do periferico para Indisponivel
                        DAO.sql = "update perifericos set status='Indisponivel' where id_peri = @id";
                        MySqlCommand commsS = new MySqlCommand(DAO.sql, DAO.mConn);
                        commsS.Parameters.AddWithValue("@id", tbidperiferico.Text);

                        try
                        {

                            var retorno = commS.ExecuteNonQuery();
                            var retorn = commsS.ExecuteNonQuery();

                            if (retorno == 1 && retorn == 1)
                            {
                                MessageBox.Show("Aluguel Realizado com Sucesso");
                                dataGridView1.DataSource = DAO.selectPeriferico();
                                dataGridView2.DataSource = DAO.selectVendas();
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro oa inserir, tente novamente...");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro" + ex.Message.ToString());
                        }


                    }


                }
            }
        }

        private void Btenviar_Click(object sender, EventArgs e)
        {
            realizaVenda();
        }

        private void Tbidperiferico_TextChanged(object sender, EventArgs e)
        {


            pegarValor();


        }

        private void Tbvenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RealizarVenda_Load(object sender, EventArgs e)
        {

        }

        private void Tbidperiferico_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void RealizarVenda_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ReaalizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realizarAluguel ra = new realizarAluguel();
            ra.Show();
            this.Hide();
        }

        private void MostrarAlugueisEVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alugueiVendas av = new alugueiVendas();
            av.Show();
            this.Hide();
        }

        private void Voltarmenusuario_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void RemoverAluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removerAluguel ra = new removerAluguel();
            ra.Show();
            this.Hide();
        }

        private void Sairusuario_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Txtvenda_Click(object sender, EventArgs e)
        {

        }

        private void Tbtelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
