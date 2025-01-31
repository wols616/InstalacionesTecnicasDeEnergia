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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 131);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(1032, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 41, 38, 0);
            this.label1.Size = new System.Drawing.Size(155, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // btnAgregarTrabajo
            // 
            this.btnAgregarTrabajo.BackColor = System.Drawing.Color.White;
            this.btnAgregarTrabajo.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnAgregarTrabajo.Location = new System.Drawing.Point(106, 293);
            this.btnAgregarTrabajo.Name = "btnAgregarTrabajo";
            this.btnAgregarTrabajo.Size = new System.Drawing.Size(221, 48);
            this.btnAgregarTrabajo.TabIndex = 1;
            this.btnAgregarTrabajo.Text = "Agregar Trabajo";
            this.btnAgregarTrabajo.UseVisualStyleBackColor = false;
            this.btnAgregarTrabajo.Click += new System.EventHandler(this.btnAgregarTrabajo_Click);
            this.btnAgregarTrabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnAgregarTrabajo.MouseEnter += new System.EventHandler(this.btnAgregarTrabajo_MouseEnter_1);
            this.btnAgregarTrabajo.MouseLeave += new System.EventHandler(this.btnAgregarTrabajo_MouseLeave_1);
            // 
            // btnTrabajosPendientes
            // 
            this.btnTrabajosPendientes.BackColor = System.Drawing.Color.White;
            this.btnTrabajosPendientes.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajosPendientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnTrabajosPendientes.Location = new System.Drawing.Point(106, 358);
            this.btnTrabajosPendientes.Name = "btnTrabajosPendientes";
            this.btnTrabajosPendientes.Size = new System.Drawing.Size(221, 48);
            this.btnTrabajosPendientes.TabIndex = 2;
            this.btnTrabajosPendientes.Text = "Trabajos Pendientes";
            this.btnTrabajosPendientes.UseVisualStyleBackColor = false;
            this.btnTrabajosPendientes.Click += new System.EventHandler(this.btnTrabajosPendientes_Click);
            this.btnTrabajosPendientes.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnTrabajosPendientes.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnTrabajosPendientes.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // btnTrabajosRealizados
            // 
            this.btnTrabajosRealizados.BackColor = System.Drawing.Color.White;
            this.btnTrabajosRealizados.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajosRealizados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnTrabajosRealizados.Location = new System.Drawing.Point(106, 425);
            this.btnTrabajosRealizados.Name = "btnTrabajosRealizados";
            this.btnTrabajosRealizados.Size = new System.Drawing.Size(221, 48);
            this.btnTrabajosRealizados.TabIndex = 3;
            this.btnTrabajosRealizados.Text = "Trabajos Realizados";
            this.btnTrabajosRealizados.UseVisualStyleBackColor = false;
            this.btnTrabajosRealizados.Click += new System.EventHandler(this.btnTrabajosRealizados_Click);
            this.btnTrabajosRealizados.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnTrabajosRealizados.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnTrabajosRealizados.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.White;
            this.btnEmpleados.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnEmpleados.Location = new System.Drawing.Point(106, 493);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(221, 48);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Ver Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            this.btnEmpleados.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnEmpleados.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnEmpleados.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.White;
            this.btnInventario.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnInventario.Location = new System.Drawing.Point(106, 562);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(221, 48);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Ver Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            this.btnInventario.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnInventario.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnInventario.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // btnManoObra
            // 
            this.btnManoObra.BackColor = System.Drawing.Color.White;
            this.btnManoObra.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManoObra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnManoObra.Location = new System.Drawing.Point(106, 628);
            this.btnManoObra.Name = "btnManoObra";
            this.btnManoObra.Size = new System.Drawing.Size(221, 48);
            this.btnManoObra.TabIndex = 6;
            this.btnManoObra.Text = "Mano de Obra";
            this.btnManoObra.UseVisualStyleBackColor = false;
            this.btnManoObra.Click += new System.EventHandler(this.btnManoObra_Click);
            this.btnManoObra.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnManoObra.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnManoObra.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.White;
            this.btnBitacora.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(99)))));
            this.btnBitacora.Location = new System.Drawing.Point(106, 695);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(221, 48);
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            this.btnBitacora.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAgregarTrabajo_Paint_1);
            this.btnBitacora.MouseEnter += new System.EventHandler(this.btnBitacora_MouseEnter);
            this.btnBitacora.MouseLeave += new System.EventHandler(this.btnBitacora_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img8;
            this.pictureBox2.Location = new System.Drawing.Point(446, 549);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img7;
            this.pictureBox1.Location = new System.Drawing.Point(446, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img1;
            this.pb4.Location = new System.Drawing.Point(1252, 549);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(376, 275);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img3;
            this.pb3.Location = new System.Drawing.Point(850, 549);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(376, 275);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 10;
            this.pb3.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img2;
            this.img1.Location = new System.Drawing.Point(1252, 245);
            this.img1.Margin = new System.Windows.Forms.Padding(0);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(376, 275);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 9;
            this.img1.TabStop = false;
            this.img1.Resize += new System.EventHandler(this.pb2_Resize);
            // 
            // pb1
            // 
            this.pb1.Image = global::InstalacionesTecnicasDeEnergia.Properties.Resources.img6;
            this.pb1.Location = new System.Drawing.Point(850, 245);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(376, 275);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 857);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.img1);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.Resize += new System.EventHandler(this.HomeForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrabajosPendientes;
        private System.Windows.Forms.Button btnTrabajosRealizados;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnManoObra;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAgregarTrabajo;
    }
}