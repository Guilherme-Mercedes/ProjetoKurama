namespace ProjetoJe
{
    partial class TelaInicialFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialFuncionario));
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btFazerLogin = new System.Windows.Forms.Button();
            this.lbusuario = new System.Windows.Forms.Label();
            this.lbsenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.Label();
            this.lbVoltarInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(345, 281);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(213, 31);
            this.txbSenha.TabIndex = 1;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // btFazerLogin
            // 
            this.btFazerLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFazerLogin.BackColor = System.Drawing.Color.White;
            this.btFazerLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btFazerLogin.FlatAppearance.BorderSize = 2;
            this.btFazerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFazerLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFazerLogin.Location = new System.Drawing.Point(409, 326);
            this.btFazerLogin.Name = "btFazerLogin";
            this.btFazerLogin.Size = new System.Drawing.Size(75, 28);
            this.btFazerLogin.TabIndex = 2;
            this.btFazerLogin.Text = "Login";
            this.btFazerLogin.UseVisualStyleBackColor = false;
            this.btFazerLogin.Click += new System.EventHandler(this.btnLogin);
            // 
            // lbusuario
            // 
            this.lbusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Transparent;
            this.lbusuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbusuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.White;
            this.lbusuario.Location = new System.Drawing.Point(342, 188);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(67, 18);
            this.lbusuario.TabIndex = 3;
            this.lbusuario.Text = "Usuário:";
            // 
            // lbsenha
            // 
            this.lbsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsenha.AutoSize = true;
            this.lbsenha.BackColor = System.Drawing.Color.Transparent;
            this.lbsenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsenha.ForeColor = System.Drawing.Color.White;
            this.lbsenha.Location = new System.Drawing.Point(342, 260);
            this.lbsenha.Name = "lbsenha";
            this.lbsenha.Size = new System.Drawing.Size(57, 18);
            this.lbsenha.TabIndex = 3;
            this.lbsenha.Text = "Senha:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(345, 209);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(213, 29);
            this.txbUsuario.TabIndex = 4;
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlogin.AutoSize = true;
            this.txtlogin.BackColor = System.Drawing.Color.Transparent;
            this.txtlogin.Font = new System.Drawing.Font("Arial", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(408, 140);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(76, 27);
            this.txtlogin.TabIndex = 6;
            this.txtlogin.Text = "Login";
            // 
            // lbVoltarInicio
            // 
            this.lbVoltarInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbVoltarInicio.AutoSize = true;
            this.lbVoltarInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbVoltarInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoltarInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbVoltarInicio.Location = new System.Drawing.Point(383, 380);
            this.lbVoltarInicio.Name = "lbVoltarInicio";
            this.lbVoltarInicio.Size = new System.Drawing.Size(125, 16);
            this.lbVoltarInicio.TabIndex = 7;
            this.lbVoltarInicio.Text = "VOLTAR AO INICIO";
            this.lbVoltarInicio.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TelaInicialFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.lbVoltarInicio);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lbsenha);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.btFazerLogin);
            this.Controls.Add(this.txbSenha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicialFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.TelaFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btFazerLogin;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Label lbsenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.Label lbVoltarInicio;
    }
}