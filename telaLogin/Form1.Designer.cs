namespace telaLogin
{
    partial class telaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.cbSalvarSenha = new System.Windows.Forms.CheckBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.LightCyan;
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbUsuario.Location = new System.Drawing.Point(86, 20);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(359, 29);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.LightCyan;
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbSenha.Location = new System.Drawing.Point(86, 67);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.Size = new System.Drawing.Size(359, 29);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.BackColor = System.Drawing.Color.LightCyan;
            this.cbMostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.cbMostrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("cbMostrarSenha.Image")));
            this.cbMostrarSenha.Location = new System.Drawing.Point(412, 73);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(31, 16);
            this.cbMostrarSenha.TabIndex = 4;
            this.cbMostrarSenha.UseVisualStyleBackColor = false;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // cbSalvarSenha
            // 
            this.cbSalvarSenha.AutoSize = true;
            this.cbSalvarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbSalvarSenha.ForeColor = System.Drawing.Color.Navy;
            this.cbSalvarSenha.Location = new System.Drawing.Point(321, 102);
            this.cbSalvarSenha.Name = "cbSalvarSenha";
            this.cbSalvarSenha.Size = new System.Drawing.Size(124, 25);
            this.cbSalvarSenha.TabIndex = 5;
            this.cbSalvarSenha.Text = "Salvar senha";
            this.cbSalvarSenha.UseVisualStyleBackColor = true;
            this.cbSalvarSenha.CheckedChanged += new System.EventHandler(this.cbSalvarSenha_CheckedChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Olive;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.Navy;
            this.buttonSair.Location = new System.Drawing.Point(11, 125);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 34);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Olive;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Navy;
            this.buttonLogin.Location = new System.Drawing.Point(368, 125);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 34);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Visible = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(457, 168);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.cbSalvarSenha);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.CheckBox cbSalvarSenha;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonLogin;
    }
}

