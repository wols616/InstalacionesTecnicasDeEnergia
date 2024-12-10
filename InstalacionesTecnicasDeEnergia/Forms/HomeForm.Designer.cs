namespace InstalacionesTecnicasDeEnergia.Forms
{
    partial class HomeForm
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
            this.btnAgregarTrabajo = new System.Windows.Forms.Button();
            this.btnTrabajosPendientes = new System.Windows.Forms.Button();
            this.btnTrabajosRealizados = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnManoObra = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(150)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(670, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(75, 136);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(178, 48);
            this.btnAgregarTrabajo.TabIndex = 1;
            this.btnAgregarTrabajo.Text = "Agregar Trabajo";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            // 
            // btnTrabajosPendientes
            // 
            this.btnTrabajosPendientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrabajosPendientes.Location = new System.Drawing.Point(75, 202);
            this.btnTrabajosPendientes.Name = "btnTrabajosPendientes";
            this.btnTrabajosPendientes.Size = new System.Drawing.Size(178, 48);
            this.btnTrabajosPendientes.TabIndex = 2;
            this.btnTrabajosPendientes.Text = "Trabajos Pendientes";
            this.btnTrabajosPendientes.UseVisualStyleBackColor = false;
            this.btnTrabajosPendientes.Click += new System.EventHandler(this.btnTrabajosPendientes_Click);
            // 
            // btnTrabajosRealizados
            // 
            this.btnTrabajosRealizados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTrabajosRealizados.Location = new System.Drawing.Point(75, 266);
            this.btnTrabajosRealizados.Name = "btnTrabajosRealizados";
            this.btnTrabajosRealizados.Size = new System.Drawing.Size(178, 48);
            this.btnTrabajosRealizados.TabIndex = 3;
            this.btnTrabajosRealizados.Text = "Trabajos Realizados";
            this.btnTrabajosRealizados.UseVisualStyleBackColor = false;
            this.btnTrabajosRealizados.Click += new System.EventHandler(this.btnTrabajosRealizados_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(75, 327);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(178, 48);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Ver Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInventario.Location = new System.Drawing.Point(75, 384);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(178, 48);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Ver Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnManoObra
            // 
            this.btnManoObra.Location = new System.Drawing.Point(75, 444);
            this.btnManoObra.Name = "btnManoObra";
            this.btnManoObra.Size = new System.Drawing.Size(178, 48);
            this.btnManoObra.TabIndex = 6;
            this.btnManoObra.Text = "Mano de Obra";
            this.btnManoObra.UseVisualStyleBackColor = true;
            this.btnManoObra.Click += new System.EventHandler(this.btnManoObra_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(75, 505);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(178, 48);
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // pb1
            // 
            this.pb1.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.Logo_Moo;
            this.pb1.Location = new System.Drawing.Point(385, 150);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(173, 143);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.Logo_Moo;
            this.pb2.Location = new System.Drawing.Point(604, 150);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(173, 143);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 9;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.Logo_Moo;
            this.pb3.Location = new System.Drawing.Point(385, 312);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(173, 143);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 10;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.Logo_Moo;
            this.pb4.Location = new System.Drawing.Point(604, 312);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(173, 143);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnManoObra);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnTrabajosRealizados);
            this.Controls.Add(this.btnTrabajosPendientes);
            this.Controls.Add(this.btnAgregarTrabajo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Resize += new System.EventHandler(this.HomeForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarTrabajo;
        private System.Windows.Forms.Button btnTrabajosPendientes;
        private System.Windows.Forms.Button btnTrabajosRealizados;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnManoObra;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}