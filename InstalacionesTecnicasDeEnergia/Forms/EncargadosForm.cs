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
    public partial class EncargadosForm : Form
    {
        public EncargadosForm()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            TrabajosPendientesForm frm = new TrabajosPendientesForm();
            frm.Show();
            this.Hide();
        }
    }
}
