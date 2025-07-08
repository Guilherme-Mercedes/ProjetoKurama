namespace ProjetoJe
{
    partial class RemoverAluguel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoverAluguel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarAlugueisEVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reaalizarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerAluguelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarmenusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairusuario = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 296);
            this.dataGridView1.TabIndex = 41;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(396, 189);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 28);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(313, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 29);
            this.label7.TabIndex = 39;
            this.label7.Text = "REMOVER ALUGUEL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(384, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(287, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "insira a id do aluguel que você deseja remover";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbId
            // 
            this.tbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbId.Location = new System.Drawing.Point(413, 135);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(43, 20);
            this.tbId.TabIndex = 36;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAlugueisEVendasToolStripMenuItem,
            this.reaalizarVendaToolStripMenuItem,
            this.removerAluguelToolStripMenuItem,
            this.voltarmenusuario,
            this.sairusuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarAlugueisEVendasToolStripMenuItem
            // 
            this.mostrarAlugueisEVendasToolStripMenuItem.Name = "mostrarAlugueisEVendasToolStripMenuItem";
            this.mostrarAlugueisEVendasToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.mostrarAlugueisEVendasToolStripMenuItem.Text = "Realizar Aluguel";
            this.mostrarAlugueisEVendasToolStripMenuItem.Click += new System.EventHandler(this.btnRealizarAlugueis_Click);
            // 
            // reaalizarVendaToolStripMenuItem
            // 
            this.reaalizarVendaToolStripMenuItem.Name = "reaalizarVendaToolStripMenuItem";
            this.reaalizarVendaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.reaalizarVendaToolStripMenuItem.Text = "Realizar Venda";
            this.reaalizarVendaToolStripMenuItem.Click += new System.EventHandler(this.btnRealizarVenda_Click);
            // 
            // removerAluguelToolStripMenuItem
            // 
            this.removerAluguelToolStripMenuItem.Name = "removerAluguelToolStripMenuItem";
            this.removerAluguelToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.removerAluguelToolStripMenuItem.Text = "Mostrar Alugueis e Vendas";
            this.removerAluguelToolStripMenuItem.Click += new System.EventHandler(this.btnMostrarAluguelVenda_Click);
            // 
            // voltarmenusuario
            // 
            this.voltarmenusuario.Name = "voltarmenusuario";
            this.voltarmenusuario.Size = new System.Drawing.Size(127, 24);
            this.voltarmenusuario.Text = "Voltar ao Menu";
            this.voltarmenusuario.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // sairusuario
            // 
            this.sairusuario.Name = "sairusuario";
            this.sairusuario.Size = new System.Drawing.Size(47, 24);
            this.sairusuario.Text = "Sair";
            this.sairusuario.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // RemoverAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.laranjo;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoverAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.RemoverAluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarAlugueisEVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reaalizarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerAluguelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarmenusuario;
        private System.Windows.Forms.ToolStripMenuItem sairusuario;
    }
}