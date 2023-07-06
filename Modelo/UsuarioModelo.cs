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
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "Select * from usuario where ID=@id AND nombre=@nombre";
                    comando.Parameters.AddWithValue("@ID", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            
        }

    }
}
