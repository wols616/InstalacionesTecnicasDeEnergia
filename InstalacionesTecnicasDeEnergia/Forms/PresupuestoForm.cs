using InstalacionesTecnicasDeEnergia.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;
using System.Drawing.Drawing2D;
using System.IO;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class PresupuestoForm : Form
    {
        Conexion conexion = new Conexion();

        Trabajo trabajoPendiente = new Trabajo();

        public PresupuestoForm()
        {
            InitializeComponent();
            configurarFormulario();
        }

        public PresupuestoForm(Trabajo trabajo)
        {
            InitializeComponent();
            configurarFormulario();
            trabajoPendiente = trabajo;
        }

        private void configurarFormulario()
        {
            ////Ancho de la pantalla
            //int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.40);
            //int heighDisplay = (int)(Screen.PrimaryScreen.Bounds.Height * 0.60);

            ////Ajustar el formulario para ocupar un porcentaje de la pantalla
            //this.Width = widthDisplay;
            //this.Height = heighDisplay;

            ////Centrarlo
            //this.StartPosition = FormStartPosition.CenterScreen;

            ////Adaptar el panel a todo el ancho
            //this.panel1.Width = Width;
            //this.label1.Left = (Width - label1.Width) - 20;

            dgvManoObra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewTextBoxColumn idMaterialColumn = new DataGridViewTextBoxColumn();
            idMaterialColumn.Name = "Id";
            idMaterialColumn.HeaderText = "Id";
            idMaterialColumn.Visible = false; // Ocultar columna
            dgvMateriales.Columns.Add(idMaterialColumn);

            dgvMateriales.Columns.Add("Material", "Material");
            dgvMateriales.Columns.Add("Cantidad", "Cantidad");
            dgvMateriales.Columns.Add("Precio", "Precio");

            // DataGridView para mano de obra
            DataGridViewTextBoxColumn idManoObraColumn = new DataGridViewTextBoxColumn();
            idManoObraColumn.Name = "Id";
            idManoObraColumn.HeaderText = "Id";
            idManoObraColumn.Visible = false; // Ocultar columna
            dgvManoObra.Columns.Add(idManoObraColumn);

            dgvManoObra.Columns.Add("ManoObra", "Mano de Obra");
            dgvManoObra.Columns.Add("Cantidad", "Cantidad");
            dgvManoObra.Columns.Add("Precio", "Precio");


            // Definición de los datos de los combo box
            try
            {
                var materiales = conexion.MaterialDb.Find(_ => true).ToList();

                this.cbxMaterial.DataSource = materiales;
                this.cbxMaterial.DisplayMember = "Nombre";
                this.cbxMaterial.ValueMember = "Id";
            } 
            catch (Exception ex) {
                MessageBox.Show($"Error al cargar materiales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var materiales = conexion.ManoObraDb.Find(_ => true).ToList();

                this.cbxObra.DataSource = materiales;
                this.cbxObra.DisplayMember = "Nombre";
                this.cbxObra.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar Mano de obra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaterial_Enter(object sender, EventArgs e)
        {
        }

        private void txtMaterial_Leave(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            double descuento = 0;
            if (this.txtDescuento != null)
            {
                descuento = Double.Parse(this.txtDescuento.Text);
            }
            trabajoPendiente.Presupuesto = Double.Parse(this.txtPre.Text) - descuento;
            llenarListaMateriales();
            llenarListaManoObra();
            
            EncargadosForm frm = new EncargadosForm(trabajoPendiente);
            frm.Show();
            this.Hide();
        }

        private void llenarListaMateriales()
        {
            foreach (DataGridViewRow row in dgvMateriales.Rows)
            {
                // Asegúrate de que la fila no esté vacía
                if (row.Cells["Id"].Value != null && row.Cells["Material"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    // Crea un nuevo objeto MaterialUsado
                    MaterialUsado material = new MaterialUsado
                    {
                        MaterialId = row.Cells["Id"].Value.ToString(),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value)
                    };

                    // Agrega el objeto a la lista de materiales
                    trabajoPendiente.Materiales.Add(material);
                }
            }
        }

        private void llenarListaManoObra()
        {
            foreach (DataGridViewRow row in dgvManoObra.Rows)
            {
                // Asegúrate de que la fila no esté vacía
                if (row.Cells["Id"].Value != null && row.Cells["ManoObra"].Value != null && row.Cells["Cantidad"].Value != null)
                {
                    // Crea un nuevo objeto MaterialUsado
                    ManoObraUsada manoObra = new ManoObraUsada
                    {
                        ManoObraId = row.Cells["Id"].Value.ToString(),
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value)
                    };

                    // Agrega el objeto a la lista de materiales
                    trabajoPendiente.ManoObra.Add(manoObra);
                }
            }
        }

        private void dgvManoObra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            string idMaterialSeleccionado = this.cbxMaterial.SelectedValue.ToString();

            Material material = conexion.MaterialDb.Find(d => d.Id == idMaterialSeleccionado).FirstOrDefault();

            if (material != null)
            {
                dgvMateriales.Rows.Add(idMaterialSeleccionado, material.Nombre, this.txtCantidad.Text, material.PrecioVenta);
            }
            else
            {
                MessageBox.Show("Material no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizarPresupuesto();
        }

        private void btnAgregarManoObra_Click(object sender, EventArgs e)
        {
            string idManoObraSeleccionada = this.cbxObra.SelectedValue.ToString();

            ManoObra manoObra = conexion.ManoObraDb.Find(d => d.Id == idManoObraSeleccionada).FirstOrDefault();

            if (manoObra != null)
            {
                dgvManoObra.Rows.Add(idManoObraSeleccionada, manoObra.Nombre, this.txtCantidadMano.Text, manoObra.Precio);
            }
            else
            {
                MessageBox.Show("Mano de obra no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            actualizarPresupuesto();
        }

        private void actualizarPresupuesto()
        {
            double presupuesto = 0;

            // Suma materiales
            foreach (DataGridViewRow row in dgvMateriales.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    presupuesto += Double.Parse(row.Cells["Cantidad"].Value.ToString()) * Double.Parse(row.Cells["Precio"].Value.ToString());
                }
            }

            // Suma mano de obra
            foreach (DataGridViewRow row in dgvManoObra.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    presupuesto += Double.Parse(row.Cells["Cantidad"].Value.ToString()) * Double.Parse(row.Cells["Precio"].Value.ToString());
                }
            }

            this.txtPre.Text = presupuesto.ToString();
            try
            {
                this.txtPreFinal.Text = (presupuesto - Double.Parse(this.txtDescuento.Text)).ToString();
            }
            catch { }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtPreFinal.Text = (Double.Parse(this.txtPre.Text) - Double.Parse(txtDescuento.Text)).ToString();
            }
            catch { }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AgregarTrabajoForm frm = new AgregarTrabajoForm();
            frm.Show();
            this.Hide();
        }

        private void btnAgregarMaterial_Paint(object sender, PaintEventArgs e)
        {
             Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#38b000"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }

        }

        private void btnAgregarMaterial_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#38b000"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnAgregarMaterial_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#38b000"); // Volver al color original del texto
        }

        private void btnAgregarManoObra_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#38b000"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }
        }

        private void btnAgregarManoObra_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#38b000"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnAgregarManoObra_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#38b000"); // Volver al color original del texto
        }

        private void btnEliminarMaterial_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#c81d25"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }
        }

        private void btnEliminarMaterial_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#c81d25"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnEliminarMaterial_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#c81d25"); // Volver al color original del texto
        }

        private void btnEliminarManoObra_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#c81d25"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }
        }

        private void btnEliminarManoObra_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#c81d25"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnEliminarManoObra_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#c81d25"); // Volver al color original del texto
        }

        private void txtPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            int borderRadius = 20; // Tamaño del radio de las esquinas
            int borderSize = 8; // Grosor del borde
            Color borderColor = ColorTranslator.FromHtml("#284b63"); // Color del borde

            Graphics gfx = e.Graphics;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Crear un rectángulo redondeado
            using (GraphicsPath path = new GraphicsPath())
            {
                int arcSize = borderRadius * 2;
                path.AddArc(0, 0, arcSize, arcSize, 180, 90);
                path.AddArc(btn.Width - arcSize, 0, arcSize, arcSize, 270, 90);
                path.AddArc(btn.Width - arcSize, btn.Height - arcSize, arcSize, arcSize, 0, 90);
                path.AddArc(0, btn.Height - arcSize, arcSize, arcSize, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path); // Aplica la forma al botón

                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, borderSize))
                {
                    gfx.DrawPath(pen, path);
                }
            }
        }

        private void btnSiguiente_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = ColorTranslator.FromHtml("#284b63"); // Cambiar color al pasar el mouse
            btn.ForeColor = Color.White; // Cambiar color del texto
        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White; // Volver al color original
            btn.ForeColor = ColorTranslator.FromHtml("#284b63"); // Volver al color original del texto
        }
    }
}
