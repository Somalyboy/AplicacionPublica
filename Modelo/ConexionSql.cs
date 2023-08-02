using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public abstract class ConexionSql
    {
        public string DatabaseIp;
        public string DatabaseUser;
        public string DatabasePassword;
        public string DatabaseName;

        public MySqlConnection conexion;
        public MySqlCommand comando;
        public MySqlDataReader Reader;

        public ConexionSql()
        {
            conectarBaseDeDatos();
            
        }
        
            private void conectarBaseDeDatos()
            {
            this.DatabaseIp = "localhost";
            this.DatabaseUser = "root";
            this.DatabasePassword = "negritoBD123";
            this.DatabaseName = "usuarios";

            this.conexion = new MySqlConnection(
                $"server={this.DatabaseIp};" +
                $"user={this.DatabaseUser};" +
                $"password={this.DatabasePassword};" +
                $"database={this.DatabaseName};"
            );

            this.comando.ExecuteNonQuery();
            this.conexion.Open();

            this.comando = new MySqlCommand();
            this.comando.Connection = this.conexion;
        }
        
    }
}
