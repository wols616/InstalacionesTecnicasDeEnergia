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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();

            //Ancho de la pantalla
            int widthDisplay = (int)(Screen.PrimaryScreen.Bounds.Width * 0.50);
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

        private void btnManoObra_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            //Esta función hace que el tamaño del panel y posición de los elementos cambie al momento de redimencionar la ventana
            this.panel1.Width = this.ClientSize.Width;
            this.label1.Left = (this.ClientSize.Width - label1.Width) - 20;
            this.pbLogo.Left = 20;
            this.btnAgregarTrabajo.Left = 100;
            this.btnBitacora.Left = 100;
            this.btnEmpleados.Left = 100;
            this.btnInventario.Left = 100;
            this.btnManoObra.Left = 100;
            this.btnTrabajosPendientes.Left = 100;
            this.btnTrabajosRealizados.Left = 100;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            InventarioForm frm = new InventarioForm();
            frm.Show();
            this.Hide();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTrabajo_Click(object sender, EventArgs e)
        {
            AgregarTrabajoForm frm = new AgregarTrabajoForm();
            frm.Show();
            this.Hide();
        }

        private void btnTrabajosPendientes_Click(object sender, EventArgs e)
        {
            TrabajosPendientesForm frm = new TrabajosPendientesForm();
            frm.Show();
            this.Hide();
        }

        private void btnTrabajosRealizados_Click(object sender, EventArgs e)
        {
            TrabajosRealizadosForm frm = new TrabajosRealizadosForm();
            frm.Show();
            this.Hide();
        }
    }
}
