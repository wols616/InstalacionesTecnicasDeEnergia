using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using InstalacionesTecnicasDeEnergia.Models;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
            configurarFormulario();
        }

        private void configurarFormulario()
        {
            Conexion conexion = new Conexion();
            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.75);
            int heighDisplay = (int)(Screen.PrimaryScreen.Bounds.Height * 0.75);

            //Ajustar el formulario para ocupar un porcentaje de la pantalla
            this.Width = widthDisplay;
            this.Height = heighDisplay;

            //Centrarlo
            this.StartPosition = FormStartPosition.CenterScreen;

            //Adaptar el panel a todo el ancho
            this.panel1.Width = Width;
            this.label1.Left = (Width - label1.Width) - 20;

            // Definición de los datos de los combo box
            try
            {
                List<CategoriaMaterial> categorias = conexion.CategoriaMaterialDb.Find(d => true).ToList();

                this.cbxCategoria.DataSource = categorias;
                this.cbxCategoria.DisplayMember = "Nombre";
                this.cbxCategoria.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void InventarioForm_Resize(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            Material material = new Material();

            material.Nombre = this.txtNombreMaterial.Text;
            material.Descripcion = this.txt_descripcion.Text;
            material.CategoriaId = this.cbxCategoria.SelectedValue.ToString();
            material.Cantidad = int.Parse(this.textCantidad.Text);
            material.PrecioCompra = double.Parse(this.textCosto.Text);
            material.Marca = this.txtProveedor.Text;
            material.FechaCompra = this.dateTimePicker1.Value;

            //conexion.MaterialDb.InsertOne(material);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
