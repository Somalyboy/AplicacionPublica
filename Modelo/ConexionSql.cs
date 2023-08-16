using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using MySqlConnector;
using MySql.Data.MySqlClient;
namespace Modelo
{
    public abstract class ConexionSql
    {
        public string DatabaseIp;
        public string DatabaseUser;
        public string DatabasePassword;
        public string DatabaseName;

        /*   public MySqlConnection conexion;
           public MySqlCommand comando;
           public MySqlDataReader Reader;
           */
           
       public  ADODB.Connection conexion = new ADODB.Connection();


            public ConexionSql()
        {

            conectarBaseDeDatos();
        }

            private void conectarBaseDeDatos()
            {
            //  string connectionString = "server=localhost;user=root;password=negritoBD123;database=usuarios;";



            //MySqlConnection connection = new MySqlConnection(connectionString);
            conexion.Open("MiODBC","root","negritoBD123");
            conexion.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
  
        }

    }
}
