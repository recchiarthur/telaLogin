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
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbUsuario.Location = new System.Drawing.Point(86, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(359, 29);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbSenha.Location = new System.Drawing.Point(86, 70);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.Size = new System.Drawing.Size(359, 29);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.TextChanged += new System.EventHandler(this.tbSenha_TextChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(86, 105);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(93, 17);
            this.cbMostrarSenha.TabIndex = 4;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // cbSalvarSenha
            // 
            this.cbSalvarSenha.AutoSize = true;
            this.cbSalvarSenha.Location = new System.Drawing.Point(185, 105);
            this.cbSalvarSenha.Name = "cbSalvarSenha";
            this.cbSalvarSenha.Size = new System.Drawing.Size(88, 17);
            this.cbSalvarSenha.TabIndex = 5;
            this.cbSalvarSenha.Text = "Salvar senha";
            this.cbSalvarSenha.UseVisualStyleBackColor = true;
            this.cbSalvarSenha.CheckedChanged += new System.EventHandler(this.cbSalvarSenha_CheckedChanged);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(16, 132);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(370, 132);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Visible = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 168);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.cbSalvarSenha);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
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

