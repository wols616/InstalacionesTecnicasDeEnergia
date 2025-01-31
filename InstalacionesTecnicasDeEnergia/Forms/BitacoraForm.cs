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
    public partial class BitacoraForm : Form
    {
        Conexion conexion = new Conexion();
        public BitacoraForm()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
            try
            {
                List<Bitacora> bitacoras = conexion.BitacoraDb.Find(d => true).ToList();
                dataGridView1.DataSource = bitacoras;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Contenido"].Visible = false;
                dataGridView1.Columns["Anotacion"].Visible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la bitacora: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarBitacora(string id, Bitacora bitacora)
        {
            Conexion conexion = new Conexion();
            var bitacoraActualizar = Builders<Bitacora>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<Bitacora>.Update
            .Set(p => p.Titulo, bitacora.Titulo)
            .Set(p => p.Contenido, bitacora.Contenido)
            .Set(p => p.Anotacion, bitacora.Anotacion)
            .Set(p => p.Fecha, bitacora.Fecha);

            var resultado = conexion.BitacoraDb.UpdateOne(bitacoraActualizar, actualizacion);
            cargarTabla();
        }

        private void limpiarCampos()
        {
            this.txtTitulo.Clear();
            this.txtContenido.Clear();
            this.txtAnotacion.Clear();
        }

        private void eliminarEntradaBitacora(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar la entrada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var entradaBitacoraEliminar = Builders<Bitacora>.Filter.Eq(p => p.Id, id);
                conexion.BitacoraDb.DeleteOne(entradaBitacoraEliminar);
                cargarTabla();
            }
            else
            {
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                Bitacora bitacora = new Bitacora
                {
                    Titulo = this.txtTitulo.Text,
                    Contenido = this.txtContenido.Text,
                    Fecha = txtFecha.Value.ToString("yyyy/MM/dd"),
                    Anotacion = this.txtAnotacion.Text,
                };

                conexion.BitacoraDb.InsertOne(bitacora);

                cargarTabla();
                limpiarCampos();
            }
            catch {
                MessageBox.Show("Error al registrar la entrada");
            }

        }

        private void BitacoraForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Bitacora> bitacoras = conexion.BitacoraDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice del producto seleccionado
                int index = dataGridView1.CurrentRow.Index;

                var bitacoraSeleccionada = bitacoras[index];

                if (bitacoraSeleccionada != null)
                {
                    this.txtTitulo.Text = bitacoraSeleccionada.Titulo;
                    this.txtContenido.Text = bitacoraSeleccionada.Contenido;
                    this.txtAnotacion.Text = bitacoraSeleccionada.Anotacion;
                    this.txtFecha.Text = bitacoraSeleccionada.Fecha.ToString();
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            Bitacora bitacora = new Bitacora
            {
                Titulo = this.txtTitulo.Text,
                Contenido = this.txtContenido.Text,
                Anotacion = this.txtContenido.Text,
                Fecha = txtFecha.Value.ToString("yyyy/MM/dd")
            };
            
            actualizarBitacora(idSeleccionado, bitacora);

            cargarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarEntradaBitacora(idSeleccionado);
        }

        private void btnAumentarFuente_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                float nuevoTamaño = control.Font.Size + 1;
                control.Font = new Font(control.Font.FontFamily, nuevoTamaño);
            }

        }

        private void btnDisminuirFuente_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                float nuevoTamaño = control.Font.Size - 1;
                control.Font = new Font(control.Font.FontFamily, nuevoTamaño);
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }
    }
}
