namespace ProjetoJe
{
    partial class removerPeriferico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removerPeriferico));
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastrarPerifericoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarPerifericoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePerifericosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(408, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 33;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(284, 60);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(303, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "REMOVER PERIFERICOS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "insira a id do periferico que você deseja remover";
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.Location = new System.Drawing.Point(431, 134);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(43, 20);
            this.tbid.TabIndex = 29;
            this.tbid.TextChanged += new System.EventHandler(this.Tbid_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarPerifericoToolStripMenuItem,
            this.alterarPerifericoToolStripMenuItem,
            this.listaDePerifericosToolStripMenuItem,
            this.voltarAoMenuToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CadastrarPerifericoToolStripMenuItem
            // 
            this.CadastrarPerifericoToolStripMenuItem.Name = "CadastrarPerifericoToolStripMenuItem";
            this.CadastrarPerifericoToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.CadastrarPerifericoToolStripMenuItem.Text = "Cadastrar Periferico";
            this.CadastrarPerifericoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarPerifericoToolStripMenuItem_Click);
            // 
            // alterarPerifericoToolStripMenuItem
            // 
            this.alterarPerifericoToolStripMenuItem.Name = "alterarPerifericoToolStripMenuItem";
            this.alterarPerifericoToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.alterarPerifericoToolStripMenuItem.Text = "Alterar Periferico";
            this.alterarPerifericoToolStripMenuItem.Click += new System.EventHandler(this.AlterarPerifericoToolStripMenuItem_Click);
            // 
            // listaDePerifericosToolStripMenuItem
            // 
            this.listaDePerifericosToolStripMenuItem.Name = "listaDePerifericosToolStripMenuItem";
            this.listaDePerifericosToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.listaDePerifericosToolStripMenuItem.Text = "Lista de Perifericos";
            this.listaDePerifericosToolStripMenuItem.Click += new System.EventHandler(this.ListaDePerifericosToolStripMenuItem_Click);
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.VoltarAoMenuToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 296);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // removerPeriferico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "removerPeriferico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.RemoverPeriferico_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CadastrarPerifericoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarPerifericoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePerifericosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}