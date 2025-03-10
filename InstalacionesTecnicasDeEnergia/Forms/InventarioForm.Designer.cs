﻿namespace InstalacionesTecnicasDeEnergia.Forms
{
    partial class InventarioForm
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
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.NumericUpDown();
            this.textCosto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_limpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(885, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 41, 38, 0);
            this.label1.Size = new System.Drawing.Size(219, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 131);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.ITE;
            this.pbLogo.Location = new System.Drawing.Point(21, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(116, 108);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(12, 152);
            this.Tabla.Name = "Tabla";
            this.Tabla.RowHeadersWidth = 51;
            this.Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla.Size = new System.Drawing.Size(776, 490);
            this.Tabla.TabIndex = 19;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(815, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del material:";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(818, 177);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(279, 20);
            this.txtNombreMaterial.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(818, 236);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(279, 66);
            this.txt_descripcion.TabIndex = 23;
            this.txt_descripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(815, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Categoria:";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(818, 348);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(212, 21);
            this.cbxCategoria.TabIndex = 25;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(1036, 346);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(61, 23);
            this.btnAgregarCategoria.TabIndex = 26;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cantidad:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(818, 406);
            this.textCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(212, 20);
            this.textCantidad.TabIndex = 28;
            // 
            // textCosto
            // 
            this.textCosto.DecimalPlaces = 2;
            this.textCosto.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.textCosto.Location = new System.Drawing.Point(818, 454);
            this.textCosto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(212, 20);
            this.textCosto.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(815, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(815, 606);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fecha de Compra:";
            // 
            // txt_FechaCompra
            // 
            this.txt_FechaCompra.Location = new System.Drawing.Point(818, 631);
            this.txt_FechaCompra.Name = "txt_FechaCompra";
            this.txt_FechaCompra.Size = new System.Drawing.Size(274, 20);
            this.txt_FechaCompra.TabIndex = 34;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(818, 673);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1022, 673);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(818, 564);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(279, 20);
            this.txtMarca.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Marca:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(917, 673);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.DecimalPlaces = 2;
            this.txtPrecioVenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtPrecioVenta.Location = new System.Drawing.Point(818, 503);
            this.txtPrecioVenta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(212, 20);
            this.txtPrecioVenta.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Precio  Venta:";
            // 
            // txt_limpiar
            // 
            this.txt_limpiar.Location = new System.Drawing.Point(826, 714);
            this.txt_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_limpiar.Name = "txt_limpiar";
            this.txt_limpiar.Size = new System.Drawing.Size(56, 19);
            this.txt_limpiar.TabIndex = 42;
            this.txt_limpiar.Text = "Limpiar";
            this.txt_limpiar.UseVisualStyleBackColor = true;
            this.txt_limpiar.Click += new System.EventHandler(this.txt_limpiar_Click);
            // 
            // InventarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1104, 764);
            this.Controls.Add(this.txt_limpiar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txt_FechaCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.panel1);
            this.Name = "InventarioForm";
            this.Text = "InventarioForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventarioForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown textCantidad;
        private System.Windows.Forms.NumericUpDown textCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txt_FechaCompra;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button txt_limpiar;
    }
}