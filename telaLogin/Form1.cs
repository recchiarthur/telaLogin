using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Globalization;

namespace telaLogin
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
            if (File.Exists("senhasalva.txt"))
            {
                var lines = File.ReadAllLines("senhasalva.txt");
                tbUsuario.Text = lines[0];
                tbSenha.Text = lines[1];
                cbSalvarSenha.Checked = true;
            }
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
            string senhaencriptada = "";
            using (HashAlgorithm alg = SHA1.Create())
            {
                var encoding = new UnicodeEncoding();
                byte[] bytes = alg.ComputeHash(encoding.GetBytes(tbSenha.Text));
                StringBuilder sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
                senhaencriptada = sb.ToString();
            }

            telaLogin2Entities entities = new telaLogin2Entities();
            var user = entities.Usuario.FirstOrDefault(u => u.nome == tbUsuario.Text && u.senha == senhaencriptada);

            if (user != null)
            {
                MessageBox.Show("Bem-vindo!", $"Bem-vindo {user.nome}!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Abra a próxima tela aqui
                this.Hide();
                if(cbSalvarSenha.Checked)
                {
                    File.WriteAllText("senhasalva.txt", $"{user.nome}\n{tbSenha.Text}");
                }
                else
                {
                    File.Delete("senhasalva.txt");
                }
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
