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
