﻿namespace ProjetoJe
{
    partial class realizarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realizarVenda));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbidperiferico = new System.Windows.Forms.TextBox();
            this.btenviar = new System.Windows.Forms.Button();
            this.tbtelefone = new System.Windows.Forms.TextBox();
            this.tbnascimento = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reaalizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerAluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAlugueisEVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarmenusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairusuario = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(345, 315);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 221);
            this.dataGridView2.TabIndex = 42;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 206);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID DO PERIFERICO";
            // 
            // txtvenda
            // 
            this.txtvenda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtvenda.AutoSize = true;
            this.txtvenda.BackColor = System.Drawing.Color.Transparent;
            this.txtvenda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvenda.ForeColor = System.Drawing.Color.White;
            this.txtvenda.Location = new System.Drawing.Point(81, 294);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.Size = new System.Drawing.Size(123, 16);
            this.txtvenda.TabIndex = 34;
            this.txtvenda.Text = "PREÇO DA VENDA";
            this.txtvenda.Click += new System.EventHandler(this.Txtvenda_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "TELEFONE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "DATA DE NASCIMENTO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "CPF";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(496, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "LISTA DE VENDAS REALIZADAS";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(513, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "LISTA DE PERIFERICOS";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "NOME";
            // 
            // tbidperiferico
            // 
            this.tbidperiferico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbidperiferico.Location = new System.Drawing.Point(84, 249);
            this.tbidperiferico.Name = "tbidperiferico";
            this.tbidperiferico.Size = new System.Drawing.Size(100, 20);
            this.tbidperiferico.TabIndex = 30;
            this.tbidperiferico.TextChanged += new System.EventHandler(this.Tbidperiferico_TextChanged);
            this.tbidperiferico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Tbidperiferico_MouseMove);
            // 
            // btenviar
            // 
            this.btenviar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btenviar.BackColor = System.Drawing.Color.White;
            this.btenviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btenviar.FlatAppearance.BorderSize = 2;
            this.btenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenviar.ForeColor = System.Drawing.Color.Black;
            this.btenviar.Location = new System.Drawing.Point(108, 343);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(75, 30);
            this.btenviar.TabIndex = 29;
            this.btenviar.Text = "Cadastrar";
            this.btenviar.UseVisualStyleBackColor = false;
            this.btenviar.Click += new System.EventHandler(this.Btenviar_Click);
            // 
            // tbtelefone
            // 
            this.tbtelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbtelefone.Location = new System.Drawing.Point(84, 168);
            this.tbtelefone.Name = "tbtelefone";
            this.tbtelefone.Size = new System.Drawing.Size(168, 20);
            this.tbtelefone.TabIndex = 28;
            this.tbtelefone.TextChanged += new System.EventHandler(this.Tbtelefone_TextChanged);
            // 
            // tbnascimento
            // 
            this.tbnascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbnascimento.Location = new System.Drawing.Point(84, 207);
            this.tbnascimento.Name = "tbnascimento";
            this.tbnascimento.Size = new System.Drawing.Size(168, 20);
            this.tbnascimento.TabIndex = 26;
            // 
            // tbcpf
            // 
            this.tbcpf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbcpf.Location = new System.Drawing.Point(84, 129);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(168, 20);
            this.tbcpf.TabIndex = 25;
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbnome.Location = new System.Drawing.Point(84, 91);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(168, 20);
            this.tbnome.TabIndex = 24;
            this.tbnome.TextChanged += new System.EventHandler(this.Tbnome_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reaalizarVendaToolStripMenuItem,
            this.removerAluguelToolStripMenuItem,
            this.mostrarAlugueisEVendasToolStripMenuItem,
            this.voltarmenusuario,
            this.sairusuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reaalizarVendaToolStripMenuItem
            // 
            this.reaalizarVendaToolStripMenuItem.Name = "reaalizarVendaToolStripMenuItem";
            this.reaalizarVendaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.reaalizarVendaToolStripMenuItem.Text = "Realizar Aluguel";
            this.reaalizarVendaToolStripMenuItem.Click += new System.EventHandler(this.ReaalizarVendaToolStripMenuItem_Click);
            // 
            // removerAluguelToolStripMenuItem
            // 
            this.removerAluguelToolStripMenuItem.Name = "removerAluguelToolStripMenuItem";
            this.removerAluguelToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.removerAluguelToolStripMenuItem.Text = "Remover Aluguel ";
            this.removerAluguelToolStripMenuItem.Click += new System.EventHandler(this.RemoverAluguelToolStripMenuItem_Click);
            // 
            // mostrarAlugueisEVendasToolStripMenuItem
            // 
            this.mostrarAlugueisEVendasToolStripMenuItem.Name = "mostrarAlugueisEVendasToolStripMenuItem";
            this.mostrarAlugueisEVendasToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.mostrarAlugueisEVendasToolStripMenuItem.Text = "Mostrar Alugueis e Vendas";
            this.mostrarAlugueisEVendasToolStripMenuItem.Click += new System.EventHandler(this.MostrarAlugueisEVendasToolStripMenuItem_Click);
            // 
            // voltarmenusuario
            // 
            this.voltarmenusuario.Name = "voltarmenusuario";
            this.voltarmenusuario.Size = new System.Drawing.Size(127, 24);
            this.voltarmenusuario.Text = "Voltar ao Menu";
            this.voltarmenusuario.Click += new System.EventHandler(this.Voltarmenusuario_Click);
            // 
            // sairusuario
            // 
            this.sairusuario.Name = "sairusuario";
            this.sairusuario.Size = new System.Drawing.Size(47, 24);
            this.sairusuario.Text = "Sair";
            this.sairusuario.Click += new System.EventHandler(this.Sairusuario_Click);
            // 
            // realizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtvenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbidperiferico);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.tbtelefone);
            this.Controls.Add(this.tbnascimento);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "realizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.RealizarVenda_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RealizarVenda_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtvenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbidperiferico;
        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.TextBox tbtelefone;
        private System.Windows.Forms.TextBox tbnascimento;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reaalizarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarAlugueisEVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerAluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarmenusuario;
        private System.Windows.Forms.ToolStripMenuItem sairusuario;
    }
}