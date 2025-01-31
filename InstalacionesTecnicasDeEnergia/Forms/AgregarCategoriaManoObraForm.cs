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
    public partial class AgregarCategoriaManoObraForm : Form
    {
        Conexion conexion = new Conexion();
        ManodeObraForm manodeObraForm = new ManodeObraForm();
        public AgregarCategoriaManoObraForm()
        {
            InitializeComponent();
        }

        public AgregarCategoriaManoObraForm(ManodeObraForm manoObra)
        {
            InitializeComponent();
            this.manodeObraForm = manoObra;
        }

        private void cargarTabla()
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<CategoriaManoObra> categorias = conexion.CategoriaManoObraDb.Find(d => true).ToList();
            dataGridView1.DataSource = categorias;
            dataGridView1.Columns["Id"].Visible = false;
            this.manodeObraForm.cargarCategoriaManoObra();
        }

        private void actualizarCategoria(string id, CategoriaManoObra categoria)
        {
            var categoriaActualizar = Builders<CategoriaManoObra>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<CategoriaManoObra>.Update
            .Set(p => p.Nombre, categoria.Nombre);

            var resultado = conexion.CategoriaManoObraDb.UpdateOne(categoriaActualizar, actualizacion);
            cargarTabla();
        }

        private void eliminarCategoria(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar la categoria?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var categoriaEliminar = Builders<CategoriaManoObra>.Filter.Eq(p => p.Id, id);
                conexion.CategoriaManoObraDb.DeleteOne(categoriaEliminar);
                cargarTabla();
            }
            else
            {
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaManoObra categoriaManoObra = new CategoriaManoObra();
            categoriaManoObra.Nombre = this.txtNombre.Text;

            conexion.CategoriaManoObraDb.InsertOne(categoriaManoObra);
            this.txtNombre.Text = "";
            cargarTabla();
        }

        private void AgregarCategoriaManoObraForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CategoriaManoObra> categorias = conexion.CategoriaManoObraDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;

                var categoriaSeleccionada = categorias[index];

                if (categoriaSeleccionada != null)
                {
                    this.txtNombre.Text = categoriaSeleccionada.Nombre;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            CategoriaManoObra categoria = new CategoriaManoObra();
            categoria.Nombre = this.txtNombre.Text;
            actualizarCategoria(idSeleccionado, categoria);

            cargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarCategoria(idSeleccionado);
        }
    }
}
