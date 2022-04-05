using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Globalization;

namespace telaLogin
{
    public class Access
    {
        private SqlConnection _connection;

        public Access()
        {
            _connection = new SqlConnection();
            _connection.ConnectionString = Properties.Settings.Default.Configuracao;
            _connection.Open();
        }

        public Usuario Login(string nome, string senha)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = _connection;
            command.CommandType = CommandType.Text;

            string senhaencriptada = "";

            using (HashAlgorithm alg = SHA1.Create())
            {
                var encoding = new UnicodeEncoding();
                byte[] bytes = alg.ComputeHash(encoding.GetBytes(senha));
                StringBuilder sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
                senhaencriptada = sb.ToString();
            }

            string query = $"select * from Usuario where nome = '{nome}' and senha = '{senhaencriptada}'";
            command.CommandText = query;

            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());

            if(dt.Rows.Count == 0)
                return null;

            var dados = dt.Rows[0].ItemArray;

            Usuario usuariologado = new Usuario();
            usuariologado.ID = (int)dt.Rows[0]["ID"];
            usuariologado.nome = dt.Rows[0]["nome"].ToString();
            usuariologado.senha = dt.Rows[0]["senha"].ToString();

            return usuariologado;
        }
    }
}
