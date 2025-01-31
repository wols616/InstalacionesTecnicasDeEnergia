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
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtTotalMateriales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxObra = new System.Windows.Forms.ComboBox();
            this.btnEliminarManoObra = new System.Windows.Forms.Button();
            this.dgvManoObra = new System.Windows.Forms.DataGridView();
            this.txtTotalManoObra = new System.Windows.Forms.Label();
            this.btnAgregarManoObra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadMano = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtPreFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadMano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1636, 128);
            this.panel1.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.ITE_Propio;
            this.pbLogo.Location = new System.Drawing.Point(21, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(116, 108);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1369, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 41, 38, 0);
            this.label1.Size = new System.Drawing.Size(267, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.cbxMaterial);
            this.panel2.Controls.Add(this.btnEliminarMaterial);
            this.panel2.Controls.Add(this.btnAgregarMaterial);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvMateriales);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.txtTotalMateriales);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(394, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 541);
            this.panel2.TabIndex = 3;
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(48, 388);
            this.cbxMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(350, 27);
            this.cbxMaterial.TabIndex = 9;
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnEliminarMaterial.Location = new System.Drawing.Point(249, 495);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(105, 29);
            this.btnEliminarMaterial.TabIndex = 8;
            this.btnEliminarMaterial.Text = "Eliminar";
            this.btnEliminarMaterial.UseVisualStyleBackColor = true;
            this.btnEliminarMaterial.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEliminarMaterial_Paint);
            this.btnEliminarMaterial.MouseEnter += new System.EventHandler(this.btnEliminarMaterial_MouseEnter);
            this.btnEliminarMaterial.MouseLeave += new System.EventHandler(this.btnEliminarMaterial_MouseLeave);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnAgregarMaterial.Location = new System.Drawing.Point(84, 495);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(105, 29);
            this.btnAgregarMaterial.TabIndex = 7;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            this.btnAgregarMaterial.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarMaterial_Paint);
            this.btnAgregarMaterial.MouseEnter += new System.EventHandler(this.btnAgregarMaterial_MouseEnter);
            this.btnAgregarMaterial.MouseLeave += new System.EventHandler(this.btnAgregarMaterial_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMateriales.Location = new System.Drawing.Point(48, 63);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.RowHeadersWidth = 51;
            this.dgvMateriales.Size = new System.Drawing.Size(350, 288);
            this.dgvMateriales.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(180, 441);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 29);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtTotalMateriales
            // 
            this.txtTotalMateriales.AutoSize = true;
            this.txtTotalMateriales.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtTotalMateriales.ForeColor = System.Drawing.Color.White;
            this.txtTotalMateriales.Location = new System.Drawing.Point(198, 363);
            this.txtTotalMateriales.Name = "txtTotalMateriales";
            this.txtTotalMateriales.Size = new System.Drawing.Size(55, 21);
            this.txtTotalMateriales.TabIndex = 1;
            this.txtTotalMateriales.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materiales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel3.Controls.Add(this.cbxObra);
            this.panel3.Controls.Add(this.btnEliminarManoObra);
            this.panel3.Controls.Add(this.dgvManoObra);
            this.panel3.Controls.Add(this.txtTotalManoObra);
            this.panel3.Controls.Add(this.btnAgregarManoObra);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCantidadMano);
            this.panel3.Location = new System.Drawing.Point(914, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 541);
            this.panel3.TabIndex = 4;
            // 
            // cbxObra
            // 
            this.cbxObra.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cbxObra.FormattingEnabled = true;
            this.cbxObra.Location = new System.Drawing.Point(50, 388);
            this.cbxObra.Margin = new System.Windows.Forms.Padding(2);
            this.cbxObra.Name = "cbxObra";
            this.cbxObra.Size = new System.Drawing.Size(350, 27);
            this.cbxObra.TabIndex = 10;
            // 
            // btnEliminarManoObra
            // 
            this.btnEliminarManoObra.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarManoObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.btnEliminarManoObra.Location = new System.Drawing.Point(254, 495);
            this.btnEliminarManoObra.Name = "btnEliminarManoObra";
            this.btnEliminarManoObra.Size = new System.Drawing.Size(105, 29);
            this.btnEliminarManoObra.TabIndex = 15;
            this.btnEliminarManoObra.Text = "Eliminar";
            this.btnEliminarManoObra.UseVisualStyleBackColor = true;
            this.btnEliminarManoObra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEliminarManoObra_Paint);
            this.btnEliminarManoObra.MouseEnter += new System.EventHandler(this.btnEliminarManoObra_MouseEnter);
            this.btnEliminarManoObra.MouseLeave += new System.EventHandler(this.btnEliminarManoObra_MouseLeave);
            // 
            // dgvManoObra
            // 
            this.dgvManoObra.BackgroundColor = System.Drawing.Color.White;
            this.dgvManoObra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManoObra.Location = new System.Drawing.Point(50, 63);
            this.dgvManoObra.Name = "dgvManoObra";
            this.dgvManoObra.RowHeadersWidth = 51;
            this.dgvManoObra.Size = new System.Drawing.Size(350, 288);
            this.dgvManoObra.TabIndex = 5;
            this.dgvManoObra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManoObra_CellContentClick);
            // 
            // txtTotalManoObra
            // 
            this.txtTotalManoObra.AutoSize = true;
            this.txtTotalManoObra.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtTotalManoObra.ForeColor = System.Drawing.Color.White;
            this.txtTotalManoObra.Location = new System.Drawing.Point(189, 354);
            this.txtTotalManoObra.Name = "txtTotalManoObra";
            this.txtTotalManoObra.Size = new System.Drawing.Size(55, 21);
            this.txtTotalManoObra.TabIndex = 2;
            this.txtTotalManoObra.Text = "Total";
            // 
            // btnAgregarManoObra
            // 
            this.btnAgregarManoObra.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarManoObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(176)))), ((int)(((byte)(0)))));
            this.btnAgregarManoObra.Location = new System.Drawing.Point(88, 495);
            this.btnAgregarManoObra.Name = "btnAgregarManoObra";
            this.btnAgregarManoObra.Size = new System.Drawing.Size(105, 29);
            this.btnAgregarManoObra.TabIndex = 14;
            this.btnAgregarManoObra.Text = "Agregar";
            this.btnAgregarManoObra.UseVisualStyleBackColor = true;
            this.btnAgregarManoObra.Click += new System.EventHandler(this.btnAgregarManoObra_Click);
            this.btnAgregarManoObra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarManoObra_Paint);
            this.btnAgregarManoObra.MouseEnter += new System.EventHandler(this.btnAgregarManoObra_MouseEnter);
            this.btnAgregarManoObra.MouseLeave += new System.EventHandler(this.btnAgregarManoObra_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mano de obra";
            // 
            // txtCantidadMano
            // 
            this.txtCantidadMano.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtCantidadMano.Location = new System.Drawing.Point(179, 441);
            this.txtCantidadMano.Name = "txtCantidadMano";
            this.txtCantidadMano.Size = new System.Drawing.Size(220, 29);
            this.txtCantidadMano.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(707, 778);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Presupuesto Inicial:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtDescuento.Location = new System.Drawing.Point(892, 815);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(121, 32);
            this.txtDescuento.TabIndex = 1;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(775, 824);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Descuento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(717, 868);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Presupuesto Final:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Window;
            this.btnSiguiente.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnSiguiente.Location = new System.Drawing.Point(1440, 824);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(188, 41);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            this.btnSiguiente.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSiguiente_Paint);
            this.btnSiguiente.MouseEnter += new System.EventHandler(this.btnSiguiente_MouseEnter);
            this.btnSiguiente.MouseLeave += new System.EventHandler(this.btnSiguiente_MouseLeave);
            // 
            // txtPre
            // 
            this.txtPre.Enabled = false;
            this.txtPre.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtPre.Location = new System.Drawing.Point(892, 769);
            this.txtPre.Margin = new System.Windows.Forms.Padding(2);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(121, 32);
            this.txtPre.TabIndex = 10;
            // 
            // txtPreFinal
            // 
            this.txtPreFinal.Enabled = false;
            this.txtPreFinal.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtPreFinal.Location = new System.Drawing.Point(892, 859);
            this.txtPreFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreFinal.Name = "txtPreFinal";
            this.txtPreFinal.Size = new System.Drawing.Size(121, 32);
            this.txtPreFinal.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1394, 1002);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PresupuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1653, 942);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPreFinal);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PresupuestoForm";
            this.Text = "PresupuestoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManoObra)).EndInit();
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
        private System.Windows.Forms.Label txtTotalMateriales;
        private System.Windows.Forms.Label txtTotalManoObra;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnEliminarManoObra;
        private System.Windows.Forms.Button btnAgregarManoObra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtCantidadMano;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.ComboBox cbxObra;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtPreFinal;
        private System.Windows.Forms.Button button1;
    }
}