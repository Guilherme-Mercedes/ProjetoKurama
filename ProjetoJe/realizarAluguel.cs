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

    public partial class realizarAluguel : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();



        private int b = 0;
        private double a = 0, c = 0;
        private string dd, dm;



        public realizarAluguel()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectPeriferico();
            dataGridView2.DataSource = DAO.selectAlugueis();


        }

        private void Conta()
        {



            if (tbdaluguel.Text == "")
            {

                label8.Text = "";


            }
            else
            {
                //pega o valor de aluguel do banco de dados
                DAO.sql = "select preço_aluguel from perifericos where id_peri = @id";
                MySqlCommand ler = new MySqlCommand(DAO.sql, DAO.mConn);
                ler.Parameters.AddWithValue("@id", tbidperiferico.Text);
                MySqlDataReader rdrrr = ler.ExecuteReader();
                rdrrr.Read();



                if (rdrrr.HasRows)
                {
                    a = double.Parse(rdrrr.GetValue(0).ToString());
                    b = int.Parse(tbdaluguel.Text);

                    c = b * a;

                    rdrrr.Close();


                }
                else
                {
                    rdrrr.Close();
                    tbidperiferico.Text = "";
                }

                label8.Text = "VALOR TOTAL DO ALUGUEL: R$" + c;

            }

            if (tbdaluguel.Text == "")
            {
                btdata.Text = "";
            }
            else
            {




                DateTime data = DateTime.Now.Date;
                DateTime dias = data.AddDays(Convert.ToInt32(tbdaluguel.Text));
                dd = String.Format("{0:dd/MM/yyyy}", dias);

                btdata.Text = "DATA DE DEVOLUÇÃO: " + dd;
            }

        }

        private void realizaAluguel()
        {

            if (DAO.mConn.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexão Ok");








                dm = DateTime.Now.ToString();

                //Vai armazenar as informações no banco 
                DAO.sql = "insert into aluguel (Nome, cpf, telefone, data_nascimento, dias_aluguel, valor_total, data_devolução, horario_e_dia_do_aluguel, id_periferico ) values (@nome, @cpf, @telefone, @datan, @dias, @valortotal, @data_devolução, @horario_e_dia, @id)";
                MySqlCommand commS = new MySqlCommand(DAO.sql, DAO.mConn);
                commS.Parameters.AddWithValue("@nome", tbnome.Text);
                commS.Parameters.AddWithValue("@cpf", tbcpf.Text);
                commS.Parameters.AddWithValue("@telefone", tbtelefone.Text);
                commS.Parameters.AddWithValue("@datan", tbnascimento.Text);
                commS.Parameters.AddWithValue("@dias", tbdaluguel.Text);
                commS.Parameters.AddWithValue("@valortotal", c);
                commS.Parameters.AddWithValue("@data_devolução", dd);
                commS.Parameters.AddWithValue("@horario_e_dia", dm);
                commS.Parameters.AddWithValue("@id", tbidperiferico.Text);




                //o famoso "PREENCHA TODAS AS INFORMAÇÕES"
                if ((tbnome.Text == "") || (tbcpf.Text == "") || (tbtelefone.Text == "") || (tbnascimento.Text == "") || (tbdaluguel.Text == "") || (c == 0) || (tbidperiferico.Text == ""))
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
                        DAO.sql = "update perifericos set status='Indisponivel' where id_peri = @idd";
                        MySqlCommand commsS = new MySqlCommand(DAO.sql, DAO.mConn);
                        commsS.Parameters.AddWithValue("@idd", tbidperiferico.Text);

                        try
                        {

                            var retorno = commS.ExecuteNonQuery();
                            var retorn = commsS.ExecuteNonQuery();

                            if (retorno == 1 && retorn == 1)
                            {
                                MessageBox.Show("Aluguel Realizado com Sucesso");
                                dataGridView1.DataSource = DAO.selectPeriferico();
                                dataGridView2.DataSource = DAO.selectAlugueis();
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
            else
            {
                MessageBox.Show("erro");
            }
        }

        private void RealizarAluguel_Load(object sender, EventArgs e)
        {

        }

        private void Btenviar_Click(object sender, EventArgs e)
        {
            realizaAluguel();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Tbvaluguel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbidperiferico_TextChanged(object sender, EventArgs e)
        {



        }

        private void Tbnome_TextChanged(object sender, EventArgs e)
        {



        }

        private void Tbcpf_TextChanged(object sender, EventArgs e)
        {




        }

        private void Tbtelefone_TextChanged(object sender, EventArgs e)
        {




        }

        private void Tbnascimento_TextChanged(object sender, EventArgs e)
        {





        }

        private void Btdata_Click(object sender, EventArgs e)
        {

        }

        private void Tbdaluguel_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Tbdaluguel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void RealizarAluguel_MouseMove(object sender, MouseEventArgs e)
        {
            Conta();
        }

        private void Voltarmenusuario_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void ReaalizarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realizarVenda rv = new realizarVenda();
            rv.Show();
            this.Hide();
        }

        private void MostrarAlugueisEVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaAluguelVendas av = new TabelaAluguelVendas();
            av.Show();
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

        private void Tbdaluguel_TextChanged(object sender, EventArgs e)
        {






        }

    }
}
