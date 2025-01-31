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
    public partial class ManodeObraForm : Form
    {
        Conexion conexion = new Conexion();
        public ManodeObraForm()
        {
            InitializeComponent();
        }

        private void cargarTabla(string filtro = "")
        {
            List<ManoObra> manosObra = conexion.ManoObraDb.Find(d => true).ToList();

            if (!string.IsNullOrEmpty(filtro))
            {
                manosObra = manosObra.Where(m => m.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                 m.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            }

            dataGridView1.DataSource = manosObra;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["CategoriaId"].Visible = false;

        }

        public void cargarCategoriaManoObra()
        {
            try
            {
                List<CategoriaManoObra> categoriaManos = conexion.CategoriaManoObraDb.Find(d => true).ToList();

                this.cbxCategoria.DataSource = categoriaManos;
                this.cbxCategoria.DisplayMember = "Nombre";
                this.cbxCategoria.ValueMember = "Id";
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void actualizarManoObra(string id, ManoObra manoObra)
        {
            Conexion conexion = new Conexion();
            var ManoObraActualizar = Builders<ManoObra>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<ManoObra>.Update
            .Set(p => p.Nombre, manoObra.Nombre)
            .Set(p => p.CategoriaId, manoObra.CategoriaId)
            .Set(p => p.Descripcion, manoObra.Descripcion)
            .Set(p => p.Precio, manoObra.Precio);

            var resultado = conexion.ManoObraDb.UpdateOne(ManoObraActualizar, actualizacion);
            cargarTabla();
        }

        private void eliminarManoObra(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar la mano de obra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var manoEliminar = Builders<ManoObra>.Filter.Eq(p => p.Id, id);
                conexion.ManoObraDb.DeleteOne(manoEliminar);
                cargarTabla();
            }
            else
            {
                return;
            }
        }

        private void ManodeObra_Load(object sender, EventArgs e)
        {
            cargarCategoriaManoObra();
            cargarTabla();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoriaManoObraForm frm = new AgregarCategoriaManoObraForm(this);
            frm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ManoObra manoObra = new ManoObra
            {
                Nombre = this.txtNombre.Text,
                Descripcion = this.txtDescripcion.Text,
                Precio = Double.Parse(this.txtPrecio.Text),
                CategoriaId = this.cbxCategoria.SelectedValue.ToString(),
            };
            conexion.ManoObraDb.InsertOne(manoObra);
            cargarTabla();
            MessageBox.Show("Mano de obra agregada correctamente");
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<ManoObra> manosObra = conexion.ManoObraDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice del producto seleccionado
                int index = dataGridView1.CurrentRow.Index;

                // Buscar el producto original en la lista de productos
                var manoSeleccionada = manosObra[index];

                if (manoSeleccionada != null)
                {
                    this.txtNombre.Text = manoSeleccionada.Nombre;
                    this.txtDescripcion.Text = manoSeleccionada.Descripcion;
                    this.txtPrecio.Value = Decimal.Parse(manoSeleccionada.Precio.ToString());

                    CategoriaManoObra categoria = conexion.CategoriaManoObraDb.Find(d => d.Id == manoSeleccionada.CategoriaId).FirstOrDefault();
                    this.cbxCategoria.SelectedValue = categoria.Id;
                    this.cbxCategoria.Text = categoria.Nombre;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            ManoObra manoObra = new ManoObra { 
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = Double.Parse(txtPrecio.Value.ToString()),
                CategoriaId = cbxCategoria.SelectedValue.ToString(),
            };
            actualizarManoObra(idSeleccionado, manoObra);

            cargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarManoObra(idSeleccionado);
        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar";
                txtBuscar.ForeColor = Color.Gray; // Cambia el color del texto si lo prefieres
            }
        }

        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black; // Cambia el color del texto si lo prefieres
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim(); // Elimina espacios innecesarios

            if (string.IsNullOrEmpty(filtro) || txtBuscar.Text == "Buscar")
            {
                // Si no hay filtro, recarga todos los datos originales
                cargarTabla();
            }
            else
            {
                // Aplica el filtro sobre la lista original
                List<ManoObra> manosObra = conexion.ManoObraDb.Find(d => true).ToList();
                manosObra = manosObra.Where(m => (m.Nombre != null && m.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                                 (m.Descripcion != null && m.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();

                // Actualiza el DataGridView con los resultados filtrados
                dataGridView1.DataSource = manosObra;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
