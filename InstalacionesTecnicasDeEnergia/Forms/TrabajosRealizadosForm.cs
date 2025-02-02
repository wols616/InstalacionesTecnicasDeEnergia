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
    public partial class TrabajosRealizadosForm : Form
    {
        Conexion conexion = new Conexion();
        public TrabajosRealizadosForm()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void cargarTabla()
        {
            List<Trabajo> trabajos = conexion.TrabajoDb.Find(d => d.Estado == "Completado").ToList();
            dataGridView1.DataSource = trabajos;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            DetalleTrabajoForm frm = new DetalleTrabajoForm();
            frm.IdSeleccionado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            frm.procedencia = false;
            frm.Show();
            this.Hide();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Trabajo> trabajos = conexion.TrabajoDb.Find(d => d.Estado == "Completado").ToList();

            if (dataGridView1.CurrentRow != null)
            {
                int index = dataGridView1.CurrentRow.Index;

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

        private void TrabajosRealizadosForm_Load(object sender, EventArgs e)
        {
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
