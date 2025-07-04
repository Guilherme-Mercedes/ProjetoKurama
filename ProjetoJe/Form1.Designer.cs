namespace ProjetoJe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btfunc = new System.Windows.Forms.Button();
            this.btusua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btfunc
            // 
            this.btfunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btfunc.BackColor = System.Drawing.Color.White;
            this.btfunc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btfunc.FlatAppearance.BorderSize = 2;
            this.btfunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfunc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfunc.Location = new System.Drawing.Point(319, 256);
            this.btfunc.Name = "btfunc";
            this.btfunc.Size = new System.Drawing.Size(104, 47);
            this.btfunc.TabIndex = 0;
            this.btfunc.Text = "Entrar como Funcionario";
            this.btfunc.UseVisualStyleBackColor = false;
            this.btfunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btusua
            // 
            this.btusua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btusua.BackColor = System.Drawing.Color.White;
            this.btusua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btusua.FlatAppearance.BorderSize = 3;
            this.btusua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btusua.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btusua.Location = new System.Drawing.Point(458, 256);
            this.btusua.Name = "btusua";
            this.btusua.Size = new System.Drawing.Size(104, 47);
            this.btusua.TabIndex = 1;
            this.btusua.Text = "Entrar como Usuário";
            this.btusua.UseVisualStyleBackColor = false;
            this.btusua.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ou";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtprincipal
            // 
            this.txtprincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprincipal.AutoSize = true;
            this.txtprincipal.BackColor = System.Drawing.Color.Transparent;
            this.txtprincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtprincipal.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprincipal.ForeColor = System.Drawing.Color.White;
            this.txtprincipal.Location = new System.Drawing.Point(373, 207);
            this.txtprincipal.Name = "txtprincipal";
            this.txtprincipal.Size = new System.Drawing.Size(137, 18);
            this.txtprincipal.TabIndex = 3;
            this.txtprincipal.Text = "SEJA BEM VINDO!";
            this.txtprincipal.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoJe.Properties.Resources.meajudadeus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.txtprincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btusua);
            this.Controls.Add(this.btfunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurama®";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btfunc;
        private System.Windows.Forms.Button btusua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtprincipal;
    }
}

