namespace InstalacionesTecnicasDeEnergia.Forms
{
    partial class PresupuestoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.txtTotalMateriales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminarManoObra = new System.Windows.Forms.Button();
            this.btnAgregarManoObra = new System.Windows.Forms.Button();
            this.dgvManoObra = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalManoObra = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precioManoObra = new System.Windows.Forms.NumericUpDown();
            this.txtManoObra = new System.Windows.Forms.TextBox();
            this.txtCantidadMano = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadMano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(150)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(559, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminarMaterial);
            this.panel2.Controls.Add(this.btnAgregarMaterial);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.txtMaterial);
            this.panel2.Controls.Add(this.dgvMateriales);
            this.panel2.Controls.Add(this.txtTotalMateriales);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 541);
            this.panel2.TabIndex = 3;
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.Location = new System.Drawing.Point(225, 494);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMaterial.TabIndex = 8;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Location = new System.Drawing.Point(15, 494);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMaterial.TabIndex = 7;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(225, 446);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.ValueChanged += new System.EventHandler(this.txtPrecio_ValueChanged);
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(15, 446);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(120, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(15, 397);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(330, 20);
            this.txtMaterial.TabIndex = 2;
            this.txtMaterial.TextChanged += new System.EventHandler(this.txtMaterial_TextChanged);
            this.txtMaterial.Enter += new System.EventHandler(this.txtMaterial_Enter);
            this.txtMaterial.Leave += new System.EventHandler(this.txtMaterial_Leave);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Location = new System.Drawing.Point(15, 40);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.Size = new System.Drawing.Size(330, 301);
            this.dgvMateriales.TabIndex = 1;
            // 
            // txtTotalMateriales
            // 
            this.txtTotalMateriales.AutoSize = true;
            this.txtTotalMateriales.Location = new System.Drawing.Point(147, 354);
            this.txtTotalMateriales.Name = "txtTotalMateriales";
            this.txtTotalMateriales.Size = new System.Drawing.Size(31, 13);
            this.txtTotalMateriales.TabIndex = 1;
            this.txtTotalMateriales.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materiales";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminarManoObra);
            this.panel3.Controls.Add(this.btnAgregarManoObra);
            this.panel3.Controls.Add(this.dgvManoObra);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtTotalManoObra);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.precioManoObra);
            this.panel3.Controls.Add(this.txtManoObra);
            this.panel3.Controls.Add(this.txtCantidadMano);
            this.panel3.Location = new System.Drawing.Point(382, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 541);
            this.panel3.TabIndex = 4;
            // 
            // btnEliminarManoObra
            // 
            this.btnEliminarManoObra.Location = new System.Drawing.Point(230, 494);
            this.btnEliminarManoObra.Name = "btnEliminarManoObra";
            this.btnEliminarManoObra.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarManoObra.TabIndex = 15;
            this.btnEliminarManoObra.Text = "Eliminar";
            this.btnEliminarManoObra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarManoObra
            // 
            this.btnAgregarManoObra.Location = new System.Drawing.Point(20, 494);
            this.btnAgregarManoObra.Name = "btnAgregarManoObra";
            this.btnAgregarManoObra.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarManoObra.TabIndex = 14;
            this.btnAgregarManoObra.Text = "Agregar";
            this.btnAgregarManoObra.UseVisualStyleBackColor = true;
            // 
            // dgvManoObra
            // 
            this.dgvManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObra.Location = new System.Drawing.Point(18, 40);
            this.dgvManoObra.Name = "dgvManoObra";
            this.dgvManoObra.Size = new System.Drawing.Size(330, 301);
            this.dgvManoObra.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio:";
            // 
            // txtTotalManoObra
            // 
            this.txtTotalManoObra.AutoSize = true;
            this.txtTotalManoObra.Location = new System.Drawing.Point(167, 354);
            this.txtTotalManoObra.Name = "txtTotalManoObra";
            this.txtTotalManoObra.Size = new System.Drawing.Size(31, 13);
            this.txtTotalManoObra.TabIndex = 2;
            this.txtTotalManoObra.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad de horas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mano de obra";
            // 
            // precioManoObra
            // 
            this.precioManoObra.Location = new System.Drawing.Point(230, 446);
            this.precioManoObra.Name = "precioManoObra";
            this.precioManoObra.Size = new System.Drawing.Size(120, 20);
            this.precioManoObra.TabIndex = 11;
            // 
            // txtManoObra
            // 
            this.txtManoObra.Location = new System.Drawing.Point(20, 397);
            this.txtManoObra.Name = "txtManoObra";
            this.txtManoObra.Size = new System.Drawing.Size(330, 20);
            this.txtManoObra.TabIndex = 9;
            // 
            // txtCantidadMano
            // 
            this.txtCantidadMano.Location = new System.Drawing.Point(20, 446);
            this.txtCantidadMano.Name = "txtCantidadMano";
            this.txtCantidadMano.Size = new System.Drawing.Size(120, 20);
            this.txtCantidadMano.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 766);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Presupuesto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.AutoSize = true;
            this.txtPresupuesto.Location = new System.Drawing.Point(424, 766);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(40, 13);
            this.txtPresupuesto.TabIndex = 6;
            this.txtPresupuesto.Text = "$00.00";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(352, 805);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(130, 20);
            this.txtDescuento.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 808);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Descuento";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.AutoSize = true;
            this.txtPrecioFinal.Location = new System.Drawing.Point(424, 847);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(40, 13);
            this.txtPrecioFinal.TabIndex = 8;
            this.txtPrecioFinal.Text = "$00.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 847);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Presupuesto:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSiguiente.Location = new System.Drawing.Point(352, 887);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(130, 23);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // PresupuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(757, 958);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PresupuestoForm";
            this.Text = "PresupuestoForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadMano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvManoObra;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label txtTotalMateriales;
        private System.Windows.Forms.Label txtTotalManoObra;
        private System.Windows.Forms.NumericUpDown txtPrecio;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnEliminarManoObra;
        private System.Windows.Forms.Button btnAgregarManoObra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown precioManoObra;
        private System.Windows.Forms.TextBox txtManoObra;
        private System.Windows.Forms.NumericUpDown txtCantidadMano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtPresupuesto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPrecioFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSiguiente;
    }
}