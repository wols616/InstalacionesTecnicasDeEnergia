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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InstalacionesTecnicasDeEnergia.Forms
{
    public partial class EmpleadosForm : Form
    {
        Conexion conexion = new Conexion();
        public EmpleadosForm()
        {
            InitializeComponent();
            this.Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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


                if (cbx_TipoEmpleado.SelectedIndex == 0 || cbx_TipoEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe elegir el tipo de contrato", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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

                string tipoContrato = cbx_TipoEmpleado.SelectedValue.ToString();

                string fechaContratacion = txt_FechaContratacion.Value.ToString("yyyy-MM-dd");

                //string fechaDespido = this.txt_FechaDespido.Text;
                string fechaDespido;

                if (txt_FechaDespido.Checked)
                {
                    // Si el DateTimePicker está activado (Checked == true), toma el valor seleccionado
                    fechaDespido = txt_FechaDespido.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    // Si el DateTimePicker está desactivado (Checked == false), asigna null
                    fechaDespido = "";
                }

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
                    cargarTablaEmpleados(); // Recargar la tabla para reflejar los cambios
                    MessageBox.Show("Empleado agregado exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex);
                }
            }

            this.txt_Nombre.Clear();
            this.txt_Apellido.Clear();
            this.txt_Dui.Clear();
            this.txt_Direccion.Clear();
            this.txt_TelefonoCelular.Clear();
            this.txt_TelefonoCasa.Clear();
            this.txt_Correo.Clear();
            this.txt_TipoContrato.Clear();
            this.txt_FechaContratacion.Value = DateTime.Now;
            this.txt_FechaDespido.Value = DateTime.Now;
            this.txt_Salario.Clear();
            this.txt_ComentariosPersonales.Clear();
        }

        //public void cargarRegistroEmpleados()
        //{
        //    List<Empleado> empleado = conexion.EmpleadoDb.Find(d => true).ToList();
        //    Tabla.DataSource = empleado;
        //    Tabla.Columns["Id"].Visible = false;
        //    Tabla.Columns["TipoEmpleado_Id"].Visible = false;

        //    try
        //    {
        //        List<TipoContrato_Empleado_> tipoEmpleados = conexion.TipoEmpleadoDb.Find(d => true).ToList();

        //        this.cbx_TipoEmpleado.DataSource = tipoEmpleados;
        //        this.cbx_TipoEmpleado.DisplayMember = "Nombre";
        //        this.cbx_TipoEmpleado.ValueMember = "Id";

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar categorias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void cargarTablaEmpleados()
        //{
        //    List<Empleado> empleado = conexion.EmpleadoDb.Find(d => true).ToList();
        //    Tabla.DataSource = empleado;
        //    Tabla.Columns["Id"].Visible = false;
        //    Tabla.Columns["TipoContrato"].Visible = false;

        //    try
        //    {

        //        List<TipoContrato_Empleado_> tipoEmpleados = conexion.TipoEmpleadoDb.Find(d => true).ToList();

        //        this.cbx_TipoEmpleado.DataSource = tipoEmpleados;
        //        this.cbx_TipoEmpleado.DisplayMember = "Nombre";
        //        this.cbx_TipoEmpleado.ValueMember = "Id";

        //        //List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();
        //        //Tabla.DataSource = empleados;
        //        //Tabla.Columns["Id"].Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al cargar a los empleados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void cargarTablaEmpleados()
        {
            try
            {
                // Obtén la lista de empleados desde la base de datos
                List<Empleado> empleados = conexion.EmpleadoDb.Find(d => true).ToList();

                // Obtén la lista de tipos de contrato desde la base de datos
                List<TipoContrato_Empleado_> tipoEmpleados = conexion.TipoEmpleadoDb.Find(d => true).ToList();

                // Proyecta los datos de empleados y reemplaza el ID de TipoContrato por su nombre
                var empleadosConTipoContrato = empleados.Select(e => new
                {
                    e.Id,
                    e.Nombres,
                    e.Apellidos,
                    e.Dui,
                    e.Direccion,
                    e.TelefonoCelular,
                    e.TelefonoCasa,
                    e.Correo,
                    TipoContrato = tipoEmpleados.FirstOrDefault(t => t.Id == e.TipoContrato)?.Nombre ?? "Desconocido",
                    FechaContratacion = DateTime.TryParse(e.FechaContratacion, out DateTime fechaContratacion) ? fechaContratacion.ToString("dd/MM/yyyy") : "N/A",
                    FechaDespido = DateTime.TryParse(e.FechaDespido, out DateTime fechaDespido) ? fechaDespido.ToString("dd/MM/yyyy") : "",
                    e.Salario,
                    e.ComentariosPersonales
                }).ToList();

                // Asigna los datos a la tabla
                Tabla.DataSource = empleadosConTipoContrato;

                // Configuración del ComboBox para tipos de contrato
                this.cbx_TipoEmpleado.DataSource = tipoEmpleados;
                this.cbx_TipoEmpleado.DisplayMember = "Nombre";
                this.cbx_TipoEmpleado.ValueMember = "Id";
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
                    //this.txt_TipoContrato.Text = empleadoSeleccionado.TipoContrato;

                    TipoContrato_Empleado_ tipoContrato = conexion.TipoEmpleadoDb.Find(d => d.Id == empleadoSeleccionado.TipoContrato).FirstOrDefault();
                    this.cbx_TipoEmpleado.SelectedItem = tipoContrato.Id;
                    this.cbx_TipoEmpleado.Text = tipoContrato.Nombre;

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
            //DataGridViewRow filaSeleccionada = Tabla.SelectedRows[0];
            //string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

            //Empleado empleado = new Empleado
            //{
            //    Nombres = this.txt_Nombre.Text,
            //    Apellidos = this.txt_Apellido.Text,
            //    Dui = this.txt_Dui.Text,
            //    Direccion = this.txt_Direccion.Text,
            //    TelefonoCelular = this.txt_TelefonoCelular.Text,
            //    TelefonoCasa = this.txt_TelefonoCasa.Text,
            //    Correo = this.txt_Correo.Text,


            //    TipoContrato = cbx_TipoEmpleado.SelectedItem.ToString(),


            //    FechaContratacion = this.txt_FechaContratacion.Text,
            //    FechaDespido = this.txt_FechaDespido.Text,
            //    Salario = this.txt_Salario.Text,
            //    ComentariosPersonales = this.txt_ComentariosPersonales.Text
            //};

            //try
            //{
            //    actualizarEmpleado(idSeleccionado, empleado);
            //    MessageBox.Show("El empleado se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cargarTablaEmpleados(); // Recargar la tabla para reflejar los cambios
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (Tabla.SelectedRows.Count > 0) // Verificar si hay una fila seleccionada
            {
                DataGridViewRow filaSeleccionada = Tabla.SelectedRows[0];
                string idSeleccionado = filaSeleccionada.Cells["Id"].Value.ToString();

                // Crear el objeto empleado con los valores del formulario
                Empleado empleado = new Empleado
                {
                    Nombres = this.txt_Nombre.Text.Trim(),
                    Apellidos = this.txt_Apellido.Text.Trim(),
                    Dui = this.txt_Dui.Text.Trim(),
                    Direccion = this.txt_Direccion.Text.Trim(),
                    TelefonoCelular = this.txt_TelefonoCelular.Text.Trim(),
                    TelefonoCasa = this.txt_TelefonoCasa.Text.Trim(),
                    Correo = this.txt_Correo.Text.Trim(),

                    // Obtener el ID seleccionado del ComboBox
                    TipoContrato = this.cbx_TipoEmpleado.SelectedValue?.ToString(),

                    // Manejar fechas con el DateTimePicker
                    FechaContratacion = this.txt_FechaContratacion.Value.ToString("yyyy-MM-dd"),
                    FechaDespido = this.txt_FechaDespido.Checked ? this.txt_FechaDespido.Value.ToString("yyyy-MM-dd") : null,

                    Salario = this.txt_Salario.Text.Trim(),
                    ComentariosPersonales = this.txt_ComentariosPersonales.Text.Trim()
                };

                try
                {
                    // Llamar al método para actualizar el empleado en la base de datos
                    actualizarEmpleado(idSeleccionado, empleado);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("El empleado se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la tabla para reflejar los cambios
                    cargarTablaEmpleados();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show($"Error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje si no hay una fila seleccionada
                MessageBox.Show("Por favor, selecciona un empleado para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            this.txt_FechaContratacion.Value = DateTime.Now;
            this.txt_FechaDespido.Value = DateTime.Now;
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

        private void txt_ComentariosPersonales_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarTipoContratoEmpleado form = new AgregarTipoContratoEmpleado(this);
            form.Show();
        }
    }
}
