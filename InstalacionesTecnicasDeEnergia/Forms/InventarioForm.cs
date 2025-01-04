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
        Conexion conexion = new Conexion();
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
            

        }


        private void InventarioForm_Resize(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            Material material = new Material();
            material.Nombre = this.txtNombreMaterial.Text;
            material.Marca = this.txtMarca.Text;
            material.PrecioCompra = Double.Parse(this.textCosto.Value.ToString());
            material.PrecioVenta = Double.Parse(this.txtPrecioVenta.Value.ToString());
            material.Cantidad = int.Parse(this.textCantidad.Value.ToString());
            material.Descripcion = this.txt_descripcion.Text;
            material.FechaCompra = this.dateTimePicker1.Value;
            material.CategoriaId = this.cbxCategoria.SelectedValue.ToString();
            actualizarMaterial(idSeleccionado, material);

            cargarRegistroMateriales();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Material material = new Material();

            material.Nombre = this.txtNombreMaterial.Text;
            material.Descripcion = this.txt_descripcion.Text;
            material.CategoriaId = this.cbxCategoria.SelectedValue.ToString();
            material.Cantidad = int.Parse(this.textCantidad.Text);
            material.PrecioCompra = double.Parse(this.textCosto.Text);
            material.PrecioVenta = double.Parse(this.txtPrecioVenta.Text);
            material.FechaCompra = this.dateTimePicker1.Value;
            material.Marca = this.txtMarca.Text;

            conexion.MaterialDb.InsertOne(material);

            cargarRegistroMateriales();
            limpiarCampos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            this.txtNombreMaterial.Text = "";
            this.txt_descripcion.Text = "";
            this.textCantidad.Text = "0";
            this.textCosto.Text = "0";
            this.txtMarca.Text = "0";
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarRegistroMateriales();
        }

        public void cargarRegistroMateriales()
        {
            List<Material> materiales = conexion.MaterialDb.Find(d => true).ToList();
            dataGridView1.DataSource = materiales;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CategoriaId"].Visible = false;

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

        private void eliminarRegistoMaterial(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar el material?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var materialEliminar = Builders<Material>.Filter.Eq(p => p.Id, id);
                conexion.MaterialDb.DeleteOne(materialEliminar);
                cargarRegistroMateriales();
            }
            else
            {
                return;
            }
        }

        private void actualizarMaterial(string id, Material material)
        {
            Conexion conexion = new Conexion();
            var materialActualizar = Builders<Material>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<Material>.Update
            .Set(p => p.Nombre, material.Nombre)
            .Set(p => p.Marca, material.Marca)
            .Set(p => p.Cantidad, material.Cantidad)
            .Set(p => p.PrecioCompra, material.PrecioCompra)
            .Set(p => p.PrecioVenta, material.PrecioVenta)
            .Set(p => p.CategoriaId, material.CategoriaId)
            .Set(p => p.FechaCompra, material.FechaCompra)
            .Set(p => p.Descripcion, material.Descripcion);

            var resultado = conexion.MaterialDb.UpdateOne(materialActualizar, actualizacion);
            cargarRegistroMateriales();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Material> materiales = conexion.MaterialDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice del producto seleccionado
                int index = dataGridView1.CurrentRow.Index;

                // Buscar el producto original en la lista de productos
                var materialSeleccionado = materiales[index];

                //List<Material> categoriasProductos = conexion.CategoriaProductoDb
                //.Find(c => c.Id == materialSeleccionado.Id) // Aquí va tu condición de comparación
                //.ToList();

                if (materialSeleccionado != null)
                {
                    this.txtNombreMaterial.Text = materialSeleccionado.Nombre;
                    this.txt_descripcion.Text = materialSeleccionado.Descripcion;

                    CategoriaMaterial categoria = conexion.CategoriaMaterialDb.Find(d => d.Id == materialSeleccionado.CategoriaId).FirstOrDefault();
                    this.cbxCategoria.SelectedValue = categoria.Id;
                    this.cbxCategoria.Text = categoria.Nombre;

                    this.textCantidad.Text = materialSeleccionado.Cantidad.ToString();
                    this.textCosto.Text = materialSeleccionado.PrecioCompra.ToString();
                    this.txtPrecioVenta.Text = materialSeleccionado.PrecioVenta.ToString();
                    this.dateTimePicker1.Text = materialSeleccionado.FechaCompra.ToString();
                    this.txtMarca.Text = materialSeleccionado.Marca;

                }
         
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoriaMaterialForm form = new AgregarCategoriaMaterialForm(this);
            form.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarRegistoMaterial(idSeleccionado);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
