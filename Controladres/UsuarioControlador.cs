using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controladres
{
    public class UsuarioControlador
    {
        UsuarioModelo modelo = new UsuarioModelo();
        public bool Login(string id, string nombre)
        {
            return modelo.Login(id,nombre);
        }
    }
}
