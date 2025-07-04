namespace ProjetoJe
{
    partial class TelaFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFunc));
            this.senhafunc = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.loginfunc = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senhafunc
            // 
            this.senhafunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senhafunc.Location = new System.Drawing.Point(409, 281);
            this.senhafunc.Name = "senhafunc";
            this.senhafunc.Size = new System.Drawing.Size(100, 20);
            this.senhafunc.TabIndex = 1;
            this.senhafunc.UseSystemPasswordChar = true;
            this.senhafunc.TextChanged += new System.EventHandler(this.senhafunc_TextChanged);
            // 
            // btlogin
            // 
            this.btlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btlogin.BackColor = System.Drawing.Color.White;
            this.btlogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btlogin.FlatAppearance.BorderSize = 2;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Location = new System.Drawing.Point(409, 339);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 28);
            this.btlogin.TabIndex = 2;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtusuario.AutoSize = true;
            this.txtusuario.BackColor = System.Drawing.Color.Transparent;
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtusuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.White;
            this.txtusuario.Location = new System.Drawing.Point(342, 251);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(67, 18);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.Text = "Usuário:";
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsenha.AutoSize = true;
            this.txtsenha.BackColor = System.Drawing.Color.Transparent;
            this.txtsenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.ForeColor = System.Drawing.Color.White;
            this.txtsenha.Location = new System.Drawing.Point(351, 281);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(57, 18);
            this.txtsenha.TabIndex = 3;
            this.txtsenha.Text = "Senha:";
            // 
            // loginfunc
            // 
            this.loginfunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginfunc.Location = new System.Drawing.Point(409, 250);
            this.loginfunc.Name = "loginfunc";
            this.loginfunc.Size = new System.Drawing.Size(100, 20);
            this.loginfunc.TabIndex = 4;
            this.loginfunc.TextChanged += new System.EventHandler(this.loginfunc_TextChanged);
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtlogin.AutoSize = true;
            this.txtlogin.BackColor = System.Drawing.Color.Transparent;
            this.txtlogin.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(415, 205);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(53, 19);
            this.txtlogin.TabIndex = 6;
            this.txtlogin.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(383, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "VOLTAR AO INICIO";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TelaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.meajudadeus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.loginfunc);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.senhafunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.TelaFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senhafunc;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label txtusuario;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.TextBox loginfunc;
        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.Label label1;
    }
}