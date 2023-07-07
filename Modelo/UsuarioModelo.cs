using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class UsuarioModelo : ConexionSql
    {
        public int Id;
        public string Nombre;
        public string Apellido;

        public bool Login(string id, string nombre)
        {

            comando.CommandText = "Select * from usuario where ID=@id AND nombre=@nombre";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            comando.Prepare();
            comando.ExecuteNonQuery();

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
