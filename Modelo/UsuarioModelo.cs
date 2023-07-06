using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modelo
{
    class UsuarioModelo:ConexionSql
    {
        public bool Login(string id,string nombre)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
            }
        }

    }
}
