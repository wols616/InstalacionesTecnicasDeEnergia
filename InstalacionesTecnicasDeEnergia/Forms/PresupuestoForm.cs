using InstalacionesTecnicasDeEnergia.Metodos;
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
    public partial class PresupuestoForm : Form
    {
        public PresupuestoForm()
        {
            InitializeComponent();
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

            //Establezco el placeholder
            Metodos.Metodos.setPlaceHolder(this.txtMaterial, "Ingrese el nombre del material");
        }

        private void txtMaterial_Enter(object sender, EventArgs e)
        {
            if (this.txtMaterial.Text == "Ingrese el nombre del material")
            {
                this.txtMaterial.Text = "";
                this.txtMaterial.ForeColor = Color.Black;
            }
        }

        private void txtMaterial_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtMaterial.Text))
            {
                Metodos.Metodos.setPlaceHolder(this.txtMaterial, "Ingrese el nombre del material");
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            EncargadosForm frm = new EncargadosForm();
            frm.Show();
            this.Hide();
        }
    }
}
