namespace LoginUsuarios
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.chkboxalmacenes = new System.Windows.Forms.CheckBox();
            this.chkboxcamioneros = new System.Windows.Forms.CheckBox();
            this.chkboxseguimiento = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LogIn Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(112, 72);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(145, 26);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(112, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(142, 187);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(147, 32);
            this.btn_Aceptar.TabIndex = 6;
            this.btn_Aceptar.Text = "INGRESAR";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(317, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Gadugi", 12.25F);
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(11, 248);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 20);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // chkboxalmacenes
            // 
            this.chkboxalmacenes.AutoSize = true;
            this.chkboxalmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkboxalmacenes.Location = new System.Drawing.Point(276, 67);
            this.chkboxalmacenes.Name = "chkboxalmacenes";
            this.chkboxalmacenes.Size = new System.Drawing.Size(111, 24);
            this.chkboxalmacenes.TabIndex = 9;
            this.chkboxalmacenes.Text = "Almacenes";
            this.chkboxalmacenes.UseVisualStyleBackColor = true;
            // 
            // chkboxcamioneros
            // 
            this.chkboxcamioneros.AutoSize = true;
            this.chkboxcamioneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkboxcamioneros.Location = new System.Drawing.Point(276, 104);
            this.chkboxcamioneros.Name = "chkboxcamioneros";
            this.chkboxcamioneros.Size = new System.Drawing.Size(118, 24);
            this.chkboxcamioneros.TabIndex = 10;
            this.chkboxcamioneros.Text = "Camioneros";
            this.chkboxcamioneros.UseVisualStyleBackColor = true;
            // 
            // chkboxseguimiento
            // 
            this.chkboxseguimiento.AutoSize = true;
            this.chkboxseguimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkboxseguimiento.Location = new System.Drawing.Point(276, 135);
            this.chkboxseguimiento.Name = "chkboxseguimiento";
            this.chkboxseguimiento.Size = new System.Drawing.Size(120, 24);
            this.chkboxseguimiento.TabIndex = 11;
            this.chkboxseguimiento.Text = "Seguimiento";
            this.chkboxseguimiento.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(408, 289);
            this.Controls.Add(this.chkboxseguimiento);
            this.Controls.Add(this.chkboxcamioneros);
            this.Controls.Add(this.chkboxalmacenes);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkboxalmacenes;
        private System.Windows.Forms.CheckBox chkboxcamioneros;
        private System.Windows.Forms.CheckBox chkboxseguimiento;
    }
}

