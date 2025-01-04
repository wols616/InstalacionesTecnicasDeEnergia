using InstalacionesTecnicasDeEnergia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class EmpleadosForm : Form
    {
        Conexion conexion = new Conexion();
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool validacion = false;

            if (validacion == false)
            {
                if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    MessageBox.Show("El campo 'Nombres' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Nombre.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Apellido.Text))
                {
                    MessageBox.Show("El campo 'Apellidos' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Apellido.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Direccion.Text))
                {
                    MessageBox.Show("El campo 'Dirección' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Direccion.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TelefonoCelular.Text))
                {
                    MessageBox.Show("El campo 'Teléfono Celular' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TelefonoCelular.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TelefonoCasa.Text))
                {
                    MessageBox.Show("El campo 'Teléfono de Casa' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TelefonoCasa.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Correo.Text))
                {
                    MessageBox.Show("El campo 'Correo' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Correo.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_TipoContrato.Text))
                {
                    MessageBox.Show("El campo 'Tipo de Contrato' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_TipoContrato.Focus();
                }
                // Validar DateTimePicker para que no tengan la fecha por defecto
                if (txt_FechaContratacion.Value == txt_FechaContratacion.MinDate)
                {
                    MessageBox.Show("Debe seleccionar una 'Fecha de Contratación' válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_FechaContratacion.Focus();
                }
                if (txt_FechaDespido.Value == txt_FechaDespido.MinDate)
                {
                    MessageBox.Show("Debe seleccionar una 'Fecha de Despido' válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_FechaDespido.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_Salario.Text))
                {
                    MessageBox.Show("El campo 'Salario' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Salario.Focus();
                }
                if (string.IsNullOrWhiteSpace(txt_ComentariosPersonales.Text))
                {
                    MessageBox.Show("El campo 'Comentarios Personales' no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ComentariosPersonales.Focus();
                }
                validacion = true;

            }

            if (validacion == true)
            {
                string nombres = this.txt_Nombre.Text;
                string apellidos = this.txt_Apellido.Text;
                string dui = this.txt_Dui.Text;
                string direccion = this.txt_Direccion.Text;
                string telefonoCelular = this.txt_TelefonoCelular.Text;
                string telefonoCasa = this.txt_TelefonoCasa.Text;
                string correo = this.txt_Correo.Text;
                string tipoContrato = this.txt_TipoContrato.Text;
                string fechaContratacion = this.txt_FechaContratacion.Text;
                string fechaDespido = this.txt_FechaDespido.Text;
                string salario = this.txt_Salario.Text;
                string comentariosPersonales = this.txt_ComentariosPersonales.Text;


                Empleado empleado = new Empleado();
                empleado.Nombres = nombres;
                empleado.Apellidos = apellidos;
                empleado.Dui = dui;
                empleado.Direccion = direccion;
                empleado.TelefonoCelular = telefonoCelular;
                empleado.TelefonoCasa = telefonoCasa;
                empleado.Correo = correo;
                empleado.TipoContrato = tipoContrato;
                empleado.FechaContratacion = fechaContratacion;
                empleado.FechaDespido = fechaDespido;
                empleado.Salario = salario;
                empleado.ComentariosPersonales = comentariosPersonales;


                try
                {
                    Conexion conexion = new Conexion();
                    conexion.EmpleadoDb.InsertOne(empleado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }



            }

        }

        private void cargarTablaEmpleados()
        {
            try
            {

                List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();
                Tabla.DataSource = empleados;
                Tabla.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar a los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            cargarTablaEmpleados();
        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();

            if (Tabla.CurrentRow != null)
            {
                // Obtener el índice del empleado seleccionado
                int index = Tabla.CurrentRow.Index;

                // Buscar el empleado seleccionado en la lista de empleados
                var empleadoSeleccionado = empleados[index];

                if (empleadoSeleccionado != null)
                {
                    this.txt_Nombre.Text = empleadoSeleccionado.Nombres;
                    this.txt_Apellido.Text = empleadoSeleccionado.Apellidos;
                    this.txt_Dui.Text = empleadoSeleccionado.Dui;
                    this.txt_Direccion.Text = empleadoSeleccionado.Direccion;
                    this.txt_TelefonoCasa.Text = empleadoSeleccionado.TelefonoCasa;
                    this.txt_TelefonoCelular.Text = empleadoSeleccionado.TelefonoCelular;
                    this.txt_Correo.Text = empleadoSeleccionado.Correo;
                    this.txt_TipoContrato.Text = empleadoSeleccionado.TipoContrato;
                    this.txt_FechaContratacion.Text = empleadoSeleccionado.FechaContratacion;
                    this.txt_FechaDespido.Text = empleadoSeleccionado.FechaDespido;
                    this.txt_Salario.Text = empleadoSeleccionado.Salario;
                    this.txt_ComentariosPersonales.Text = empleadoSeleccionado.ComentariosPersonales;
                }
            }
        }

        private void eliminarEmpleado(string id)
        {
            var result = MessageBox.Show("Estás seguro que quieres eliminar al empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var empleadoEliminar = Builders<Empleado>.Filter.Eq(p => p.Id, id);
                conexion.EmpleadoDb.DeleteOne(empleadoEliminar);
                cargarTablaEmpleados();
            }
            else
            {
                return;
            }
        }

        private void actualizarEmpleado(string id, Empleado empleado)
        {
            Conexion conexion = new Conexion();
            var empleadoActualizar = Builders<Empleado>.Filter.Eq(p => p.Id, id);

            var actualizacion = Builders<Empleado>.Update
            .Set(p => p.Nombres, empleado.Nombres)
            .Set(p => p.Apellidos, empleado.Apellidos)
            .Set(p => p.Dui, empleado.Dui)
            .Set(p => p.Direccion, empleado.Direccion)
            .Set(p => p.TelefonoCasa, empleado.TelefonoCasa)
            .Set(p => p.TelefonoCelular, empleado.TelefonoCelular)
            .Set(p => p.Correo, empleado.Correo)
            .Set(p => p.TipoContrato, empleado.TipoContrato)
            .Set(p => p.FechaContratacion, empleado.FechaContratacion)
            .Set(p => p.FechaDespido, empleado.FechaDespido)
            .Set(p => p.Salario, empleado.Salario)
            .Set(p => p.ComentariosPersonales, empleado.ComentariosPersonales);

            var resultado = conexion.EmpleadoDb.UpdateOne(empleadoActualizar, actualizacion);
            cargarTablaEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = Tabla.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();
            eliminarEmpleado(idSeleccionado);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = Tabla.SelectedRows[0];
            string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            Empleado empleado = new Empleado
            {
                Nombres = this.txt_Nombre.Text,
                Apellidos = this.txt_Apellido.Text,
                Dui = this.txt_Dui.Text,
                Direccion = this.txt_Direccion.Text,
                TelefonoCelular = this.txt_TelefonoCelular.Text,
                TelefonoCasa = this.txt_TelefonoCasa.Text,
                Correo = this.txt_Correo.Text,
                TipoContrato = this.txt_TipoContrato.Text,
                FechaContratacion = this.txt_FechaContratacion.Text,
                FechaDespido = this.txt_FechaDespido.Text,
                Salario = this.txt_Salario.Text,
                ComentariosPersonales = this.txt_ComentariosPersonales.Text
            };

            try
            {
                actualizarEmpleado(idSeleccionado, empleado);
                MessageBox.Show("El empleado se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarTablaEmpleados(); // Recargar la tabla para reflejar los cambios
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            this.txt_Nombre.Clear();
            this.txt_Apellido.Clear();
            this.txt_Dui.Clear();
            this.txt_Direccion.Clear();
            this.txt_TelefonoCelular.Clear();
            this.txt_TelefonoCasa.Clear();
            this.txt_Correo.Clear();
            this.txt_TipoContrato.Clear();
            this.txt_FechaContratacion.Value = this.txt_FechaContratacion.MinDate; // Restablecer al valor mínimo
            this.txt_FechaDespido.Value = this.txt_FechaDespido.MinDate; // Restablecer al valor mínimo
            this.txt_Salario.Clear();
            this.txt_ComentariosPersonales.Clear();

            // Deseleccionar la fila del DataGridView
            if (Tabla.SelectedRows.Count > 0)
            {
                Tabla.ClearSelection();
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }
    }
}
