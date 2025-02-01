namespace InstalacionesTecnicasDeEnergia.Forms
{
    partial class DetalleTrabajoForm
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TablaManoObra = new System.Windows.Forms.DataGridView();
            this.TablaMateriales = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPresupuestoTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TablaEncargados = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEncargados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1304, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 50, 51, 0);
            this.label1.Size = new System.Drawing.Size(279, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo N";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1583, 161);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.ITE;
            this.pbLogo.Location = new System.Drawing.Point(28, 14);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(155, 133);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(757, 176);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(239, 22);
            this.txtFecha.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fecha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(757, 239);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 59);
            this.textBox2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lugar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 56);
            this.textBox1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción del proyecto";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(267, 177);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(239, 22);
            this.txtNombreCliente.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre del cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mano de Obra:";
            // 
            // TablaManoObra
            // 
            this.TablaManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaManoObra.Location = new System.Drawing.Point(75, 367);
            this.TablaManoObra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TablaManoObra.Name = "TablaManoObra";
            this.TablaManoObra.RowHeadersWidth = 51;
            this.TablaManoObra.Size = new System.Drawing.Size(923, 185);
            this.TablaManoObra.TabIndex = 23;
            this.TablaManoObra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TablaMateriales
            // 
            this.TablaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMateriales.Location = new System.Drawing.Point(75, 576);
            this.TablaMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TablaMateriales.Name = "TablaMateriales";
            this.TablaMateriales.RowHeadersWidth = 51;
            this.TablaMateriales.Size = new System.Drawing.Size(923, 185);
            this.TablaMateriales.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 556);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Materiales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 1007);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Presupuesto Total:";
            // 
            // txtPresupuestoTotal
            // 
            this.txtPresupuestoTotal.Location = new System.Drawing.Point(223, 1007);
            this.txtPresupuestoTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPresupuestoTotal.Name = "txtPresupuestoTotal";
            this.txtPresupuestoTotal.Size = new System.Drawing.Size(132, 22);
            this.txtPresupuestoTotal.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 1007);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Encargados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TablaEncargados
            // 
            this.TablaEncargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEncargados.Location = new System.Drawing.Point(75, 795);
            this.TablaEncargados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TablaEncargados.Name = "TablaEncargados";
            this.TablaEncargados.RowHeadersWidth = 51;
            this.TablaEncargados.Size = new System.Drawing.Size(923, 185);
            this.TablaEncargados.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 775);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Encargados:";
            // 
            // DetalleTrabajoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 935);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TablaEncargados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPresupuestoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TablaMateriales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TablaManoObra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetalleTrabajoForm";
            this.Text = "DetalleTrabajoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetalleTrabajoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEncargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TablaManoObra;
        private System.Windows.Forms.DataGridView TablaMateriales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPresupuestoTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView TablaEncargados;
        private System.Windows.Forms.Label label10;
    }
}