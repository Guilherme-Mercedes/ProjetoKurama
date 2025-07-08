namespace ProjetoJe
{
    partial class TelaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuario));
            this.btmostperif = new System.Windows.Forms.Button();
            this.btcomprarperif = new System.Windows.Forms.Button();
            this.btalugarperif = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarmenusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.sairusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmostperif
            // 
            this.btmostperif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmostperif.BackColor = System.Drawing.Color.White;
            this.btmostperif.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btmostperif.FlatAppearance.BorderSize = 2;
            this.btmostperif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmostperif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmostperif.Location = new System.Drawing.Point(249, 243);
            this.btmostperif.Name = "btmostperif";
            this.btmostperif.Size = new System.Drawing.Size(102, 54);
            this.btmostperif.TabIndex = 2;
            this.btmostperif.Text = "Mostrar Periféricos";
            this.btmostperif.UseVisualStyleBackColor = false;
            this.btmostperif.Click += new System.EventHandler(this.btnMostrarPerifericos_Click);
            // 
            // btcomprarperif
            // 
            this.btcomprarperif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btcomprarperif.BackColor = System.Drawing.Color.White;
            this.btcomprarperif.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btcomprarperif.FlatAppearance.BorderSize = 2;
            this.btcomprarperif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcomprarperif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcomprarperif.Location = new System.Drawing.Point(520, 243);
            this.btcomprarperif.Name = "btcomprarperif";
            this.btcomprarperif.Size = new System.Drawing.Size(102, 54);
            this.btcomprarperif.TabIndex = 3;
            this.btcomprarperif.Text = "Comprar";
            this.btcomprarperif.UseVisualStyleBackColor = false;
            this.btcomprarperif.Click += new System.EventHandler(this.btComprarPeriferico_Click);
            // 
            // btalugarperif
            // 
            this.btalugarperif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btalugarperif.BackColor = System.Drawing.Color.White;
            this.btalugarperif.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btalugarperif.FlatAppearance.BorderSize = 2;
            this.btalugarperif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btalugarperif.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btalugarperif.Location = new System.Drawing.Point(386, 243);
            this.btalugarperif.Name = "btalugarperif";
            this.btalugarperif.Size = new System.Drawing.Size(102, 54);
            this.btalugarperif.TabIndex = 4;
            this.btalugarperif.Text = "Alugar";
            this.btalugarperif.UseVisualStyleBackColor = false;
            this.btalugarperif.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::ProjetoJe.Properties.Resources.cinza;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarmenusuario,
            this.sairusuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarmenusuario
            // 
            this.voltarmenusuario.Name = "voltarmenusuario";
            this.voltarmenusuario.Size = new System.Drawing.Size(124, 24);
            this.voltarmenusuario.Text = "Voltar ao Ínicio";
            this.voltarmenusuario.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // sairusuario
            // 
            this.sairusuario.Name = "sairusuario";
            this.sairusuario.Size = new System.Drawing.Size(47, 24);
            this.sairusuario.Text = "Sair";
            this.sairusuario.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaUsua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.fundo13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.btalugarperif);
            this.Controls.Add(this.btcomprarperif);
            this.Controls.Add(this.btmostperif);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaUsua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.TelaUsua_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmostperif;
        private System.Windows.Forms.Button btcomprarperif;
        private System.Windows.Forms.Button btalugarperif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarmenusuario;
        private System.Windows.Forms.ToolStripMenuItem sairusuario;
    }
}