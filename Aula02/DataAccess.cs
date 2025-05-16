using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;

namespace Aula02
{
    public class DataAccess
    {
        private string connectionSTRING = "Server=localhost\\SQLEXPRESS;Database=SantaCruz;Uid=sa;Password=santacruz;Encrypt=No";
        public SqlConnection obterConexao()
        {
            SqlConnection conn = new SqlConnection(connectionSTRING);
            return conn;
        }
    }
}
