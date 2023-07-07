using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public abstract class ConexionSql
    {
        public SqlConnection conexion;
        public SqlCommand comando;
        
 
        public ConexionSql()
        {
            conectarBaseDeDatos();
            iniciarComandos();

        }
        // private readonly
        /*   StringDeConexion = "Server=(local);user=root;password=negritoBD123;database=usuarios";
        string StringDeConexion;
        StringDeConexion = "Server=127.0.0.1;Uid=root;Pwd=negritoBD123;Database=usuarios;";
        SqlConnection conexion = new SqlConnection(StringDeConexion);
        conexion.Open();*/
        private void iniciarComandos()
            {
                comando = new SqlCommand();
                comando.Connection = conexion;
            }

            private void conectarBaseDeDatos()
            {
                conexion = new SqlConnection(
                    "server=127.0.0.1;" +
                    "user=root;" +
                    "password=negritoBD123;" +
                    "database=usuarios;" +
                    "port=3308"
                );
               conexion.Open();
            }
        
    }
}
