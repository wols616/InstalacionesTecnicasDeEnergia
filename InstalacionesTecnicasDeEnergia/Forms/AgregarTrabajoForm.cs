using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstalacionesTecnicasDeEnergia.Models;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class AgregarTrabajoForm : Form
    {
        public AgregarTrabajoForm()
        {
            InitializeComponent();
            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.60);
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

        private void AgregarTrabajoForm_Resize(object sender, EventArgs e)
        {
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombreCliente = this.txtNombreCliente.Text;
            string lugarProyecto = this.txtLugarProyecto.Text;
            DateTime fecha = this.dateTimePicker1.Value;
            string descripcion = this.textBox1.Text;

            Trabajo trabajo = new Trabajo();
            trabajo.NombreCliente = nombreCliente;
            trabajo.Lugar = lugarProyecto;
            trabajo.Fecha = fecha;
            trabajo.DescripcionProyecto = descripcion;
            trabajo.Estado = "Pendiente";

            PresupuestoForm frm = new PresupuestoForm(trabajo);
            frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
