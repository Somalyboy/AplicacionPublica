using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladres;


namespace LoginUsuarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            /*   if(txtId.Text == " "){
                   if (txtNombre.Text == " "){
                   }
                   else mensajeError("Debe ingresar un ID");            La idea de estas condiciones es que aparezca 
               }                                                        un cartel de aviso si se dejo algun campo incompleto
                 else  mensajeError("Debe Ingresar su Nombre");
               }

           private void mensajeError(string msg)
           {
               lblError.Text = msg;
               lblError.Visible = true;
           }*/


           UsuarioControlador control = new UsuarioControlador();
            control.LoginUser(txtId.Text,txtNombre.Text);

            /* if (validLogin && chkUsuarios.AccessibleName == " chofer ") // No se si es asi el check de choferes, pero es un ejemplo de como seria  
             {                                                           // la condicion segun el Usuario(check) se haya elejido
                 FormChoferes form = new FormChoferes();
                 form.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Algo salio mal :c");
             }*/


            MessageBox.Show("Usuario Encontrado");
        }
    }
}
