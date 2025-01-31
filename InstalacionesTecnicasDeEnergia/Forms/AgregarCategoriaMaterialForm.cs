using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class AgregarCategoriaMaterialForm : Form
    {
        Conexion conexion = new Conexion();
        InventarioForm inventarioForm = new InventarioForm();

        public AgregarCategoriaMaterialForm()
        {
            InitializeComponent();
        }

        public AgregarCategoriaMaterialForm(InventarioForm inventario)
        {
            InitializeComponent();
            inventarioForm = inventario;
        }

        private void cargarCategorias()
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<CategoriaMaterial> categorias = conexion.CategoriaMaterialDb.Find(d => true).ToList();
            dataGridView1.DataSource = categorias;
            dataGridView1.Columns["Id"].Visible = false;
            inventarioForm.cargarRegistroMateriales();

        }

        private void actualiarCategoriaMaterial(string id, CategoriaMaterial categoria)
        {
            var categoriaActualizar = Builders<CategoriaMaterial>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<CategoriaMaterial>.Update
            .Set(p => p.Nombre, categoria.Nombre);

            var resultado = conexion.CategoriaMaterialDb.UpdateOne(categoriaActualizar, actualizacion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaMaterial categoria = new CategoriaMaterial();
            categoria.Nombre = txtNombre.Text;

            conexion.CategoriaMaterialDb.InsertOne(categoria);
            cargarCategorias();
        }

        private void AgregarCategoriaMaterialForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarCategorias();
        }

        private void eliminarRegistroCategoria(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar la categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var categoriaEliminar = Builders<CategoriaMaterial>.Filter.Eq(p => p.Id, id);
                conexion.CategoriaMaterialDb.DeleteOne(categoriaEliminar);
                cargarCategorias();
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CategoriaMaterial> categoriaMateriales = conexion.CategoriaMaterialDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice del producto seleccionado
                int index = dataGridView1.CurrentRow.Index;

                // Buscar el producto original en la lista de productos
                var categoriaSeleccionada = categoriaMateriales[index];

                if (categoriaSeleccionada != null)
                {
                    this.txtNombre.Text = categoriaSeleccionada.Nombre;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CategoriaMaterial categoria = new CategoriaMaterial();
            categoria.Nombre = txtNombre.Text;

            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            actualiarCategoriaMaterial(idSeleccionado, categoria);
            cargarCategorias();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarRegistroCategoria(idSeleccionado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
