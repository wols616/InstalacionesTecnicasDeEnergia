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
            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.40);
            int heighDisplay = (int)(Screen.PrimaryScreen.Bounds.Height * 0.60);

            //Ajustar el formulario para ocupar un porcentaje de la pantalla
            this.Width = widthDisplay;
            this.Height = heighDisplay;

            //Centrarlo
            this.StartPosition = FormStartPosition.CenterScreen;

            //Adaptar el panel a todo el ancho
            this.panel1.Width = Width;
            this.label1.Left = (Width - label1.Width) - 20;

            // Definición de la estructura de las tablas
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.Visible = false; // Ocultar columna
            dgvMateriales.Columns.Add(idColumn);

            dgvMateriales.Columns.Add("Material", "Material");
            dgvMateriales.Columns.Add("Cantidad", "Cantidad");

            DataGridViewTextBoxColumn idColumn2 = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.Visible = false;
            dgvManoObra.Columns.Add(idColumn2);

            dgvManoObra.Columns.Add("ManoObra", "ManoObra");
            dgvManoObra.Columns.Add("Cantidad", "Cantidad");

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
            trabajoPendiente.Presupuesto = Double.Parse(this.txtPresupuesto.Text) - Double.Parse(this.txtDescuento.Text);
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
    }
}
