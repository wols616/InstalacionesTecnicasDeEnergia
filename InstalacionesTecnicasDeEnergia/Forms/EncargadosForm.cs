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

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class EncargadosForm : Form
    {
        Trabajo trabajo;
        public EncargadosForm()
        {
            InitializeComponent();
        }

        public EncargadosForm(Trabajo trabajoPendiente)
        {
            InitializeComponent();
            trabajo = trabajoPendiente;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.Visible = false; // Ocultar columna
            dataGridView1.Columns.Add(idColumn);

            dataGridView1.Columns.Add("Nombre", "Nombre");

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            llenarListaEncargados();
            Conexion.TrabajoDb.InsertOne(trabajo);

            TrabajosPendientesForm frm = new TrabajosPendientesForm();
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cbxEmpleado.SelectedIndex >= 0)
            {
                string nombreEmpleado = cbxEmpleado.Text;
                string idEmpleado = cbxEmpleado.SelectedValue.ToString(); 
                
                dataGridView1.Rows.Add(idEmpleado, nombreEmpleado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llenarListaEncargados()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Asegúrate de que la fila no esté vacía
                if (row.Cells["Id"].Value != null && row.Cells["Nombre"].Value != null)
                {
                    // Crea un nuevo objeto MaterialUsado
                    Encargado encargados = new Encargado
                    {
                        EmpleadoId = row.Cells["Id"].Value.ToString()
                    };

                    // Agrega el objeto a la lista de materiales
                    trabajo.Encargados.Add(encargados);
                }
            }
        }
    }
}
