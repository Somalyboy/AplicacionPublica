﻿using System;
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
                   else mensajeError("Debe ingresar un ID");
               }
                 else  mensajeError("Debe Ingresar su Nombre");

               }

           private void mensajeError(string msg)
           {
               lblError.Text = msg;
               lblError.Visible = true;
           }*/

            UsuarioControlador control = new UsuarioControlador();
            var validLogin = control.LoginUser(txtId.Text,txtNombre.Text);
            if (validLogin)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Algo salio mal :c");
            }


        }
    }
}
