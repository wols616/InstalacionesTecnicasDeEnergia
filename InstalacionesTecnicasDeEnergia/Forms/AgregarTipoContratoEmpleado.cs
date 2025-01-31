using InstalacionesTecnicasDeEnergia.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class AgregarTipoContratoEmpleado : Form
    {
        Conexion conexion = new Conexion();
        EmpleadosForm empleadoForm = new EmpleadosForm();

        public AgregarTipoContratoEmpleado()
        {
            InitializeComponent();
        }

        public AgregarTipoContratoEmpleado(EmpleadosForm tipoEmpleados)
        {
            InitializeComponent();
            empleadoForm = tipoEmpleados;
        }

        private void cargarTipoEmpleados()
        {

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<TipoContrato_Empleado_> tipos = conexion.TipoEmpleadoDb.Find(d => true).ToList();
            dataGridView1.DataSource = tipos;
            dataGridView1.Columns["Id"].Visible = false;

            empleadoForm.cargarTablaEmpleados();
        }


        private void actualiarTipoEmpleado(string id, TipoContrato_Empleado_ tipoEmpleado)
        {
            var tipoActualizar = Builders<TipoContrato_Empleado_>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<TipoContrato_Empleado_>.Update
            .Set(p => p.Nombre, tipoEmpleado.Nombre);

            var resultado = conexion.TipoEmpleadoDb.UpdateOne(tipoActualizar, actualizacion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoContrato_Empleado_ tipoEmpleado = new TipoContrato_Empleado_();
            tipoEmpleado.Nombre = txtNombre.Text;

            conexion.TipoEmpleadoDb.InsertOne(tipoEmpleado);
            cargarTipoEmpleados();
        }

        private void AgregarTipoContratoEmpleado_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarTipoEmpleados();
        }

        private void eliminarTipoEmpleado(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar el tipo de empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var eliminarTipo = Builders<TipoContrato_Empleado_>.Filter.Eq(p => p.Id, id);
                conexion.TipoEmpleadoDb.DeleteOne(eliminarTipo);
                cargarTipoEmpleados();
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<TipoContrato_Empleado_> tipoEmpleado = conexion.TipoEmpleadoDb.Find(d => true).ToList();

            if (dataGridView1.CurrentRow != null)
            {
                // Obtener el índice del producto seleccionado
                int index = dataGridView1.CurrentRow.Index;

                // Buscar el producto original en la lista de productos
                var tipoSeleccionado = tipoEmpleado[index];

                if (tipoSeleccionado != null)
                {
                    this.txtNombre.Text = tipoSeleccionado.Nombre;
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoContrato_Empleado_ tipoEmpleado = new TipoContrato_Empleado_();
            tipoEmpleado.Nombre = txtNombre.Text;

            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            actualiarTipoEmpleado(idSeleccionado, tipoEmpleado);
            cargarTipoEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarTipoEmpleado(idSeleccionado);
        }
    }
}
