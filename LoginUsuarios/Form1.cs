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
            UsuarioControlador control = new UsuarioControlador();
            control.LoginUser(txtId.Text, txtNombre.Text);

            string id;
            string nombre;

            id = txtId.Text;
            nombre = txtNombre.Text;

            if (chkboxcamioneros.Checked && control.LoginUser(id,nombre)) {
                MessageBox.Show("Usuario Encontrado");

            }
            else
            {
                MessageBox.Show("Algo salio mal :( //Usuario no Encontrado");
            }
            
            if (txtId.Text == " ")
            {
                mensajeError("Debe ingresar un ID");
            }
                 if (txtNombre.Text == " ")
                mensajeError("Debe Ingresar su Nombre");
               }

           private void mensajeError(string msg)
           {
               lblError.Text = msg;
               lblError.Visible = true;
        
        }
    }
}
