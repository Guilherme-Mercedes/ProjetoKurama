﻿using System;
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
    public partial class listadeFuncionarios : Form
    {
        DAOMysql.DAOMysql DAO = new DAOMysql.DAOMysql();

        public listadeFuncionarios()
        {
            InitializeComponent();
            dataGridView1.DataSource = DAO.selectLogin();
            
        }

        private void ListadeFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            adicionarFuncionario ad = new adicionarFuncionario();
            ad.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            atualizarFuncionario af = new atualizarFuncionario();
            af.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            removerCadastro rc = new removerCadastro();
            rc.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FuncMenu fm = new FuncMenu();
            fm.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
