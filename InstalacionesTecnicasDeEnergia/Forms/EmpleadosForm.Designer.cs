﻿namespace InstalacionesTecnicasDeEnergia.Forms
{
    partial class EmpleadosForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Dui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TelefonoCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TelefonoCasa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TipoContrato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.txt_FechaDespido = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ComentariosPersonales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(645, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(150)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 126);
            this.panel1.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.Logo_Moo;
            this.pbLogo.Location = new System.Drawing.Point(11, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(82, 170);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(382, 20);
            this.txt_Nombre.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nombre del empleado:";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(82, 221);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(382, 20);
            this.txt_Apellido.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Apellidos del empleado:";
            // 
            // txt_Dui
            // 
            this.txt_Dui.Location = new System.Drawing.Point(82, 269);
            this.txt_Dui.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Dui.Name = "txt_Dui";
            this.txt_Dui.Size = new System.Drawing.Size(382, 20);
            this.txt_Dui.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "DUI:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(82, 318);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(382, 20);
            this.txt_Direccion.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Dirección:";
            // 
            // txt_TelefonoCelular
            // 
            this.txt_TelefonoCelular.Location = new System.Drawing.Point(82, 372);
            this.txt_TelefonoCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TelefonoCelular.Name = "txt_TelefonoCelular";
            this.txt_TelefonoCelular.Size = new System.Drawing.Size(162, 20);
            this.txt_TelefonoCelular.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Teléfono Celular:";
            // 
            // txt_TelefonoCasa
            // 
            this.txt_TelefonoCasa.Location = new System.Drawing.Point(297, 372);
            this.txt_TelefonoCasa.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TelefonoCasa.Name = "txt_TelefonoCasa";
            this.txt_TelefonoCasa.Size = new System.Drawing.Size(162, 20);
            this.txt_TelefonoCasa.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Teléfono de Casa:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(82, 422);
            this.txt_Correo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(382, 20);
            this.txt_Correo.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Correo Electrónico:";
            // 
            // txt_TipoContrato
            // 
            this.txt_TipoContrato.Location = new System.Drawing.Point(82, 475);
            this.txt_TipoContrato.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TipoContrato.Name = "txt_TipoContrato";
            this.txt_TipoContrato.Size = new System.Drawing.Size(382, 20);
            this.txt_TipoContrato.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 460);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Tipo de Contrato:";
            // 
            // txt_FechaContratacion
            // 
            this.txt_FechaContratacion.Location = new System.Drawing.Point(82, 535);
            this.txt_FechaContratacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FechaContratacion.Name = "txt_FechaContratacion";
            this.txt_FechaContratacion.Size = new System.Drawing.Size(162, 20);
            this.txt_FechaContratacion.TabIndex = 54;
            // 
            // txt_FechaDespido
            // 
            this.txt_FechaDespido.Location = new System.Drawing.Point(302, 535);
            this.txt_FechaDespido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FechaDespido.Name = "txt_FechaDespido";
            this.txt_FechaDespido.Size = new System.Drawing.Size(162, 20);
            this.txt_FechaDespido.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 513);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Fecha de Contratación";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 513);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Fecha de Despido:";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Location = new System.Drawing.Point(82, 589);
            this.txt_Salario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(382, 20);
            this.txt_Salario.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 574);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Salario:";
            // 
            // txt_ComentariosPersonales
            // 
            this.txt_ComentariosPersonales.Location = new System.Drawing.Point(82, 644);
            this.txt_ComentariosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ComentariosPersonales.Multiline = true;
            this.txt_ComentariosPersonales.Name = "txt_ComentariosPersonales";
            this.txt_ComentariosPersonales.Size = new System.Drawing.Size(382, 37);
            this.txt_ComentariosPersonales.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 628);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Comentarios Personales:";
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(566, 165);
            this.Tabla.Margin = new System.Windows.Forms.Padding(2);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.RowTemplate.Height = 24;
            this.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla.Size = new System.Drawing.Size(602, 515);
            this.Tabla.TabIndex = 62;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(74, 708);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 28);
            this.btn_Modificar.TabIndex = 63;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(214, 708);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(118, 28);
            this.btn_Agregar.TabIndex = 64;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(74, 740);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 28);
            this.btnEliminar.TabIndex = 66;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1187, 777);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.txt_ComentariosPersonales);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_FechaDespido);
            this.Controls.Add(this.txt_FechaContratacion);
            this.Controls.Add(this.txt_TipoContrato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TelefonoCasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TelefonoCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Dui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmpleadosForm";
            this.Text = "EmpleadosForm";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Dui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TelefonoCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TelefonoCasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TipoContrato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txt_FechaContratacion;
        private System.Windows.Forms.DateTimePicker txt_FechaDespido;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_ComentariosPersonales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEliminar;
    }
}