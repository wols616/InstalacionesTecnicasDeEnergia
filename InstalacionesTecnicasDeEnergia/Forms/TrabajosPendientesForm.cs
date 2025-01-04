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
            List<Trabajo> trabajos = conexion.TrabajoDb.Find(d => true).ToList();
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
    }
}
