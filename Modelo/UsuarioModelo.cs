using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
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
            ADODB.Recordset rs;
            object filasAfectadas;

/*
            comando.CommandText = "Select * from usuario where ID=@id AND nombre=@nombre";
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

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
            */
            string sql = "Select * from usuario where ID='"+id+"' AND nombre='"+nombre+"'";
            rs = conexion.Execute(sql,out filasAfectadas);
            if (rs.RecordCount == 1)
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
