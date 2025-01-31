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
    public partial class TrabajosPendientesForm : Form
    {
        Conexion conexion = new Conexion();
        Trabajo trabajoPendiente;
        public TrabajosPendientesForm()
        {
            InitializeComponent();
            configurarFormulario();
        }

        public TrabajosPendientesForm(Trabajo trabajo)
        {
            InitializeComponent();
            configurarFormulario();

            trabajoPendiente = trabajo;
        }

        private void cargarTabla()
        {
            List<Trabajo> trabajos = conexion.TrabajoDb.Find(d => d.Estado == "Pendiente").ToList();
            dataGridView1.DataSource = trabajos;
            dataGridView1.Columns["Id"].Visible = false;
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
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetalleTrabajoForm frm = new DetalleTrabajoForm();
            frm.Show();
            this.Hide();
        }

        private void TrabajosPendientesForm_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void actualizarTrabajo(string id, Trabajo trabajo)
        {
            var trabajoActualizar = Builders<Trabajo>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<Trabajo>.Update
            .Set(p => p.Estado, trabajo.Estado);

            var resultado = conexion.TrabajoDb.UpdateOne(trabajoActualizar, actualizacion);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Trabajo> trabajos = conexion.TrabajoDb.Find(d => d.Estado == "Pendiente").ToList();

            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;

                // Buscar el producto original en la lista de productos
                var trabajoSeleccionado = trabajos[index];

                if (trabajoSeleccionado != null)
                {
                    this.txtNombreCliente.Text = trabajoSeleccionado.NombreCliente;
                    this.txtDescripcion.Text = trabajoSeleccionado.DescripcionProyecto;
                    this.txtFecha.Text = trabajoSeleccionado.Fecha.ToString();
                    this.txtLugar.Text = trabajoSeleccionado.Lugar;
                    this.txtPresupuesto.Text = trabajoSeleccionado.Presupuesto.ToString();
                }

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            Trabajo trabajo = new Trabajo();
            trabajo.Estado = "Completado";
            actualizarTrabajo(idSeleccionado, trabajo);


            DialogResult resultado = MessageBox.Show(
                "¿Desea finalizar el trabajo?",
                "Guardar Cambios",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation
            );

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Trabajo finalizado");
            }
            else
            {
                MessageBox.Show("El trabajo sigue en pie", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cargarTabla();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm();
            frm.Show();
            this.Hide();
        }
    }
}
