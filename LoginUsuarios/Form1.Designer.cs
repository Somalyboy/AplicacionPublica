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
            this.chkUsuarios = new System.Windows.Forms.CheckedListBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
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
            this.txtId.Size = new System.Drawing.Size(122, 26);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(112, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(122, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsuarios.FormattingEnabled = true;
            this.chkUsuarios.Items.AddRange(new object[] {
            "Chofer",
            "Administrador",
            "Seguimiento",
            "Almacenes"});
            this.chkUsuarios.Location = new System.Drawing.Point(240, 71);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(159, 88);
            this.chkUsuarios.TabIndex = 5;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(128, 189);
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
            this.button2.Location = new System.Drawing.Point(306, 253);
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
            this.lblError.Location = new System.Drawing.Point(21, 248);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 20);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(406, 303);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.chkUsuarios);
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
        private System.Windows.Forms.CheckedListBox chkUsuarios;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblError;
    }
}

