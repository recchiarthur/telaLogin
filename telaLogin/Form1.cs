using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaLogin
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked) tbSenha.PasswordChar = '\0';
            else tbSenha.PasswordChar = '●';
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbSalvarSenha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            var user = access.Login(tbUsuario.Text, tbSenha.Text);

            if(user != null)
            {
                MessageBox.Show("Bem-vindo!", $"Bem-vindo {user.nome}!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Abra a próxima tela aqui
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro!", "Senha ou Usuario incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            buttonLogin.Visible = tbUsuario.Text.Length > 0 && tbSenha.Text.Length > 0;
        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            buttonLogin.Visible = tbUsuario.Text.Length > 0 && tbSenha.Text.Length > 0;
        }
    }
}
