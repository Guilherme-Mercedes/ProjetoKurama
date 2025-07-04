namespace ProjetoJe
{
    partial class atualizarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(atualizarFuncionario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsenha2 = new System.Windows.Forms.TextBox();
            this.btenviar = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.tbnascimento = new System.Windows.Forms.TextBox();
            this.tbcpf = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(314, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "ALTERAR CADASTRO";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(500, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CONFIRMAÇÃO";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(500, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "SENHA";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(230, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(416, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "insira a id do usuario que você quer alterar e preencha os campos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(500, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "DATA DE NASCIMENTO";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "CPF";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "NOME COMPLETO";
            // 
            // tbsenha2
            // 
            this.tbsenha2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha2.Location = new System.Drawing.Point(503, 242);
            this.tbsenha2.Name = "tbsenha2";
            this.tbsenha2.Size = new System.Drawing.Size(100, 20);
            this.tbsenha2.TabIndex = 30;
            this.tbsenha2.UseSystemPasswordChar = true;
            // 
            // btenviar
            // 
            this.btenviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btenviar.BackColor = System.Drawing.Color.White;
            this.btenviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btenviar.FlatAppearance.BorderSize = 2;
            this.btenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btenviar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btenviar.ForeColor = System.Drawing.Color.Black;
            this.btenviar.Location = new System.Drawing.Point(399, 302);
            this.btenviar.Name = "btenviar";
            this.btenviar.Size = new System.Drawing.Size(86, 39);
            this.btenviar.TabIndex = 29;
            this.btenviar.Text = "Cadastrar";
            this.btenviar.UseVisualStyleBackColor = false;
            this.btenviar.Click += new System.EventHandler(this.Btenviar_Click);
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.Location = new System.Drawing.Point(274, 127);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(55, 20);
            this.tbid.TabIndex = 27;
            this.tbid.TextChanged += new System.EventHandler(this.Tbid_TextChanged);
            // 
            // tbusuario
            // 
            this.tbusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbusuario.Location = new System.Drawing.Point(503, 166);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(100, 20);
            this.tbusuario.TabIndex = 28;
            // 
            // tbsenha
            // 
            this.tbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbsenha.Location = new System.Drawing.Point(503, 204);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.Size = new System.Drawing.Size(100, 20);
            this.tbsenha.TabIndex = 26;
            this.tbsenha.UseSystemPasswordChar = true;
            // 
            // tbnascimento
            // 
            this.tbnascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnascimento.Location = new System.Drawing.Point(274, 242);
            this.tbnascimento.Name = "tbnascimento";
            this.tbnascimento.Size = new System.Drawing.Size(168, 20);
            this.tbnascimento.TabIndex = 25;
            // 
            // tbcpf
            // 
            this.tbcpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbcpf.Location = new System.Drawing.Point(274, 204);
            this.tbcpf.Name = "tbcpf";
            this.tbcpf.Size = new System.Drawing.Size(168, 20);
            this.tbcpf.TabIndex = 24;
            // 
            // tbnome
            // 
            this.tbnome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbnome.Location = new System.Drawing.Point(274, 166);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(168, 20);
            this.tbnome.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCadastroToolStripMenuItem,
            this.listaDeFuncionariosToolStripMenuItem,
            this.removerCadastroToolStripMenuItem,
            this.voltarAoMenuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarCadastroToolStripMenuItem
            // 
            this.adicionarCadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarCadastroToolStripMenuItem.Name = "adicionarCadastroToolStripMenuItem";
            this.adicionarCadastroToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.adicionarCadastroToolStripMenuItem.Text = "Adicionar Cadastro";
            this.adicionarCadastroToolStripMenuItem.Click += new System.EventHandler(this.AdicionarCadastroToolStripMenuItem_Click);
            // 
            // listaDeFuncionariosToolStripMenuItem
            // 
            this.listaDeFuncionariosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeFuncionariosToolStripMenuItem.Name = "listaDeFuncionariosToolStripMenuItem";
            this.listaDeFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.listaDeFuncionariosToolStripMenuItem.Text = "Lista de Funcionarios";
            this.listaDeFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.ListaDeFuncionariosToolStripMenuItem_Click);
            // 
            // removerCadastroToolStripMenuItem
            // 
            this.removerCadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removerCadastroToolStripMenuItem.Name = "removerCadastroToolStripMenuItem";
            this.removerCadastroToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.removerCadastroToolStripMenuItem.Text = "Remover Cadastro";
            this.removerCadastroToolStripMenuItem.Click += new System.EventHandler(this.RemoverCadastroToolStripMenuItem_Click);
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu ";
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.VoltarAoMenuToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // atualizarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsenha2);
            this.Controls.Add(this.btenviar);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.tbsenha);
            this.Controls.Add(this.tbnascimento);
            this.Controls.Add(this.tbcpf);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "atualizarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.AtualizarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsenha2;
        private System.Windows.Forms.Button btenviar;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.TextBox tbnascimento;
        private System.Windows.Forms.TextBox tbcpf;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removerCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeFuncionariosToolStripMenuItem;
    }
}