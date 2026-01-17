using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BibliotecaDigital.DAL
{
    public class Conexao
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=BibliotecaDigital;Integrated Security=True");
        }
    }
}