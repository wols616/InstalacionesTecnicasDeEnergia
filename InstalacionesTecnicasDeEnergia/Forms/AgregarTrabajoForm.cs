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
            ////Esta función hace que el tamaño del panel y posición de los elementos cambie al momento de redimencionar la ventana
            //this.panel1.Width = this.ClientSize.Width;
            //this.label1.Left = (this.ClientSize.Width - label1.Width) - 20;
            //this.pbLogo.Left = 20;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PresupuestoForm frm = new PresupuestoForm();
            frm.Show();
            this.Hide();
        }
    }
}
