using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    public abstract class ConexionSql
    {
        private readonly string StringDeConexion;

        public ConexionSql()
        {
            StringDeConexion = "Server=127.0.0.1;user=root;password=negritoBD123;database=usuarios";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(StringDeConexion);
        }
    }
}
